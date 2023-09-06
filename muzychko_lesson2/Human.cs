using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muzychko_lesson2
{
    internal class Human
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public Human (string name, string age)
        {
            Name = name;
            Age = age;
        }
    }
}
