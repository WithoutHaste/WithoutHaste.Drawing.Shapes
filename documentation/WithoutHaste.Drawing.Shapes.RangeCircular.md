# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).RangeCircular

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md) → [Range](WithoutHaste.Drawing.Shapes.Range.md)  

A range on a circular scale within range [0, CircularModulus). Immutable.  

# Fields

## CircularModulus

**readonly int**  

The value where the range loops back to 0.  

# Properties

## Middle

**double { public get; }**  

Middle value in range.  

## Span

**double { public get; }**  

Length from Start to End.  

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

