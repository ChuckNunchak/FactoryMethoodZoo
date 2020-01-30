using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Park
    {
        private IAnimal[] animals;

        private Tree[] trees;

        public Park(IAnimal[] animals, Tree[] trees)
        {
            this.animals = animals;
            this.trees = trees;
            
        }

        public void AnimalInfo()
        {
            var lev = animals.Where((item) => {
                return item.ToString() == "Лев";
            }).Count();

            Console.WriteLine($"{lev} Лев");


            var zebra = animals.Where((item) => {
                return item.ToString() == "Зебра";
            }).Count();

            Console.WriteLine($"{zebra} Зебра");

        }
    }
}
