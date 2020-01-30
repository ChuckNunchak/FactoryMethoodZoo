using ConsoleApp1.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Factories
{
    class SimpleZooFactory : IAnimalFactory
    {
        private static Random rnd = new Random();
        public IAnimal Create()
        {
            string[] animals = new string[] {
                "Лев",
                "Зебра"
            };

            switch (animals[rnd.Next(0, animals.Length)]) // Рандомно выбираем из всех
            {
                case "Лев":
                    return new Lev();
                case "Зебра":
                    return new Zebra();
                default:
                    throw new Exception("Таких конкретных классов нет");
            }
        }
        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Самый простой зоопарк";
        }
    }
}
