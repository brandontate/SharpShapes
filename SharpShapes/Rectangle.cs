using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Rectangle : Shape
    {
        private decimal width;
        public decimal Width
        {
            get { return this.width; }
        }

        private decimal height;
        public decimal Height 
        {
            get { return this.height; }
        }

        public override int SidesCount
        {
            get { return 4; }
        }

        public override decimal Perimeter()
        {
            return (width * 2) + (height * 2);
        }

        public override decimal Area()
        {
            return width * height;
        }

        public Rectangle(decimal width, decimal height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width;
            this.height = height;
        }

        public override void Scale(decimal percent)
        {
            if (percent <= 0)
            {
                throw new ArgumentException();
            }
            this.width = width * (percent/100);
            this.height = height * (percent/100);
        }
    }
}
