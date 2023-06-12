using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobloxMultiInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "funny multiple roblos";
            new Mutex(true, "ROBLOX_singletonEvent");
            Console.WriteLine("don, keep open pls");
            Console.ReadLine();
        }
    }
}
