﻿using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\simar\C#\Exercise1\Exercise1\c# crash course exercises data.csv");

            var lines = System.IO.File.ReadLines(@"C:\test.txt");            
        var Minimum = "";
        var Maximum = "";


            foreach (string line in lines)
            {

                if (Maximum.Length < line.Length)
                {
                    Maximum = line;
                }


                if (Minimum.Length > line.Length)
                {
                    Minimum = line;
                }
           }

            //while ((line = file.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(line);
            //    counter++;
            //}

            //file.Close();
            ////System.Console.WriteLine("There were {0} lines.", counter);
            ////// Suspend the screen.  
            ////System.Console.ReadLine();
        }
    }
}
