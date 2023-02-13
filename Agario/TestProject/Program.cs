using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Numerics;
using Model;

namespace TestProject
{
    class Program
    {

        static void Main(string[] args)
        {
            PointF point = new PointF(1.0f, 1.0f);
            Vector2 vec = Vector2.One;
            string pf = JsonConvert.SerializeObject(point);
            string vector = JsonConvert.SerializeObject(vec);
            Console.WriteLine(pf);
            Console.WriteLine(vector);
            Circle circle = new Circle(1, point, 885581824, 2000.0f, 1, -1, "aname");
            string msg = JsonConvert.SerializeObject(circle);
            Console.WriteLine(msg);
            JsonConvert.DeserializeObject(msg);
        }
    }
}
