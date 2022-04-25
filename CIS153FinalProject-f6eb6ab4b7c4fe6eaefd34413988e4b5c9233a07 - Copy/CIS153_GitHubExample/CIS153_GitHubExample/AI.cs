using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CIS153_GitHubExample
{
    class AI
    {

        public static bool possibleWin = false;
        public static bool moveMade = false;

        // ai will be red , so if turn = true
        // need to pass the ai the game board 

        public static void makeMove(Board gameBoard)
        {

                
                // AI picks center buttons early game beacuse they are more valuable 
                // first 3 moves
                if (gameBoard.getCell(5, 3).getButton().BackColor != Color.Red && gameBoard.getCell(5, 3).getButton().BackColor != Color.Blue)
                {

                    gameBoard.getCell(5, 3).getButton().BackColor = Color.Red;
                    return;
                    
                }

                else if (gameBoard.getCell(4, 3).getButton().BackColor != Color.Red && gameBoard.getCell(4, 3).getButton().BackColor != Color.Blue)
                {
                    gameBoard.getCell(4, 3).getButton().BackColor = Color.Red;
                    return;

                }
                else if (gameBoard.getCell(3, 3).getButton().BackColor != Color.Red && gameBoard.getCell(3, 3).getButton().BackColor != Color.Blue)
                {
                    gameBoard.getCell(3, 3).getButton().BackColor = Color.Red;
                    return;
                }


                // ======================================================
                // Rule 1 - Take win 
                // ======================================================
                //  -scan for 3 in a row of red
                //  -set adjacent cell if a win 




                //  -horizontal win chance
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

                        // possible win found, place for the win  
                        // if next square isnt red or blue, place
                        if (count == 3)
                        {

                            // !!!!! CHECK IF CHECKABLE
                            if (gameBoard.getCell(x, y).getRow() >= 3 && gameBoard.getCell(x, y).getCol() >= 3)
                            {

                                if (gameBoard.getCell(x + 1, y).getButton().BackColor != Color.Red && gameBoard.getCell(x + 1, y).getButton().BackColor != Color.Blue)
                                {
                                    gameBoard.getCell(x + 1, y).getButton().BackColor = Color.Red;
                                    return;
                                
                                }

                                else if (gameBoard.getCell(x - 3, y).getButton().BackColor != Color.Red && gameBoard.getCell(x - 3, y).getButton().BackColor != Color.Blue)
                                {
                                    gameBoard.getCell(x - 3, y).getButton().BackColor = Color.Red;
                                    return;
                                }

                            }

                            // closing this if statement? idk 

                        }

                    }

                }

                // vertical win chance 
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

                        // 3 in row found, check for availible winning button 
                        if (count == 3)
                        {
                            // check one spot lower
                            if (gameBoard.getCell(x, y + 1).getButton().BackColor != Color.Red && gameBoard.getCell(x, y + 1).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x, y + 1).getButton().BackColor = Color.Red;
                                return;
                            }
                            // check 3 higher
                            else if (gameBoard.getCell(x, y - 3).getButton().BackColor != Color.Red && gameBoard.getCell(x, y - 3).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x, y - 3).getButton().BackColor = Color.Red;
                                return;
                            }

                            // closing this if statement? idk if needed

                        }

                    }

                }

                //// upper left to bottom right 
                //for (int y = 0; y < 6; y++)
                //{

                //    for (int x = 0; x < 5; x++)
                //    {

                //        // first color found
                //        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                //        {

                //            if (gameBoard.getCell(x + 1, y + 1).getButton().BackColor == Color.Red && gameBoard.getCell(x - 1, y - 1).getButton().BackColor == Color.Red)
                //            {

                //                // 3 found, check above and below 
                //                // check lower diag
                //                if (gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Red && gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x - 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }
                //                // check higher diag 
                //                else if (gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Red && gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x + 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }

                //                // closing this if statement? idk if needed

                //            }

                //        }

                //    }

                //}

                //// bottom right to upper left
                //for (int y = 0; y < 6; y++)
                //{

                //    for (int x = 0; x < 5; x++)
                //    {

                //        // first color found
                //        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Red)
                //        {

                //            // checks above and below cell found 
                //            if (gameBoard.getCell(x + 1, y - 1).getButton().BackColor == Color.Red && gameBoard.getCell(x - 1, y + 1).getButton().BackColor == Color.Red)
                //            {

                //                // 3 found, check above and below 
                //                // check lower diag
                //                if (gameBoard.getCell(x + 2, y - 2).getButton().BackColor != Color.Red && gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x + 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }
                //                // checkhigher diag 
                //                else if (gameBoard.getCell(x - 2, y + 2).getButton().BackColor != Color.Red && gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x - 2, y + 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }

                //                // closing this if statement? idk if needed

                //            }

                //        }

                //    }

                //}


                // ======================================================
                // Rule 2 - Block opponent 
                // ======================================================
                //  -scan for 3 in a row of red
                //  -set adjacent cell if a win
                //  - if not blocking, check colors 


                // horizontal win chance
                for (int x = 0; x < 5; x++)
                {

                    int count = 0;

                    for (int y = 0; y < 6; y++)
                    {

                        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                        {
                            count++;
                        }

                        else
                        {
                            count = 0;
                        }

                        // possible win found, place for the win  
                        // if next square isnt red or blue, place
                        if (count == 3)
                        {

                            if (gameBoard.getCell(x + 1, y).getButton().BackColor != Color.Red && gameBoard.getCell(x + 1, y).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x + 1, y).getButton().BackColor = Color.Red;
                                return;
                            }

                            else if (gameBoard.getCell(x - 3, y).getButton().BackColor != Color.Red && gameBoard.getCell(x - 3, y).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x - 3, y).getButton().BackColor = Color.Red;
                                return;
                            }

                            // closing this if statement? idk 

                        }

                    }

                }

                // vertical win chance 
                for (int y = 0; y < 6; y++)
                {

                    int count = 0;

                    for (int x = 0; x < 5; x++)
                    {

                        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                        {
                            count++;
                        }

                        else
                        {
                            count = 0;
                        }

                        // 3 in row found, check for availible winning button 
                        if (count == 3)
                        {
                            // check one spot lower
                            if (gameBoard.getCell(x, y + 1).getButton().BackColor != Color.Red && gameBoard.getCell(x, y + 1).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x, y + 1).getButton().BackColor = Color.Red;
                                return;
                            }
                            // check 3 higher
                            else if (gameBoard.getCell(x, y - 3).getButton().BackColor != Color.Red && gameBoard.getCell(x, y - 3).getButton().BackColor != Color.Blue)
                            {
                                gameBoard.getCell(x, y - 3).getButton().BackColor = Color.Red;
                                return;
                            }

                            // closing this if statement? idk if needed

                        }

                    }

                }

                //// upper left to bottom right 
                //for (int y = 0; y < 6; y++)
                //{

                //    for (int x = 0; x < 5; x++)
                //    {

                //        // first color found
                //        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                //        {

                //            if (gameBoard.getCell(x + 1, y + 1).getButton().BackColor == Color.Blue && gameBoard.getCell(x - 1, y - 1).getButton().BackColor == Color.Blue)
                //            {
                //                // 3 found, check above and below 
                //                // check lower diag
                //                if (gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Red && gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x - 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }
                //                // check higher diag 
                //                else if (gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Red && gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x + 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }

                //                // closing this if statement? idk if needed

                //            }

                //        }

                //    }

                //}

                //// bottom right to upper left
                //for (int y = 0; y < 6; y++)
                //{

                //    for (int x = 0; x < 5; x++)
                //    {

                //        // first color found
                //        if (gameBoard.getCell(x, y).getButton().BackColor == Color.Blue)
                //        {

                //            // checks above and below cell found 
                //            if (gameBoard.getCell(x + 1, y - 1).getButton().BackColor == Color.Blue && gameBoard.getCell(x - 1, y + 1).getButton().BackColor == Color.Blue)
                //            {

                //                // 3 found, check above and below 
                //                // check lower diag
                //                if (gameBoard.getCell(x + 2, y - 2).getButton().BackColor != Color.Red && gameBoard.getCell(x - 2, y - 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x + 2, y - 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }
                //                // checkhigher diag 
                //                else if (gameBoard.getCell(x - 2, y + 2).getButton().BackColor != Color.Red && gameBoard.getCell(x + 2, y + 2).getButton().BackColor != Color.Blue)
                //                {
                //                    gameBoard.getCell(x - 2, y + 2).getButton().BackColor = Color.Red;
                //                    return;
                //                }

                //                // closing this if statement? idk if needed

                //            }

                //        }

                //    }

                //}

            // ======================================================
            // Rule 3 - Next best move 
            // ======================================================
            // - search whole array  
            // - find red button
            // - search around button 

            // next best move

            for (int x = 5; x > 0; x--)
            {

                for (int y = 6; y > 0; y--)
                {


                    if (gameBoard.getCell(x, y).getButton().BackColor != Color.Red && gameBoard.getCell(x, y).getButton().BackColor != Color.Blue)
                    {

                        gameBoard.getCell(x, y).getButton().BackColor = Color.Red;
                        return;

                    }

                    
                }

            }


            // ===============================================================================================================================================================

        }

        

            





    }
}
