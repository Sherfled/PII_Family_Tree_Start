using System;

namespace Library
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { set; get; }
        public int Age { set; get; }
    }
}