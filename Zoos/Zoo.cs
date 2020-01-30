using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Zoos
{
    class Zoo
    {
        private Park location;
        public Zoo(IAnimalFactory factory)
        {
            Tree[] trees = new Tree[]
            {
            new Tree(),
            new Tree(),
            new Tree()
            };
            IAnimal[] animals = new IAnimal[100];
            for(int i = 0; i < animals.Length; i++)
            {
                animals[i] = factory.Create();
            }
            location = new Park(animals, trees);
        }
        public void Start()
        {
            Console.WriteLine("Локация загружена");
            Console.WriteLine("Деревья расставлены");
            Console.WriteLine("Животные в вальере");
            

            location.AnimalInfo(); // Выведем инфу о том, сколько и каких типов быдло у нас сгенерилось 

        }

    }
}

