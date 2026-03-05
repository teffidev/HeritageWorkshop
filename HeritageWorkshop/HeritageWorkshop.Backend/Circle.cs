namespace HeritageWorkshop.Backend;

public class Circle : GeometricFigure
{
    //Fields
    private double _r;

    //Constructors
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    //Properties
    public double R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    //Methods
    public override double GetArea() => Math.PI * Math.Pow(R, 2);

    public override double GetPerimeter() => 2 * Math.PI * R;

    private double ValidateR(double r)
    {
        if (r <= 1)
            throw new ArgumentException("Radius must be greater than zero.");
        return r;
    }
}
