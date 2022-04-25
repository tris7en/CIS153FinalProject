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
    public partial class Form1 : Form
    {
       
        List<PlayerStats> Stats = new List<PlayerStats>();
        Main_Menu formstats;
        public Form1()
        {
            InitializeComponent();
            readTextFile();
            //string x;
            //string y;
            //y = Stats[0].getComWins();
            //x = Stats[1].getComWins();
            //Int16.Parse(y);
            //Int16.Parse(x);
            //int z = Int16.Parse(y) + Int16.Parse(x);
            //Console.WriteLine(z);

            gameStatistics();
        }

        public Form1(Main_Menu stats1)
        {
            InitializeComponent();
            formstats = stats1;
        }

        public void formPassedToMe(Main_Menu stats1)
        {
            formstats = stats1;
        }

        public void readTextFile()
        {         
            string fileContent = "";
            int count = 0;
            string comWins = "";
            string playerWins = "";
            string numTies = "";
            string numGames = "";
           

            try
            {
                fileContent = CIS153_GitHubExample.Properties.Resources.TextFile1;
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading File: " + e.Message);
            }
            //split all of the information from the file based off commas
            String[] words = fileContent.Split(',');


            foreach (String word in words)
            {
                if (count == 0)
                {                    
                    comWins = word;
                    count++;
                }
                else if (count == 1)
                {

                    playerWins = word;
                    
                    //delete the newline character
                    playerWins.Replace(System.Environment.NewLine, " ");
                    count++;
                }
                else if (count == 2)
                {                   
                    numTies = word;                   
                    numTies.Replace(System.Environment.NewLine, " ");
                    count++;
                }
                else if (count == 3)
                {
                    numGames = word;                   
                    numGames.Replace(System.Environment.NewLine, " ");
                    count++;
                    count = 0;
                    Stats.Add(new PlayerStats(comWins, playerWins, numTies, numGames));
                   
                }
            }
        }

        public void gameStatistics()
        {
            float comWins = 0;
            float playerWins = 0;
            int numTies = 0;
            float numGames = 0;
            float winPerPlayer = 0;
            float winPerCom = 0;

            for (int i = 0; i < Stats.Count(); i++)
            {
                string p = Stats[i].getComWins();

                comWins = comWins + Int16.Parse(p);
            }

            for (int i = 0; i < Stats.Count(); i++)
            {
                string p = Stats[i].getPlayerWins();

                playerWins = playerWins + Int16.Parse(p);
            }

            for (int i = 0; i < Stats.Count(); i++)
            {
                string p = Stats[i].getNumTies();

                numTies = numTies + Int16.Parse(p);
            }

            for (int i = 0; i < Stats.Count(); i++)
            {
                string p = Stats[i].getNumGames();

                numGames = numGames + Int16.Parse(p);
            }

            winPerPlayer = playerWins / numGames;
            winPerCom = comWins / numGames;

            listBox1.Items.Add("Player Wins :");
            listBox1.Items.Add(playerWins);
            listBox1.Items.Add("Computer Wins : ");
            listBox1.Items.Add(comWins);
            listBox1.Items.Add("Total Number of Ties: ");
            listBox1.Items.Add(numTies);
            listBox1.Items.Add("Total Games Played : ");
            listBox1.Items.Add(numGames);
            listBox1.Items.Add("Player Win Percentage: ");
            listBox1.Items.Add(winPerPlayer);
            listBox1.Items.Add("Computer Win Percentage: ");
            listBox1.Items.Add(winPerCom);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
