using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    public abstract class Shape
    {
        /// <summary>
        /// The number of sides of this shape 
        /// </summary>
        //number of lines
        public virtual int SidesCount { get; }

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
        public abstract decimal Area();

        /// <summary>
        /// Calculate the perimeter of the shape
        /// </summary>
        /// <returns> The perimeter of the shape </returns>
        //perimeter
        public abstract int Perimeter();

        /// <summary>
        /// Scales the shape in size 
        /// </summary>
        /// <param name="percent"> The percent by which to scale the shape </param>
        //resize a shape by percent
        public abstract void scale(int percent) { }


        //width
        //height

    }
}
