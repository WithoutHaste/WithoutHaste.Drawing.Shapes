# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Wedge

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [WedgeUnbound](WithoutHaste.Drawing.Shapes.WedgeUnbound.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

A wedge is a slice of a circle. It is also known as a circular sector. Immutable.  

**Remarks:**  
"Arc" refers to the segment of circle's circumference that makes up the curved edge of the wedge. And arc is 1-dimensional; an arc is a curved line.  

# Fields

## Radius

**readonly double**  

The radius of the full circle this wedge is a slice of. Also the length of either straight side of the wegde.  

# Properties

## ArcPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

The point at the middle of the arc edge of the wedge.  

## Circle

**[Circle](WithoutHaste.Drawing.Shapes.Circle.md) { public get; }**  

The full circle that this wedge is a part of.  

## EndPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

The point on circumference of Circle where the wedge ends.  

## FourPoints

**[Dot[]](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

The boundary points of the wedge:  
   
* Center  
* StartPoint  
* EndPoint  
* ArcPoint  

## LineEdges

**[LineSegment[]](WithoutHaste.Drawing.Shapes.LineSegment.md) { public get; }**  

The straight edges of the wedge:  
   
* Center to StartPoint  
* Center to EndPoint  

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

## StartPoint

**[Dot](WithoutHaste.Drawing.Shapes.Dot.md) { public get; }**  

The point on circumference of Circle where the wedge begins.  

# Constructors

## Wedge([Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle, [RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md) degreeRange)

**Parameters:**  
* **[Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle**: The full circle this wedge is a part of.  
* **[RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md) degreeRange**: The range of degrees this wedge covers.  

## Wedge([Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle, double degreeStart, double degreeEnd)

**Parameters:**  
* **[Circle](WithoutHaste.Drawing.Shapes.Circle.md) circle**: The full circle this wedge is a part of.  
* **double degreeStart**: The starting degree the wedge covers.  
* **double degreeEnd**: The ending degree the wedge covers.  

# Methods

## ArcOverlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) lineSegment)

**bool**  

Returns true if the arc overlaps any part of the _lineSegment_.  

## ArcOverlapsArc([Wedge](WithoutHaste.Drawing.Shapes.Wedge.md) b)

**bool**  

Returns true if this arc overlaps any part of _b_'s arc.  

## Contains([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

Returns true if this wedge fully contains circle _b_.  

## Contains([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**bool**  

Returns true if this wedge contains point _b_, including if _b_ lies on one of this wedge's edges.  

## Overlaps([Circle](WithoutHaste.Drawing.Shapes.Circle.md) b)

**bool**  

Returns true if any part of this wedge overlaps any part of circle _b_.  

## Overlaps([Wedge](WithoutHaste.Drawing.Shapes.Wedge.md) b)

**bool**  

Returns true if any part of this wedge overlaps any part of wedge _b_.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## ToString()

**virtual string**  

Format "C:(X,Y) R:Radius Degrees:Start-End".  

# Operators

## Wedge = Wedge a / double b

Scale wedge down by _b_ amount. Affects length and location measures, but not degrees.  

