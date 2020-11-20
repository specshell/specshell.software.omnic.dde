using System;
using System.Threading;

namespace specshell.software.omnic.dde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It starting");
            Console.WriteLine("It starting123");
            CommandResponse commandResponse = Commands.AdvancedAtr(1.36, 2.40, 1.0, 45.0);
            Console.WriteLine(commandResponse.DdeException);
            Thread.Sleep(60 * 60 * 1000);
            // Commands.AdvancedAtr(1.36, 2.40, 1.0, 45.0);
            // 16394
        }
    }
}
