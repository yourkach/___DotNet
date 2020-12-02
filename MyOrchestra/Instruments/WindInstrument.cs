namespace MyOrchestra.Instruments
{
    public class WindInstrument : MusicalInstrument
    {
        public override InstrumentType Type => InstrumentType.Wind;

        public WindInstrument(string name, Range range)
        {
            Name = name;
            FrequencyRange = range;
        }
    }
}