public class Circle : Shapes
{
    public double radius;

    //constructor
    public Circle() => radius = 0;
    public Circle(double radius) => this.radius = radius;

    //get/set
    public double GetRadius() => radius;
    public void SetRadius(double radius)=> this.radius = radius;

    public override double GetArea()
    {
        double areaCircle = radius * radius * Math.PI;
        Console.WriteLine($"Area of circle: {areaCircle:F2}");
        return areaCircle;
    }
}