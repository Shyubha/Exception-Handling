using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day4
{
    abstract public class Shapes
    {
        abstract public void CalculateArea();
    }

    public class Circle : Shapes, IPrintable
    {
        private int radius;
        private double result, PI = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            result = PI * radius * radius;
        }

        public string Print()
        {
            return result + " ";
        }

        public override string ToString()
        {
            return result + " ";
        }
    }

    public class Rectangle : Shapes
    {
        private int width;
        private int lenght;
        private int result1;

        public Rectangle(int width, int lenght)
        {
            this.width = width;
            this.lenght = lenght;
        }

        public override void CalculateArea()
        {
            result1 = lenght * width;
        }

        public override string ToString()
        {
            return result1 + "  ";
        }

    }
}

