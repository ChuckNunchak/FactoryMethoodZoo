using ConsoleApp1.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Factories
{
    class MidleZooFactory : IAnimalFactory
    {
        private static int MidleAnimalCount = 0;

        public IAnimal Create()
        {
            if (MidleAnimalCount < 10)
            {
                MidleAnimalCount += 1;
                return new Zebra();
            }
            IAnimalFactory simpleFactory = new SimpleZooFactory();
            return simpleFactory.Create();
        }
        public override string ToString()
        {
            return "Апнутный зоопарк";
        }
    }
}
