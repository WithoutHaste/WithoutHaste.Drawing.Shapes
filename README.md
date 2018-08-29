# WithoutHaste.Drawing.Shapes

C# Library of shape and geometry calculations and operations.

This library is under active development. Report bugs and request features on Github, or to wohaste@gmail.com.

## Shapes

[Point](documentation/Point.md)  
[Line](documentation/Line.md)  
[LineSegment](documentation/LineSegment.md)  

[Range](documentation/Range.md)  
[RangeCircular](documentation/RangeCircular.md)  

[Circle](documentation/Circle.md)  
[Wedge](documentation/Wedge.md)  
[WedgeUnbound](documentation/WedgeUnbound.md)  

## IDraw interface

A shape that can be drawn on a `Graphics` object.

### Properties

`double MaxX`: highest x value required to draw the shape.  
`double MaxY`: highest y value required to draw the shape.  

### Methods

#### Paint

Paint the shape on the provided `Graphics` object.

`shape.Paint(Graphics, Pen, decimal scale);`

`scale` is the ratio of shape "units" to graphics pixels.

## Geometry static class

### Enums

`CoordinatePlanes`  
- Screen: the coordinate plane of a computer screen, with the origin in the upper-left corner, increasing to the right and down.
- Paper: the coordinate plane of a paper graph, with the origin in the lower-left corner, increasing the the right and up.

`Direction`: North is up  
- East
- SouthEast
- South
- SouthWest
- West
- NorthWest
- North
- NorthEast

### Static Properties

`CoordinatePlanes CoordinatePlane`: set the `CoordinatePlanes` to be used on all `Shapes` operations.

`double MarginOfError`: set the margin of error to use when comparing equality in all `Shapes` operations.

`bool WithinMarginOfError`: false means equality operations must be exact, true means the `MarginOfError` is taken into account.

### Static Methods

#### LineDirection

Given a line AB (from A to B), what cardinal direction is the line pointing? The result depends on which `CoordinatePlanes` is set.

`Direction direction = Geometry.LineDirection(Point a, Point b);`

#### PointOnLine

Calculates a point along line AB (from A to B) at the specified distance from A. It is ok for the result to be beyond B.

`Point point = Geometry.PointOnLine(Point a, Point b, double distance);`

#### PointPastLine

Calculates a point along line BA (from B to A) at the specified distance beyond A.

`Point point = Geometry.PointPastLine(Point a, Point b, double distance);`


