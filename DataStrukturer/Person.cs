using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrukturer
{
    public class Person
    {
        private int _id;
        private string _name;

        public Person()
        {
        }

        public Person(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}
