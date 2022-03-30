using System.Numerics;

namespace ShapeMath.Shapes;

/// <summary>
/// Represents a square shape with 4 vertices.
/// </summary>
public class Square : Rectangle
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="pivot">Pivot of this <see cref="Square"/></param>.
    /// <param name="size">Size (both width and height) of this <see cref="Square"/></param>.
    public Square(Vector2 pivot, float size) : base(pivot, size, size)
    {
        
    }
}