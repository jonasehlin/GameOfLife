using System;

namespace GameOfLife.Engine
{
	public struct Area
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public Area(int x, int y, int width, int height)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

		public int Top
		{
			get { return Y; }
			set { Y = value; }
		}

		public int Left
		{
			get { return X; }
			set { X = value; }
		}

		public int Bottom
		{
			get { return Y + Height; }
			set { Height = value - Y; }
		}

		public int Right
		{
			get { return X + Width; }
			set { Width = value - X; }
		}

		public Coordinate Center
		{
			get
			{
				return new Coordinate(
					(int)Math.Round((X + Width) / 2.0),
					(int)Math.Round((Y + Height) / 2.0));
			}
		}

		public override string ToString()
		{
			return $"X = {X}, Y = {Y}, Width = {Width}, Height = {Height}";
		}

		public bool Contains(Coordinate coordinate)
		{
			return coordinate.X >= X && coordinate.Y >= Y &&
				coordinate.X <= Right && coordinate.Y <= Bottom;
		}
	}
}
