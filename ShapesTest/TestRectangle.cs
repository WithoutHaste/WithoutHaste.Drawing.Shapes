using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestRectangle
	{
		[TestMethod]
		public void Corners_Paper_Flat()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 0;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WPoint[] result = rectangle.Corners;
			//assert
			Assert.AreEqual(4, result.Length);
			Assert.AreEqual(topLeftCorner, result[0]);
			Assert.AreEqual(new WPoint(topLeftCorner.X + width, topLeftCorner.Y), result[1]);
			Assert.AreEqual(new WPoint(topLeftCorner.X + width, topLeftCorner.Y - height), result[2]);
			Assert.AreEqual(new WPoint(topLeftCorner.X, topLeftCorner.Y - height), result[3]);
		}

		[TestMethod]
		public void Corners_Screen_Flat()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 0;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WPoint[] result = rectangle.Corners;
			//assert
			Assert.AreEqual(4, result.Length);
			Assert.AreEqual(topLeftCorner, result[0]);
			Assert.AreEqual(new WPoint(topLeftCorner.X + width, topLeftCorner.Y), result[1]);
			Assert.AreEqual(new WPoint(topLeftCorner.X + width, topLeftCorner.Y + height), result[2]);
			Assert.AreEqual(new WPoint(topLeftCorner.X, topLeftCorner.Y + height), result[3]);
		}

		[TestMethod]
		public void Corners_Paper_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 45;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WPoint[] result = rectangle.Corners;
			//assert
			Assert.AreEqual(4, result.Length);
			Assert.AreEqual(topLeftCorner, result[0]);
			Assert.AreEqual(new WPoint(18.485, 13.485), result[1]);
			Assert.AreEqual(new WPoint(21.313, 10.656), result[2]);
			Assert.AreEqual(new WPoint(12.828, 2.171), result[3]);
		}

		[TestMethod]
		public void Corners_Screen_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 45;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WPoint[] result = rectangle.Corners;
			//assert
			Assert.AreEqual(4, result.Length);
			Assert.AreEqual(topLeftCorner, result[0]);
			Assert.AreEqual(new WPoint(18.485, -3.485), result[1]);
			Assert.AreEqual(new WPoint(21.313, -0.656), result[2]);
			Assert.AreEqual(new WPoint(12.828, 7.828), result[3]);
		}

		[TestMethod]
		public void GetFlatEnclosingRectangle_Paper_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 45;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WRectangle result = rectangle.GetFlatEnclosingRectangle();
			//assert
			Assert.AreEqual(new WPoint(10, 13.485), result.Corner);
			Assert.IsTrue(Geometry.WithinMarginOfError(21.313 - 10, result.Width));
			Assert.IsTrue(Geometry.WithinMarginOfError(13.485 - 2.171, result.Height));
			Assert.IsTrue(result.IsFlat);
		}

		[TestMethod]
		public void GetFlatEnclosingRectangle_Screen_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint topLeftCorner = new WPoint(10, 5);
			double width = 12;
			double height = 4;
			double rotation = 45;
			WRectangle rectangle = new WRectangle(width, height, topLeftCorner, rotation);
			//act
			WRectangle result = rectangle.GetFlatEnclosingRectangle();
			//assert
			Assert.AreEqual(new WPoint(10, -3.485), result.Corner);
			Assert.IsTrue(Geometry.WithinMarginOfError(21.313 - 10, result.Width));
			Assert.IsTrue(Geometry.WithinMarginOfError(7.828 - -3.485, result.Height));
			Assert.IsTrue(result.IsFlat);
		}

	}
}
