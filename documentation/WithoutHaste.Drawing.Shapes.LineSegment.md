# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).LineSegment

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [Line](WithoutHaste.Drawing.Shapes.Line.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

Line segment from point A to point B. Immutable.  

# Properties

## Length

**double { public get; }**  

Distance between points A and B. Always positive.  

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

# Constructors

## LineSegment([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

## LineSegment([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, bool isDirected)

# Methods

## Overlaps([Dot](WithoutHaste.Drawing.Shapes.Dot.md) c)

**bool**  

Returns true if point _c_ lies on this line segment.  

## Overlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) b)

**bool**  

Returns true if this line segments overlaps line segment _b_ at any point.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## ToLine()

**[Line](WithoutHaste.Drawing.Shapes.Line.md)**  

Convert to [Line](WithoutHaste.Drawing.Shapes.Line.md).  

## ToString()

**virtual string**  

Format "(A.x,A.y) to (B.x,B.y)"  

