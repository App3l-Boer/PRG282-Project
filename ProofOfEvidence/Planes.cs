using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProofOfEvidence
{
    class Planes
    {
        List<Planes> AllPlanes = new List<Planes>();
        private string planeModel;
        private string callsign;
        private double fuelcapacity;
        private int planeweight;
        private int inventoryweight;
        private int maxaltitude;
        private int maxspeed;
        private string imgname;

        public Planes()
        {

        }

        public Planes(string planeModel, string callsign, double fuelcapacity, int planeweight, int inventoryweight, int maxaltitude, int maxspeed, string imgname)
        {
            this.planeModel = planeModel;
            this.callsign = callsign;
            this.fuelcapacity = fuelcapacity;
            this.planeweight = planeweight;
            this.inventoryweight = inventoryweight;
            this.maxaltitude = maxaltitude;
            this.maxspeed = maxspeed;
            this.imgname = imgname;
        }

        public string PlaneModel { get => planeModel; set => planeModel = value; }
        public string Callsign { get => callsign; set => callsign = value; }
        public double Fuelcapacity { get => fuelcapacity; set => fuelcapacity = value; }
        public int Planeweight { get => planeweight; set => planeweight = value; }
        public int Inventoryweight { get => inventoryweight; set => inventoryweight = value; }
        public int Maxaltitude { get => maxaltitude; set => maxaltitude = value; }
        public int Maxspeed { get => maxspeed; set => maxspeed = value; }
        public string Imgname { get => imgname; set => imgname = value; }



        public List<Planes> GetPlanes()
        {
            string connect = @"Data Source=.; Initial Catalog= MilSimDB; Integrated Security= SSPI";
            SqlConnection conn;
            SqlCommand command;
            SqlDataReader reader;

            AllPlanes.Add(new Planes("Rafale", "FTH513", 16500, 10100, 8000, 16000, 1400, "FighterPlane.jpg"));
            AllPlanes.Add(new Planes("Blackbird", "TXP798", 45000, 31000, 20000, 26000, 3600, "SonicPlane.jpg"));
            AllPlanes.Add(new Planes("LightningII", "WTF850", 10300, 13500, 8000, 15000, 13000, "StealthPlane.jpg"));
            return AllPlanes;


            string query = $"SELECT * FROM Planes";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);
            List<Planes> planes = new List<Planes>();
            try
            {
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PlaneModel = reader[0].ToString();
                    Callsign = reader[1].ToString();
                    Fuelcapacity = int.Parse(reader[3].ToString());
                    Planeweight = int.Parse(reader[4].ToString());
                    Inventoryweight = int.Parse(reader[5].ToString());
                    Maxspeed = int.Parse(reader[6].ToString());
                    Maxaltitude = int.Parse(reader[4].ToString());
                    Imgname = reader[8].ToString();

                    planes.Add(new Planes(PlaneModel, Callsign, Fuelcapacity, Planeweight, Inventoryweight, Maxaltitude, Maxspeed, Imgname));
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return planes;
        }

    }
}
