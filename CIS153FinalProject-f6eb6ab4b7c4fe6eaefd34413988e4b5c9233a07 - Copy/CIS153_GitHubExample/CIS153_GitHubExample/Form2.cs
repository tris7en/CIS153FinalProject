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

    List<PlayerStats> Stats = new List<PlayerStats>();
    
    public partial class Form2 : Form
    {
        //ai game == 1 player mode 
        public static bool aiGame = false;

        public static bool gameOver = false;

        public static bool turn = true; // true = red turn, false = blue turn
        public int turn_count = 0;


        private Board gameBoard;

        // overloaded constructor method to load new forms 
        Form mainForm;

        public Form2(Form f1)
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //Need to set global varible equal to the form that was passed

            //so I have a reference to it in the button click
            mainForm = f1;

            gameBoard = new Board();

            setUpGame();

        }


        // ====================================
        // f u n c t i o n s 
        // ====================================


        // when game ends function 
        // gets turn bool to congratulate a winner
        // This form will say who won, show the players statistics against the computer, have an action to play again,
        // have an action to review the game, and have an action to exit.  
        public void whenGameEnds(bool turn)
        {

            // show winner form 
            //      - send winner form 
            // disable buttons w/ disableForm();

            
            loadEndScreen2();

            
        }

        public void loadEndScreen2()            // opens the game end screen
        {
             End_Screen formToLoad3 = new End_Screen(this);

             End_Screen formToLoadNoOverload3 = new End_Screen();

             formToLoadNoOverload3.formPassedToMe(this);

             formToLoad3.Show();

             this.Hide();
        }


        private static bool checkForBlueWin(Board gameBoard)
        {

            // horizontal Blue
            for (int x = 0; x <= 5; x++)
            {

                int count = 0;

                for (int y = 0; y <= 6; y++)
                {

                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                }

                // breaking loop if count = 4 
                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            // vertical Blue
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {
                        count++;
                    }

                    else
                    {
                        count = 0;
                    }

                }

                // breaking loop if count = 4 
                if (count == 4)
                {
                    return gameOver = true;
                }

            }


            // up and left

            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() >= 3 && gameBoard.getCell(x, y).getCol() >= 3)
                        {

                            count++;
                            // second surrounding found

                            if (gameBoard.getCell(x - 1, y - 1).getButton().BackColor == Color.Blue)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x - 2, y - 2).getButton().BackColor == Color.Blue)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x - 3, y - 3).getButton().BackColor == Color.Blue)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }


                            }

                            else
                            {
                                count = 0;


                            }



                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            //down and right
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {

                        count++;

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() <= 2 && gameBoard.getCell(x, y).getCol() <= 3)
                        {

                            // second surrounding found 
                            if (gameBoard.getCell(x + 1, y + 1).getButton().BackColor == Color.Blue)
                            {
                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x + 2, y + 2).getButton().BackColor == Color.Blue)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x + 3, y + 3).getButton().BackColor == Color.Blue)
                                    {
                                        count++;
                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }
                            }

                        }

                        else
                        {
                            count = 0;
                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }



            // down and left 
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {

                        count++;

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() >= 3 && gameBoard.getCell(x, y).getCol() <= 3)
                        {

                            // down and left 
                            // second surrounding found
                            if (gameBoard.getCell(x - 1, y + 1).getButton().BackColor == Color.Blue)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x - 2, y + 2).getButton().BackColor == Color.Blue)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x - 3, y + 3).getButton().BackColor == Color.Blue)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }

                            }

                            else
                            {
                                count = 0;
                            }

                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }







            // up and right 
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                    {

                        count++;


                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() <= 2 && gameBoard.getCell(x, y).getCol() >= 3)
                        {

                            //up and right 
                            // second surrounding found 
                            if (gameBoard.getCell(x + 1, y - 1).getButton().BackColor == Color.Blue)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x + 2, y - 2).getButton().BackColor == Color.Blue)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x + 3, y - 3).getButton().BackColor == Color.Blue)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }


                            }

                            else
                            {
                                count = 0;
                            }

                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            return gameOver = false;

        }

        
        private static bool checkForWin(Board gameBoard)
        {

            // horizontal red
            for (int x = 0; x <= 5; x++)
            {

                int count = 0;

                for (int y = 0; y <= 6; y++)
                {

                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                }

                // breaking loop if count = 4 
                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            // vertical red
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {
                        count++;
                    }

                    else
                    {
                        count = 0;
                    }

                }

                // breaking loop if count = 4 
                if (count == 4)
                {
                    return gameOver = true;
                }

            }


            // up and left

            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() >= 3 && gameBoard.getCell(x, y).getCol() >= 3)
                        {

                            count++;
                            // second surrounding found

                            if (gameBoard.getCell(x - 1, y - 1).getButton().BackColor == Color.Red)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x - 2, y - 2).getButton().BackColor == Color.Red)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x - 3, y - 3).getButton().BackColor == Color.Red)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }


                            }

                            else
                            {
                                count = 0;


                            }

                            

                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }               

                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            //down and right
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {

                        count++;

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() <= 2 && gameBoard.getCell(x, y).getCol() <= 3)
                        {

                            // second surrounding found 
                            if (gameBoard.getCell(x + 1, y + 1).getButton().BackColor == Color.Red)
                            {
                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x + 2, y + 2).getButton().BackColor == Color.Red)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x + 3, y + 3).getButton().BackColor == Color.Red)
                                    {
                                        count++;
                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }
                            }

                        }
                         
                        else
                        {
                            count = 0;
                        }

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }



            // down and left 
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {

                        count++;

                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() >= 3 && gameBoard.getCell(x, y).getCol() <= 3)
                        {

                            // down and left 
                            // second surrounding found
                            if (gameBoard.getCell(x - 1, y + 1).getButton().BackColor == Color.Red)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x - 2, y + 2).getButton().BackColor == Color.Red)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x - 3, y + 3).getButton().BackColor == Color.Red)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }

                            }

                            else
                            {
                                count = 0;
                            }

                        }                   

                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            





            // up and right 
            for (int y = 0; y <= 6; y++)
            {

                int count = 0;

                for (int x = 0; x <= 5; x++)
                {

                    // first color found
                    if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                    {

                        count++;


                        // !!!!! CHECK IF CHECKABLE
                        if (gameBoard.getCell(x, y).getRow() <= 2 && gameBoard.getCell(x, y).getCol() >= 3)
                        {

                            //up and right 
                            // second surrounding found 
                            if (gameBoard.getCell(x + 1, y - 1).getButton().BackColor == Color.Red)
                            {

                                count++;

                                // third surrounding found
                                if (gameBoard.getCell(x + 2, y - 2).getButton().BackColor == Color.Red)
                                {

                                    count++;

                                    // fourth surrounding found
                                    if (gameBoard.getCell(x + 3, y - 3).getButton().BackColor == Color.Red)
                                    {

                                        count++;

                                    }

                                    else
                                    {
                                        count = 0;
                                    }

                                }

                                else
                                {
                                    count = 0;
                                }


                            }

                            else
                            {
                                count = 0;
                            }

                        }
                      
                    }

                    else
                    {
                        count = 0;
                    }

                }

                if (count == 4)
                {
                    return gameOver = true;
                }

            }

            return gameOver = false;
            
        }


        
        // test to change cells 
        public void messWithBoard()
        {

            gameBoard.getCell(0, 0).getButton().BackColor = Color.Red;

            //or look at the entire array and grab a cell from the array that was returned.
            gameBoard.getGameBoard()[1, 1].getButton().BackColor = Color.Blue;

        }


        public void setUpGame()
        {
            
            //(btn_row_col) button naming format
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell c;

            //Find all buttons on the form

            //Be careful becuase if you have other buttons besides the cells (restart, exit, etc) this could cause an issue
            //Might need an if statement to exclude those buttons
            foreach (var button in this.Controls.OfType<Button>())
            {

                name = button.Name;
                posDelim = name.IndexOf(delim);
                //Look one place past where we found the delim and then read one character.  that is the row
                //If this was a two digit by two digit grid (10x10, 15x30, etc.) this would break.
                row = Int32.Parse(name.Substring(posDelim + 1, 1));
                //name is now only equal to everything after the row number we found.
                name = name.Substring(posDelim + 2);
                //Find the delim again
                posDelim = name.IndexOf(delim);
                col = Int32.Parse(name.Substring(posDelim + 1));

                //create a new cell
                c = new Cell(row, col, button);

                //add that cell to the gameboard
                gameBoard.setGameBoardCell(c);

            }
        }


        // might delete, alternate to overloaded constructor 
        public void formPassedToMe(Form f1)
        {
            mainForm = f1;
        }


        public int getTurnCount()
        {
            return turn_count;
        }

        public static bool getAiGame()
        {
            return aiGame;
        }


        // will turn off board after game 
        private void disableButtons()
        {
            try
            {

                //runs through all objects in form - all buttons 
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }

            }

            catch { }

        }




        // ===================================================================================================================
        //                                                            o b j e c t s 
        // ====================================================================================================================

        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void col2Click(object sender, EventArgs e)
        {

            // column number
            int y = 2;
            
            // cycle through column
            for (int x = 5; x > 0; x--)
            {
                
                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }


                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);
                        
                        

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }

                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }

                ////add??
                //// disables buttons
                //b.Enabled = false;
                //turn_count++;
                ////checkForWinner();




            }



        }



        private void col3Click(object sender, EventArgs e)
        {
            // column number
            int y = 3;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }


                   

                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }

                    //makes other players turn start
                    turn = !turn;


                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }



            }
        }

        private void col4Click(object sender, EventArgs e)
        {
            // column number
            int y = 4;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }

                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }


                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }



            }
        }

        private void col5Click(object sender, EventArgs e)
        {
            // column number
            int y = 5;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }


                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }


                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }


            }
        }

        private void col6Click(object sender, EventArgs e)
        {
            // column number
            int y = 6;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }


                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }

                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }



            }

            
        }

        private void col0Click(object sender, EventArgs e)
        {
            // column number
            int y = 0;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }


                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {

                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }

                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }

            }

        }


        private void col1Click(object sender, EventArgs e)
        {
            // column number
            int y = 1;

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // changing color based on turn 
                    if (turn)
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    }

                    checkForWin(gameBoard);
                    if (gameOver == true && turn == true)
                    {



                        string message = "Winner Red";

                        MessageBox.Show(message);

                    }

                    checkForBlueWin(gameBoard);


                    if (gameOver == true && turn == false)
                    {

                        string message = "Winner Blue";

                        MessageBox.Show(message);

                    }

                    //makes other players turn start
                    turn = !turn;

                    //exit the loop once a color is changed, could be a while loop also
                    break;

                }

            }
        }

    

        

      
