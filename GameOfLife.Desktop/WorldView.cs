using GameOfLife.Engine;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife.Desktop
{
	public partial class WorldView : Control
	{
		private World _world = new World();
		private float _cellSize = 10.0f;
		private Coordinate _topLeft;

		public Coordinate TopLeft
		{
			get { return _topLeft; }
			set
			{
				if (_topLeft == value)
					return;

				_topLeft = value;
				Invalidate();
			}
		}

		public float CellSize
		{
			get { return _cellSize; }
			set
			{
				if (_cellSize == value)
					return;

				_cellSize = value;
				Invalidate();
			}
		}

		private Area VisibleArea
		{
			get
			{
				return new Area(
					_topLeft.X,
					_topLeft.Y,
					(int)Math.Ceiling(ClientRectangle.Width / CellSize),
					(int)Math.Ceiling(ClientRectangle.Height / CellSize));
			}
		}

		public WorldView()
		{
			InitializeComponent();
		}

		public void Start()
		{
			_worldTimer.Start();
		}

		public void Step()
		{
			_world.NextGeneration();
			Invalidate();
		}

		public void Stop()
		{
			_worldTimer.Stop();
		}

		public void Clear()
		{
			_world.Reset();
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			DrawCells(pe.Graphics);
		}

		private RectangleF GetCellRectangle(Coordinate position)
		{
			return new RectangleF(
				(position.X - _topLeft.X) * CellSize,
				(position.Y - _topLeft.Y) * CellSize,
				CellSize,
				CellSize);
		}

		private void DrawCells(Graphics gr)
		{
			var cells = _world.GetCells(VisibleArea);

			using (var brush = new SolidBrush(ForeColor))
			{
				foreach (var cell in cells)
				{
					gr.FillRectangle(brush, GetCellRectangle(cell));
				}
			}
		}

		private void WorldTimer_Tick(object sender, EventArgs e)
		{
			_world.NextGeneration();
			Invalidate();
		}

		private Coordinate ToWorldCoordinate(Point p)
		{
			return new Coordinate(
				_topLeft.X + (int)Math.Floor(p.X / CellSize),
				_topLeft.Y + (int)Math.Floor(p.Y / CellSize));
		}

		Coordinate? _startTopLeft;
		Point? _startMove;

		private void WorldView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Left))
			{
				var coordinate = ToWorldCoordinate(e.Location);
				_world[coordinate] = !_world[coordinate];
				Invalidate();
			}
			else if (e.Button.HasFlag(MouseButtons.Right))
			{
				_startTopLeft = TopLeft;
				_startMove = e.Location;
			}
		}

		private void WorldView_MouseMove(object sender, MouseEventArgs e)
		{
			if (_startMove.HasValue && e.Button.HasFlag(MouseButtons.Right))
			{
				MoveView(e.Location);
			}
		}

		private void WorldView_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Right) && _startMove.HasValue)
			{
				MoveView(e.Location);
				_startMove = null;
				_startTopLeft = null;
			}
		}

		private void MoveView(Point location)
		{
			int diffX = _startMove.Value.X - location.X;
			int diffY = _startMove.Value.Y - location.Y;

			int offsetX = (int)(diffX / CellSize);
			int offsetY = (int)(diffY / CellSize);

			TopLeft = _startTopLeft.Value.Offset(offsetX, offsetY);
		}

		private void WorldView_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case 'l':
				case 'L':
					// Scroll right
					TopLeft = new Coordinate(TopLeft.X - 1, TopLeft.Y);
					break;

				case 'j':
				case 'J':
					// Scroll left
					TopLeft = new Coordinate(TopLeft.X + 1, TopLeft.Y);
					break;

				case 'i':
				case 'I':
					// Scroll up
					TopLeft = new Coordinate(TopLeft.X, TopLeft.Y + 1);
					break;

				case 'k':
				case 'K':
					// Scroll down
					TopLeft = new Coordinate(TopLeft.X, TopLeft.Y - 1);
					break;
			}
		}
	}
}
