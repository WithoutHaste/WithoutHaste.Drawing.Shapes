# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WRectangle

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  

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

## Diagonal

**double { public get; }**  

Returns the distance between diagonal corners. Absolute value.  

## IsFlat

**bool { public get; }**  

True if the rectangle is at 0 degrees rotation.  

## IsSquare

**bool { public get; }**  

True if the rectangle is a square.  

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

