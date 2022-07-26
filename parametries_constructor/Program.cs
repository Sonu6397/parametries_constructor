using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_constructor
{
    class Addition
    {
        public int a;
        public string b;

        public Addition(int x, string y)
        {
            a = x;
            b = y;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition obj = new Addition(12, "sonu kumar");
            Console.WriteLine("value of a=" + obj.a);
            Console.WriteLine("value of b=" + obj.b);

            Console.ReadLine();
        }
    }
}
