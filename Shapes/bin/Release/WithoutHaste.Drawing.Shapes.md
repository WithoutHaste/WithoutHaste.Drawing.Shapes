<a name='assembly'></a>
# WithoutHaste.Drawing.Shapes

## Contents

- [Circle](#T-WithoutHaste-Drawing-Shapes-Circle 'WithoutHaste.Drawing.Shapes.Circle')
  - [Contains()](#M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Circle.Contains(WithoutHaste.Drawing.Shapes.Circle)')
  - [Contains()](#M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Wedge- 'WithoutHaste.Drawing.Shapes.Circle.Contains(WithoutHaste.Drawing.Shapes.Wedge)')
  - [Contains()](#M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Circle.Contains(WithoutHaste.Drawing.Shapes.Point)')
  - [ContainsOrIsContained()](#M-WithoutHaste-Drawing-Shapes-Circle-ContainsOrIsContained-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Circle.ContainsOrIsContained(WithoutHaste.Drawing.Shapes.Circle)')
  - [DegreesAtPoint()](#M-WithoutHaste-Drawing-Shapes-Circle-DegreesAtPoint-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Circle.DegreesAtPoint(WithoutHaste.Drawing.Shapes.Point)')
  - [GetIntersectionPoints()](#M-WithoutHaste-Drawing-Shapes-Circle-GetIntersectionPoints-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Circle.GetIntersectionPoints(WithoutHaste.Drawing.Shapes.Circle)')
  - [GetIntersectionPoints(line)](#M-WithoutHaste-Drawing-Shapes-Circle-GetIntersectionPoints-WithoutHaste-Drawing-Shapes-Line- 'WithoutHaste.Drawing.Shapes.Circle.GetIntersectionPoints(WithoutHaste.Drawing.Shapes.Line)')
  - [GetTangentPoints()](#M-WithoutHaste-Drawing-Shapes-Circle-GetTangentPoints-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Circle.GetTangentPoints(WithoutHaste.Drawing.Shapes.Point)')
  - [op_Division()](#M-WithoutHaste-Drawing-Shapes-Circle-op_Division-WithoutHaste-Drawing-Shapes-Circle,System-Double- 'WithoutHaste.Drawing.Shapes.Circle.op_Division(WithoutHaste.Drawing.Shapes.Circle,System.Double)')
  - [Overlaps()](#M-WithoutHaste-Drawing-Shapes-Circle-Overlaps-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Circle.Overlaps(WithoutHaste.Drawing.Shapes.Circle)')
  - [Overlaps()](#M-WithoutHaste-Drawing-Shapes-Circle-Overlaps-WithoutHaste-Drawing-Shapes-LineSegment- 'WithoutHaste.Drawing.Shapes.Circle.Overlaps(WithoutHaste.Drawing.Shapes.LineSegment)')
  - [PointAtDegrees()](#M-WithoutHaste-Drawing-Shapes-Circle-PointAtDegrees-System-Double- 'WithoutHaste.Drawing.Shapes.Circle.PointAtDegrees(System.Double)')
  - [PointAtRadians()](#M-WithoutHaste-Drawing-Shapes-Circle-PointAtRadians-System-Double- 'WithoutHaste.Drawing.Shapes.Circle.PointAtRadians(System.Double)')
- [CoordinatePlanes](#T-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes 'WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes')
  - [Paper](#F-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes-Paper 'WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes.Paper')
  - [Screen](#F-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes-Screen 'WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes.Screen')
- [Geometry](#T-WithoutHaste-Drawing-Shapes-Geometry 'WithoutHaste.Drawing.Shapes.Geometry')
  - [MarginOfError](#F-WithoutHaste-Drawing-Shapes-Geometry-MarginOfError 'WithoutHaste.Drawing.Shapes.Geometry.MarginOfError')
  - [LineDirection()](#M-WithoutHaste-Drawing-Shapes-Geometry-LineDirection-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Geometry.LineDirection(WithoutHaste.Drawing.Shapes.Point,WithoutHaste.Drawing.Shapes.Point)')
  - [PointOnLine()](#M-WithoutHaste-Drawing-Shapes-Geometry-PointOnLine-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point,System-Double- 'WithoutHaste.Drawing.Shapes.Geometry.PointOnLine(WithoutHaste.Drawing.Shapes.Point,WithoutHaste.Drawing.Shapes.Point,System.Double)')
  - [PointPastLine()](#M-WithoutHaste-Drawing-Shapes-Geometry-PointPastLine-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point,System-Double- 'WithoutHaste.Drawing.Shapes.Geometry.PointPastLine(WithoutHaste.Drawing.Shapes.Point,WithoutHaste.Drawing.Shapes.Point,System.Double)')
- [Line](#T-WithoutHaste-Drawing-Shapes-Line 'WithoutHaste.Drawing.Shapes.Line')
  - [IsDirected](#F-WithoutHaste-Drawing-Shapes-Line-IsDirected 'WithoutHaste.Drawing.Shapes.Line.IsDirected')
  - [Slope](#P-WithoutHaste-Drawing-Shapes-Line-Slope 'WithoutHaste.Drawing.Shapes.Line.Slope')
  - [GetPerpendicularIntersect()](#M-WithoutHaste-Drawing-Shapes-Line-GetPerpendicularIntersect-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Line.GetPerpendicularIntersect(WithoutHaste.Drawing.Shapes.Point)')
  - [op_Division()](#M-WithoutHaste-Drawing-Shapes-Line-op_Division-WithoutHaste-Drawing-Shapes-Line,System-Double- 'WithoutHaste.Drawing.Shapes.Line.op_Division(WithoutHaste.Drawing.Shapes.Line,System.Double)')
- [Point](#T-WithoutHaste-Drawing-Shapes-Point 'WithoutHaste.Drawing.Shapes.Point')
  - [Distance()](#M-WithoutHaste-Drawing-Shapes-Point-Distance-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Point.Distance(WithoutHaste.Drawing.Shapes.Point)')
  - [op_LessThan()](#M-WithoutHaste-Drawing-Shapes-Point-op_LessThan-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Point.op_LessThan(WithoutHaste.Drawing.Shapes.Point,WithoutHaste.Drawing.Shapes.Point)')
- [Range](#T-WithoutHaste-Drawing-Shapes-Range 'WithoutHaste.Drawing.Shapes.Range')
  - [Start](#F-WithoutHaste-Drawing-Shapes-Range-Start 'WithoutHaste.Drawing.Shapes.Range.Start')
  - [ConvertValue()](#M-WithoutHaste-Drawing-Shapes-Range-ConvertValue-WithoutHaste-Drawing-Shapes-Range,WithoutHaste-Drawing-Shapes-Range,System-Double- 'WithoutHaste.Drawing.Shapes.Range.ConvertValue(WithoutHaste.Drawing.Shapes.Range,WithoutHaste.Drawing.Shapes.Range,System.Double)')
  - [op_Addition()](#M-WithoutHaste-Drawing-Shapes-Range-op_Addition-WithoutHaste-Drawing-Shapes-Range,WithoutHaste-Drawing-Shapes-Range- 'WithoutHaste.Drawing.Shapes.Range.op_Addition(WithoutHaste.Drawing.Shapes.Range,WithoutHaste.Drawing.Shapes.Range)')
- [RangeCircular](#T-WithoutHaste-Drawing-Shapes-RangeCircular 'WithoutHaste.Drawing.Shapes.RangeCircular')
  - [Mod()](#M-WithoutHaste-Drawing-Shapes-RangeCircular-Mod-System-Double,System-Int32- 'WithoutHaste.Drawing.Shapes.RangeCircular.Mod(System.Double,System.Int32)')
  - [op_Addition()](#M-WithoutHaste-Drawing-Shapes-RangeCircular-op_Addition-WithoutHaste-Drawing-Shapes-RangeCircular,WithoutHaste-Drawing-Shapes-RangeCircular- 'WithoutHaste.Drawing.Shapes.RangeCircular.op_Addition(WithoutHaste.Drawing.Shapes.RangeCircular,WithoutHaste.Drawing.Shapes.RangeCircular)')
- [Wedge](#T-WithoutHaste-Drawing-Shapes-Wedge 'WithoutHaste.Drawing.Shapes.Wedge')
  - [ArcPoint](#P-WithoutHaste-Drawing-Shapes-Wedge-ArcPoint 'WithoutHaste.Drawing.Shapes.Wedge.ArcPoint')
  - [ArcOverlaps()](#M-WithoutHaste-Drawing-Shapes-Wedge-ArcOverlaps-WithoutHaste-Drawing-Shapes-LineSegment- 'WithoutHaste.Drawing.Shapes.Wedge.ArcOverlaps(WithoutHaste.Drawing.Shapes.LineSegment)')
  - [ArcOverlapsArc()](#M-WithoutHaste-Drawing-Shapes-Wedge-ArcOverlapsArc-WithoutHaste-Drawing-Shapes-Wedge- 'WithoutHaste.Drawing.Shapes.Wedge.ArcOverlapsArc(WithoutHaste.Drawing.Shapes.Wedge)')
  - [Contains()](#M-WithoutHaste-Drawing-Shapes-Wedge-Contains-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Wedge.Contains(WithoutHaste.Drawing.Shapes.Circle)')
  - [Contains()](#M-WithoutHaste-Drawing-Shapes-Wedge-Contains-WithoutHaste-Drawing-Shapes-Point- 'WithoutHaste.Drawing.Shapes.Wedge.Contains(WithoutHaste.Drawing.Shapes.Point)')
  - [op_Division()](#M-WithoutHaste-Drawing-Shapes-Wedge-op_Division-WithoutHaste-Drawing-Shapes-Wedge,System-Double- 'WithoutHaste.Drawing.Shapes.Wedge.op_Division(WithoutHaste.Drawing.Shapes.Wedge,System.Double)')
  - [Overlaps()](#M-WithoutHaste-Drawing-Shapes-Wedge-Overlaps-WithoutHaste-Drawing-Shapes-Circle- 'WithoutHaste.Drawing.Shapes.Wedge.Overlaps(WithoutHaste.Drawing.Shapes.Circle)')
  - [Overlaps()](#M-WithoutHaste-Drawing-Shapes-Wedge-Overlaps-WithoutHaste-Drawing-Shapes-Wedge- 'WithoutHaste.Drawing.Shapes.Wedge.Overlaps(WithoutHaste.Drawing.Shapes.Wedge)')
- [WedgeUnbound](#T-WithoutHaste-Drawing-Shapes-WedgeUnbound 'WithoutHaste.Drawing.Shapes.WedgeUnbound')

<a name='T-WithoutHaste-Drawing-Shapes-Circle'></a>
## Circle `type`

##### Namespace

WithoutHaste.Drawing.Shapes

<a name='M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Circle-'></a>
### Contains() `method`

##### Summary

This circle entirely contains circle B, or they exactly overlap.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Wedge-'></a>
### Contains() `method`

##### Summary

This circle entirely contains wedge B.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-Contains-WithoutHaste-Drawing-Shapes-Point-'></a>
### Contains() `method`

##### Summary

Point B lies within or on this circle.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-ContainsOrIsContained-WithoutHaste-Drawing-Shapes-Circle-'></a>
### ContainsOrIsContained() `method`

##### Summary

This circle entirely contains circle B, or B entirely contains this circle, or they exactly overlap.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-DegreesAtPoint-WithoutHaste-Drawing-Shapes-Point-'></a>
### DegreesAtPoint() `method`

##### Summary

Given a line from the center of a circle to a point, what degrees is the line angle at? 0 degrees is East from center, and increases clockwise.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-GetIntersectionPoints-WithoutHaste-Drawing-Shapes-Circle-'></a>
### GetIntersectionPoints() `method`

##### Summary

Returns null (no intersection), an array of length 1, or an array of length 2.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-GetIntersectionPoints-WithoutHaste-Drawing-Shapes-Line-'></a>
### GetIntersectionPoints(line) `method`

##### Summary

Returns null (no intercepts), or array of length 1 or 2.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [WithoutHaste.Drawing.Shapes.Line](#T-WithoutHaste-Drawing-Shapes-Line 'WithoutHaste.Drawing.Shapes.Line') |  |

<a name='M-WithoutHaste-Drawing-Shapes-Circle-GetTangentPoints-WithoutHaste-Drawing-Shapes-Point-'></a>
### GetTangentPoints() `method`

##### Summary

Find the two tangent points on the circle that form lines to point B.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-op_Division-WithoutHaste-Drawing-Shapes-Circle,System-Double-'></a>
### op_Division() `method`

##### Summary

Scale circle down by B amount. Affects length and location measures.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-Overlaps-WithoutHaste-Drawing-Shapes-Circle-'></a>
### Overlaps() `method`

##### Summary

Any part of this circle overlaps any part of circle B.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-Overlaps-WithoutHaste-Drawing-Shapes-LineSegment-'></a>
### Overlaps() `method`

##### Summary

Any part of this circle overlaps any part of line segment B.
If line B lies within the circle, that counts as overlapping.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-PointAtDegrees-System-Double-'></a>
### PointAtDegrees() `method`

##### Summary

Return the point on the circle at this degree. 0 degrees is East of center, increases clockwise.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Circle-PointAtRadians-System-Double-'></a>
### PointAtRadians() `method`

##### Summary

Return the point on the circle at this radians. 0 radians is East of center, increases clockwise.

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes'></a>
## CoordinatePlanes `type`

##### Namespace

WithoutHaste.Drawing.Shapes.Geometry

<a name='F-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes-Paper'></a>
### Paper `constants`

##### Summary

Paper graphs have (0,0) in the lower-left corner and increase to the right and up.

<a name='F-WithoutHaste-Drawing-Shapes-Geometry-CoordinatePlanes-Screen'></a>
### Screen `constants`

##### Summary

Computer screens have (0,0) in the upper-left corner and increase to the right and down.

<a name='T-WithoutHaste-Drawing-Shapes-Geometry'></a>
## Geometry `type`

##### Namespace

WithoutHaste.Drawing.Shapes

<a name='F-WithoutHaste-Drawing-Shapes-Geometry-MarginOfError'></a>
### MarginOfError `constants`

##### Summary

When determining equality, all values have a +- margin of error.

<a name='M-WithoutHaste-Drawing-Shapes-Geometry-LineDirection-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point-'></a>
### LineDirection() `method`

##### Summary

Given directed line A to B, what direction is it pointing?
North, South, East, and West are precise. The inbetween directions are vague.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Geometry-PointOnLine-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point,System-Double-'></a>
### PointOnLine() `method`

##### Summary

Calculates point along line AB, starting at A and moving towards B

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Geometry-PointPastLine-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point,System-Double-'></a>
### PointPastLine() `method`

##### Summary

Calculates point along line AB, starting at B and moving away from A

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-Line'></a>
## Line `type`

##### Namespace

WithoutHaste.Drawing.Shapes

##### Summary

Line of infinite length passing between points A and B.

<a name='F-WithoutHaste-Drawing-Shapes-Line-IsDirected'></a>
### IsDirected `constants`

##### Summary

When directed, the direction is A to B.

<a name='P-WithoutHaste-Drawing-Shapes-Line-Slope'></a>
### Slope `property`

##### Summary

Slope assumes direction from A to B.

<a name='M-WithoutHaste-Drawing-Shapes-Line-GetPerpendicularIntersect-WithoutHaste-Drawing-Shapes-Point-'></a>
### GetPerpendicularIntersect() `method`

##### Summary

Get the point where a perpendicular line passing through point C intersects this line.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Line-op_Division-WithoutHaste-Drawing-Shapes-Line,System-Double-'></a>
### op_Division() `method`

##### Summary

Scale line down by B amount. Affects length and location measures.

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-Point'></a>
## Point `type`

##### Namespace

WithoutHaste.Drawing.Shapes

<a name='M-WithoutHaste-Drawing-Shapes-Point-Distance-WithoutHaste-Drawing-Shapes-Point-'></a>
### Distance() `method`

##### Summary

Distance between this point and point B.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Point-op_LessThan-WithoutHaste-Drawing-Shapes-Point,WithoutHaste-Drawing-Shapes-Point-'></a>
### op_LessThan() `method`

##### Summary

Greater than/less than is judged along the x-axis first, then the y-axis

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-Range'></a>
## Range `type`

##### Namespace

WithoutHaste.Drawing.Shapes

<a name='F-WithoutHaste-Drawing-Shapes-Range-Start'></a>
### Start `constants`

##### Summary

For non-circular ranges, operations assume that Start is the minimum value.

<a name='M-WithoutHaste-Drawing-Shapes-Range-ConvertValue-WithoutHaste-Drawing-Shapes-Range,WithoutHaste-Drawing-Shapes-Range,System-Double-'></a>
### ConvertValue() `method`

##### Summary

Convert a value in originalRange to one in newRange, assuming that the original range is re-scaled to the new range.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Range-op_Addition-WithoutHaste-Drawing-Shapes-Range,WithoutHaste-Drawing-Shapes-Range-'></a>
### op_Addition() `method`

##### Summary

Returns a range that covers all the area both A and B cover, including any gap in between.
This operation is commutative.

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-RangeCircular'></a>
## RangeCircular `type`

##### Namespace

WithoutHaste.Drawing.Shapes

<a name='M-WithoutHaste-Drawing-Shapes-RangeCircular-Mod-System-Double,System-Int32-'></a>
### Mod() `method`

##### Summary

Returns number modulus m. Ensures a positive result.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-RangeCircular-op_Addition-WithoutHaste-Drawing-Shapes-RangeCircular,WithoutHaste-Drawing-Shapes-RangeCircular-'></a>
### op_Addition() `method`

##### Summary

Returns a range that covers all the area both A and B cover, including any gap in between.
If the ranges overlap, there is no gap filled in.
Gaps are covered from direction A to B, therefore this operation is not commutative.

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-Wedge'></a>
## Wedge `type`

##### Namespace

WithoutHaste.Drawing.Shapes

##### Summary

A wedge (aka circular sector) is a slice of a circle.

<a name='P-WithoutHaste-Drawing-Shapes-Wedge-ArcPoint'></a>
### ArcPoint `property`

##### Summary

The point at the center of the arc, furthest from the center.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-ArcOverlaps-WithoutHaste-Drawing-Shapes-LineSegment-'></a>
### ArcOverlaps() `method`

##### Summary

The arc is the curved circle segment part of the wedge.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-ArcOverlapsArc-WithoutHaste-Drawing-Shapes-Wedge-'></a>
### ArcOverlapsArc() `method`

##### Summary

The arc is the curved circle segment part of the wedge.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-Contains-WithoutHaste-Drawing-Shapes-Circle-'></a>
### Contains() `method`

##### Summary

Circle B lies entirely within this wedge.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-Contains-WithoutHaste-Drawing-Shapes-Point-'></a>
### Contains() `method`

##### Summary

This wedge contains point B, including point B being on an edge of the wedge.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-op_Division-WithoutHaste-Drawing-Shapes-Wedge,System-Double-'></a>
### op_Division() `method`

##### Summary

Scale wedge down by B amount. Affects length and location measures, but not degrees.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-Overlaps-WithoutHaste-Drawing-Shapes-Circle-'></a>
### Overlaps() `method`

##### Summary

Any part of this wedge overlaps any part of circle B.

##### Parameters

This method has no parameters.

<a name='M-WithoutHaste-Drawing-Shapes-Wedge-Overlaps-WithoutHaste-Drawing-Shapes-Wedge-'></a>
### Overlaps() `method`

##### Summary

Any part of this wedge overlaps any part of wedge B.

##### Parameters

This method has no parameters.

<a name='T-WithoutHaste-Drawing-Shapes-WedgeUnbound'></a>
## WedgeUnbound `type`

##### Namespace

WithoutHaste.Drawing.Shapes

##### Summary

A wedge (aka circular sector) is a slice of a circle.
An unbounded wedge is a slice of circle that extends outward with no limit.
