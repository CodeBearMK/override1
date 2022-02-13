using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override1
{
    internal class Person:Animal
    {
        public new string Mammal
        {
            get { return "人"; }
        }

        public string Special
        {
            get { return "智慧"; }
        }

        public override void display()
        {
            Console.WriteLine("{0} 是 {1}", Mammal, kind);
            Console.WriteLine("{0} 是 {1} 的 {2}", Mammal, Special, kind);
        }
    }
}
