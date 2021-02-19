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
            Person p3 = new Person(5, "Charlotte");
            personer.Add(p3);
            personer.Add(p3);
            //personer.Insert(2, p3);


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



        public void DoLinkedList()
        {
            // Erlæring
            LinkedList<Person> personer;

            // Initialisering
            personer = new LinkedList<Person>();

            // Indsætte værdier 
            Person p1 = new Person(2, "Peter");
            personer.AddFirst(p1);
            personer.AddLast(new Person(3, "Jakob"));
            personer.AddFirst(new Person(5, "Charlotte"));


            // Hente værdier
            // kender id 
            Person p = personer.First.Value;

            // Udskrive værdier
            foreach (Person person in personer)
            {
                Console.WriteLine(person);
            }

        }


        public void DoQueue()
        {
            // Erlæring
            Queue<Person> personer;

            // Initialisering
            personer  = new Queue<Person>();

            // Indsætte værdier 
            personer.Enqueue(new Person(2, "Peter"));
            personer.Enqueue(new Person(3, "Jakob"));
            personer.Enqueue(new Person(5, "Charlotte"));

            // Hente værdier
            // kender id 
            // kan ikke kigge ind i køeen vi kan se den første
            Person p1 = personer.Peek();


            // tage ud
            Person p2 = personer.Dequeue();

            // Udskrive værdier
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }

        }

        public void DoStack()
        {
            // Erlæring
            Stack<Person> personer;

            // Initialisering
            personer = new Stack<Person>();

            // Indsætte værdier 
            personer.Push(new Person(2, "Peter"));
            personer.Push(new Person(3, "Jakob"));
            personer.Push(new Person(4, "Charlotte"));

            // Hente værdier
            // kender id 
            // kan ikke kigge ind i stakken vi kan se den første
            Person p1 = personer.Peek(); // chatlotte men bliver i stakken


            // Udskrive værdier
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }

            Person p2 = personer.Pop(); // charlotte men tages ud af stak
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }




        }

        public void DoHashSet()
        {
            // Erlæring
            HashSet<Person> personer;

            // Initialisering
            personer = new HashSet<Person>();

            // Indsætte værdier 
            personer.Add(new Person(3, "peter"));
            personer.Add(new Person(4, "jakob"));
            Person p3 = new Person(5, "Charlotte");
            personer.Add(p3);
            personer.Add(p3);
            personer.Add(new Person(5, "Charlotte"));
            
            // Hente værdier
            // kender id 
            Person pout;
            bool found = personer.TryGetValue(p3, out pout);

            Console.WriteLine("Pout = " + pout);


            // Udskrive værdier
            foreach (Person p in personer)
            {
                Console.WriteLine(p);
            }

        }
    }
}