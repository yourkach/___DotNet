using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using MyOrchestra.Melodies;
using MyOrchestra.Persons;

namespace MyOrchestra.Orchestra
{
    public class Orchestra : IOrchestra
    {
        public Orchestra(IEnumerable<Musician> musicians, Conductor conductor)
        {
            Musicians = musicians.ToImmutableList();
            Conductor = conductor;
            
            _persons = Musicians.ToList<Person>();
            _persons.Add(conductor);
        }

        private List<Person> _persons;

        public ImmutableList<Musician> Musicians { get; }

        public Conductor Conductor { get; }

        public void PlayComposition(MusicalComposition composition)
        {
            if (!CheckCanPlayComposition(composition))
            {
                Console.WriteLine("Оркестр не может сыграть эту композицию!");
            }
            else
            {
                Console.WriteLine($"Дирижирует {Conductor.Name}!");
                Console.WriteLine(composition.Name);
                foreach (var part in composition.MusicalParts)
                {
                    Console.WriteLine("Партию играют: ");
                    var currentPartMusicians = Musicians.Where(m => m.Instrument.Type == part.InstrumentType);
                    foreach (var partMusician in currentPartMusicians)
                    {
                        Console.WriteLine($"{partMusician.Instrument.Name} ");
                    }
                    foreach (var note in part.Melody.Notes)
                    {
                        Console.Write(note + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Спасибо за внимание!");
                Console.WriteLine("Для вас играли:");
                foreach (var musician in Musicians)
                {
                    Console.WriteLine($"{musician.Instrument.Name} - {musician.Name}");
                }
                Console.WriteLine("Апплодисменты!");
            }
        }

        // Метод для проверки может ли оркестр сыграть композицию (есть ли в нём инструменты чтобы сыграть все партии)
        private bool CheckCanPlayComposition(MusicalComposition composition)
        {
            foreach (var part in composition.MusicalParts)
            {
                if (Musicians.All(m => m.Instrument.Type != part.InstrumentType)) return false;
            }
            return true;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return _persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}