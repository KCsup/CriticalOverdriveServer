using System;

namespace CriticalOverdriveServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Critical Overdrive Server v1.0";
            Server.Start(20, 8280);
            Console.ReadKey();
        }
    }
}
