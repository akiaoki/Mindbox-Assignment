// ReSharper disable InconsistentNaming

using System.Numerics;
using NUnit.Framework;
using ShapeMath.Shapes;

namespace ShapeMath.Tests;

[TestFixture]
public class Square_Tests
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
            var size = _random.NextSingle();
            var square = new Square(new Vector2(_random.NextSingle(), _random.NextSingle()), size);

            var expected = size * size;
            var received = square.CalculateArea();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }

    [Test]
    public void CalculatePerimeter_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var size = _random.NextSingle();
            var square = new Square(new Vector2(_random.NextSingle(), _random.NextSingle()), size);

            var expected = 2.0f * (size + size);
            var received = square.CalculatePerimeter();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }
}