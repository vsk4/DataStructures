﻿using System;

namespace DS_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 450);

            list.Display();

        }
    }
}