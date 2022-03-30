namespace ShapeMath.Shapes;

/// <summary>
/// Represents simple non-vertex circle shape.
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Radius of this <see cref="Circle"/>.
    /// </summary>
    public float Radius { get; }
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="radius"><see cref="Circle"/> <see cref="Radius"/></param>
    /// <exception cref="ArgumentException">Thrown if <see cref="radius"/> is negative.</exception>
    public Circle(float radius)
    {
        if (radius < 0.0f)
            throw new ArgumentException("Radius cannot be negative.", nameof(radius));
        Radius = radius;
    }
    
    /// <summary>
    /// Calculates area of this <see cref="Circle"/>.
    /// </summary>
    /// <returns>Result value.</returns>
    public float CalculateArea()
    {
        return MathF.PI * Radius * Radius;
    }

    /// <summary>
    /// Calculates perimeter of this <see cref="Circle"/>.
    /// </summary>
    /// <returns>Result value.</returns>
    public float CalculatePerimeter()
    {
        return 2.0f * MathF.PI * Radius;
    }
}