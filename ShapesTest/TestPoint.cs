using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestPoint
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_X_NaN_Exception()
		{
			//assign
			double x = double.NaN;
			double y = 1;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_Y_NaN_Exception()
		{
			//assign
			double x = 1;
			double y = double.NaN;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_X_PositiveInfinity_Exception()
		{
			//assign
			double x = double.PositiveInfinity;
			double y = 1;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_Y_PositiveInfinity_Exception()
		{
			//assign
			double x = 1;
			double y = double.PositiveInfinity;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_X_NegativeInfinity_Exception()
		{
			//assign
			double x = double.NegativeInfinity;
			double y = 1;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_Y_NegativeInfinity_Exception()
		{
			//assign
			double x = 1;
			double y = double.NegativeInfinity;
			//act
			WPoint Dot = new WPoint(x, y);
			//expected exception
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_0Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 0;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 45;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(1.414, 1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_90Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 90;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 2), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_135Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 135;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-1.414, 1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_180Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 180;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-2, 0), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_225Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 225;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-1.414, -1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_270Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 270;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(0, -2), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_315Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 315;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(1.414, -1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Paper_360Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			double degrees = 360;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_0Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 0;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 45;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(1.414, -1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_90Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 90;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(0, -2), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_135Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 135;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-1.414, -1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_180Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 180;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-2, 0), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_225Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 225;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(-1.414, 1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_270Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 270;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 2), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_315Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 315;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(new WPoint(1.414, 1.414), result);
		}

		[TestMethod]
		public void RotateAroundOrigin_Screen_360Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			double degrees = 360;
			//act
			WPoint result = start.RotateAroundOrigin(degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void Rotate_Paper_0Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 0;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void Rotate_Paper_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 45;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(2.414, 1), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_90Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 90;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(2, 2), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_135Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 135;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(1, 2.414), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_180Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 180;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 2), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_225Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 225;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(-0.414, 1), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_270Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 270;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 0), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_315Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 315;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(1, -0.414), result);
		}
		
		[TestMethod]
		public void Rotate_Paper_360Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Paper;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 360;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void Rotate_Screen_0Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 0;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void Rotate_Screen_45Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 45;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(1, -0.414), result);
		}

		[TestMethod]
		public void Rotate_Screen_90Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 90;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 0), result);
		}

		[TestMethod]
		public void Rotate_Screen_135Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 135;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(-0.414, 1), result);
		}

		[TestMethod]
		public void Rotate_Screen_180Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 180;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(0, 2), result);
		}

		[TestMethod]
		public void Rotate_Screen_225Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 225;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(1, 2.414), result);
		}

		[TestMethod]
		public void Rotate_Screen_270Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 270;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(2, 2), result);
		}

		[TestMethod]
		public void Rotate_Screen_315Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 315;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(new WPoint(2.414, 1), result);
		}

		[TestMethod]
		public void Rotate_Screen_360Degrees()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WPoint start = new WPoint(2, 0);
			WPoint reference = new WPoint(1, 1);
			double degrees = 360;
			//act
			WPoint result = start.Rotate(reference, degrees);
			//assert
			Assert.AreEqual(start, result);
		}

		[TestMethod]
		public void Equality_DifferentX_OutsideMarginOfError()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WPoint a = new WPoint(1, 2);
			WPoint b = new WPoint(a.X + (2 * Geometry.MarginOfError), a.Y);
			//act
			bool result = (a == b);
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Equality_DifferentX_InsideMarginOfError()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WPoint a = new WPoint(1, 2);
			WPoint b = new WPoint(a.X + Geometry.MarginOfError, a.Y);
			//act
			bool result = (a == b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Equality_DifferentY_OutsideMarginOfError()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WPoint a = new WPoint(1, 2);
			WPoint b = new WPoint(a.X, a.Y + (2 * Geometry.MarginOfError));
			//act
			bool result = (a == b);
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Equality_DifferentY_InsideMarginOfError()
		{
			//assign
			Geometry.MarginOfError = 0.001;
			WPoint a = new WPoint(1, 2);
			WPoint b = new WPoint(a.X, a.Y + Geometry.MarginOfError);
			//act
			bool result = (a == b);
			//assert
			Assert.IsTrue(result);
		}
	}
}
