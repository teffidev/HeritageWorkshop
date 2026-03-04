namespace HeritageWorkshop.Backend;

public abstract class GeometricFigure
{
    //Constructors
    public GeometricFigure(string name)
    {
        Name = name;
    }

    //Properties
    public string Name { get; set; } = null!;

    //Methods
    override public string ToString()
    {
        return $"{Name, -15} => Area.....: {GetArea(), 15:N5}\tPerimeter: {GetPerimeter(), 15:N5}";
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

}
