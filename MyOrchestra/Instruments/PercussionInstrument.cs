namespace MyOrchestra.Instruments
{
    public class PercussionInstrument : MusicalInstrument
    {
        public override InstrumentType Type => InstrumentType.Percussion;

        public PercussionInstrument(string name, Range range)
        {
            Name = name;
            FrequencyRange = range;
        }
    }
}