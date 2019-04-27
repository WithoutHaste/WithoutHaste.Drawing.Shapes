# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WCircle

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  
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

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

## Diameter

**double { public get; }**  

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxXDegrees

**double { public get; }**  

Based on coordinate plane, which degree points towards the MaxX coordinate?  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

## MaxYDegrees

**double { public get; }**  

Based on coordinate plane, which degree points towards the MaxY coordinate?  

# Constructors

## WCircle(double x, double y, double radius)

## WCircle([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) center, double radius)

# Methods

## Contains([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**bool**  

Returns true if this circle entirely contains circle _b_, or they exactly overlap.  

## Contains([WWedge](WithoutHaste.Drawing.Shapes.WWedge.md) b)

**bool**  

Returns true if this circle entirely contains wedge _b_.  

## Contains([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

**bool**  

Returns true if point _b_ lies within or on this circle.  

## ContainsOrIsContained([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**bool**  

Returns true if this circle entirely contains circle _b_, or _b_ entirely contains this circle, or they exactly overlap.  

## DegreesAtPoint([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) lineEnd)

**double**  

Given a line from the center of this circle to a point (_lineEnd_), what degrees is the line angle at?   
0 degrees is East of center, increases clockwise.  

## Equals(object b)

**virtual bool**  

Circle centers and radiuses are the same.  

## GetHashCode()

**virtual int**  

## GetIntersectionPoints([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Finds the intersection points between the edge of this circle and circle _b_.  

**Returns:**  
Null (no intersection), an array of length 1, or an array of length 2.  

## GetIntersectionPoints([WLine](WithoutHaste.Drawing.Shapes.WLine.md) line)

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md)**  

**Returns:**  
Null (no intercepts), or array of length 1 or 2.  

## GetIntersectionPoints([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) lineSegment)

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Find the intersection points between the edge of this circle and the _lineSegment_.  

**Returns:**  
Null (no intercepts), or array of length 1, or array of length 2.  

## GetTangentPoints([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Find the two tangent points on the circle that form lines to point _b_.  

**Returns:**  
Array of length 2.  

## Overlaps([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**bool**  

Returns true if any part of this circle overlaps any part of circle _b_.  

## Overlaps([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) b)

**bool**  

Returns true if any part of this circle overlaps any part of line segment _b_.  

**Remarks:**  
If line _b_ lies within the circle, that counts as overlapping.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## PointAtDegrees(double degrees)

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Returns the point on this circle at the _degrees_ measurement.   
0 degrees is East of center, increases clockwise.  

## PointAtRadians(double radians)

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Returns the point on this circle at the _radians_ measurement.   
0 radians is East of center, increases clockwise.  

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

## WCircle = WCircle a / double b

Scale circle down by _b_ amount. Affects length and location measures.  

**Example A:**  
`circle / 2` returns a new Circle with half the radius and half the distance from point (0,0).  

## bool = WCircle a == WCircle b

Circle centers and radiuses are the same.  

## bool = WCircle a != WCircle b

Circle centers or radiuses are different.  

