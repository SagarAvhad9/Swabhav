﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    [MyUnitTestClass]
    public class Foo
    {
        public bool F1()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool F2()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool F3()
        {
            return true;
        }
    }
}