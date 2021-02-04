using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    public class MaalingsRegister
    {
        // aggregering 
        private readonly Dictionary<int, Maaling> maalinger;

        public MaalingsRegister()
        {
            maalinger = new Dictionary<int, Maaling>();
        }

        public void OpretMaaling(double temp, int co2, int antalPersoner, Lokale lokale)
        {
            Maaling maaling = new Maaling(DateTime.Today, temp, co2, antalPersoner, lokale);
            maalinger.Add(maaling.Id, maaling);
        }

        public Maaling HentMåling(int id)
        {
            if (maalinger.ContainsKey(id))
            {
                return maalinger[id];
            }

            throw new KeyNotFoundException("Ingen måling med id = " + id);
        }

        public void PrintAlleMålinger()
        {
            foreach (Maaling maaling in maalinger.Values)
            {
                Console.WriteLine(maaling);
            }
        }

        public int AntalUlovligeCO2Målinger()
        {
            int antal = 0;
            foreach (Maaling maaling in maalinger.Values)
            {
                if (maaling.Co2 > 1000)
                {
                    antal++;
                }
            }

            return antal;

        }

        public List<Maaling> AlleTempUnderOver(int min, int max)
        {
            List<Maaling> maalingerUdenFor = new List<Maaling>();

            foreach (Maaling maaling in maalinger.Values)
            {
                if (maaling.Temp < min || max < maaling.Temp)
                {
                    maalingerUdenFor.Add(maaling);
                }
            }

            return maalingerUdenFor;
        }


    }
}
