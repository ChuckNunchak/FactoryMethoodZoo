using ConsoleApp1.Factories;
using ConsoleApp1.Zoos;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory[] zoos = new IAnimalFactory[]
            {
                new SimpleZooFactory(),
                new MidleZooFactory()
            };
            Console.WriteLine("Выберите зоопарк: ");
            for (int i = 0; i < zoos.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {zoos[i].ToString()}"); // i+1 потому что нормальные люди считают с 1, а не с 0
            }
            int Number = Convert.ToInt32(Console.ReadLine()) - 1; // -1 потому что нормальные люди всё ещё считают с 1)))

            if (Number > -1 && Number < zoos.Length) // проверяем находится ли число в пределах массива
            {
                Zoo zoo = new Zoo(zoos[Number]); // создаём парк с выбранным уровнем сложности
                zoo.Start();
            }
            else
            {
                Console.WriteLine("Недопустимое число");
            }

            Console.ReadKey();
        }
    }
}

