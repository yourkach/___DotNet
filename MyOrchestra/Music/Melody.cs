using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace MyOrchestra.Melodies
{
    public class Melody
    {
        public Melody(IEnumerable<Note> notes, int tempoMillis)
        {
            Notes = notes.ToImmutableList();
            TempoMillis = tempoMillis;
        }

        public readonly ImmutableList<Note> Notes;

        public readonly int TempoMillis;
    }
}