namespace MyOrchestra.Instruments
{
    public class StringInstrument : MusicalInstrument
    {
        public readonly int StringCount;

        public override InstrumentType Type => InstrumentType.String;

        public StringInstrument(int stringCount, string name, Range range)
        {
            StringCount = stringCount;
            Name = name;
            FrequencyRange = range;
        }
    }
}