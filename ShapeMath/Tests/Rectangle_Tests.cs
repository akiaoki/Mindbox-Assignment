// ReSharper disable InconsistentNaming

using System.Numerics;
using NUnit.Framework;
using ShapeMath.Shapes;

namespace ShapeMath.Tests;

[TestFixture]
public class Rectangle_Tests
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
            var width = _random.NextSingle();
            var height = _random.NextSingle();
            var rectangle = new Rectangle(new Vector2(_random.NextSingle(), _random.NextSingle()), width, height);

            var expected = width * height;
            var received = rectangle.CalculateArea();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }

    [Test]
    public void CalculatePerimeter_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var width = _random.NextSingle();
            var height = _random.NextSingle();
            var rectangle = new Rectangle(new Vector2(_random.NextSingle(), _random.NextSingle()), width, height);

            var expected = 2.0f * (width + height);
            var received = rectangle.CalculatePerimeter();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }
}