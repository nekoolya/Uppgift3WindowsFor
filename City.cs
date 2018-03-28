using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAirBnB
{
    class City
    {
        private string namn;
        private int population;
        private int avgIncome;
        private int numTourists;
        private int antalAccommondations; // Ska skapas och synkronisera med objektlistan med accommodations!
        private List<Accommondation> accomList = new List<Accommondation>();

        public string Namn { get => namn; set => namn = value; }
        public int Population { get => population; set => population = value; }
        public int AvgIncome { get => avgIncome; set => avgIncome = value; }
        public int NumTourists { get => numTourists; set => numTourists = value; }
        public int AntalAccommondations { get => antalAccommondations; set => antalAccommondations = value; }
        public List<City> cities { get; internal set; }
        public List<Accommondation> AccomList { get => accomList; set => accomList = value; }

        //konstruktor
        public City(string namn, int population, int avgIncome, int numTourists, int antalAccommondations, int v) // var från klass = var från objekt

        {
            this.namn = namn;
            this.population = population;
            this.avgIncome = avgIncome;
            this.numTourists = numTourists;
            this.antalAccommondations = antalAccommondations;
            createAccommList();

        }

        private void createAccommList()

        {
            accomList = new List<Accommondation>();
            //accomList.Add(new Accommondation(0, 0, "", "", "", 0, 0.0, 0, 0, 0, 0, 0.0, 0.0, ""));


        }

        public void addAccomm(Accommondation stad)
        {
            accomList.Add(stad);

        }

    }
}
