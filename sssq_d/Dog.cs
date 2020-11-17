using System;
using System.Collections.Generic;
using System.Text;

namespace sssq_d
{
    class Dog: Animal, IWalking
    {
        public string Name
        { get; set; }
        public Dog(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public override string ToString() => Name;
    }
}
