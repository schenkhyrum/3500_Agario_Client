using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Model
{
    public class Box
    {
        public Rectangle rect;
        static private Random generator = new Random();
        public Box()
        {
            rect = new Rectangle(
                generator.Next(0, 3000),  //Warning: the 3000 and 2000 should really be constants in the world class!
                generator.Next(0, 2000),
                generator.Next(50, 1000),
                generator.Next(50, 1000));
        }
    }
}
