﻿using GameOfLife.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Tests
{
	[TestClass]
	public class WorldTests
	{
		[TestMethod]
		public void GeneralTest()
		{
			World world = new World();
			world.SetCell(0, 0, true);
			var cell = world.GetCell(0, 0);
			Assert.IsTrue(cell);
		}

		[TestMethod]
		public void IndexerTest()
		{
			var world = new World();
			world[1, 1] = true;
			var cell = world[1, 1];
			Assert.IsTrue(cell);

			world[1, 1] = false;
			cell = world[1, 1];
			Assert.IsFalse(cell);
		}

		[TestMethod]
		public void GetCellsInAreaTest()
		{
			var world = new World();
			world[10, 10] = true;
			world[10, 11] = true;
			world[10, 12] = true;
			world[7, 8] = true;

			IEnumerable<Coordinate> cells = world.GetCells(new Area(0, 0, 20, 20));
			Assert.AreEqual(4, cells.Count());
			Assert.AreEqual(4, world.Count);

			world.Reset();
			cells = world.GetCells(new Area(-20, -20, 20, 20));
			Assert.AreEqual(0, cells.Count());
			Assert.AreEqual(0, world.Count);

			world[10, 10] = true;
			world[10, 11] = true;
			world[10, 12] = true;
			world[7, 8] = true;
			world[30, 30] = true;
			world[-10, 5] = true;

			cells = world.GetCells(new Area(0, 0, 20, 20));
			Assert.AreEqual(4, cells.Count());
			Assert.AreEqual(6, world.Count);
		}
	}
}
