using System;

namespace Algostruct.Questions.Other.GuessOutput
{
    public class VirtualNewInheritance
    {
        public static void Print()
        {
            A ac = new C();
            C c = new C();
            Console.WriteLine(ac.Print());
            Console.WriteLine(c.Print());
        }


        public abstract class A
        {
            public virtual string Print() { return "A"; }
        }

        public class B : A
        {
            // From this time this method will be overriden.
            public virtual new string Print() { return "B"; }
        }

        public class C : B
        {
            public override string Print()
            {
                //return base.Print();
                return "C";
            }
        }
    }
}
