﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sssq_d
{
    class Fish: Animal, ISwimming
    {
        public string Name
        { get; set; }
        public Fish(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        public override string ToString() => Name;
    }
}
