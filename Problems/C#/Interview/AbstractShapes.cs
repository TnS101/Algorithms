using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Interview
{
    public class AbstractShapes
    {
        public abstract class Shape 
        {
            public virtual double CalculateSurface() 
            {
                return this.Width * this.Height;
            }

            public int Width { get; set; }

            public int Height { get; set; }
        }

        public class Triangle : Shape
        {
            public Triangle()
            {

            }

            public override double CalculateSurface()
            {
                return this.Height * this.Width / 2;
            }
        }

        public class Rectangle : Shape 
        {
            public Rectangle()
            {
            }

            public override double CalculateSurface()
            {
                return this.Width * this.Height;
            }
        }

        public class Circle : Shape 
        {
            public Circle()
            {
                this.Height = this.Width;
            }

            public override double CalculateSurface()
            {
                var r = this.Width / 2;
                return Math.PI * r * r;
            }
        }
    }
}
