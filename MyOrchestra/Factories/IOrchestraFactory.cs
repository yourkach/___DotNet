using MyOrchestra.Orchestra;

namespace MyOrchestra.Factories
{
    public interface IOrchestraFactory
    {
        public IOrchestra create();
    }
}