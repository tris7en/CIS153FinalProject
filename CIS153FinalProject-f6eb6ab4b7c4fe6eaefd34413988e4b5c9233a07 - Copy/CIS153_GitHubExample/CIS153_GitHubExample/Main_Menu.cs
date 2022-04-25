using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_GitHubExample
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btn_1Player_Click(object sender, EventArgs e)
        {
            //Form 1Player = new Form...();
            //1Player.Show();

        }

        private void btn_2player_Click(object sender, EventArgs e)
        {
            //Form 2Player = new Form....();
            //2Player.Show();
        }

        private void stats_Click(object sender, EventArgs e)
        {
            loadStats();
        }

        public void loadStats()
        {
            Form1 formToLoad1 = new Form1(this);

            Form1 formToLoadNoOverload1 = new Form1();

            formToLoadNoOverload1.formPassedToMe(this);

            formToLoad1.Show();

            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
