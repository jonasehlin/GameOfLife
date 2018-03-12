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
		private Coordinate? _startTopLeft;
		private Point? _startMove;
		private bool _drawCell;

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

		public event EventHandler<WorldArgs> Advanced;

		public WorldView()
		{
			InitializeComponent();
			DoubleBuffered = true;
			Cursor = Cursors.Cross;
			MouseWheel += WorldView_MouseWheel;
		}

		public void Start()
		{
			_worldTimer.Start();
		}

		public void Step()
		{
			var stat = _world.NextGeneration();
			Invalidate();
			OnAdvanced(stat);
		}

		public void Stop()
		{
			_worldTimer.Stop();
		}

		public void Clear()
		{
			_world.Reset();
			Invalidate();
			OnAdvanced(new GenerationStatistics(0, 0));
		}

		public void SetTimerInterval(int interval)
		{
			_worldTimer.Interval = interval;
		}

		protected void OnAdvanced(GenerationStatistics generation)
		{
			Advanced?.Invoke(this, new WorldArgs(_world, generation));
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
			var visibleArea = VisibleArea;
			using (var brush = new SolidBrush(ForeColor))
			{
				int visibleCells = 0;
				foreach (var cell in _world)
				{
					if (visibleArea.Contains(cell))
					{
						gr.FillRectangle(brush, GetCellRectangle(cell));
						visibleCells++;
					}
				}
			}
		}

		private void WorldTimer_Tick(object sender, EventArgs e)
		{
			var generationStatistics = _world.NextGeneration();
			Invalidate();
			OnAdvanced(generationStatistics);
		}

		private Coordinate ToWorldCoordinate(Point p)
		{
			return new Coordinate(
				_topLeft.X + (int)Math.Floor(p.X / CellSize),
				_topLeft.Y + (int)Math.Floor(p.Y / CellSize));
		}

		private void MouseMoveView(Point location)
		{
			int diffX = _startMove.Value.X - location.X;
			int diffY = _startMove.Value.Y - location.Y;

			int offsetX = (int)(diffX / CellSize);
			int offsetY = (int)(diffY / CellSize);

			TopLeft = _startTopLeft.Value.Offset(offsetX, offsetY);
		}

		private void WorldView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Left))
			{
				var coordinate = ToWorldCoordinate(e.Location);
				_drawCell = !_world[coordinate];
				_world[coordinate] = _drawCell;
				Invalidate();
			}
			else if (e.Button.HasFlag(MouseButtons.Right))
			{
				_startTopLeft = TopLeft;
				_startMove = e.Location;
				Cursor = Cursors.Hand;
			}
		}

		private void WorldView_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Left))
			{
				var coordinate = ToWorldCoordinate(e.Location);
				_world[coordinate] = _drawCell;
				Invalidate();
			}
			if (_startMove.HasValue && e.Button.HasFlag(MouseButtons.Right))
			{
				MouseMoveView(e.Location);
			}
		}

		private void WorldView_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Right) && _startMove.HasValue)
			{
				MouseMoveView(e.Location);
				_startMove = null;
				_startTopLeft = null;
				Cursor = Cursors.Cross;
			}
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

		private void WorldView_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				Coordinate oldCoordinate = ToWorldCoordinate(e.Location);
				CellSize = Math.Min(CellSize * 1.1f, 50);
				Coordinate newCoordinate = ToWorldCoordinate(e.Location);
				TopLeft = TopLeft.Offset(
					oldCoordinate.X - newCoordinate.X,
					oldCoordinate.Y - newCoordinate.Y);
			}
			else if (e.Delta < 0)
			{
				Coordinate oldCoordinate = ToWorldCoordinate(e.Location);
				CellSize = Math.Max(CellSize * 0.9f, 1f);
				Coordinate newCoordinate = ToWorldCoordinate(e.Location);
				TopLeft = TopLeft.Offset(
					oldCoordinate.X - newCoordinate.X,
					oldCoordinate.Y - newCoordinate.Y);
			}
		}
	}
}
