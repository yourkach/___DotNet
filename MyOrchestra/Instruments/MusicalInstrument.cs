namespace MyOrchestra.Instruments
{
    // Базовый класс для музыкального инструмента
    public abstract class MusicalInstrument
    {
        // Название инструмента
        public string Name { get; protected set; }

        // Частотный диапазон инструмента
        public Range FrequencyRange { get; protected set; }
        
        // Тип музыкального инструмента
        public abstract InstrumentType Type { get; }
    }
}