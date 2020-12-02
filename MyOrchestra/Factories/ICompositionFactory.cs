using MyOrchestra.Melodies;

namespace MyOrchestra.Factories
{
    public interface ICompositionFactory
    {
        public MusicalComposition create();
    }
}