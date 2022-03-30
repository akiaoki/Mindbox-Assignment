// ReSharper disable InconsistentNaming

using NUnit.Framework;
using ShapeMath.Shapes;

namespace ShapeMath.Tests;

[TestFixture]
public class Circle_Tests
{
    private Random _random = null!;
    
    [SetUp]
    public void SetUp()
    {
        _random = new Random(0);
    }
    
    [Test]
    public void Constructor_NegativeRadius_ThrowsException()
    { 
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-1.0f);
        });
    }

    [Test]
    public void CalculateArea_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var radius = _random.NextSingle();
            var circle = new Circle(radius);

            var expected = MathF.PI * radius * radius;
            var received = circle.CalculateArea();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }
    
    [Test]
    public void CalculateArea_ZeroRadius_ReturnsProperValue()
    { 
        const float radius = 0.0f; 
        var circle = new Circle(radius);
        
        const float expected = 0.0f;
        var received = circle.CalculateArea();
        
        Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
    }
    
    [Test]
    public void CalculatePerimeter_GeneralCase_ReturnsProperValue()
    {
        for (var i = 0; i < 100; i++)
        {
            var radius = _random.NextSingle();
            var circle = new Circle(radius);

            var expected = 2.0f * MathF.PI * radius;
            var received = circle.CalculatePerimeter();

            Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
        }
    }
    
    [Test]
    public void CalculatePerimeter_ZeroRadius_ReturnsProperValue()
    { 
        const float radius = 0.0f; 
        var circle = new Circle(radius);
        
        const float expected = 0.0f;
        var received = circle.CalculatePerimeter();
        
        Assert.That(received, Is.EqualTo(expected).Within(0.000001f));
    }
}