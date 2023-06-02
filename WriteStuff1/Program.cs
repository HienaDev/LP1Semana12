using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> texto = new Queue<string>();

            string input = null;

            while (input != "")
            {
                input = Console.ReadLine();

                texto.Enqueue(input);
            }

            File.WriteAllLines(args[0], texto);

        }
    }
}
