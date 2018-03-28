using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAirBnB
{
    class Accommondation

    {
        private int Room_id;
        private int Host_id;
        private string Room_type;
        private string Borough;
        private string Neighbourhood;
        private int Reviews;
        private double Overall_satisfaction;
        private int Accomodates;
        private int Bedrooms;
        private int Price;
        private int Minstay;
        private double Latitude;
        private double Longitude;
        private string Last_modified;

        public int Room_id1 { get => Room_id; set => Room_id = value; }
        public int Host_id1 { get => Host_id; set => Host_id = value; }
        public string Room_type1 { get => Room_type; set => Room_type = value; }
        public string Borough1 { get => Borough; set => Borough = value; }
        public string Neighbourhood1 { get => Neighbourhood; set => Neighbourhood = value; }
        public int Reviews1 { get => Reviews; set => Reviews = value; }
        public double Overall_satisfaction1 { get => Overall_satisfaction; set => Overall_satisfaction = value; }
        public int Accomodates1 { get => Accomodates; set => Accomodates = value; }
        public int Bedrooms1 { get => Bedrooms; set => Bedrooms = value; }
        public int Price1 { get => Price; set => Price = value; }
        public int Minstay1 { get => Minstay; set => Minstay = value; }
        public double Latitude1 { get => Latitude; set => Latitude = value; }
        public double Longitude1 { get => Longitude; set => Longitude = value; }
        public string Last_modified1 { get => Last_modified; set => Last_modified = value; }

        //konstruktor
        public Accommondation(int Room_id, int Host_id, string Room_type, string Borough, string Neighbourhood,
        int Reviews, double Overall_satisfaction, int Accomodates, int Bedrooms, int Price, int Minstay, double Latitude,
        double Longitude, string Last_modified)

        {
            this.Room_id = Room_id;
            this.Host_id = Host_id;
            this.Room_type = Room_type;
            this.Borough = Borough;
            this.Neighbourhood = Neighbourhood;
            this.Reviews = Reviews;
            this.Overall_satisfaction = Overall_satisfaction;
            this.Accomodates = Accomodates;
            this.Bedrooms = Bedrooms;
            this.Price = Price;
            this.Minstay = Minstay;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Last_modified = Last_modified;


        }

        public Accommondation(int host_id, string room_type, string room_id, string borougt, string neighbourhood, int reviews, double overall_satisfaction, int accomodates, int bedrooms, int price, int minstay, double latitude, double longitude, string last_modified)
        {
            Host_id = host_id;
            Room_type = room_type;
            Neighbourhood = neighbourhood;
            Reviews = reviews;
            Overall_satisfaction = overall_satisfaction;
            Accomodates = accomodates;
            Bedrooms = bedrooms;
            Price = price;
            Minstay = minstay;
            Latitude = latitude;
            Longitude = longitude;
            Last_modified = last_modified;
        }

        public Accommondation(int host_id, string room_type, int room_id, string borougt, string neighbourhood, int reviews, double overall_satisfaction, int accomodates, int bedrooms, int price, int minstay, double latitude, double longitude, string last_modified)
        {
            Host_id = host_id;
            Room_type = room_type;
            Room_id = room_id;
            Neighbourhood = neighbourhood;
            Reviews = reviews;
            Overall_satisfaction = overall_satisfaction;
            Accomodates = accomodates;
            Bedrooms = bedrooms;
            Price = price;
            Minstay = minstay;
            Latitude = latitude;
            Longitude = longitude;
            Last_modified = last_modified;
        }
    }
}


