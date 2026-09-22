using System.Net.WebSockets;
using System.Threading.Channels;

namespace PrüfungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("Zeichne die dreien Shapes");
            Shape s = new Circle();
            s.Draw();
            Shape t = new Triangle();
            t.Draw();
            Shape r = new Rectangle();
            r.Draw();
        }
    }
    abstract class Shape
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public ConsoleColor Color { get; set; }

        public virtual void Draw()
        {

        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Circle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Triangle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Rectangle"); 
        }
    }
}
