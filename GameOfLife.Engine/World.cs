﻿using System;
using System.Collections.Generic;

namespace GameOfLife.Engine
{
	public class World
	{
		Dictionary<Coordinate, bool> _cells = new Dictionary<Coordinate, bool>();

		public int Age { get; private set; }

		public int Count
		{
			get { return _cells.Count; }
		}

		public bool GetCell(int x, int y)
		{
			return GetCell(new Coordinate(x, y));
		}

		public bool GetCell(Coordinate position)
		{
			if (_cells.TryGetValue(position, out bool cell))
			{
				return cell;
			}

			return false;
		}

		public void SetCell(int x, int y, bool value)
		{
			SetCell(new Coordinate(x, y), value);
		}

		public void SetCell(Coordinate position, bool value)
		{
			if (value)
				_cells[position] = value;
			else
				_cells.Remove(position);
		}

		public bool this[Coordinate position]
		{
			get { return GetCell(position); }
			set { SetCell(position, value); }
		}

		public bool this[int x, int y]
		{
			get { return GetCell(x, y); }
			set { SetCell(x, y, value); }
		}

		public void Reset()
		{
			_cells.Clear();
			Age = 0;
		}

		public IEnumerable<Coordinate> GetCells(Area area)
		{
			var cells = new List<Coordinate>();
			for (int x = area.Left; x < area.Right; x++)
			{
				for (int y = area.Top; y < area.Bottom; y++)
				{
					var position = new Coordinate(x, y);
					if (GetCell(position))
					{
						cells.Add(position);
					}
				}
			}
			return cells;
		}

		public void NextGeneration()
		{
			var live = new Dictionary<Coordinate, bool>();
			var die = new List<Coordinate>();
			foreach (var cell in _cells)
			{
				int neighbours = GetNeighbourCount(cell.Key);
				if (neighbours < 2 || neighbours > 3)
					die.Add(cell.Key);

				AddIfShouldLive(cell.Key.Offset(-1, -1), live);
				AddIfShouldLive(cell.Key.Offset(-1, 0), live);
				AddIfShouldLive(cell.Key.Offset(-1, 1), live);
				AddIfShouldLive(cell.Key.Offset(0, -1), live);
				AddIfShouldLive(cell.Key.Offset(0, 1), live);
				AddIfShouldLive(cell.Key.Offset(1, -1), live);
				AddIfShouldLive(cell.Key.Offset(1, 0), live);
				AddIfShouldLive(cell.Key.Offset(1, 1), live);
			}

			foreach (var cell in die)
			{
				this[cell] = false;
			}

			foreach (var cell in live)
			{
				_cells[cell.Key] = true;
			}

			Age++;

			// TODO: Return how many cells died and how many born
		}

		private int GetNeighbourCount(Coordinate position)
		{
			int count = 0;
			if (GetCell(position.Offset(-1, -1))) count++;
			if (GetCell(position.Offset(-1, 0))) count++;
			if (GetCell(position.Offset(-1, 1))) count++;
			if (GetCell(position.Offset(0, -1))) count++;
			if (GetCell(position.Offset(0, 1))) count++;
			if (GetCell(position.Offset(1, -1))) count++;
			if (GetCell(position.Offset(1, 0))) count++;
			if (GetCell(position.Offset(1, 1))) count++;
			return count;
		}

		private void AddIfShouldLive(Coordinate cell, Dictionary<Coordinate, bool> live)
		{
			// Check if dead cell should live, if not already checked
			if (GetCell(cell) == false && live.ContainsKey(cell) == false)
			{
				if (GetNeighbourCount(cell) == 3)
					live[cell] = true;
			}
		}
	}
}