using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            Random random = new Random();

            for (int i = 0; i < 15; i++)
                myList.Add(random.Next(1, 100));

            for (int i = 0; i < myList.Length; i++)
                Console.Write(myList[i] + " ");

            Console.WriteLine("\n" + new string('-', 45));

            int[] ExtList = myList.GetArray();

            for (int i = 0; i < ExtList.Length; i++)
                Console.Write(ExtList[i] + " ");

            Console.ReadKey();
        }
    }
}
