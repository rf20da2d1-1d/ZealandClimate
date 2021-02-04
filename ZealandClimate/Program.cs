using System;

namespace ZealandClimate
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateWorker worker = new ClimateWorker();
            worker.Start();


            Console.ReadLine();
        }
    }
}
