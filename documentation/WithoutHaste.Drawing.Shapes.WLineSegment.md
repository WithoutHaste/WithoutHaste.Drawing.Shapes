# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WLineSegment

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md) → [WLine](WithoutHaste.Drawing.Shapes.WLine.md)  
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

## WLineSegment([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) a, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

## WLineSegment([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) a, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b, bool isDirected)

# Methods

## Coincidental([WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**virtual bool**  

Returns false. An infinite line cannot be coincidental to a finite line.  

## Coincidental([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) b)

**virtual bool**  

Returns true if lines are coincidental to each other.  

**Remarks:**  
Coincidental means that every point on this line is also on the other, and vice versa. In short, the lines are equal.  

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## GetIntersection([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) that)

**virtual [Intersection](WithoutHaste.Drawing.Shapes.Intersection.md)**  

Returns intersection between a line segment and another line segment.  

## GetIntersection([WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**virtual [Intersection](WithoutHaste.Drawing.Shapes.Intersection.md)**  

Returns intersection between a line segment and a line.  

## Overlaps([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) c)

**virtual bool**  

Returns true if point _c_ lies on this line segment.  

## Overlaps([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) b)

**bool**  

Returns true if this line segments overlaps line segment _b_ at any point.  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **[System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics**:   
* **[System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen**:   
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## ToString()

**virtual string**  

Format "(A.x,A.y) to (B.x,B.y)"  

## ToWLine()

**[WLine](WithoutHaste.Drawing.Shapes.WLine.md)**  

Convert to [WLine](WithoutHaste.Drawing.Shapes.WLine.md).  

# Operators

## bool = WLineSegment a == WLineSegment b

## bool = WLineSegment a != WLineSegment b

