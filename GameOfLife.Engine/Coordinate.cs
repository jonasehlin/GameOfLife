namespace GameOfLife.Engine
{
	public struct Coordinate
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Coordinate(int x, int y)
		{
			X = x;
			Y = y;
		}

		public Coordinate Offset(int dx, int dy)
		{
			return new Coordinate(X + dx, Y + dy);
		}

		public override string ToString()
		{
			return $"X = {X}, Y = {Y}";
		}
	}
}
