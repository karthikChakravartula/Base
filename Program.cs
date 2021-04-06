using System;
using CoreLogic;

namespace Interfce
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogic c = new SomeLogic();
            var dd = c.DoAdd(23, 12);
            ILogic2 sss = new SomeLogic();
            //sss.
            c = new SomeLogic2();
            dd = c.DoAdd(12, 43);

            Console.WriteLine("Hello World!");
        }
    }
}
