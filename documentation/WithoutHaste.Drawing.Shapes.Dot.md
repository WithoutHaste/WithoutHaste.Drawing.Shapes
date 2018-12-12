# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Dot

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

An (X, Y) coordinate. Immutable.  

**Remarks:**  
It's called "Dot" so as not to conflict with System.Drawing.Point. Points use integer coordinates, these Dots use doubles.  
  
I'm considering changing all the names to use a common suffix character for differentiation, instead of synonyms.  
Such as "WPoint, WCircle, WLineSegment" instead of "Dot, Circle, LineSegment".  

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

## Dot(double x, double y)

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: X or Y was NaN or Infinity.  

**Parameters:**  
* **double x**: Cannot be NaN or Infinity.  
* **double y**: Cannot be NaN or Infinity.  

# Methods

## Distance([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**double**  

Returns the distance between this point and point _b_. Always positive.  

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## Overlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) lineSegment)

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

## Dot = Dot a + Dot b

## Dot = Dot a - Dot b

## Dot = double a * Dot b

## Dot = Dot a * double b

## Dot = double a / Dot b

## Dot = Dot a / double b

## bool = Dot a == Dot b

## bool = Dot a != Dot b

## bool = Dot a > Dot b

Greater than/less than is judged along the x-axis first, then the y-axis  

## bool = Dot a < Dot b

Greater than/less than is judged along the x-axis first, then the y-axis  

