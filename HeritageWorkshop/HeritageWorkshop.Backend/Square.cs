namespace HeritageWorkshop.Backend;

public class Square : GeometricFigure
{
    //Fields
    private double _a;

    //Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    //Properties
    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    }

    //Methods
    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;
    private double ValidateA(double a)
    {
        if (a <= 1)
            throw new ArgumentException("Side must be greater than zero.");
        return a;
    }
}
