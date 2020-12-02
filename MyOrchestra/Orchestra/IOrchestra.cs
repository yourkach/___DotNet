using System.Collections.Generic;
using System.Collections.Immutable;
using MyOrchestra.Melodies;
using MyOrchestra.Persons;

namespace MyOrchestra.Orchestra
{
    public interface IOrchestra
    {
        ImmutableList<Musician> Musicians { get; }

        Conductor Conductor { get; }

        void PlayComposition(MusicalComposition composition);
    }
}