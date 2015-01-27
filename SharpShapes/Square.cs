using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Square : Rectangle
    {
        private int sidelength;

        public Square(int sidelength) : base(sidelength, sidelength)
        {
        }
    }
}
