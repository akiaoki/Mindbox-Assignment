// ReSharper disable InconsistentNaming

using System.Numerics;
using NUnit.Framework;
using ShapeMath.Shapes;

namespace ShapeMath.Tests;

[TestFixture]
public class ConvexVertexShape_Tests
{
    private Random _random = null!;
    
    [SetUp]
    public void SetUp()
    {
        _random = new Random(0);
    }
    
    [Test]
    public void CalculateArea_GeneralCase_ReturnsProperValue()
    {
        var pivot = new Vector2(_random.NextSingle(), _random.NextSingle());
        var v0 = pivot;
        var v1 = v0 + new Vector2(0, 2.0f);
        var v2 = v0 + new Vector2(3.0f, 2.0f);
        var v3 = v0 + new Vector2(5.0f, 0.0f);
        var polygon = new ConvexVertexShape(new[] {v0, v1, v2, v3});
        
        const float expected = 6.0f + 2.0f;
        var received = MathF.Abs(polygon.CalculateArea());

        Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
    }

    [Test]
    public void CalculatePerimeter_GeneralCase_ReturnsProperValue()
    {
        var pivot = new Vector2(_random.NextSingle(), _random.NextSingle());
        var v0 = pivot;
        var v1 = v0 + new Vector2(0, 2.0f);
        var v2 = v0 + new Vector2(3.0f, 2.0f);
        var v3 = v0 + new Vector2(5.0f, 0.0f);
        var polygon = new ConvexVertexShape(new[] {v0, v1, v2, v3});
        
        var expected = 2.0f + 3.0f + MathF.Sqrt(8.0f) + 5.0f;
        var received = MathF.Abs(polygon.CalculatePerimeter());

        Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
    }
}