﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    [MyUnitTestClass]
    class Bar
    {
        [MyUnitTestMethod]
        public bool B1()
        {
            return false; 
        }
        public bool B2()
        {
            return false; 
        }
        public bool B3()
        {
            return false;
        }
    }
    [MyUnitTestClass]
    class sutar
    {
        [MyUnitTestMethod]
        public bool s()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool s1()
        {
            return false;
        }
    }
}
