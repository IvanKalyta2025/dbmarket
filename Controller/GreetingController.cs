using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace dbmarket.Controller
{
    public class GreetingController
    {
        public static void Run(string? yourname)
        {
            Console.WriteLine($"Hello, {yourname}!");
        }
    }
}