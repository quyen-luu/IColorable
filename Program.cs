public class Program
{
    public static void Main(string[] args)
    {
        Shapes[] shapes = new Shapes[]
        {
            new Circle(2),
            new Rectangle(3, 5),
            new Square(4)
        };


        foreach (Shapes shape in shapes)
        {
            shape.GetArea();
            if (shape is Square square)
            {
                square.HowToColor();
            }
        }
    }
}