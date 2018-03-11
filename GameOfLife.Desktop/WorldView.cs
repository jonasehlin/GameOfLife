using GameOfLife.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife.Desktop
{
	public partial class WorldView : Control
	{
		private World _world;
		private float _cellSize;
		private Coordinate _topLeft;

		public float CellSize
		{
			get { return _cellSize; }
			set
			{
				_cellSize = value;
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

			_world = new World();

			_world[10, 10] = true;
			_world[10, 11] = true;
			_world[10, 12] = true;
			_world[11, 12] = true;
			_world[12, 12] = true;
			_world[12, 10] = true;
			_world[11, 10] = true;

			CellSize = 10.0f;

			_worldTimer.Start();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			DrawCells(pe.Graphics);
		}

		private RectangleF GetCellRectangle(Coordinate position)
		{
			return new RectangleF(
				position.X * CellSize,
				position.Y * CellSize,
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
	}
}
