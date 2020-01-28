using System;

namespace TicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are watching this ticket?");
            int watchingNum = 3;
            string Watching = "";
            for(int i=1;i<=watchingNum;i++)
            {
                Console.WriteLine("What is the name of Watcher " + i + "?");
                Watching += Console.ReadLine();

                if (i == watchingNum)
                {
                    break;
                }
                Watching += "|";

            }
            Console.WriteLine(Watching);
        }
    }
}
