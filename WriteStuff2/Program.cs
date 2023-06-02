using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff2
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(args[0]);

            string input = null;

            while (input != "")
            {
                input = Console.ReadLine();

                if (input != "")
                    sw.WriteLine(input);
            }

            sw.Close();

        }
    }
}
