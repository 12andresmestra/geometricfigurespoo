namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) : base(name)
    {
        _a = a;
    }

    public override double GetArea() => _a * _a;

    public override double GetPerimeter() => 4 * _a;
}