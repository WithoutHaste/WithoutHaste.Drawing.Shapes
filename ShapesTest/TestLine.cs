using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestLine
	{
		[TestMethod]
		public void Slope()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WLine a = new WLine(new WPoint(0, -4.0/9.0), new WPoint(-4.0/6.0, 0));
			//act
			double result = a.Slope;
			//assert
			Assert.AreEqual(-2.0/3.0, result);
		}

		[TestMethod]
		public void PerpendicularSlope()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WLine a = new WLine(new WPoint(0, -4.0/9.0), new WPoint(-4.0/6.0, 0));
			//act
			double result = a.PerpendicularSlope;
			//assert
			Assert.AreEqual(3.0/2.0, result);
		}

		[TestMethod]
		public void GetPerpendicularIntersect()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WLine a = new WLine(new WPoint(0, 15.0/6.0), new WPoint(15.0/8.0, 0));
			WPoint c = new WPoint(3, -4);
			//act
			WPoint result = a.GetPerpendicularIntersect(c);
			//assert
			Assert.IsTrue(Geometry.WithinMarginOfError(21.0/5.0, result.X));
			Assert.IsTrue(Geometry.WithinMarginOfError(-31.0/10.0, result.Y));
		}

		[TestMethod]
		public void IsVertical_MarginOfError_Yes()
		{
			//arrange (from real example)
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint a = new WPoint(160.00000000000006, 1);
			WPoint b = new WPoint(159.99999999999994, 10);
			WLine line = new WLine(a, b);
			//act
			bool result = line.IsVertical;
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsVertical_MarginOfError_No()
		{
			//arrange (from real example)
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint a = new WPoint(160.06, 1);
			WPoint b = new WPoint(159.94, 10);
			WLine line = new WLine(a, b);
			//act
			bool result = line.IsVertical;
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void IsHorizontal_MarginOfError_Yes()
		{
			//arrange (from real example)
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint a = new WPoint(1,  160.00000000000006);
			WPoint b = new WPoint(10, 159.99999999999994);
			WLine line = new WLine(a, b);
			//act
			bool result = line.IsHorizontal;
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsHorizontal_MarginOfError_No()
		{
			//arrange (from real example)
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint a = new WPoint(1,  160.06);
			WPoint b = new WPoint(10, 159.94);
			WLine line = new WLine(a, b);
			//act
			bool result = line.IsHorizontal;
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void GetIntersection_WLine_FirstLineVertical()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLine a = new WLine(new WPoint(39, 129), new WPoint(39, 171));
			WLine b = new WLine(new WPoint(36.3639, 305.3639), new WPoint(30, 129));
			//act
			Intersection result = a.GetIntersection(b);
			//assert
			Assert.IsTrue(result.IsPoint);
		}

		[TestMethod]
		public void GetIntersection_WLine_SecondLineVertical()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLine a = new WLine(new WPoint(36.3639, 305.3639), new WPoint(30, 129));
			WLine b = new WLine(new WPoint(39, 129), new WPoint(39, 171));
			//act
			Intersection result = a.GetIntersection(b);
			//assert
			Assert.IsTrue(result.IsPoint);
		}

		[TestMethod]
		public void Overlaps_WPoint_PointIsWithinLineSegment()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLine line = new WLine(new WPoint(0, 0), new WPoint(5, 0));
			WPoint point = new WPoint(1, 0);
			//act
			bool result = line.Overlaps(point);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Overlaps_WPoint_PointIsOutsideLineSegment()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLine line = new WLine(new WPoint(1, 0), new WPoint(5, 0));
			WPoint point = new WPoint(0, 0);
			//act
			bool result = line.Overlaps(point);
			//assert
			Assert.IsTrue(result);
		}
	}
}
