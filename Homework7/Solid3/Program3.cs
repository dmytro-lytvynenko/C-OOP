using System;


class Rectangle
{
    public int Width
    { get; set; }
    public int Height
    { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square
{
    public int Side { get; set; }
    public int GetRectangleArea()
    {
        return Side*Side;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;
            Console.WriteLine(rect.GetRectangleArea());
            
            Square square = new Square();
            square.Side = 10;
            Console.WriteLine(square.GetRectangleArea());

            Console.ReadKey();
        }
    }
}