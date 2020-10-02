using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProofOfEvidence
{
    class EnemyIcon
    {
        List<EnemyIcon> AllIcons = new List<EnemyIcon>();

        private string obsName;
        private int heightReach;
        private int priorityNum;
        private double hitrate;
        private string imgPath;

        public string ObsName { get => obsName; set => obsName = value; }
        public int HeightReach { get => heightReach; set => heightReach = value; }
        public int PriorityNum { get => priorityNum; set => priorityNum = value; }
        public double Hitrate { get => hitrate; set => hitrate = value; }
        public string ImgPath { get => imgPath; set => imgPath = value; }

        public EnemyIcon()
        {

        }

        public EnemyIcon(string obsName, int heightReach, int priorityNum, double hitrate, string imgPath)
        {
            this.obsName = obsName;
            this.heightReach = heightReach;
            this.priorityNum = priorityNum;
            this.hitrate = hitrate;
            this.imgPath = imgPath;
        }



        public List<EnemyIcon> GetIcons()
        {
            string connect = @"Data Source=.; Initial Catalog= MilSimDB; Integrated Security= SSPI";
            SqlConnection conn;
            SqlCommand command;
            SqlDataReader reader;

            string query = $"SELECT * FROM Obstacles";
            conn = new SqlConnection(connect);
            conn.Open();
            command = new SqlCommand(query, conn);
            List<EnemyIcon> Obstacle = new List<EnemyIcon>();
            try
            {
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    obsName = reader[0].ToString();
                    heightReach = int.Parse(reader[1].ToString());
                    priorityNum = int.Parse(reader[2].ToString());
                    hitrate = int.Parse(reader[3].ToString());
                    imgPath = @"AAGun.jpg";

                    Obstacle.Add(new EnemyIcon(obsName, heightReach, priorityNum, hitrate, imgPath));
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return Obstacle;
        }
    }
}
