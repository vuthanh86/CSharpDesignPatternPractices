using System;
using System.Threading;

namespace FlyweightPattern
{
    class Program
    {
        static string[] _roboColors = new [] { "Red", "Blue", "Green", "Yellow", "Pink" };
        static void Main (string[] args)
        {
            Console.WriteLine ("Flyweight Pattern Demo");
            var randomColor = new Random ();
            var maxColorSize = _roboColors.Length - 1;

            var roboFactory = new RobotFactory ();
            IRobot shape = null;

            for (int i = 0; i < 3; i++)
            {
                shape = roboFactory.GetRobotFromFactory (RoboType.Small);
                Thread.Sleep (1000);
                shape.SetColor (_roboColors[randomColor.Next (0, maxColorSize)]);
                shape.Print ();
            }

            var totalRobots = roboFactory.TotalObjectsCreated;

            System.Console.WriteLine ($"Total robot objects = {totalRobots}");

            for (int i = 0; i < 3; i++)
            {
                shape = roboFactory.GetRobotFromFactory (RoboType.Large);
                Thread.Sleep (1000);
                shape.SetColor (_roboColors[randomColor.Next (0, maxColorSize)]);
                shape.Print ();
            }
            totalRobots = roboFactory.TotalObjectsCreated;

            System.Console.WriteLine ($"Total robot objects = {totalRobots}");

            Console.ReadKey ();
        }
    }
}