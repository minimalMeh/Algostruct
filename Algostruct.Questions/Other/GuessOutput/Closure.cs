using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algostruct.Questions.Other.GuessOutput
{
    public class Test1
    {
        public static void WhatWillBePrinted()
        {
            var listActions = new List<Action>();

            for (var i = 0; i < 10; i++)
            {
                listActions.Add(() => Console.WriteLine(i + " "));
            }

            for (int i = 0; i < 10; i++)
                listActions[i]();
        }
    }

    public class Test2
    {
        public static void WhatWillBePrinted()
        {
            Predicate<int> predicate = delegate (int a)
            {
                if (a >= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            };

            Console.WriteLine(predicate(-1));
        }
    }

    public class Test3
    {
        public static void WhatWillBePrinted()
        {
            JustDerivedClass<int>.JustPrint(4);
            JustDerivedClass<string>.JustPrint("reewrwe");
        }

        class JustClass<T>
        {
            public static void JustPrint(T item)
            {
                Console.WriteLine(item.GetType().Name + ' ');
            }
        }

        class JustDerivedClass<U> : JustClass<U>
        {
        }
    }

    public class Test4
    {
        public static async void WhatWillBePrinted()
        {
            await Task.Run(async () =>
            {
                Async();
                Sync();
            });
        }

        public static async Task Sync()
        {
            Task.Delay(1000);

            Console.WriteLine("Sync");
        }

        public static async Task Async()
        {
            await Task.Delay(1000);

            Console.WriteLine("Async");
        }
    }

    public class Test5
    {
        private static object syncObject = new object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }
        public static void Test()
        {
            lock (syncObject)
            {
                Write();
            }
        }
    }

    public class Test6
    {
        public class A
        {
            public virtual void Print1()
            {
                Console.Write("A");
            }
            public void Print2()
            {
                Console.Write("A");
            }
        }
        public class B : A
        {
            public override void Print1()
            {
                Console.Write("B");
            }
        }
        public class C : B
        {
            new public void Print2()
            {
                Console.Write("C");
            }
        }

        public static void Test()
        {
            var c = new C();
            A a = c;

            a.Print2();
            a.Print1();
            c.Print2();
        }
    }

    public class Test7
    {
        static IEnumerable<int> Square(IEnumerable<int> a)
        {
            foreach (var r in a)
            {
                Console.WriteLine(r * r);
                yield return r * r;
            }
        }
        class Wrap
        {
            private static int init = 0;
            public int Value
            {
                get
                {
                    //Console.WriteLine("Reached Value in Wrap: " + init);
                    return ++init;
                }
            }
        }
        public static void Test()
        {
            var w = new Wrap();
            var wraps = new Wrap[3];
            for (int i = 0; i < wraps.Length; i++)
            {
                wraps[i] = w;
            }

            var values = wraps.Select(x => x.Value); //.ToList();
            var results = Square(values);  // or .ToList();
            int sum = 0;
            int count = 0;
            foreach (var r in results)
            {
                count++;
                sum += r;
            }
            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Sum {0}", sum);

            Console.WriteLine("Count {0}", results.Count());
            Console.WriteLine("Sum {0}", results.Sum());
        }
    }

    public class Test8
    {
        public static void Test()
        {
            List<string> projects = new();
            List<string> measures = new() { "cm", "m", "km" };

            measures.ForEach(async x =>
            {
                Console.WriteLine("In ForEach");
                var result = await GetResultOfMeasure(x);
                projects.Add(result);
            });

            Console.WriteLine(projects.Count);

            async Task<string> GetResultOfMeasure(string s)
            {
                Console.WriteLine("In GetResultOfMeasure Before Delay");
                await Task.Delay(100);
                Console.WriteLine("In GetResultOfMeasure After Delay");
                return $"Measured as {s}";
            }
        }
    }

    public class Test9
    {
        class MyCustomException : DivideByZeroException
        {

        }
        public static void Test()
        {
            try
            {
                Calc();
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch MyCustomException");
                //throw;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Catch Exception");
            }
            Console.ReadLine();
        }

        private static void Calc()
        {
            int result = 0;
            var x = 5;
            int y = 0;
            try
            {
                result = x / y;
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch DivideByZeroException");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch Exception");
            }
            finally
            {
                throw new MyCustomException();
            }
        }
    }

    public class Test10
    {
        private class TestClass
        {
            public void Print()
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.Write("9");
                    throw new Exception();
                }
                finally
                {
                    Console.Write("2");
                }
            }
        }
        public static void Test()
        {
            var test = new TestClass();
            try
            {
                test.Print();
            }
            catch (Exception)
            {
                Console.Write("5");
            }
            finally
            {
                Console.Write("4");
            }
            Console.ReadLine();
        }
    }
}
