using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestCircle
	{
		[TestMethod]
		public void GetIntersectionPointsCircle_NoIntersection_SameX()
		{
			//assign
			Circle a = new Circle(new Dot(-2, 0), 1);
			Circle b = new Circle(new Dot(2, 0), 1);
			//act
			Dot[] result = a.GetIntersectionPoints(b);
			//assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void GetIntersectionPointsCircle_SingleIntersection_SameX()
		{
			//assign
			Circle a = new Circle(new Dot(-1, 0), 1);
			Circle b = new Circle(new Dot(1, 0), 1);
			//act
			Dot[] result = a.GetIntersectionPoints(b);
			//assert
			Assert.AreEqual(1, result.Length);
			Assert.AreEqual(new Dot(0, 0), result[0]);
		}

		[TestMethod]
		public void GetIntersectionPointsCircle_SingleIntersection_SameX_DiffRadius()
		{
			//assign
			Circle a = new Circle(new Dot(-2, 0), 2);
			Circle b = new Circle(new Dot(1, 0), 1);
			//act
			Dot[] result = a.GetIntersectionPoints(b);
			//assert
			Assert.AreEqual(1, result.Length);
			Assert.AreEqual(new Dot(0, 0), result[0]);
		}

		[TestMethod]
		public void GetIntersectionPointsCircle_DoubleIntersection_SameX()
		{
			//assign
			Circle a = new Circle(new Dot(-0.5, 0), 1);
			Circle b = new Circle(new Dot(0.5, 0), 1);
			//act
			Dot[] result = a.GetIntersectionPoints(b);
			Dot minResult = (result[0] < result[1]) ? result[0] : result[1];
			Dot maxResult = (minResult == result[0]) ? result[1] : result[0];
			//assert
			Assert.AreEqual(2, result.Length);
			Assert.AreEqual(new Dot(0, -0.5 * Math.Sqrt(3)), minResult);
			Assert.AreEqual(new Dot(0, 0.5 * Math.Sqrt(3)), maxResult);
		}

		[TestMethod]
		public void GetIntersectionPointsLine_VerticalLine_A()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(53.8075, 29.1875), 4.6825) / Utilities.UNITS_TO_PIXELS;
			Line b = new Line(new Dot(51.27, 25), new Dot(51.27, 19.125)) / Utilities.UNITS_TO_PIXELS;
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b.ToLineSegment() }, nameof(TestCircle));
			//act
			Dot[] result = a.GetIntersectionPoints(b);
			//assert
			Assert.AreEqual(2, result.Length);
		}

		[TestMethod]
		public void GetIntersectionPointsLineSegment_DoubleIntersection()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			//(x - 2)^2 + (y + 3)^2 = 4 
			Circle a = new Circle(new Dot(2, -3), 2);
			//2x + 2y = -1 
			LineSegment c = new LineSegment(new Dot(5, -11.0/2.0), new Dot(0, -1.0/2.0));
			//account
			Utilities.SaveDiagram(new IDraw[] { a, c }, nameof(TestCircle));
			//act
			Dot[] result = a.GetIntersectionPoints(c);
			Dot minResult = (result[0] < result[1]) ? result[0] : result[1];
			Dot maxResult = (minResult == result[0]) ? result[1] : result[0];
			//assert
			Assert.AreEqual(2, result.Length);
			Assert.IsTrue(new Dot(0.86, -1.36) == minResult);
			Assert.IsTrue(new Dot(3.64, -4.14) == maxResult);
		}

		//Resource: https://www.geogebra.org/m/qBfHYSTQ
		//gives Dots around a unit circle

		[TestMethod]
		public void PointAtDegrees_0()
		{
			//assign
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 0;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(1, 0), result);
		}

		[TestMethod]
		public void PointAtDegrees_30()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 30;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.87, 0.5), result);
		}

		[TestMethod]
		public void PointAtDegrees_45()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 45;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.71, 0.71), result);
		}

		[TestMethod]
		public void PointAtDegrees_60()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 60;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.5, 0.87), result);
		}

		[TestMethod]
		public void PointAtDegrees_90()
		{
			//assign
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 90;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0, 1), result);
		}

		[TestMethod]
		public void PointAtDegrees_120()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 120;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.5, 0.87), result);
		}

		[TestMethod]
		public void PointAtDegrees_135()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 135;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.71, 0.71), result);
		}

		[TestMethod]
		public void PointAtDegrees_150()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 150;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.87, 0.5), result);
		}

		[TestMethod]
		public void PointAtDegrees_180()
		{
			//assign
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 180;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-1, 0), result);
		}

		[TestMethod]
		public void PointAtDegrees_210()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 210;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.87, -0.5), result);
		}

		[TestMethod]
		public void PointAtDegrees_225()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 225;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.71, -0.71), result);
		}

		[TestMethod]
		public void PointAtDegrees_240()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 240;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(-0.5, -0.87), result);
		}

		[TestMethod]
		public void PointAtDegrees_270()
		{
			//assign
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 270;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0, -1), result);
		}

		[TestMethod]
		public void PointAtDegrees_300()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 300;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.5, -0.87), result);
		}

		[TestMethod]
		public void PointAtDegrees_315()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 315;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.71, -0.71), result);
		}

		[TestMethod]
		public void PointAtDegrees_330()
		{
			//assign
			Geometry.MarginOfError = 0.01;
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 330;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(0.87, -0.5), result);
		}

		[TestMethod]
		public void PointAtDegrees_360()
		{
			//assign
			Circle a = new Circle(new Dot(0, 0), 1);
			double degrees = 360;
			//act
			Dot result = a.PointAtDegrees(degrees);
			//assert
			Assert.AreEqual(new Dot(1, 0), result);
		}

		[TestMethod]
		public void DegreesToRadians()
		{
			//assign
			double degreesA = 0;
			double degreesB = 90;
			double degreesC = 180;
			double degreesD = 270;
			double degreesE = 360;
			//act
			double radiansA = Circle.DegreesToRadians(degreesA);
			double radiansB = Circle.DegreesToRadians(degreesB);
			double radiansC = Circle.DegreesToRadians(degreesC);
			double radiansD = Circle.DegreesToRadians(degreesD);
			double radiansE = Circle.DegreesToRadians(degreesE);
			//assert
			Assert.AreEqual(0, radiansA);
			Assert.AreEqual(Math.PI / 2, radiansB);
			Assert.AreEqual(Math.PI, radiansC);
			Assert.AreEqual(Math.PI + (Math.PI / 2), radiansD);
			Assert.AreEqual(2 * Math.PI, radiansE);
		}

		[TestMethod]
		public void RadiansToDegrees()
		{
			//assign
			double radiansA = 0;
			double radiansB = Math.PI / 2;
			double radiansC = Math.PI;
			double radiansD = Math.PI + (Math.PI / 2);
			double radiansE = 2 * Math.PI;
			//act
			double degreesA = Circle.RadiansToDegrees(radiansA);
			double degreesB = Circle.RadiansToDegrees(radiansB);
			double degreesC = Circle.RadiansToDegrees(radiansC);
			double degreesD = Circle.RadiansToDegrees(radiansD);
			double degreesE = Circle.RadiansToDegrees(radiansE);
			//assert
			Assert.AreEqual(0, degreesA);
			Assert.AreEqual(90, degreesB);
			Assert.AreEqual(180, degreesC);
			Assert.AreEqual(270, degreesD);
			Assert.AreEqual(360, degreesE);
		}
		
		[TestMethod]
		public void DegreesAtPoint_OnPaper_A()
		{
			//assign
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			Geometry.MarginOfError = 0.1;
			Circle circle = new Circle(new Dot(0, 0), 1);
			Dot lineEnd = new Dot(13, 22.5166604984);
			//act
			double degrees = circle.DegreesAtPoint(lineEnd);
			//assert
			Assert.IsTrue(Geometry.WithinMarginOfError(300, degrees));
		}

		[TestMethod]
		public void DegreesAtPoint_OnScreen_A()
		{
			//assign
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			Geometry.MarginOfError = 0.1;
			Circle circle = new Circle(new Dot(0, 0), 1);
			Dot lineEnd = new Dot(13, 22.5166604984);
			//act
			double degrees = circle.DegreesAtPoint(lineEnd);
			//assert
			Assert.IsTrue(Geometry.WithinMarginOfError(60, degrees));
		}

		[TestMethod]
		public void DegreesAtPoint_OnScreen_B()
		{
			//assign
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			Geometry.MarginOfError = 5;
			Circle circle = new Circle(new Dot(2019, 866), 1);
			Dot lineEnd = new Dot(1500, 1000);
			//act
			double degrees = circle.DegreesAtPoint(lineEnd);
			//assert
			Assert.IsTrue(Geometry.WithinMarginOfError(165, degrees));
		}

		[TestMethod]
		public void DegreesAtPoint_OnScreen_C()
		{
			//assign
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			Geometry.MarginOfError = 5;
			Circle circle = new Circle(new Dot(1737, 1730), 1);
			Dot lineEnd = new Dot(1573, 1227);
			//act
			double degrees = circle.DegreesAtPoint(lineEnd);
			//assert
			Assert.IsTrue(Geometry.WithinMarginOfError(252, degrees));
		}

	}
}
