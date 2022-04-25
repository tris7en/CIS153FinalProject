using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4_MainMenu
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1Player_Click(object sender, EventArgs e)
        {
            /*1Player f2 = new 1Player();
            f2.ShowDialog();*/
        }

        private void btn_2player_Click(object sender, EventArgs e)
        {
            /*2Player f2 = new 2Player();
            f2.ShowDialog();*/
        }

        private void stats_Click(object sender, EventArgs e)
        {
            /*Form1 f2 = new form1();
            f2.ShowDialog();*/
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
