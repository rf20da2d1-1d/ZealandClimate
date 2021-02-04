using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    public class Maaling
    {
        // klasse felt
        private static int nextId = 0; // til at automatisk tælle og initialisere id'er'

        // instans felter - attributter
        private int _id;
        private DateTime _dateTime;
        private double _temp;
        private int _co2;
        private int _antalPersoner;

        // associering til lokale
        private Lokale _lokale;

        // properties
        public int Id
        {
            get => _id;
        }

        public DateTime DateTime
        {
            get => _dateTime;
            set => _dateTime = value;
        }

        public double Temp
        {
            get => _temp;
            set
            {
                if (value < 0 || 35 < value)
                {
                    throw new ArgumentOutOfRangeException("Temperaturen bør være mellem 0 og 35 men var " + value);
                }

                _temp = value;
            }
        }

        public int Co2
        {
            get => _co2;
            set => _co2 = value;
        }

        public int AntalPersoner
        {
            get => _antalPersoner;
            set => _antalPersoner = value;
        }

        public Lokale Lokale
        {
            get => _lokale;
            set => _lokale = value;
        }

        public Maaling(DateTime dateTime, double temp, int co2, int antalPersoner, Lokale lokale)
        {
            _id = ++nextId; // tæller klasse variablen 1 op og bagefter tildeler til Id, dvs første værdi er 0+1 = 1
            _dateTime = dateTime;
            _temp = temp;
            _co2 = co2;
            _antalPersoner = antalPersoner;
            _lokale = lokale;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(DateTime)}: {DateTime}, {nameof(Temp)}: {Temp}, {nameof(Co2)}: {Co2}, {nameof(AntalPersoner)}: {AntalPersoner}, {nameof(Lokale)}: {Lokale}";
        }
    }
}
