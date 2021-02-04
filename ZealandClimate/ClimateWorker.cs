using System;

namespace ZealandClimate
{
    public class ClimateWorker
    {
        public ClimateWorker()
        {
        }

        public void Start()
        {
            Lokale lokale1 = new Lokale("D203", 34);
            Maaling maaling1 = new Maaling(DateTime.Today,20.4, 455,23, lokale1 );

            Console.WriteLine(maaling1);


        }
    }
}