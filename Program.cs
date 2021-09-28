using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210923
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "";

            Dictionary<int, string> cheeze = new Dictionary<int, string>();
            cheeze.Add(3, "Fizz");
            cheeze.Add(5, "Buzz");
            cheeze.Add(7, "Foo");
            cheeze.Add(11, "Bar");
            cheeze.Add(13, "Baz");

            //string finalMsg = "";

            for (int i = 1; i <= 10000; i++)
            {
                msg = "";
                foreach(int key in cheeze.Keys) { if (i % key == 0) { msg += cheeze[key]; } }
                if (msg == "") { msg += i; }
                Console.WriteLine(msg);
                //finalMsg += msg + "\n";
            }
            //Console.WriteLine(finalMsg);





            Console.ReadLine();

            /*
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0) { output += "Fizz"; }
                if (i % 3 == 0) { output += "Buzz"; }

                if(output == "") { output += i; }

                Console.WriteLine(output);
            }
            //*/

            
        }
    }
}
