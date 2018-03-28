using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAirBnB
{
    class Country
    {
        private string name; // private so we cannot change info
        private int antalInvanare;
        private int bnp;
        private List<City> cities;

        public string Name { get => name; set => name = value; } //Get/set method
        public int AntalInvanare { get => antalInvanare; set => antalInvanare = value; }
        public int Bnp { get => bnp; set => bnp = value; }
        public List<City> Cities { get => cities; set => cities = value; }

        public Country(string name, int antalInvanare, int bnp) // construktor
        {
            this.name = name;
            this.antalInvanare = antalInvanare;
            this.bnp = bnp;

        }


    }
}

