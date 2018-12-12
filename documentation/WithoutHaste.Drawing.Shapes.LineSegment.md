# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).LineSegment

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [Line](WithoutHaste.Drawing.Shapes.Line.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

Line segment from point A to point B. Immutable.  

# Properties

## Length

**double { public get; }**  

## MaxX

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## MaxY

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

# Constructors

## LineSegment([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

## LineSegment([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, bool isDirected)

# Methods

## Overlaps([Dot](WithoutHaste.Drawing.Shapes.Dot.md) c)

**bool**  

## Overlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) b)

**bool**  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## ToLine()

**[Line](WithoutHaste.Drawing.Shapes.Line.md)**  

Convert to [Line](WithoutHaste.Drawing.Shapes.Line.md).  

## ToString()

**virtual string**  

Format "(x,y) to (x,y)"  

