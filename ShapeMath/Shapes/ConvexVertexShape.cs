using System.Numerics;

namespace ShapeMath.Shapes;

/// <summary>
/// A class representing any <b>simple</b> polygon (edges do not cross).
/// </summary>
public class ConvexVertexShape : IShape
{
    /// <summary>
    /// Vertices of this <see cref="ConvexVertexShape"/>.
    /// <b>Has one extra vertex at the end which is equal to the first one.</b>
    /// </summary>
    public List<Vector2> Vertices { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="vertices">Initial vertices of this <see cref="ConvexVertexShape"/>.
    /// Should <b>not</b> include extra vertex equal to the first one at the end.</param>
    public ConvexVertexShape(IEnumerable<Vector2> vertices)
    {
        Vertices = new List<Vector2>(vertices);
        if (Vertices.Count > 0)
            Vertices.Add(Vertices[0]);
    }
    
    /// <summary>
    /// Calculates area of this <see cref="ConvexVertexShape"/>.
    /// </summary>
    /// <returns>If vertices are oriented counter-clockwise, returns a negative result. Otherwise, an absolute result.</returns>
    public virtual float CalculateArea()
    {
        return Vertices
            .Take(Vertices.Count - 1)
            .Select((v, vi) => (Vertices[vi + 1].X - v.X) * (Vertices[vi + 1].Y + v.Y))
            .Sum() / 2.0f;
    }

    /// <summary>
    /// Calculates perimeter of this <see cref="ConvexVertexShape"/>.
    /// </summary>
    /// <returns>Result value.</returns>
    public virtual float CalculatePerimeter()
    {
        return Vertices
            .Take(Vertices.Count - 1)
            .Select((v, vi) => (v - Vertices[vi + 1]).Length())
            .Sum();
    }
}