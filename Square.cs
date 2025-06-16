
using System.Drawing;

public class Square : Shapes, IColorable
    {
    public double side;

    //constructor
    public Square() => side = 0;
    public Square(double side) => this.side = side;

    //get/set
    public double GetSide() => side;
    public void SetSide(double side)=>this.side = side;

    public override double GetArea()
    {
        double areaSquare = side * side;
        Console.WriteLine($"Area of Square: {areaSquare:F2}");
        return areaSquare;
    }

    public void HowToColor()
    {
        Console.WriteLine("Color all four sides.");
    }
}
