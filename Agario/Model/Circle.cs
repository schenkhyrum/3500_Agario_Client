/// <summary> 
/// Author:    Samuel Hancock 
/// Partner:   Hyrum Schenk 
/// Date:      April 1, 2020 
/// Course:    CS 3500, University of Utah, School of Computing 
/// Copyright: CS 3500, Samuel Hancock and Hyrum Schenk - This work may not be copied for use in Academic Coursework. 
/// 
/// I, Samuel Hancock and Hyrum Schenk, certify that I wrote this code from scratch and did not copy it in part or whole from  
/// another source.  All references used in the completion of the assignment are cited in my README file. 
/// 
/// File Contents 
/// 
///    This file contains the class object for a circle and all information stored within it, including mass, poisition, color,
///    ID, type, name and owner
/// </summary>

using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Numerics;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Circle
    {
        // The following fields are suggestions only
        // Consider which fields should be readonly
        [JsonProperty]

        public int ID { get; private set; }


        [JsonProperty]
        public PointF Position { get; set; }// from drawing

        public Vector2 _Position { get; set; }// from numerics

        [JsonProperty]


        public Color CircleColor { get; set; }


        [JsonProperty]
        public float _Mass { get; private set; } // how does this come from the server? Is it actually a int?


        [JsonProperty]
        public string type { get; set; } // Should we write subclasses to define this?

        [JsonProperty]
        public int OwnerId { get; set; }

        [JsonProperty]
        public string name;

        public Circle(int id, PointF loc, int argb_color, float Mass, int Type, int belongs_to, string Name)
        {
            ID = id;
            Position = loc;

            CircleColor = Color.FromArgb(argb_color);

            _Mass = Mass;
            type = ConvertIntToType(Type);
            OwnerId = belongs_to;
            name = Name;
        }

        private static string ConvertIntToType(int TypeEnum)
        {
            return TypeEnum.ToString();
        }
    }
}
