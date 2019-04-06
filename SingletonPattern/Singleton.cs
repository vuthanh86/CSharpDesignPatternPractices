using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton()
        {
            Console.WriteLine("Initial singleton object.");
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Intance already init.");
                return _instance;
            }
        }

        public static int Numbers = 25;
    }
}
