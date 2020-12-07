using System;
using System.Collections.Generic;
using MyOrchestra.Factories;
using MyOrchestra.Instruments;
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
            
            /*
             * IOrchestra наследует интерфейс IEnumerable<Person>
             * IFactory<IEnumerable<Person>> создаёт IEnumerable<Person> - толпу людей
             * Проявление ковариантности - фабрику, создающую IOrchestra можно привести к типу фабрики,
             * которая создает IEnumerable<Person>
             */
            Console.WriteLine("\nСоздаём толпу людей:");
            IFactory<IEnumerable<Person>> crowdFactory = orchestraFactory;
            IEnumerable<Person> crowd = crowdFactory.create();
            foreach (Person dude in crowd)
            {
                Console.WriteLine("Просто человек из толпы: " + dude.Name);
            }
        }
    }
}