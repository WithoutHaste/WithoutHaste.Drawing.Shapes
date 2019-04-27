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
	}
}
