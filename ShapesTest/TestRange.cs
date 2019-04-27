using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestRange
	{
		[TestMethod]
		public void Span_StartLessThanEnd()
		{
			//assign
			WRange a = new WRange(5, 120);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(115, result);
		}

		[TestMethod]
		public void Span_StartGreaterThanEnd()
		{
			//assign
			WRange a = new WRange(120, 5);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(-115, result);
		}

		[TestMethod]
		public void Span_StartEqualToEnd()
		{
			//assign
			WRange a = new WRange(120, 120);
			//act
			double result = a.Span;
			//assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void Middle_StartEqualToEnd()
		{
			//assign
			WRange a = new WRange(0, 0);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void Middle_StartLessThanEnd()
		{
			//assign
			WRange a = new WRange(45, 55);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(50, result);
		}

		[TestMethod]
		public void Middle_StartGreaterThanEnd()
		{
			//assign
			WRange a = new WRange(350, 10);
			//act
			double result = a.Middle;
			//assert
			Assert.AreEqual(350 - 170, result);
		}

		[TestMethod]
		public void Overlaps_False()
		{
			//assign
			WRange a = new WRange(270, 300);
			WRange b = new WRange(10, 30);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsFalse(resultA);
			Assert.IsFalse(resultB);
		}

		[TestMethod]
		public void Overlaps_Barely()
		{
			//assign
			WRange a = new WRange(30, 100);
			WRange b = new WRange(0, 30);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsTrue(resultA);
			Assert.IsTrue(resultB);
		}

		[TestMethod]
		public void Overlaps_Some()
		{
			//assign
			WRange a = new WRange(20, 100);
			WRange b = new WRange(-5, 30);
			//act
			bool resultA = a.Overlaps(b);
			bool resultB = b.Overlaps(a);
			//assert
			Assert.IsTrue(resultA);
			Assert.IsTrue(resultB);
		}

		[TestMethod]
		public void Overlaps_Completely()
		{
			//assign
			WRange a = new WRange(-270, 450);
			WRange b = new WRange(-5, 5);
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
			WRange a = new WRange(-270, 450);
			WRange b = new WRange(-5, 5);
			//act
			WRange resultA = a + b;
			WRange resultB = b + a;
			//assert
			Assert.AreEqual(resultA, resultB);
			Assert.AreEqual(a, resultA);
		}

		[TestMethod]
		public void OperatorPlus_PartialOverlap()
		{
			//assign
			WRange a = new WRange(20, 100);
			WRange b = new WRange(-5, 30);
			//act
			WRange resultA = a + b;
			WRange resultB = b + a;
			//assert
			Assert.AreEqual(resultA, resultB);
			Assert.AreEqual(new WRange(-5, 100), resultA);
		}

		[TestMethod]
		public void OperatorPlus_NoOverlap()
		{
			//assign
			WRange a = new WRange(270, 300);
			WRange b = new WRange(10, 30);
			//act
			WRange resultA = a + b;
			WRange resultB = b + a;
			//assert
			Assert.AreEqual(resultA, resultB);
			Assert.AreEqual(new WRange(10, 300), resultA);
		}
	}
}
