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

From IDraw

### Double MaxXDegrees

Based on coordinate plane, which degree points towards the MaxX coordinate?

### Double MaxY

From IDraw

### Double MaxYDegrees

Based on coordinate plane, which degree points towards the MaxY coordinate?

## Methods

### Contains(Circle)

This circle entirely contains circle B, or they exactly overlap.

### Contains(Wedge)

This circle entirely contains wedge B.

### Contains(Point)

Point B lies within or on this circle.

### ContainsOrIsContained(Circle)

This circle entirely contains circle B, or B entirely contains this circle, or they exactly overlap.

### DegreesAtPoint(Point)

Given a line from the center of a circle to a point, what degrees is the line angle at? 0 degrees is East from center, and increases clockwise.

### GetIntersectionPoints(Circle)

Returns null (no intersection), an array of length 1, or an array of length 2.

### GetIntersectionPoints(Line)

Returns null (no intercepts), or array of length 1 or 2.

### GetTangentPoints(Point)

Find the two tangent points on the circle that form lines to point B.

### op_Division(Circle, System.Double)

Scale circle down by B amount. Affects length and location measures.

### Overlaps(Circle)

Any part of this circle overlaps any part of circle B.

### Overlaps(LineSegment)

Any part of this circle overlaps any part of line segment B.
            If line B lies within the circle, that counts as overlapping.

### PointAtDegrees(System.Double)

Return the point on the circle at this degree. 0 degrees is East of center, increases clockwise.

### PointAtRadians(System.Double)

Return the point on the circle at this radians. 0 radians is East of center, increases clockwise.

