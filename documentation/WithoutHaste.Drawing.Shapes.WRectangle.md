# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WRectangle

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

Represents a rectangle or square.  

# Fields

## Corner

**readonly [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)**  

Refers to the top-left corner, regardless of the coordinate plane being used.  

## Height

**readonly double**  

Length of vertical edges, when rectangle is at 0 degree rotation.  

## Rotation

**readonly double**  

Degrees of rotation.  

**Remarks:**  
A positive rotation means the top-edge of the rectangle (the "width" edge connecting to the [Corner](WithoutHaste.Drawing.Shapes.WRectangle.md)) has rotated counter-clockwise around the [Corner](WithoutHaste.Drawing.Shapes.WRectangle.md).  

## Width

**readonly double**  

Length of horizontal edges, when rectangle is at 0 degree rotation.  

# Properties

## Corners

**[WPoint[]](WithoutHaste.Drawing.Shapes.WPoint.md) { public get; }**  

Returns all four corners, starting with the top-left (or reference corner) and proceeding in clockwise order.  

## DiagonalLength

**double { public get; }**  

Returns the distance between diagonal corners. Absolute value.  

## Edges

**[WLineSegment[]](WithoutHaste.Drawing.Shapes.WLineSegment.md) { public get; }**  

Returns all four edges, starting with the top-left (or reference corner) and proceeding in clockwise order.  

## IsFlat

**bool { public get; }**  

True if the rectangle is at 0 degrees rotation.  

## IsSquare

**bool { public get; }**  

True if the rectangle is a square.  

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

## MinX

**double { public get; }**  

Minimum x coordinate required to draw the figure.  

## MinY

**double { public get; }**  

Minimum y coordinate required to draw the figure.  

# Constructors

## WRectangle(double width, double height)

Corner defaults to (0, 0). Rotation defaults to 0 degrees.  

## WRectangle(double width, double height, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) corner)

Rotation defaults to 0 degrees.  

## WRectangle(double width, double height, [WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) corner, double rotation)

# Methods

## GetFlatEnclosingRectangle()

**WRectangle**  

Returns the smallest "IsFlat" rectangle that encloses this rectangle.  

## GetIntersection([WLine](WithoutHaste.Drawing.Shapes.WLine.md) line)

**[Intersection](WithoutHaste.Drawing.Shapes.Intersection.md)**  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **[System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics**:   
* **[System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen**:   
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

