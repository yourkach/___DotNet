using System.Collections.Generic;
using MyOrchestra.Instruments;
using MyOrchestra.Orchestra;
using MyOrchestra.Persons;

namespace MyOrchestra.Factories
{
    // Фабрика, создающая оркестр
    public class OrchestraFactory : IFactory<IOrchestra>
    {
        public IOrchestra create()
        {
            var musicians = new List<Musician>
            {
                new Musician(
                    new StringInstrument(6, "Гитара", new Range(20, 15000)),
                    "Алексей Гладков", GenderType.Male
                ),
                new Musician(
                    new StringInstrument(3, "Скрипка тенор", new Range(14000, 18000)),
                    "Дарья Ковалёва", GenderType.Female
                ),
                new Musician(
                    new WindInstrument("Саксофон", new Range(5000, 12000)),
                    "Николай Александров", GenderType.Male
                ),
                new Musician(
                    new PercussionInstrument("Тарелка", new Range(15000, 20000)),
                    "Петр Авокадо", GenderType.Male
                ),
                new Musician(
                    new PercussionInstrument("Барабун", new Range(40, 2000)),
                    "Анастасия Бабабой", GenderType.Female
                ),
                new Musician(
                    new StringInstrument(4, "Скрипка", new Range(8000, 18000)),
                    "Иван Богдан", GenderType.Male
                ),
                new Musician(
                    new WindInstrument("Труба", new Range(2000, 8000)),
                    "Алионио Фапс", GenderType.Male
                ),
                new Musician(
                    new PercussionInstrument("Бочка басс", new Range(40, 2000)),
                    "Аполлинария Волкодавова", GenderType.Female
                )
            };
            var conductor = new Conductor("Вячеслав Жанно", GenderType.Male);

            return new Orchestra.Orchestra(musicians, conductor);
        }
    }
}