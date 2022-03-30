using System.Numerics;

namespace ShapeMath.Shapes;

/// <summary>
/// Represents a rectangular shape that has 4 vertices.
/// </summary>
public class Rectangle : ConvexVertexShape
{
    /// <summary>
    /// Width of this <see cref="Rectangle"/>.
    /// </summary>
    public float Width => Vertices[2].X - Vertices[0].X;
    /// <summary>
    /// Height of this <see cref="Rectangle"/>.
    /// </summary>
    public float Height => Vertices[2].Y - Vertices[0].Y;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="pivot">Pivot for this <see cref="Rectangle"/></param>.
    /// <param name="width">Width for this <see cref="Rectangle"/></param>.
    /// <param name="height">Height for this <see cref="Rectangle"/></param>.
    public Rectangle(Vector2 pivot, float width, float height) : base(
        new [] { 
            pivot, 
            pivot + new Vector2(0, height),
            pivot + new Vector2(width, height),
            pivot + new Vector2(width, 0)
        })
    {
    }

    // Override for better performance
    /// <summary>
    /// Calculates area of this <see cref="Rectangle"/>.
    /// </summary>
    /// <returns>Calculated result.</returns>
    public override float CalculateArea()
    {
        return Width * Height;
    }

    // Override for better performance
    /// <summary>
    /// Calculates perimeter of this <see cref="Rectangle"/>.
    /// </summary>
    /// <returns>Calculated result.</returns>
    public override float CalculatePerimeter()
    {
        return 2.0f * (Width + Height);
    }
}