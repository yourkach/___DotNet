using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace MyOrchestra.Melodies
{
    public class MusicalComposition
    {
        public MusicalComposition(string name, IEnumerable<MusicalPart> musicalParts)
        {
            Name = name;
            MusicalParts = musicalParts.ToImmutableList();
        }

        public readonly string Name;

        public readonly ImmutableList<MusicalPart> MusicalParts;
    }
}