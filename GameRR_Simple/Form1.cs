using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameRR_Simple
{
    public partial class Form1 : Form
    {
        Game Gameobj = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {   
            //This method  is using for loading the bullets
            pictureBox1.Image = GameRR_Simple.Resource1.load;
            SoundPlayer sc = new SoundPlayer(GameRR_Simple.Resource1.loadG);
            sc.Play();
            Spin.Enabled = true;

            //run the function from the object of the class Shooting to run the logic of shooting
            Gameobj.LoadingFunc();
        }
        

        private void Spin_Click(object sender, EventArgs e)
        {  // Spin the revolver
            Spin.Enabled = true;
            pictureBox1.Image = GameRR_Simple.Resource1.spin;
            SoundPlayer sc = new SoundPlayer(GameRR_Simple.Resource1.Trriger);
            sc.Play();
            Gameobj.SpinFunc();//Calling the spin function to act
            ShootAt.Enabled = true;
            ShootHd.Enabled = true;
        }

        private void ShootAt_Click(object sender, EventArgs e)
        {
           // SpinBtn.Enabled = true;
            pictureBox1.Image = GameRR_Simple.Resource1.try_again;
            SoundPlayer sc = new SoundPlayer(GameRR_Simple.Resource1.Reload);
            sc.Play();
            int chances = Gameobj.ShootingAtHead();//calling the shootingAwayFunc
        }

        private void ShootHd_Click(object sender, EventArgs e)
        {
           Spin.Enabled = true;
            pictureBox1.Image = GameRR_Simple.Resource1.shot;
            SoundPlayer sc = new SoundPlayer(GameRR_Simple.Resource1.ShotGu);
            sc.Play();
            int chancesAway = Gameobj.ShootingAwayFunc();//calling the ShootingAwayFunc2 
        }

        private void PLyAgn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
