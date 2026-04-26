namespace GeometricFigures.Backend;

public class Kite : GeometricFigure
{
    private double _a, _b, _d1, _d2;

    public Kite(string name, double a, double b, double d1, double d2) : base(name)
    {
        _a = a;
        _b = b;
        _d1 = d1;
        _d2 = d2;
    }

    public override double GetArea() => (_d1 * _d2) / 2;

    public override double GetPerimeter() => 2 * (_a + _b);
}