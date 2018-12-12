# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Circle

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

A circle shape. Immutable.  

# Fields

## DEGREES_IN_CIRCLE

**const int**  

## DEGREES_IN_HALF_CIRCLE

**const int**  

## RADIANS_180DEGREES

**const double**  

## RADIANS_270DEGREES

**const double**  

## RADIANS_360DEGREES

**const double**  

## RADIANS_90DEGREES

**const double**  

## Radius

**readonly double**  

## X

**readonly double**  

Center x coordinate.  

## Y

**readonly double**  

Center y coordinate.  

# Properties

## Center

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

## Diameter

**double { public get; }**  

## MaxX

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## MaxXDegrees

**double { public get; }**  

Based on coordinate plane, which degree points towards the MaxX coordinate?  

## MaxY

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## MaxYDegrees

**double { public get; }**  

Based on coordinate plane, which degree points towards the MaxY coordinate?  

# Constructors

## Circle(double x, double y, double radius)

## Circle([Dot](WithoutHaste.Drawing.Shapes.Dot.md) center, double radius)

# Methods

## Contains([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

This circle entirely contains circle B, or they exactly overlap.  

## Contains([Wedge](WithoutHaste.Drawing.Shapes.Wedge.md) b)

**bool**  

This circle entirely contains wedge B.  

## Contains([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**bool**  

Point B lies within or on this circle.  

## ContainsOrIsContained([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

This circle entirely contains circle B, or B entirely contains this circle, or they exactly overlap.  

## DegreesAtPoint([Dot](WithoutHaste.Drawing.Shapes.Dot.md) lineEnd)

**double**  

Given a line from the center of a circle to a point, what degrees is the line angle at? 0 degrees is East from center, and increases clockwise.  

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## GetIntersectionPoints([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md)**  

**Returns:**  
Null (no intersection), an array of length 1, or an array of length 2.  

## GetIntersectionPoints([Line](WithoutHaste.Drawing.Shapes.Line.md) line)

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md)**  

**Returns:**  
Null (no intercepts), or array of length 1 or 2.  

## GetIntersectionPoints([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) lineSegment)

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md)**  

**Returns:**  
Null (no intercepts), or array of length 1 or 2.  

## GetTangentPoints([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md)**  

Find the two tangent points on the circle that form lines to point B.  

**Returns:**  
Array of 2 Points.  

## Overlaps([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

Any part of this circle overlaps any part of circle B.  

## Overlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) b)

**bool**  

Any part of this circle overlaps any part of line segment B.  

If line B lies within the circle, that counts as overlapping.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## PointAtDegrees(double degrees)

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Return the point on the circle at this degree. 0 degrees is East of center, increases clockwise.  

## PointAtRadians(double radians)

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Return the point on the circle at this radians. 0 radians is East of center, increases clockwise.  

## ToString()

**virtual string**  

Format "C:(x,y) R:radius"  

# Static Methods

## DegreesToRadians(double degrees)

**static double**  

Convert degrees to radians.  

## RadiansToDegrees(double radians)

**static double**  

Convert radians to degrees.  

# Operators

## Circle = Circle a / double b

Scale circle down by B amount. Affects length and location measures.  

## bool = Circle a == Circle b

## bool = Circle a != Circle b

