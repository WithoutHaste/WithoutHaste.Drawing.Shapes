using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestDot
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
