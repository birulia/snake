﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 2;
            p1.y = 4;
            p1.sym = '*';

            p2.x = 5;
            p2.y = 5;
            p2.sym = '#';

            p1.Draw();
            p2.Draw();
          
       
            Console.ReadLine();
        }
    }
}
