using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlyweightPattern
{
    public interface IRobot
    {
        void Print ();

        void SetColor (string color);
    }

    public class Robot : IRobot
    {
        private readonly RoboType roboType;

        public Robot (RoboType roboType)
        {
            this.roboType = roboType;
        }
        private string color;

        public void SetColor (string color)
        {
            this.color = color;
        }

        public void Print ()
        {
            System.Console.WriteLine ($"This is a {roboType} type with {color} color.");
        }
    }

    public enum RoboType
    {
        [Display (Name = "Small Robot")]
        Small = 0, [Display (Name = "Large Robot")]
        Large = 1
    }

    // public class SmallRobot : IRobot
    // {
    //     public void Print ()
    //     {
    //         System.Console.WriteLine ("This is a small robot.");
    //     }
    // }

    // public class LargeRobot : IRobot
    // {
    //     public void Print ()
    //     {
    //         System.Console.WriteLine ("I am a large Robot");
    //     }
    // }

    public class RobotFactory
    {
        private readonly IDictionary<RoboType, IRobot> shapes = new Dictionary<RoboType, IRobot> ();       

        public int TotalObjectsCreated => shapes.Count;

        public IRobot GetRobotFromFactory (RoboType roboType)
        {
            IRobot robotCategory = null;

            if (shapes.ContainsKey (roboType))
            {
                robotCategory = shapes[roboType];
            }
            else
            {
                switch (roboType)
                {
                    case RoboType.Small:
                        robotCategory = new Robot (RoboType.Small);
                        shapes[RoboType.Small] = robotCategory;
                        break;

                    case RoboType.Large:
                        robotCategory = new Robot (RoboType.Large);
                        shapes[RoboType.Large] = robotCategory;
                        break;
                    default:
                        throw new System.Exception ("Robo type not found !!!");
                }
            }

            return robotCategory;
        }
    }
}