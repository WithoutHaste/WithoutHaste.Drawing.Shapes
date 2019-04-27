# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).WPoint

**Inheritance:** object → [WShape](WithoutHaste.Drawing.Shapes.WShape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

An (X, Y) coordinate. Immutable.  

# Fields

## X

**readonly double**  

## Y

**readonly double**  

# Properties

## MaxX

**double { public get; }**  

Maximum x coordinate required to draw the figure.  

## MaxY

**double { public get; }**  

Maximum y coordinate required to draw the figure.  

# Constructors

## WPoint(double x, double y)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: X or Y was NaN or Infinity.  

**Parameters:**  
* **double x**: Cannot be NaN or Infinity.  
* **double y**: Cannot be NaN or Infinity.  

# Methods

## Distance([WPoint](WithoutHaste.Drawing.Shapes.WPoint.md) b)

**double**  

Returns the distance between this point and point _b_. Always positive.  

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## Overlaps([WLineSegment](WithoutHaste.Drawing.Shapes.WLineSegment.md) lineSegment)

**bool**  

Returns true if this point overlaps any part of the .  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

Draw the figure on the _graphics_ with the _pen_.  

**Parameters:**  
* **double unitsToPixels**: Conversion ratio from figure units to pixels. A value of "2" means all figure measurements will be doubled.  

## ToString()

**virtual string**  

Format "(X,Y)"  

# Operators

## WPoint = WPoint a + WPoint b

## WPoint = WPoint a - WPoint b

## WPoint = double a * WPoint b

## WPoint = WPoint a * double b

## WPoint = double a / WPoint b

## WPoint = WPoint a / double b

## bool = WPoint a == WPoint b

## bool = WPoint a != WPoint b

## bool = WPoint a > WPoint b

Greater than/less than is judged along the x-axis first, then the y-axis  

## bool = WPoint a < WPoint b

Greater than/less than is judged along the x-axis first, then the y-axis  

