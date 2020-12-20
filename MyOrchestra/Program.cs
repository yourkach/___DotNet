using System;
using System.Collections.Generic;
using MyOrchestra.Factories;
using MyOrchestra.Orchestra;
using MyOrchestra.Persons;

namespace MyOrchestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Готовится оркестр...");
            IFactory<IOrchestra> orchestraFactory = new OrchestraFactory();
            var orchestra = orchestraFactory.create();

            Console.WriteLine("Готовится композиция...");
            ICompositionFactory compositionFactory = new CompositionFactory();
            var composition = compositionFactory.create();

            Console.WriteLine("Оркестр попытается сыграть композицию:");
            orchestra.PlayComposition(composition);


            Console.WriteLine("\nПредставим музыкантов, как обычных людей");
            Console.WriteLine(
                "Как отсортировать людей в оркестре?\nN > по имени\nG > по половому признаку\nОжидается ввод..");

            // переменная делегата, хранящая ссылку на метод, используемый для сравнения в сортировке
            Func<Person, Person, bool> compareFunction;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.G:
                    compareFunction = comparePersonsByGender;
                    break;
                case ConsoleKey.N:
                    compareFunction = comparePersonsByName;
                    break;
                default:
                    compareFunction = null;
                    break;
            }

            Console.WriteLine();

            // сортировка внутреннего списка с использованием переданной функции сравнения
            orchestra.SortPersonsWithFunction(compareFunction);
            
            IEnumerable<Person> crowd = orchestra;
            foreach (Person dude in crowd)
            {
                Console.WriteLine("Имя: " + dude.Name + ", " + dude.Gender);
            }
        }

        static bool comparePersonsByName(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name) < 0;
        }

        static bool comparePersonsByGender(Person p1, Person p2)
        {
            return p1.Gender.CompareTo(p2.Gender) < 0;
        }
    }
}