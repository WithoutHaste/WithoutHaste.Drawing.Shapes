# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).IDraw

**Interface**  

Represents anything that can be drawn on a Graphics object.  

# Properties

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

# Methods

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**abstract void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

# Implemented By

[WithoutHaste.Drawing.Shapes.WCircle](WithoutHaste.Drawing.Shapes.WCircle.md)  
A circle shape. Immutable.  

[WithoutHaste.Drawing.Shapes.WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md)  
Line segment from point A to point B. Immutable.  

[WithoutHaste.Drawing.Shapes.WPoint](WithoutHaste.Drawing.Shapes.WPoint.md)  
An (X, Y) coordinate. Immutable.  

[WithoutHaste.Drawing.Shapes.WWedge](WithoutHaste.Drawing.Shapes.WWedge.md)  
A wedge is a slice of a circle. It is also known as a circular sector. Immutable.  

