using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Boy : Man
    {
       public override void Jump()
       {
            Console.WriteLine("boy jump");
       }
        public void Play()
        {
            Console.WriteLine("boy play");
        }
    }
}
