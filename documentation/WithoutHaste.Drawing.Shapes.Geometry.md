# [WithoutHaste.Drawing.Shapes](TableOfContents.WithoutHaste.Drawing.Shapes.md).Geometry

**Static**  
**Inheritance:** object  

Global settings and miscellaneous operations.  

# Enums

**[CoordinatePlanes](WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes.md)**  
Determines how cardinal directions apply to coordinates.  

* 0: None  
* 1: Screen  
* 2: Paper  

**[Direction](WithoutHaste.Drawing.Shapes.Geometry.Direction.md)**  
Cardinal directions.  

* 0: None  
* 1: East  
* 2: SouthEast  
* 3: South  
* 4: SouthWest  
* 5: West  
* 6: NorthWest  
* 7: North  
* 8: NorthEast  

# Fields

## CoordinatePlane

**static [CoordinatePlanes](WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes.md)**  

This coordinate plane is used in all Shape operations that require one.  

## MarginOfError

**static double**  

When determining equality, all values have a +/- margin of error. This setting is used in all Shape operations that check equality.  

# Static Methods

## LineDirection([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b)

**static [Direction](WithoutHaste.Drawing.Shapes.Geometry.Direction.md)**  

Given directed line A to B, what direction is it pointing?  

North, South, East, and West are precise. The inbetween directions are vague.  

## PointOnLine([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, double distance)

**static [Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Calculates point along line AB, starting at A and moving towards B  

## PointPastLine([Dot](WithoutHaste.Drawing.Shapes.Dot.md) a, [Dot](WithoutHaste.Drawing.Shapes.Dot.md) b, double distance)

**static [Dot](WithoutHaste.Drawing.Shapes.Dot.md)**  

Calculates point along line AB, starting at B and moving away from A  

## WithinMarginOfError(double a, double b)

**static bool**  

Check if values are equal, within the MarginOfError.  

# Nested Types

[CoordinatePlanes](WithoutHaste.Drawing.Shapes.Geometry.CoordinatePlanes.md)  
Determines how cardinal directions apply to coordinates.  

[Direction](WithoutHaste.Drawing.Shapes.Geometry.Direction.md)  
Cardinal directions.  

