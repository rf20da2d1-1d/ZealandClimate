using System;
using System.Collections.Generic;

namespace DataStrukturer
{
    public class ADTWorker
    {
        public ADTWorker()
        {
        }

        public void DoArray()
        {
            // Erlæring
            Person[] personer;
            int næsteFriePlads = 0;

            // Initialisering
            personer = new Person[23];

            // Indsætte værdier 
            personer[næsteFriePlads] = new Person(3, "peter");
            næsteFriePlads++;
            personer[næsteFriePlads++] = new Person(4, "jakob");

            // Hente værdier
            Person p = personer[0]; // den første i arrayet

            // Udskrive værdier
            foreach (Person person in personer)
            {
                Console.WriteLine(person); // udskriver alle 23 pladser
            }

            for (int i = 0; i < næsteFriePlads; i++)
            {
                Console.WriteLine(personer[i]); // udskriver kun de pladser hvor der er noget
            }
        }

        public void DoList()
        {
            // Erlæring
            List<Person> personer;

            // Initialisering
            personer = new List<Person>();

            // Indsætte værdier 
            personer.Add(new Person(3, "peter"));
            personer.Add(new Person(4, "jakob"));


            // Hente værdier
            Person p = personer[0]; // første i listen


            // Udskrive værdier
            foreach (var person in personer)
            {
                Console.WriteLine(person);
            }

        }

        public void DoDictionary()
        {
            // Erlæring
            Dictionary<int, Person> personer;

            // Initialisering
            personer = new Dictionary<int, Person>();

            // Indsætte værdier 
            personer.Add(3, new Person(3, "peter"));
            personer.Add(4, new Person(4, "jakob"));


            // Hente værdier
            // kender id 
            Person p = personer[3]; // person med id = 3


            // Udskrive værdier
            foreach (var person in personer.Values)
            {
                Console.WriteLine(person);
            }

        }
    }
}