using System;

using NDde.Client;


namespace specshell.software.omnic.dde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string result = sendDDE("[About]");
            Console.WriteLine("Result is " + result);
        }

        public static string sendDDE(string request)
        {
            Dde dde = new Dde();
            dde.Connect();
            dde.Execute(request, 1000);
            return dde.ResultCurrent;
        }
    }
}
