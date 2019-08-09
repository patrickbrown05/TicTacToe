using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int turn_No = 1;
        public Image OMove = Image.FromFile("C:/Users/Patrick.DSIPBS/source/repos/TicTacToe/O.jpg");
        public Image XMove = Image.FromFile("C:/Users/Patrick.DSIPBS/source/repos/TicTacToe/X.jpg");
        bool tile1 = false;
        bool tile2 = false;
        bool tile3 = false;
        bool tile4 = false;
        bool tile5 = false;
        bool tile6 = false;
        bool tile7 = false;
        bool tile8 = false;
        bool tile9 = false;

        public void CheckGameComplete()
        {
            // Do the checking here
            // call checkThread.Stop() once checking is done.
            if (pictureBox1.Image == XMove && pictureBox2.Image == XMove && pictureBox3.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            } else if (pictureBox1.Image == XMove && pictureBox4.Image == XMove && pictureBox7.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox2.Image == XMove && pictureBox5.Image == XMove && pictureBox8.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox3.Image == XMove && pictureBox6.Image == XMove && pictureBox9.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox1.Image == XMove && pictureBox5.Image == XMove && pictureBox9.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox3.Image == XMove && pictureBox5.Image == XMove && pictureBox7.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox4.Image == XMove && pictureBox5.Image == XMove && pictureBox6.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox7.Image == XMove && pictureBox8.Image == XMove && pictureBox9.Image == XMove)
            {
                label1.Text = "X has won! Please hit the reset button to play again!";
                turn_No = 999;
            } else if (pictureBox1.Image == OMove && pictureBox2.Image == OMove && pictureBox3.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox1.Image == OMove && pictureBox4.Image == OMove && pictureBox7.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox2.Image == OMove && pictureBox5.Image == OMove && pictureBox8.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox3.Image == OMove && pictureBox6.Image == OMove && pictureBox9.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox1.Image == OMove && pictureBox5.Image == OMove && pictureBox9.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox3.Image == OMove && pictureBox5.Image == OMove && pictureBox7.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox4.Image == OMove && pictureBox5.Image == OMove && pictureBox6.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
            else if (pictureBox7.Image == OMove && pictureBox8.Image == OMove && pictureBox9.Image == OMove)
            {
                label1.Text = "O has won! Please hit the reset button to play again!";
                turn_No = 999;
            }
        }

        public bool canMakeMove()
        {
            if (turn_No >= 11)
            {
                return true;
            } else
            {
                return false;
            }

        }
        public void upDateLabel()
        {
            
            if (turn_No % 2 == 1 && turn_No <= 9)
            {
                label1.Text = "Its X's turn, click on a box to play a move!";
            }
            else if (turn_No % 2 == 0 && turn_No <= 9)
            {
                label1.Text = "Its O's turn, click on a box to play a move!";
            } else if (turn_No == 10)
            {
                label1.Text = "the game has ended in a draw. Please hit the reset button";
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Its X's turn, click on a box to play a move!";
            
        }

        public void makeMove(int boxNo)
        {
            if (turn_No % 2 == 0)
            {
                pictureBox3.Image = OMove;
                turn_No++;
            }
            else
            {
                pictureBox3.Image = XMove;
                turn_No++;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile3 == false)
            {
                if (turn_No % 2 == 0)
                {
                    pictureBox3.Image = OMove;
                    turn_No++;
                    tile3 = true;
                }
                else
                {
                    pictureBox3.Image = XMove;
                    turn_No++;
                    tile3 = true;
                }
                upDateLabel();
                CheckGameComplete();
            }
        }



        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile2 == false) {   
            if (turn_No % 2 == 0)
            {
                pictureBox2.Image = OMove;
                turn_No++;
                tile2 = true;
            }
            else
            {
                pictureBox2.Image = XMove;
                turn_No++;
                tile2 = true;
            }
          }
            upDateLabel();
            CheckGameComplete();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile1 == false) { 
            if (turn_No % 2 == 0)
            {
                pictureBox1.Image = OMove;
                turn_No++;
                tile1 = true;
            }
            else
            {
                pictureBox1.Image = XMove;
                turn_No++;
                tile1 = true;
            }
            }
            upDateLabel();
            CheckGameComplete();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile6 == false) { 
            if (turn_No % 2 == 0)
            {
                pictureBox6.Image = OMove;
                turn_No++;
                tile6 = true;
            }
            else
            {
                pictureBox6.Image = XMove;
                turn_No++;
                tile6 = true;
            }
           }
            upDateLabel();
            CheckGameComplete();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile4 == false ) { 
            if (turn_No % 2 == 0)
            {
                pictureBox4.Image = OMove;
                turn_No++;
                tile4 = true;
            }
            else
            {
                pictureBox4.Image = XMove;
                turn_No++;
                tile4 = true;
            }
        }
            upDateLabel();
            CheckGameComplete();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile5 == false) { 
            if (turn_No % 2 == 0)
            {
                pictureBox5.Image = OMove;
                turn_No++;
                tile5 = true;
            }
            else
            {
                pictureBox5.Image = XMove;
                turn_No++;
                tile5 = true;
            }
        }
            upDateLabel();
            CheckGameComplete();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile7 == false) { 
            if (turn_No % 2 == 0)
            {
                pictureBox7.Image = OMove;
                turn_No++;
                tile7 = true;
            }
            else
            {
                pictureBox7.Image = XMove;
                turn_No++;
                tile7 = true;
            }
            upDateLabel();
            CheckGameComplete();
        }
      }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile8 == false) { 
            if (turn_No % 2 == 0)
            {
                pictureBox8.Image = OMove;
                turn_No++;
                tile8 = true;
            }
            else
            {
                pictureBox8.Image = XMove;
                turn_No++;
                tile8 = true;
            }

            upDateLabel();
            CheckGameComplete();
        }
    }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (!canMakeMove() && tile9 == false) {
            if (turn_No % 2 == 0)
            {
                pictureBox9.Image = OMove;
                turn_No++;
                tile9 = true;
            }
            else
            {
                pictureBox9.Image = XMove;
                turn_No++;
                tile9 = true;
            }
 }
            upDateLabel();
            CheckGameComplete();
        }

        private void game_win() {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            turn_No = 1;

            label1.Text = "Its X's turn, click on a box to play a move!";

            tile1 = false;
            tile2 = false;
            tile3 = false;
            tile4 = false;
            tile5 = false;
            tile6 = false;
            tile7 = false;
            tile8 = false;
            tile9 = false;
        }
    }
}

