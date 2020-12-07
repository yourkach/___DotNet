using System;
using MyOrchestra.Orchestra;
using MyOrchestra.Persons;

namespace MyOrchestra.Factories
{
    // базовый класс фабрики, тип объявлен ковариантным
    public interface IFactory<out T>
    {
        public T create();
    }
}