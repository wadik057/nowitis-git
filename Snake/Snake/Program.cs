﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();
            VerticalLine Vline = new VerticalLine(11, 20, 6, '#');

            Console.ReadLine();
        }
    }
}
