namespace ShapeMath.Shapes;

/*
 * Due to Numerics limitation, it was decided to use Single precision instead of double to make use of it.
 * However potentially speaking, it is possible to make a generic-defined computing based on the new INumber interface
 * introduced in .NET 7 which was not released yet. The architecture would include one more abstract class called
 * "ComputableShape" which contains all required operators and types to make more specific computing.
 */
/// <summary>
/// Represents a shape that has area and perimeter.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Calculates area of this <see cref="IShape"/>.
    /// </summary>
    /// <returns>Calculated result.</returns>
    float CalculateArea();

    /// <summary>
    /// Calculates perimeter of this <see cref="IShape"/>.
    /// </summary>
    /// <returns>Calculated result.</returns>
    float CalculatePerimeter();
}