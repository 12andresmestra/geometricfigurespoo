namespace GeometricFigures.Backend;

public class Rectangle : GeometricFigure
{
    private double _a, _b;

    public Rectangle(string name, double a, double b) : base(name)
    {
        _a = a;
        _b = b;
    }

    public override double GetArea() => _a * _b;

    public override double GetPerimeter() => 2 * (_a + _b);
}