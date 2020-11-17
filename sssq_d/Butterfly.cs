using System;
using System.Collections.Generic;
using System.Text;

namespace sssq_d
{
    class Butterfly: Animal, IFlying
    { 
        public string Name
        { get; set; }
        public Butterfly(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public override string ToString() => Name;
    }
}
