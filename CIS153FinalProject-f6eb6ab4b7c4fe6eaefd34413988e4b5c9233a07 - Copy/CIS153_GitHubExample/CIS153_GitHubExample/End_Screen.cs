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
    public partial class End_Screen : Form
    {
        Form2 formend;
        public End_Screen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public End_Screen(Form2 EndScreen2)
        {
            InitializeComponent();
            formend = EndScreen2;
        }

        public void formPassedToMe(Form2 EndScreen2)
        {
            formend = EndScreen2;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
