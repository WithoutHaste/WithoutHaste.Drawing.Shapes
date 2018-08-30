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
			LineSegment a = new LineSegment(new Dot(0, 0), new Dot(5, 0));
			LineSegment b = new LineSegment(new Dot(1, 0), new Dot(4, 0));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void OverlapsLineSegment_Overlaid_LargeBothWays()
		{
			//assign
			LineSegment a = new LineSegment(new Dot(1, 0), new Dot(4, 0));
			LineSegment b = new LineSegment(new Dot(0, 0), new Dot(5, 0));
			//act
			bool result = a.Overlaps(b);
			//assert
			Assert.IsTrue(result);
		}
	}
}
