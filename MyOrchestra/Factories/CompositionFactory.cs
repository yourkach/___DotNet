using System.Collections.Generic;
using MyOrchestra.Instruments;
using MyOrchestra.Melodies;

namespace MyOrchestra.Factories
{
    class CompositionFactory : ICompositionFactory
    {
        public MusicalComposition create()
        {
            var musicalParts = new[]
            {
                new MusicalPart(
                    new Melody(new[] {Note.Do, Note.Fa, Note.La, Note.Mi, Note.Mi, Note.Si, Note.Sol, Note.Mi}, 120),
                    InstrumentType.String
                ),
                new MusicalPart(
                    new Melody(new[] {Note.Re, Note.Fa, Note.La, Note.Mi, Note.Mi, Note.Re, Note.Re, Note.Do}, 120),
                    InstrumentType.Percussion
                ),
                new MusicalPart(
                    new Melody(new[] {Note.La, Note.La, Note.La, Note.Mi, Note.Mi, Note.Sol, Note.Sol, Note.La}, 120),
                    InstrumentType.Wind
                )
            };
            
            var name = "Симфония \"Воспоминания о юности №8\"";
            
            return new MusicalComposition(name, musicalParts);
        }
    }
}