using System.Numerics;

namespace ShapeMath.Shapes;

/// <summary>
/// Represents a shape with 3 vertices.
/// </summary>
public class Triangle : ConvexVertexShape
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="v0">First vertex</param>.
    /// <param name="v1">Second vertex</param>.
    /// <param name="v2">Third vertex</param>.
    public Triangle(Vector2 v0, Vector2 v1, Vector2 v2) : base(new []{ v0, v1, v2 })
    {
        
    }

    /// <summary>
    /// Returns index of the vertex which is the origin vertex of a right angle in this <see cref="Triangle"/>.
    /// </summary>
    /// <returns>If no right angle found, returns -1.</returns>
    public int GetRightAngle()
    {
        if (MathF.Abs(Vector2.Dot(Vertices[1] - Vertices[0], Vertices[2] - Vertices[0])) < float.Epsilon)
        {
            return 0;
        }
        if (MathF.Abs(Vector2.Dot(Vertices[2] - Vertices[1], Vertices[0] - Vertices[1])) < float.Epsilon)
        {
            return 1;
        }
        if (MathF.Abs(Vector2.Dot(Vertices[1] - Vertices[2], Vertices[0] - Vertices[2])) < float.Epsilon)
        {
            return 2;
        }

        return -1;
    }

    /// <summary>
    /// Returns <c>true</c> if this <see cref="Triangle"/> has a right angle. Otherwise, <c>false</c>.
    /// </summary>
    public bool IsRightTriangle() => GetRightAngle() != -1;
}