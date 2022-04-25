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
    public partial class _1Player : Form
    {
        Main_Menu form1Player;
        // ================================================================================================================
        // varibles 
        // ================================================================================================================

        //ai game == 2 player mode 

        public static bool gameOver = false;
        public static bool turn = true; // true = red turn, false = blue turn
        public int turn_count = 0;

        private Board gameBoard;

        Form mainForm;

        public _1Player()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void formPassedToMe(Main_Menu _1Player)
        {
            form1Player = _1Player;
        }

        public _1Player(Form f1)
        {
            InitializeComponent();

            gameBoard = new Board();

            //so I have a reference to it in the button click
            mainForm = f1;

            setUpGame();

            //messWithBoard();

        }

        // ================================================================================================================
        // functions 
        // ================================================================================================================


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

        // check for win 
        // 
        private static bool checkForWin(Board gameBoard)
        {

            // horizontal red
            for (int x = 0; x < 5; x++)
            {

                int count = 0;

                for (int y = 0; y < 6; y++)
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
            for (int y = 0; y < 6; y++)
            {

                int count = 0;

                for (int x = 0; x < 5; x++)
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

            for (int y = 0; y < 6; y++)
            {

                int count = 0;

                for (int x = 0; x < 5; x++)
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
            for (int y = 0; y < 6; y++)
            {

                int count = 0;

                for (int x = 0; x < 5; x++)
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
            for (int y = 0; y < 6; y++)
            {

                int count = 0;

                for (int x = 0; x < 5; x++)
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
            for (int y = 0; y < 6; y++)
            {

                int count = 0;

                for (int x = 0; x < 5; x++)
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


            return gameOver;
        }




        // check for win 



        private void _1Player_Load(object sender, EventArgs e)
        {

        }



        // ==========================================================================================================
        //                              click events 
        // ==========================================================================================================
        
        private void col0Click(object sender, EventArgs e)
        {
            // column number
            int y = 0;

            // ai needs to move second

            // cycle through column
            for (int x = 5; x > 0; x--)
            {

                // check from bottom up
                // if button isnt red or blue, change color 
                if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                {

                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);


                    if (gameOver == true)
                    {

                        //game over form

                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }
                    

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

                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);

                    if (gameOver == true)
                    {

                        //game over form

                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

                }
            }
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


                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);

                    if (gameOver == true)
                    {

                        //game over form

                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

                }
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


                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);


                    if (gameOver == true)
                    {

                        //game over form

                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

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


                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);


                    if (gameOver == true)
                    {

                        //game over form

                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

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

                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);

                    if (gameOver == true)
                    {
                        //game over form
                    }
                    else
                    {
                        //makes other players turn start
                        turn = !turn;

                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

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

                    // player move and check
                    gameBoard.getCell(x, y).getButton().BackColor = Color.Blue;
                    checkForWin(gameBoard);

                    // ai move and check 
                    AI.makeMove(gameBoard);
                    checkForWin(gameBoard);

                    if (gameOver == true)
                    {
                        //game over form
                    }

                    else
                    {
                        //makes other players turn start
                        turn = !turn;
                        //exit the loop once a color is changed, could be a while loop also
                        break;
                    }

                }
            }
        }
    }
}
