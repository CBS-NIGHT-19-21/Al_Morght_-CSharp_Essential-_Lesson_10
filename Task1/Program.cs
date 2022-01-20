using System;

namespace Task1
{
    internal class Program
    {
        class Car { }

        class BMW : Car { public string Name { get; } = "E34"; }

        public class MyClass<T> where T : new()
        {
            public static T FacrotyMethod()
            {
                return new T();
            }
        }
        static void Main(string[] args)
        {
            Car automobile = MyClass<BMW>.FacrotyMethod();
            BMW automobile2 = new BMW();

            Console.WriteLine(automobile.GetType().Name);
            Console.WriteLine(automobile2.Name);

            Console.ReadKey();
        }
    }
}
