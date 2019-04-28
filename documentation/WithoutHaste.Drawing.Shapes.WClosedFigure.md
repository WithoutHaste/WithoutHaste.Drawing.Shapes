# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WClosedFigure

**Abstract**  
**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

Represents any planar (2D) figure with a single outline. Outline/edges may include straight sections and curved sections.  

# Properties

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

## Path

**[System.Drawing.Drawing2D.GraphicsPath](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.drawing2d.graphicspath) { public get; }**  

Path of outline/edges of entire figure. Path is expected to be closed.  

# Methods

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **[System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics**:   
* **[System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen**:   
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

