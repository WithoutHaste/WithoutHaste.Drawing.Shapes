# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WWedge

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md) → [WWedgeUnbound](WithoutHaste.Drawing.Shapes.WWedgeUnbound.md)  
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

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

The point at the middle of the arc edge of the wedge.  

## Circle

**[WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) { public get; }**  

The full circle that this wedge is a part of.  

## EndPoint

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

The point on circumference of Circle where the wedge ends.  

## FourPoints

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

The boundary points of the wedge:  
   
* Center  
* StartPoint  
* EndPoint  
* ArcPoint  

## LineEdges

**[WLineSegment[]](WithoutHaste.Drawing.Shapes.WLineSegment.md) { public get; }**  

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

**[WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

The point on circumference of Circle where the wedge begins.  

# Constructors

## WWedge([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) circle, [WRangeCircular](WithoutHaste.Drawing.Shapes.WRangeCircular.md) degreeRange)

**Parameters:**  
* **[WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) circle**: The full circle this wedge is a part of.  
* **[WRangeCircular](WithoutHaste.Drawing.Shapes.WRangeCircular.md) degreeRange**: The range of degrees this wedge covers.  

## WWedge([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) circle, double degreeStart, double degreeEnd)

**Parameters:**  
* **[WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) circle**: The full circle this wedge is a part of.  
* **double degreeStart**: The starting degree the wedge covers.  
* **double degreeEnd**: The ending degree the wedge covers.  

# Methods

## ArcOverlaps([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) lineSegment)

**bool**  

Returns true if the arc overlaps any part of the _lineSegment_.  

## ArcOverlapsArc([WWedge](WithoutHaste.Drawing.Shapes.WWedge.md) b)

**bool**  

Returns true if this arc overlaps any part of _b_'s arc.  

## Contains([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**bool**  

Returns true if this wedge fully contains circle _b_.  

## Contains([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

**bool**  

Returns true if this wedge contains point _b_, including if _b_ lies on one of this wedge's edges.  

## Overlaps([WCircle](WithoutHaste.Drawing.Shapes.WCircle.md) b)

**bool**  

Returns true if any part of this wedge overlaps any part of circle _b_.  

## Overlaps([WWedge](WithoutHaste.Drawing.Shapes.WWedge.md) b)

**bool**  

Returns true if any part of this wedge overlaps any part of wedge _b_.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **[System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics**:   
* **[System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen**:   
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## ToString()

**virtual string**  

Format "C:(X,Y) R:Radius Degrees:Start-End".  

# Operators

## WWedge = WWedge a / double b

Scale wedge down by _b_ amount. Affects length and location measures, but not degrees.  

