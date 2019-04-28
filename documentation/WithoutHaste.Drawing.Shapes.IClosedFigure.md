# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).IClosedFigure

**Interface**  

Represents a closed figure shape.  

# Methods

## Slice([WLine](WithoutHaste.Drawing.Shapes.WLine.md) a, [WLine](WithoutHaste.Drawing.Shapes.WLine.md) b)

**abstract [System.Drawing.Drawing2D.GraphicsPath](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.drawing2d.graphicspath)**  

Cuts a slice out of a shape, bounded by two lines running completely through the figure.  
Assumes lines _a_ and _b_ are parallel and different.  

**Returns:**  
Returns a path from one bounding line, around the figure, to the other bounding line, and back around the figure.  

**Parameters:**  
* **[WLine](WithoutHaste.Drawing.Shapes.WLine.md) a**: One bounding line.  
* **[WLine](WithoutHaste.Drawing.Shapes.WLine.md) b**: Other bounding line.  

