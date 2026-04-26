namespace GeometricFigures.Backend;

public class Parallelogram : GeometricFigure
{
    private double _a, _b, _h;

    public Parallelogram(string name, double a, double b, double h) : base(name)
    {
        _a = a;
        _b = b;
        _h = h;
    }

    public override double GetArea() => _b * _h;

    public override double GetPerimeter() => 2 * (_a + _b);
}