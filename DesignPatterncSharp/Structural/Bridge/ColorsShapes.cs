using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesignPatterncSharp.Structural.Bridge
{
    // Implementor
    public interface painter
    {
        void Paint();
    }

    public class Red : painter
    {
        public void Paint()
        {
            Console.WriteLine("Paint Red");
        }
    }

    public class Blue : painter
    {
        public void Paint()
        {
            Console.WriteLine("Paint Red");
        }
    }


    // Abstractions
    public abstract class Shapes { 
    
        public painter painter;
        public Shapes(painter painter)
        {
            this.painter = painter;
        }

      public abstract void Draw();
    }

    // Refined abstractions
    public class Circle : Shapes
    {

      public  Circle(painter painter):base(painter) { 
        
        }
        public override void Draw()
        {
            Console.Write("Draw circle");
            this.painter.Paint();

        }
    }

    public class Reactangle : Shapes
    {

       public Reactangle(painter painter) : base(painter)
        {

        }
        public override void Draw()
        {
            Console.Write("Draw Reactange");
            this.painter.Paint();

        }
    }

    public class Square : Shapes
    {

       public Square(painter painter) : base(painter)
        {

        }
        public override void Draw()
        {
            Console.Write("Draw Square");
            this.painter.Paint();

        }
    }


    public class TestBridge { 
    
    
       public static void main()
        {
            Shapes shape = new Circle(new Red());
            shape.Draw();

             shape = new Circle(new Blue());
            shape.Draw();

             shape = new Reactangle(new Red());
            shape.Draw();

            shape = new Reactangle(new Blue());
            shape.Draw();

            shape = new Square(new Red());
            shape.Draw();

            shape = new Square(new Blue());
            shape.Draw();
        }
    
    }

}
