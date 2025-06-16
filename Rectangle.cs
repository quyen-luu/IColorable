public class Rectangle : Shapes
{
    //variables
    public double width;
    public double height;

    //constructor
    public Rectangle()
    {
        width = 0;
        height = 0;
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    //get/set
    public double GetWidth() => width;
    public void SetWidth(double width) => this.width = width;

    public double GetHeight() => height;
    public void SetHeight(double height) => this.height = height;

    public override double GetArea()
    {
        double areaRectangle = width * height;
        Console.WriteLine($"Area of rectangle: {areaRectangle:F2}");
        return areaRectangle;
    }
    
}