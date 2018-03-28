using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataAirBnB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  

            City[] stader = new City[] // listan med städer
            {
                new City("Amsterdam2",0,0,0,0,0), //skapar city objekt
                new City("Barcelona2",0,0,0,0,0),
                new City("Boston2",0,0,0,0,0),
                };

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-OBD0K6JL;Initial Catalog=airbnbtest;Integrated Security=True";

            for (int i = 0; i < stader.Length; i++) // hämtar 3 tabbeler från SQL
            {

                    conn.Open();

                    SqlCommand myQuery = new SqlCommand("SELECT * FROM " + stader[i].Namn, conn); //same name as in Boston2 i SQL
                    SqlDataReader myReader = myQuery.ExecuteReader();

                    while (myReader.Read()) // sätter in rätt objekt

                    {

                        int host_id = (int)myReader["host_id"];  // Reading all variables from database.
                        string room_type = (string)myReader["room_type"].ToString();
                        int room_id = (int)myReader["room_id"];
                        string borough; //= (string)myReader["borough"];

                        if (myReader["borough"] is String)
                        {

                            borough = (string)myReader["borough"];
                        }

                        else

                        {

                            borough = "";
                        }

                        string neighborhood = (string)myReader["neighborhood"];
                        int reviews = (int)myReader["Reviews"];

                        string var1 = (string)myReader["Overall_satisfaction"];
                        double Overall_satisfaction;
                        double.TryParse(var1, out Overall_satisfaction); //Overall_satisfaction får värdet som skickas ut i out
                        int accomodates = (int)myReader["accommodates"];

                        var1 = (string)myReader["Bedrooms"];
                        double d_bedrooms;
                        double.TryParse(var1, out d_bedrooms);
                        int bedrooms = (int)Math.Round(d_bedrooms);

                        var1 = (string)myReader["Price"];
                        double d_price;
                        double.TryParse(var1, out d_price);
                        int price = (int)Math.Round(d_price);

                        var1 = myReader["minstay"].ToString();
                        double m_minstay;
                        double.TryParse(var1, out m_minstay);
                        int minstay = (int)Math.Round(m_minstay);

                        var1 = (string)myReader["latitude"];
                        double l_latitude;
                        double.TryParse(var1, out l_latitude);
                        int latitude = (int)Math.Round(l_latitude);

                        var1 = (string)myReader["Longitude"];
                        double l_longitude;
                        double.TryParse(var1, out l_longitude);
                        int longitude = (int)Math.Round(l_longitude);

                        string last_modified = (string)myReader["last_modified"].ToString();

                        Accommondation getAccommondation = new Accommondation(room_id, host_id, room_type, borough, neighborhood, reviews, Overall_satisfaction,
                        accomodates, bedrooms, price, minstay, latitude, longitude, last_modified);
                        stader[i].addAccomm(getAccommondation);

                    }
                    conn.Close(); // hämtat och sparad, behöver inte ha det öppet

            }

            chart7.Titles.Add("Barcelona price");
            chart7.ChartAreas[0].AxisX.Title = "Room";
            chart7.ChartAreas[0].AxisY.Title = "Price";

            chart8.Titles.Add("Amsterdam price");
            chart8.ChartAreas[0].AxisX.Title = "Room";
            chart8.ChartAreas[0].AxisY.Title = "Price";

            chart3.Titles.Add("Boston price");
            chart3.ChartAreas[0].AxisX.Title = "Room";
            chart3.ChartAreas[0].AxisY.Title = "Price";

            chart4.Titles.Add("Barcelona price/overall satisfaction");
            chart4.ChartAreas[0].AxisX.Title = "Price";
            chart4.ChartAreas[0].AxisY.Title = "Overall Satisfation";

            chart5.Titles.Add("Amsterdam price/overall satisfaction");
            chart5.ChartAreas[0].AxisX.Title = "Price";
            chart5.ChartAreas[0].AxisY.Title = "Overall Satisfation";

            chart6.Titles.Add("Boston price/overall satisfaction");
            chart6.ChartAreas[0].AxisX.Title = "Price";
            chart6.ChartAreas[0].AxisY.Title = "Overall Satisfation";


            //Histogram 1,2 och 3
            foreach (Accommondation a in stader[0].AccomList.Where(x => x.Room_type1 == "Private room")) //hämta data från objekt till graf
            {
                chart7.Series["Series1"].Points.AddY(a.Price1); // lägger till varje datapoint
            }


            chart7.Series["Series1"].ChartType = SeriesChartType.Column;


            foreach (Accommondation a in stader[1].AccomList.Where (x => x.Room_type1 == "Private room"))
            {
                chart8.Series["Series1"].Points.AddY(a.Price1);
            }

            chart8.Series["Series1"].ChartType = SeriesChartType.Column;

            foreach (Accommondation a in stader[2].AccomList.Where(x => x.Room_type1 == "Private room"))
            {
                chart3.Series["Series1"].Points.AddY(a.Price1);
            }

            chart3.Series["Series1"].ChartType = SeriesChartType.Column;

            //Scatterplott 1,2 och 3 
            foreach (Accommondation a in stader[0].AccomList.Where(x => x.Overall_satisfaction1 != 0 && x.Overall_satisfaction1 < 4.5))
            {
                chart4.Series["Series1"].Points.AddXY(a.Price1, a.Overall_satisfaction1);
            }

            chart4.Series["Series1"].ChartType = SeriesChartType.Point;

            foreach (Accommondation a in stader[1].AccomList.Where(x => x.Overall_satisfaction1 != 0 && x.Overall_satisfaction1 < 4.5))
            {
                chart5.Series["Series1"].Points.AddXY(a.Price1, a.Overall_satisfaction1);
            }

            chart5.Series["Series1"].ChartType = SeriesChartType.Point;

            foreach (Accommondation a in stader[2].AccomList.Where (x => x.Overall_satisfaction1 != 0 && x.Overall_satisfaction1 < 4.5))
            {
                chart6.Series["Series1"].Points.AddXY(a.Price1, a.Overall_satisfaction1);
            }

            chart6.Series["Series1"].ChartType = SeriesChartType.Point;



        }
    }

      
}
