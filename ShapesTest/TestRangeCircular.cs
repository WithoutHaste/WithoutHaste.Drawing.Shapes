using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestRangeCircular
	{
		[TestMethod]
		public void Span_StartLessThanEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(5, 120, 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(115, result);
		}

		[TestMethod]
		public void Span_StartLessThanEnd_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(360 + 5, 360 + 120, 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(115, result);
		}

		[TestMethod]
		public void Span_StartGreaterThanEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(120, 5, 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(245, result);
		}

		[TestMethod]
		public void Span_StartGreaterThanEnd_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(-1 * (360 - 120), -1 * (360 - 5), 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(245, result);
		}

		[TestMethod]
		public void Span_StartEqualToEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(120, 120, 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(360, result);
		}

		[TestMethod]
		public void Span_StartEqualToEnd_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(0, 360, 360);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(360, result);
		}

		[TestMethod]
		public void Middle_StartEqualToEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(0, 0, 360);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(180, result);
		}

		[TestMethod]
		public void Middle_StartEqualToEnd_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(0, 360, 360);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(180, result);
		}

		[TestMethod]
		public void Middle_StartLessThanEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(45, 55, 360);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(50, result);
		}

		[TestMethod]
		public void Middle_StartGreaterThanEnd()
		{
			//assign
			WRangeCircular a = new WRangeCircular(350, 10, 360);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void Middle_StartGreaterThanEnd_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(-10, 10, 360);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_ZeroModulus()
		{
			//assign
			int modulus = 0;
			//act
			WRangeCircular range = new WRangeCircular(0, 0, modulus);
			//expected exception
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void Constructor_NegativeModulus()
		{
			//assign
			int modulus = -1;
			//act
			WRangeCircular range = new WRangeCircular(0, 0, modulus);
			//expected exception
		}

		[TestMethod]
		public void Overlaps_False()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 300, 360);
			WRangeCircular b = new WRangeCircular(10, 30, 360);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsFalse(resultA);
			Assert.IsFalse(resultB);
		}

		[TestMethod]
		public void Overlaps_Barely_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 360, 360);
			WRangeCircular b = new WRangeCircular(0, 30, 360);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsTrue(resultA);
			Assert.IsTrue(resultB);
		}

		[TestMethod]
		public void Overlaps_Some_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 370, 360);
			WRangeCircular b = new WRangeCircular(-5, 30, 360);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsTrue(resultA);
			Assert.IsTrue(resultB);
		}

		[TestMethod]
		public void Overlaps_Completely_Mod()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 450, 360);
			WRangeCircular b = new WRangeCircular(-5, 5, 360);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsTrue(resultA);
			Assert.IsTrue(resultB);
		}

		[TestMethod]
		public void OperatorPlus_CompleteOverlap()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 450, 360);
			WRangeCircular b = new WRangeCircular(-5, 5, 360);
			//act
			WRangeCircular resultA = a + b;
			WRangeCircular resultB = b + a;
			//assert
			Assert.AreEqual(resultA, resultB);
			Assert.AreEqual(a, resultA);
		}

		[TestMethod]
		public void OperatorPlus_PartialOverlap()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 360, 360);
			WRangeCircular b = new WRangeCircular(-5, 5, 360);
			//act
			WRangeCircular resultA = a + b;
			WRangeCircular resultB = b + a;
			//assert
			Assert.AreEqual(resultA, resultB);
			Assert.AreEqual(new WRangeCircular(270, 5, 360), resultA);
		}

		[TestMethod]
		public void OperatorPlus_NoOverlap()
		{
			//assign
			WRangeCircular a = new WRangeCircular(270, 280, 360);
			WRangeCircular b = new WRangeCircular(-5, 5, 360);
			//act
			WRangeCircular resultA = a + b;
			WRangeCircular resultB = b + a;
			//assert
			Assert.AreNotEqual(resultA, resultB);
			Assert.AreEqual(new WRangeCircular(270, 5, 360), resultA);
			Assert.AreEqual(new WRangeCircular(-5, 280, 360), resultB);
		}
	}
}
