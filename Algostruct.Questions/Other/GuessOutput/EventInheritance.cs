using System;

namespace Algostruct.Questions.Other.GuessOutput
{
    public class EventInheritance
    {
        public static void Print()
        {
            A a = new B();
            a.Evt += a.Print;
            a.DoAction();
            Console.ReadKey();
        }

        // A() will be called before B()
        public class A
        {
            public A()
            {
                Evt += x => Console.WriteLine(x);
            }

            public event Action<object> Evt;

            public void DoAction()
            {
                if (Evt != null)
                    Evt("Hello");
            }

            public void Print(object o)
            {
                Console.WriteLine(o);
            }
        }

        public class B : A
        {
            public B()
            {
                Evt += x => Console.WriteLine(x);
            }
        }
    }
}
