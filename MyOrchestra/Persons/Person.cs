namespace MyOrchestra.Persons
{
    public abstract class Person
    {
        public string Name { get; protected set; }

        public GenderType Gender { get; protected set; }

    }

    public enum GenderType {
        Male, Female
    }
    
}