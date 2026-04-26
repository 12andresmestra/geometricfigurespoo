namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private double _r;

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public double R
    {
        get => _r;
        set => _r = value > 0 ? value : throw new ArgumentException("Invalid radius");
    }

    public override double GetArea() => Math.PI * _r * _r;

    public override double GetPerimeter() => 2 * Math.PI * _r;
}