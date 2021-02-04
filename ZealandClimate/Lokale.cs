using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    public class Lokale
    {
        // klasse felt
        private static int nextId = 0; // til at automatisk tælle og initialisere id'er'

        // instans felter - attributter
        private int _id;
        private String _lokaleNummer;
        private int _maxAntalPersoner;

        // properties
        public int Id
        {
            get => _id;
            // ingen set kan IKKE tildeles nye værdier
        }

        public string LokaleNummer
        {
            get => _lokaleNummer;
            set => _lokaleNummer = value;
        }

        public int MaxAntalPersoner
        {
            get => _maxAntalPersoner;
            set => _maxAntalPersoner = value;
        }

        public Lokale(string lokaleNummer, int maxAntalPersoner)
        {
            _id = ++nextId; // tæller klasse variablen 1 op og bagefter tildeler til Id, dvs første værdi er 0+1 = 1
            _lokaleNummer = lokaleNummer;
            _maxAntalPersoner = maxAntalPersoner;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(LokaleNummer)}: {LokaleNummer}, {nameof(MaxAntalPersoner)}: {MaxAntalPersoner}";
        }
    }
}
