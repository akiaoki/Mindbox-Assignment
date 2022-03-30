// ReSharper disable InconsistentNaming

using System.Numerics;
using NUnit.Framework;
using ShapeMath.Shapes;

namespace ShapeMath.Tests;

[TestFixture]
public class Triangle_Tests
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
        for (var i = 0; i < 100; i++)
        {
            var v0 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var v1 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var v2 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var triangle = new Triangle(v0, v1, v2);

            var expected = MathF.Abs(v0.X * (v1.Y - v2.Y) + v1.X * (v2.Y - v0.Y) + v2.X * (v0.Y - v1.Y)) / 2.0f;
            var received = MathF.Abs(triangle.CalculateArea());

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }

    [Test]
    public void CalculatePerimeter_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var v0 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var v1 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var v2 = new Vector2(_random.NextSingle(), _random.NextSingle());
            var triangle = new Triangle(v0, v1, v2);

            var expected = (v0 - v1).Length() + (v1 - v2).Length() + (v2 - v0).Length();
            var received = triangle.CalculatePerimeter();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }
    
    [Test]
    public void GetRightAngle_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var expected = _random.Next() % 4 - 1;

            Vector2 v0 = Vector2.One, v1 = Vector2.One, v2 = Vector2.One;

            switch (expected)
            {
                case -1:
                    v0 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    v1 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    v2 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    break;
                case 0:
                    v0 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    v1 = v0 + new Vector2(_random.NextSingle(), 0);
                    v2 = v0 + new Vector2(0, _random.NextSingle());
                    break;
                case 1:
                    v1 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    v0 = v1 + new Vector2(_random.NextSingle(), 0);
                    v2 = v1 + new Vector2(0, _random.NextSingle());
                    break;
                case 2:
                    v2 = new Vector2(_random.NextSingle(), _random.NextSingle());
                    v0 = v2 + new Vector2(_random.NextSingle(), 0);
                    v1 = v2 + new Vector2(0, _random.NextSingle());
                    break;
            }
            
            var triangle = new Triangle(v0, v1, v2);

            var received = triangle.GetRightAngle();

            Assert.AreEqual(expected, received);
        }
    }
}