# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Range

**Inheritance:** object → [Shape](WithoutHaste.Drawing.Shapes.Shape.md)  

A linear range of values. Immutable.  

**Remarks:**  
Ranges are inclusive: both the Start and the End values are included in the range.  

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

Returns true if this range overlaps range _b_.  

## Overlaps(double b)

**virtual bool**  

Returns true if this range includes value _b_.  

## ToString()

**virtual string**  

Format "Start-End".  

# Static Methods

## Centered(double middle, double span)

**static Range**  

Create a range with this span and middle value.  

## ConvertValue([Range](WithoutHaste.Drawing.Shapes.Range.md) originalRange, [Range](WithoutHaste.Drawing.Shapes.Range.md) newRange, double value)

**static double**  

Convert the _value_ in _originalRange_ to one in _newRange_.  

**Remarks:**  
Essentially, _originalRange_ is scaled up or down to match _newRange_.  
So the returned value is the same percentage along _newRange_ as the provided _value_ was along _originalRange_.  

# Operators

## Range = Range a + Range b

Returns a range that covers all the area both _a_ and _b_ cover, including any gap in between.  
This operation is commutative.  

## bool = Range a == Range b

## bool = Range a != Range b

# Derived By

[WithoutHaste.Drawing.Shapes.RangeCircular](WithoutHaste.Drawing.Shapes.RangeCircular.md)  
A range on a circular scale. Immutable.  

