using GameOfLife.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.Tests
{
	[TestClass]
	public class AreaTests
	{
		[TestMethod]
		public void TopLeftBottomRightTest()
		{
			var area = new Area(10, 20, 50, 25);
			Assert.AreEqual(10, area.X);
			Assert.AreEqual(20, area.Y);
			Assert.AreEqual(50, area.Width);
			Assert.AreEqual(25, area.Height);
			Assert.AreEqual(20, area.Top);
			Assert.AreEqual(10, area.Left);
			Assert.AreEqual(45, area.Bottom);
			Assert.AreEqual(60, area.Right);
		}

		[TestMethod]
		public void SetBottomRightTest()
		{
			var area = new Area();
			area.Top = 20;
			area.Left = 10;
			area.Bottom = 45;
			area.Right = 60;
			Assert.AreEqual(10, area.X);
			Assert.AreEqual(20, area.Y);
			Assert.AreEqual(50, area.Width);
			Assert.AreEqual(25, area.Height);
			Assert.AreEqual(20, area.Top);
			Assert.AreEqual(10, area.Left);
			Assert.AreEqual(45, area.Bottom);
			Assert.AreEqual(60, area.Right);
		}
	}
}
