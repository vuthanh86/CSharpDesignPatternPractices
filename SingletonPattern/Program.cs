using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello singleton");
            Console.WriteLine(Singleton.Numbers);
            Console.Read();
        }
    }
}
