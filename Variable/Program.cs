using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            //1.Integers --> 4 Bytes
            int a = 5;
            Console.WriteLine(a);

            //2. Double --> 4 Bytes
            double b = 5.5D;
            Console.WriteLine(b);

            //3. Character --> 2 Bytes
            char c = 'A';
            Console.WriteLine(c);

            //4. String --> 2Bytes
            string s = "Devansh Jangid";
            Console.WriteLine("My Name Is " + s);

            //Boolen --> 1 Bits
            bool d = true;
            bool e = false;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
