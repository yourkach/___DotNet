namespace MyOrchestra.Instruments
{
    public readonly struct Range
    {
        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }

        public readonly int Start;
        public readonly int End;
    }
}