namespace GeometricFigures.Backend;

public class Trapeze : GeometricFigure
{
    private double _a, _b, _c, _d, _h;

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name)
    {
        _a = a;
        _b = b;
        _c = c;
        _d = d;
        _h = h;
    }

    public override double GetArea() => ((_b + _d) * _h) / 2;

    public override double GetPerimeter() => _a + _b + _c + _d;
}