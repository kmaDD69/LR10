﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.ISP_right
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }
}