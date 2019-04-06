using System;
using System.Threading;

namespace VisitorPattern
{
    interface IVisitor
    {
        void Visit (VisitorClass visitorObject);
    }

    class Visitor : IVisitor
    {
        public void Visit (VisitorClass visitorObject)
        {
            Console.WriteLine ("Visitor is trying to change the integer value.");
            visitorObject.MyNumber = 100;
            Console.WriteLine ("Exiting from Visitor.");
        }
    }

    interface IOriginal
    {
        void Accept (IVisitor visitor);
    }

    class VisitorClass : IOriginal
    {
        private int myNumber;

        public int MyNumber { get => myNumber; set => myNumber = value; }
        public void Accept (IVisitor visitor)
        {
            Console.WriteLine ("Initial value of the integer:{0}", myNumber);
            visitor.Visit (this);
            Console.WriteLine ("\nValue of the integer now:{0}", myNumber);
        }
    }
}