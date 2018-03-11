using System.Collections.Generic;

namespace GameOfLife.Engine
{
	public class World
	{
		Dictionary<int, Dictionary<int, bool>> _cells = new Dictionary<int, Dictionary<int, bool>>();

		public int Age { get; private set; }

		public int Count { get; set; }

		public bool GetCell(int x, int y)
		{
			if (_cells.TryGetValue(x, out Dictionary<int, bool> xCells))
			{
				if (xCells.TryGetValue(y, out bool cell))
				{
					return cell;
				}
			}

			return false;
		}

		public void SetCell(int x, int y, bool value)
		{
			if (!_cells.TryGetValue(x, out Dictionary<int, bool> xCells))
			{
				_cells[x] = xCells = new Dictionary<int, bool>();
			}

			if (value)
			{
				xCells[y] = value;
				Count++;
			}
			else
			{
				xCells.Remove(y);
				Count--;
			}
		}

		public bool this[int x, int y]
		{
			get { return GetCell(x, y); }
			set
			{
				SetCell(x, y, value);
			}
		}

		public void Reset()
		{
			_cells.Clear();
			Age = 0;
			Count = 0;
		}

		public IEnumerable<Coordinate> GetCells(Area area)
		{
			var cells = new List<Coordinate>();
			for (int x = area.Left; x < area.Right; x++)
			{
				for (int y = area.Top; y < area.Bottom; y++)
				{
					if (GetCell(x, y))
					{
						cells.Add(new Coordinate(x, y));
					}
				}
			}
			return cells;
		}

		public void NextGeneration()
		{
			// TODO: Advance one generation.
		}
	}
}
