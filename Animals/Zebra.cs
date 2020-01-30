using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    class Zebra : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("BBBBBBBBBBRRRRR");
        }
        public override string ToString()
        {
            return "Зебра";
        }
    }
}
