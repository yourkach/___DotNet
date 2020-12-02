using MyOrchestra.Instruments;

namespace MyOrchestra.Persons
{
    public class Musician : Person
    {
        public readonly MusicalInstrument Instrument;

        public Musician(MusicalInstrument instrument, string name, GenderType gender)
        {
            Instrument = instrument;
            Name = name;
            Gender = gender;
        }
    }
}