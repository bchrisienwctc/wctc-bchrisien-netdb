using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bogus = new string[]
           {
                "tom",
                "richard",
                "harry"
           };
            Console.WriteLine($"The Second name is: {bogus[1]}");
            for (int i = 0; i < bogus.length; i++)
            {

            }

            string myString = "";
            var myString2;

            foreach(string name in bogus)
            {
                Console.WriteLine($"The second name is: {name}");
            }
        }
    }
}
