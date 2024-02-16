using System;

namespace Algostruct.Questions.Other.GuessOutput
{
    public class MethodHiding
    {
        // Because it is stored in A class, the hidden Print method in C is not visible.
        public static void Print()
        {
            A a = new A();
            A b = new B();
            A c = new C();

            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }

        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A::Print");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B::Print");
            }
        }
        class C : B
        {
            public new void Print()
            {
                base.Print();

                Console.WriteLine("C::Print");
            }
        }
    }
}
