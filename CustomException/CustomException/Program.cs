﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomException.Model;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new SagarException();
            throw new SagarException("sagar");
            Console.ReadKey();
        }
    }
}
