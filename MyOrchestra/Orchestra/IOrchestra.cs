using System.Collections.Generic;
using System.Collections.Immutable;
using MyOrchestra.Melodies;
using MyOrchestra.Persons;

namespace MyOrchestra.Orchestra
{
    // Интерфейс оркестра наследует интерфейс перечисляемого для типа Person
    public interface IOrchestra : IEnumerable<Person>
    {
        ImmutableList<Musician> Musicians { get; }

        Conductor Conductor { get; }

        void PlayComposition(MusicalComposition composition);
    }
}