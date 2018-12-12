# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Range

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  

A linear range of values. Immutable.  

# Fields

## End

**readonly double**  

## Start

**readonly double**  

For non-circular ranges, operations assume that Start is the minimum value.  

# Properties

## Middle

**double { public get; }**  

Middle value between Start and End.  

## Span

**double { public get; }**  

End minus Start.  

# Constructors

## Range(double start, double end)

# Methods

## Equals(object b)

**virtual bool**  

## GetHashCode()

**virtual int**  

## Overlaps([Range](WithoutHaste.Drawing.Shapes.Range.md) b)

**virtual bool**  

## Overlaps(double b)

**virtual bool**  

## ToString()

**virtual string**  

Format "start-end"  

# Static Methods

## Centered(double middle, double span)

**static Range**  

Create a range with this span and middle value.  

## ConvertValue([Range](WithoutHaste.Drawing.Shapes.Range.md) originalRange, [Range](WithoutHaste.Drawing.Shapes.Range.md) newRange, double value)

**static double**  

Convert a value in originalRange to one in newRange, assuming that the original range is re-scaled to the new range.  

# Operators

## Range = Range a + Range b

Returns a range that covers all the area both A and B cover, including any gap in between.  

This operation is commutative.  

.  

## bool = Range a == Range b

## bool = Range a != Range b

# Derived By

[WithoutHaste.Drawing.Shapes.RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md)  
A range on a circular scale within range [0, CircularModulus). Immutable.  

