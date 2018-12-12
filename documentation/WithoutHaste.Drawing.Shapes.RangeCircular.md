# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).RangeCircular

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [Range](WithoutHaste.Drawing.Shapes.Range.md)  

A range on a circular scale. Immutable.  

**Remarks:**  
A circular scale can be written shorthand as [0, CircularModulus), meaning 0 is included in the scale and CircularModulus is excluded from the scale.  
  
The range may cover the entire scale, or only a portion of the scale.  

# Examples

## Example A:

The degrees of a circle make up a circular scale [0, 360).  
The range may only cover [25, 45] of the scale [0, 360).  
In this case, Start=25, End=45, and CircularModulus=360.  

## Example B:

The hours of a clock make up a circular range [1, 13) for a normal clock, or [0, 24) for a military clock.  
Since RangeCircular always starts at 0, the normal clock would need to be represented as [0, 12). You'd need to handle the +1 offset when setting or displaying values.  

# Fields

## CircularModulus

**readonly int**  

The distance from Start when the range loops back to Start.  

**Remarks:**  
If your Start is 0, CircularModulus will be the same as End.  

# Properties

## Middle

**double { public get; }**  

Middle value in range.  

## Span

**double { public get; }**  

Length from Start to End. Always positive.  

# Constructors

## RangeCircular(double s, double e, int mod)

# Methods

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## Mod(double number)

**double**  

Convert a number into this range.  

## Overlaps([RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md) b)

**bool**  

## Overlaps(double b)

**virtual bool**  

# Static Methods

## Centered(double center, double span, int mod)

**static RangeCircular**  

Create a range with this span, middle value, and modulus.  

## Mod(double number, int m)

**static double**  

Returns number modulus m. Ensures a positive result.  

# Operators

## RangeCircular = RangeCircular a + RangeCircular b

Returns a range that covers all the area both A and B cover, including any gap in between.  

If the ranges overlap, there is no gap filled in.  

Gaps are covered from direction A to B, therefore this operation is not commutative.  

## bool = RangeCircular a == RangeCircular b

## bool = RangeCircular a != RangeCircular b

