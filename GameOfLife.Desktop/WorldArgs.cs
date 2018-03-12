using GameOfLife.Engine;

namespace GameOfLife.Desktop
{
	public class WorldArgs
	{
		public World World { get; private set; }
		public GenerationStatistics Generation { get; set; }

		public WorldArgs(World world, GenerationStatistics generation)
		{
			World = world;
			Generation = generation;
		}
	}
}
