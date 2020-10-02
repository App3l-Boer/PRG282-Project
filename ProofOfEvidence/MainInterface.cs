using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace ProofOfEvidence
{
    public partial class MainInterface : Form
    {
        string user;

        public string User { get => user; set => user = value; }

        Planes planes = new Planes();
        EnemyIcon icons = new EnemyIcon();
        

        public MainInterface(string user)
        {
            InitializeComponent();
            this.user = user;
            lblUserDisplay.Text = user;
            
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            List<Planes> plane = planes.GetPlanes();
            List<EnemyIcon> enemies = icons.GetIcons();

            foreach (Planes instance in plane)
            {
                cbxPlanes.Items.Add(instance.PlaneModel);
            }
            foreach (EnemyIcon instance in enemies)
            {
                cbxEnemy.Items.Add(instance.ObsName);
            }
            prbFuel.Value = 100;
            prbHit.Value = 100;
            prbLoad.Value = 50;
        }

        private void MainInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            int planeID = cbxPlanes.SelectedIndex;
            pbxPlane.Image = null;
            switch (planeID)
            {
                case 1:
                    pbxPlane.Image = Properties.Resources.FighterPlane;
                    break;
                case 2:
                    pbxPlane.Image = Properties.Resources.SonicPlane;
                    break;
                case 3:
                    pbxPlane.Image = Properties.Resources.StealthPlane;
                    break;
                default:
                    break;
            }
        }

        private void btnAddObs_Click(object sender, EventArgs e)
        {
            List<EnemyIcon> enemies = icons.GetIcons();
            string enemybase = cbxEnemy.Text;
            foreach (EnemyIcon item in enemies)
            {

            }
            int basearea = Convert.ToInt32(Math.Round(numericUpDown1.Value,0));
            switch (basearea)
            {
                case 1:
                    pbxEnemy1.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy1.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy1.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy1.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy1.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy1.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy1.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy1.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy1.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy1.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy1.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    pbxEnemy2.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy2.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy2.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy2.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy2.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy2.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy2.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy2.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy2.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy2.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy2.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    pbxEnemy3.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy3.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy3.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy3.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy3.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy3.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy3.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy3.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy3.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy3.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy3.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    pbxEnemy4.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy4.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy4.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy4.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy4.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy4.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy4.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy4.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy4.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy4.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy4.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    pbxEnemy5.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy5.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy5.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy5.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy5.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy5.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy5.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy5.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy5.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy5.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy5.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    pbxEnemy6.Image = null;
                    switch (enemybase)
                    {
                        case "AA - Gun":
                            pbxEnemy6.Image = Properties.Resources.AAGun;
                            break;
                        case "Armoured Unit":
                            pbxEnemy6.Image = Properties.Resources.ArmouredUnit;
                            break;
                        case "Outpost":
                            pbxEnemy6.Image = Properties.Resources.EnemyOutpost;
                            break;
                        case "Infantry Unit":
                            pbxEnemy6.Image = Properties.Resources.InfantryUnit;
                            break;
                        case "Lookout Tower":
                            pbxEnemy6.Image = Properties.Resources.LookoutTower;
                            break;
                        case "Motor Camp":
                            pbxEnemy6.Image = Properties.Resources.MotorCamp;
                            break;
                        case "Occupied Building":
                            pbxEnemy6.Image = Properties.Resources.OccupiedBuilding;
                            break;
                        case "Officer":
                            pbxEnemy6.Image = Properties.Resources.OfficerLocation;
                            break;
                        case "Rocket Unit":
                            pbxEnemy6.Image = Properties.Resources.RocketUnit;
                            break;
                        case "Weapon Storage":
                            pbxEnemy6.Image = Properties.Resources.WeaponStorage;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}