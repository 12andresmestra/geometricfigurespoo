namespace GeometricFigures.Backend;

public class Rhombus : GeometricFigure
{
    private double _a, _d1, _d2;

    public Rhombus(string name, double a, double d1, double d2) : base(name)
    {
        _a = a;
        _d1 = d1;
        _d2 = d2;
    }

    public override double GetArea() => (_d1 * _d2) / 2;

    public override double GetPerimeter() => 4 * _a;
}