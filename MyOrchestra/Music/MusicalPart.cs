using MyOrchestra.Instruments;

namespace MyOrchestra.Melodies
{
    public class MusicalPart
    {
        public readonly Melody Melody;

        public readonly InstrumentType InstrumentType;
        
        public MusicalPart(Melody melody, InstrumentType instrumentType)
        {
            Melody = melody;
            InstrumentType = instrumentType;
        }
    }
}