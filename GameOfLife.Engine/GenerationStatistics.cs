using System;

namespace GameOfLife.Engine
{
	public class GenerationStatistics : EventArgs
	{
		public int CellsBorn { get; private set; }
		public int CellsDied { get; private set; }

		public GenerationStatistics(int cellsBorn, int cellsDied)
		{
			CellsBorn = cellsBorn;
			CellsDied = cellsDied;
		}
	}
}
