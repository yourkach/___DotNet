using System;
using MyOrchestra.Factories;
using MyOrchestra.Instruments;

namespace MyOrchestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Готовится оркестр...");
            IOrchestraFactory orchestraFactory = new OrchestraFactory();
            var orchestra = orchestraFactory.create();
            
            Console.WriteLine("Готовится композиция...");
            ICompositionFactory compositionFactory = new CompositionFactory();
            var composition = compositionFactory.create();

            Console.WriteLine("Оркестр попытается сыграть композицию:");
            orchestra.PlayComposition(composition);
        }
    }
}