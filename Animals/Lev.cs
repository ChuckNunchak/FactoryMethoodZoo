using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    class Lev:IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAARRRRR");
        }
        public override string ToString()
        {
            return "Лев";
        }
    }
}
