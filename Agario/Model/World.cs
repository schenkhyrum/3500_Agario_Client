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
///    This file contains the code for the World class object. This keeps track of world coordinates and stores all recieved circles
///    in a Dictionary sorted by ID number. It also includes helper methods for adding and removing circles from saved circles.
/// </summary>

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class World
    {


        int PlayerId;


        public Dictionary<int, Circle> circles = new Dictionary<int, Circle>(); // This way we can look up a circle by its identifier. We should consider what a list would do here.

        public Dictionary<int, Circle> GetCircles()
        {
            return circles;
        }
        public int World_Height { get; set; } = HEIGHT;//Shouldn't we just use the constructors?
        public int World_Width { get; set; } = WIDTH; // These are supposed to be Default of 5000.

        private static int WIDTH = 5000;
        private static int HEIGHT = 5000;

        ILogger _logger; // This seemed to be the most appropriate type for our logger

        public World() : this(new Logger.CustomLogger())
        {

        }

        public World(ILogger logger) : this(logger, 5000, 5000)
        {

        }

        public World (ILogger logger, int height, int width)
        {
            World_Height = height;
            World_Width = width;
            //_logger = logger;
            circles = new Dictionary<int, Circle>();
        }

        public void AddCircle(Circle circle)
        {
            circles.Add(circle.ID, circle);
        }
        /// <summary>
        /// Add and replace all the circles to the world model
        /// </summary>
        /// <param name="args">A list of circles to add or update.</param>
        public void AddAll(List<Circle> args)
        {
            lock (circles) 
            {
                foreach (Circle circle in args)
                {
                    circles[circle.ID] = circle;
                }
            }
        }
        /// <summary>
        /// Used to remove circles from the world model. 
        /// </summary>
        /// <param name="ToRemove"></param>
        public void RemoveCircles(List<Circle> ToRemove)
        {
            lock (circles)
            {
                foreach (Circle circle in ToRemove)
                {
                    circles.Remove(circle.ID);
                }
            }
        }

        public void SetPlayerId(int id)
        {
            this.PlayerId = id;
        }
    }
}
