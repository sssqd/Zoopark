using System;
using System.Collections.Generic;
using System.Text;

namespace sssq_d
{
    interface IFlying
    {
        public void Walk()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}
