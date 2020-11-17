using System;
using System.Collections.Generic;
using System.Text;

namespace sssq_d
{
    interface IWalking
    {
        public void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
