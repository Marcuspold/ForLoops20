﻿using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string name = "Harry";
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i}. {name[i]}");
            }
                
        }
    }
}
