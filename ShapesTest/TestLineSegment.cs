using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestLineSegment
	{
		[TestMethod]
		public void OverlapsLineSegment_Overlaid_SmallerBothWays()
		{
			//assign
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(5, 0));
			WLineSegment b = new WLineSegment(new WPoint(1, 0), new WPoint(4, 0));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsLineSegment_Overlaid_LargeBothWays()
		{
			//assign
			WLineSegment a = new WLineSegment(new WPoint(1, 0), new WPoint(4, 0));
			WLineSegment b = new WLineSegment(new WPoint(0, 0), new WPoint(5, 0));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_SameDirection_NoOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(3, 0));
			WLineSegment b = new WLineSegment(new WPoint(4, 0), new WPoint(6, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsNone);
			Assert.IsTrue(resultB.IsNone);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_DifferentDirection_NoOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(3, 0));
			WLineSegment b = new WLineSegment(new WPoint(6, 0), new WPoint(4, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsNone);
			Assert.IsTrue(resultB.IsNone);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_SameDirection_PointOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(3, 0));
			WLineSegment b = new WLineSegment(new WPoint(3, 0), new WPoint(6, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsPoint);
			Assert.IsTrue(resultB.IsPoint);
			Assert.AreEqual(new WPoint(3, 0), resultA.Point);
			Assert.AreEqual(new WPoint(3, 0), resultB.Point);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_DifferentDirection_PointOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(3, 0));
			WLineSegment b = new WLineSegment(new WPoint(6, 0), new WPoint(3, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsPoint);
			Assert.IsTrue(resultB.IsPoint);
			Assert.AreEqual(new WPoint(3, 0), resultA.Point);
			Assert.AreEqual(new WPoint(3, 0), resultB.Point);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_SameDirection_BothPartialOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(4, 0));
			WLineSegment b = new WLineSegment(new WPoint(3, 0), new WPoint(6, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultB.LineSegment);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_DifferentDirection_BothPartialOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(4, 0));
			WLineSegment b = new WLineSegment(new WPoint(6, 0), new WPoint(3, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultB.LineSegment);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_SameDirection_OnePartialOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(6, 0));
			WLineSegment b = new WLineSegment(new WPoint(3, 0), new WPoint(6, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(6, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(6, 0)), resultB.LineSegment);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_DifferentDirection_OnePartialOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(6, 0));
			WLineSegment b = new WLineSegment(new WPoint(6, 0), new WPoint(3, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(6, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(6, 0)), resultB.LineSegment);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_SameDirection_OneEncompassingOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(6, 0));
			WLineSegment b = new WLineSegment(new WPoint(3, 0), new WPoint(4, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultB.LineSegment);
		}

		[TestMethod]
		public void GetIntersection_WLineSegment_Parallel_DifferentDirection_OneEncompassingOverlap()
		{
			//arrange
			Geometry.MarginOfError = 0.001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WLineSegment a = new WLineSegment(new WPoint(0, 0), new WPoint(6, 0));
			WLineSegment b = new WLineSegment(new WPoint(4, 0), new WPoint(3, 0));
			//act
			Intersection resultA = a.GetIntersection(b);
			Intersection resultB = b.GetIntersection(a);
			//assert
			Assert.IsTrue(resultA.IsLineSegment);
			Assert.IsTrue(resultB.IsLineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultA.LineSegment);
			Assert.AreEqual(new WLineSegment(new WPoint(3, 0), new WPoint(4, 0)), resultB.LineSegment);
		}
	}
}
