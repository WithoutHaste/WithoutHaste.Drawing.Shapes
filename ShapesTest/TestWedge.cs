using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutHaste.Drawing.Shapes;

namespace GeometryTests
{
	[TestClass]
	public class TestWedge
	{
		[TestMethod]
		public void OverlapsWedge_LineEdge_AdjacentExternal_CircleInCircle_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 260, 280);
			WLineSegment aEdge = new WLineSegment(a.Circle.Center, a.EndPoint);
			WPoint centerB =  Geometry.PointOnLine(a.Circle.Center, a.EndPoint, a.Circle.Radius * 0.25);
			WCircle circleB = new WCircle(centerB, a.Circle.Radius * 0.5);
			double startDegreesB = circleB.DegreesAtPoint(a.EndPoint);
			WWedge b = new WWedge(circleB, startDegreesB, startDegreesB + 10);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_LineEdge_AdjacentExternal_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 260, 280);
			WLineSegment aEdge = new WLineSegment(a.Circle.Center, a.EndPoint);
			WPoint centerB =  Geometry.PointOnLine(a.Circle.Center, a.EndPoint, a.Circle.Radius * 0.25);
			WCircle circleB = new WCircle(centerB, a.Circle.Radius * 1.5);
			double startDegreesB = circleB.DegreesAtPoint(a.EndPoint);
			WWedge b = new WWedge(circleB, startDegreesB, startDegreesB + 10);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_LineEdge_AdjacentExternal_Almost_False()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 260, 280);
			WLineSegment aEdge = new WLineSegment(a.Circle.Center, a.EndPoint);
			WPoint centerB =  Geometry.PointOnLine(a.Circle.Center, a.EndPoint, a.Circle.Radius * 0.25);
			centerB = new WPoint(centerB.X + 0.05, centerB.Y);
			WCircle circleB = new WCircle(centerB, a.Circle.Radius * 0.5);
			double startDegreesB = circleB.DegreesAtPoint(a.EndPoint) + 2;
			WWedge b = new WWedge(circleB, startDegreesB, startDegreesB + 10);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcAndLineEdge_CircleInCircle_SmallBelow_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(1.8, 2.3), 0.75), 190, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcAndLineEdge_CircleInCircle_SmallAbove_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(1.8, 1.5), 0.75), 190, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcAndLineEdge_SmallBelow_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(3.2, 1.5), 2.5), 190, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcAndLineEdge_SmallAbove_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(2.7, 3.2), 2.5), 190, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_LineEdge_CrossWise_CircleInCircle_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(1.8, 2.3), 0.75), 260, 280);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_LineEdge_CrossWise_CircleInCircle_Almost_False()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(2.2, 2.3), 0.75), 260, 280);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void OverlapsWedge_LineEdge_CrossWise_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(2, 2), 2), 190, 230);
			WWedge b = new WWedge(new WCircle(new WPoint(1, 2.3), 2), 265, 275);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcOverLineEdge_CircleInCircle_FromOutside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 100, 145);
			WWedge b = new WWedge(new WCircle(new WPoint(1.8, 3.3), 0.5), 10, 170);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcOverLineEdge_CircleInCircle_FromInside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 100, 145);
			WWedge b = new WWedge(new WCircle(new WPoint(2.1, 4.1), 0.5), 180, 300);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcOverLineEdge_FromOutside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 100, 145);
			WWedge b = new WWedge(new WCircle(new WPoint(5.5, 5), 3), 160, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_Center_CircleInCircle_Inside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 0, 45);
			WWedge b = new WWedge(new WCircle(new WPoint(3, 3), 1.5), 30, 35);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_Center_CircleInCircle_Outside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 0, 45);
			WWedge b = new WWedge(new WCircle(new WPoint(3, 3), 3), 60, 90);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_CenterToEdge_CircleInCircle_Outside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			WLineSegment edgeA = a.LineEdges[1];
			WPoint centerB = Geometry.PointOnLine(edgeA.A, edgeA.B, a.Circle.Radius * 0.25);
			WWedge b = new WWedge(new WCircle(centerB, 0.5), 90, 120);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_CenterToEdge_CircleInCircle_Inside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			WLineSegment edgeA = a.LineEdges[1];
			WPoint centerB = Geometry.PointOnLine(edgeA.A, edgeA.B, a.Circle.Radius * 0.25);
			WWedge b = new WWedge(new WCircle(centerB, 0.5), 300, 330);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_CenterToEdge_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			WLineSegment edgeA = a.LineEdges[1];
			WPoint centerB = Geometry.PointOnLine(edgeA.A, edgeA.B, a.Circle.Radius * 0.25);
			WWedge b = new WWedge(new WCircle(centerB, 3), 90, 120);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_EntirelyInside_CircleInCircle_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			WWedge b = new WWedge(new WCircle(new WPoint(4, 3), 0.5), 300, 330);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_EntirelyInside_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), 250, 290);
			WWedge b = new WWedge(new WCircle(new WPoint(3, 0.25), 1), 80, 100);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcToArc_OneIntersect_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(1, 1), 1), -30, 30);
			WWedge b = new WWedge(new WCircle(new WPoint(3, 1), 1), 100, 200);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_ArcToArc_TwoIntersects_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(1, 1), 1), -30, 30);
			WWedge b = new WWedge(new WCircle(new WPoint(2.9, 1), 1), 100, 230);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_CenterToArc_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(1, 1), 1), -30, 30);
			WWedge b = new WWedge(new WCircle(new WPoint(2, 1), 1), -30, 30);
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsWedge_OneIsFullCircle_A_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(1342.5, 867.2), 187.338), 0, 360) / Utilities.UNITS_TO_PIXELS;
			WWedge b = new WWedge(new WCircle(new WPoint(1170.45, 1133.45), 225.53), 631, 648) / Utilities.UNITS_TO_PIXELS;
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsCircle_A_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WCircle a = new WCircle(new WPoint(1342.5, 867.2), 187.338) / Utilities.UNITS_TO_PIXELS;
			WWedge b = new WWedge(new WCircle(new WPoint(1170.45, 1133.45), 225.53), 631, 648) / Utilities.UNITS_TO_PIXELS;
			//account
			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = b.Overlaps(a);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsCircle_Temp()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(550.83386399939, 0), 235.084533229311), 73.6363636363638, 90.0000000000002) / Utilities.UNITS_TO_PIXELS;
			WCircle b = new WCircle(new WPoint(444.902178042324, 244.587042149464), 149.14086054459278) / Utilities.UNITS_TO_PIXELS;
			//account
//			Utilities.SaveDiagram(new IDraw[] { a, b }, nameof(TestWedge));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DegreesContains_RangeCrosses360_Below360_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			//act
			bool result = a.Degrees.Overlaps(355);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DegreesContains_RangeCrosses360_Above0_True()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			//act
			bool result = a.Degrees.Overlaps(10);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DegreesContains_RangeCrosses360_Below360_False()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			//act
			bool result = a.Degrees.Overlaps(-50);
			//assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void DegreesContains_RangeCrosses360_Above0_False()
		{
			//assign
			Geometry.MarginOfError = 0.000001;
			Geometry.CoordinatePlane = Geometry.CoordinatePlanes.Screen;
			WWedge a = new WWedge(new WCircle(new WPoint(3, 3), 3), -45, 45);
			//act
			bool result = a.Degrees.Overlaps(55);
			//assert
			Assert.IsFalse(result);
		}
	}
}
