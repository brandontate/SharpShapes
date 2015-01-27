using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    abstract public class Shape
    {
        public Shape()
        {
            FillColor = Color.Bisque;
            BorderColor = Color.Tomato;
        }

        /// <summary>
        /// The number of sides of this shape 
        /// </summary>
        //number of lines
        abstract public int SidesCount { get; }

        /// <summary>
        /// The border color of the shape 
        /// </summary>

        //border color
        public Color BorderColor { get; set; }

        /// <summary>
        /// The interior color of the shape 
        /// </summary>
        //fill color
        public Color FillColor { get; set; }

        /// <summary>
        /// Calculate the area of the shape 
        /// </summary>
        /// <returns> The area of the shape </returns>
        //area
        abstract public decimal Area();

        /// <summary>
        /// Calculate the perimeter of the shape
        /// </summary>
        /// <returns> The perimeter of the shape </returns>
        //perimeter
        abstract public decimal Perimeter();

        /// <summary>
        /// Scales the shape in size 
        /// </summary>
        /// <param name="percent"> The percent by which to scale the shape </param>
        //resize a shape by percent
        abstract public void Scale(decimal percent);

    }
}
