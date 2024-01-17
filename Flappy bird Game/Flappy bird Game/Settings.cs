using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird_Game
{
    public partial class Settings : Form
    {
        string str = "";
        int soundValue = 100;
        string clr = "Blue";
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main(str,soundValue, clr).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundValue = trackBar1.Value;
            str = comboBox1.SelectedItem.ToString();
            clr = comboBox2.SelectedItem.ToString();
            if (clr.Equals("Blue")){
                this.BackColor = Color.DodgerBlue;
            } else if (clr.Equals("Green")){
                this.BackColor = Color.Green;
            }else if(clr.Equals("Red")){
                this.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
