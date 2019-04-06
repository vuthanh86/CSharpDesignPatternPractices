using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern Demo***\n");
            var visitor = new Visitor();
            var myClass = new VisitorClass();
            myClass.Accept(visitor);
            Console.ReadLine();
        }
    }
}
