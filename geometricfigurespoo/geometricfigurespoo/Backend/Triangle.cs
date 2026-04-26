namespace GeometricFigures.Backend;

public class Triangle : GeometricFigure
{
    private double _a, _b, _c, _h;

    public Triangle(string name, double a, double b, double c, double h) : base(name)
    {
        _a = a;
        _b = b;
        _c = c;
        _h = h;
    }

    public override double GetArea() => (_b * _h) / 2;

    public override double GetPerimeter() => _a + _b + _c;
}