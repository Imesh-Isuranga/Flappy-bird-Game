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
    public partial class Main : Form
    {
        string str = "";
        string clr = "Blue";
        int soundValue = 10;
        public Main(string str, int soundValue,string clr)
        {
            InitializeComponent();
            this.str = str;
            this.soundValue = soundValue;
            this.clr = clr;
            if (clr.Equals("Blue"))
            {
                this.BackColor = Color.DodgerBlue;
            }
            else if (clr.Equals("Green"))
            {
                this.BackColor = Color.Green;
            }
            else if (clr.Equals("Red"))
            {
                this.BackColor = Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(str,soundValue,clr).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Settings().Show();
        }
    }
}
