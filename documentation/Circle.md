# Circle

A circle shape. Immutable.

## Fields

### Constant Fields

#### Int32 DEGREES_IN_CIRCLE

#### Int32 DEGREES_IN_HALF_CIRCLE

#### Double RADIANS_180DEGREES

#### Double RADIANS_270DEGREES

#### Double RADIANS_360DEGREES

#### Double RADIANS_90DEGREES

### Normal Fields

#### Double Radius

#### Double X

Center x coordinate.

#### Double Y

Center y coordinate.

## Properties

### Point Center

### Double Diameter

### Double MaxX

See [IDraw](IDraw.md).

### Double MaxXDegrees

Based on coordinate plane, which degree points towards the MaxX coordinate?

### Double MaxY

See [IDraw](IDraw.md).

### Double MaxYDegrees

Based on coordinate plane, which degree points towards the MaxY coordinate?

## Constructors

### Circle(System.Double, System.Double, System.Double)

### Circle(Point, System.Double)

## Static Methods

### Double DegreesToRadians(System.Double)

Convert degrees to radians.

### Double RadiansToDegrees(System.Double)

Convert radians to degrees.

## Methods

### Boolean Contains(Circle)

This circle entirely contains circle B, or they exactly overlap.

### Boolean Contains(Wedge)

This circle entirely contains wedge B.

### Boolean Contains(Point)

Point B lies within or on this circle.

### Boolean ContainsOrIsContained(Circle)

This circle entirely contains circle B, or B entirely contains this circle, or they exactly overlap.

### Double DegreesAtPoint(Point)

Given a line from the center of a circle to a point, what degrees is the line angle at? 0 degrees is East from center, and increases clockwise.

### Point[] GetIntersectionPoints(Circle)

Returns: Null (no intersection), an array of length 1, or an array of length 2.

### Point[] GetIntersectionPoints(Line)

Returns: Null (no intercepts), or array of length 1 or 2.

### Point[] GetIntersectionPoints(LineSegment)

Returns: Null (no intercepts), or array of length 1 or 2.

### Point[] GetTangentPoints(Point)

Find the two tangent points on the circle that form lines to point B.

Returns: Array of 2 Points.

### Boolean Overlaps(Circle)

Any part of this circle overlaps any part of circle B.

### Boolean Overlaps(LineSegment)

Any part of this circle overlaps any part of line segment B.

If line B lies within the circle, that counts as overlapping.

### Point PointAtDegrees(System.Double)

Return the point on the circle at this degree. 0 degrees is East of center, increases clockwise.

### Point PointAtRadians(System.Double)

Return the point on the circle at this radians. 0 radians is East of center, increases clockwise.

## Operators

### Circle = Circle / System.Double

Scale circle down by B amount. Affects length and location measures.

