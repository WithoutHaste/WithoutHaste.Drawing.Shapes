# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Dot

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  
**Implements:** [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md)  

An (X, Y) coordinate. Immutable.  

**Remarks:**  
It's called "Dot" so as not to conflict with System.Drawing.Point. Points use integer coordinates, these Dots use doubles.  

# Fields

## X

**readonly double**  

## Y

**readonly double**  

# Properties

## MaxX

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

## MaxY

**double { public get; }**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

# Constructors

## Dot(double x, double y)

**Misc:**  
  

**Exceptions:**  
* **[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)**: X or Y was NaN or Infinity.  

**Parameters:**  
* **double x**: Cannot be NaN or Infinity.  
* **double y**: Cannot be NaN or Infinity.  

# Methods

## Distance([Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**double**  

Distance between this point and point B.  

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## Overlaps([LineSegment](WithoutHaste.Drawing.Shapes.LineSegment.md) line)

**bool**  

## Paint([System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics) graphics, [System.Drawing.Pen](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen) pen, double unitsToPixels)

**void**  

See [IDraw](WithoutHaste.Drawing.Shapes.IDraw.md).  

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

