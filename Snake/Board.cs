using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Board
    {
        int maxRow = 10, maxCol = 20;       //Max 10 rows, and 20 columns in the board
        int squareSize = 30;                //Each square is 30px by 30px

        PictureBox[,] squares;

        public Board(Form mainForm)
        {
            squares = new PictureBox[maxRow, maxCol];
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col] = new PictureBox();
                    squares[row, col].Location = new Point(col * squareSize, row * squareSize);
                    squares[row, col].Height = squareSize;
                    squares[row, col].Width = squareSize;
                    squares[row, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    if((row % 2 == 0) && (col % 2 == 0) || (row % 2 == 1) && (col % 2 == 1) ) // rows & col are alternating 
                    {
                        squares[row, col].BackColor = Color.Brown;
                    }
                    else
                    {
                        squares[row, col].BackColor = Color.MidnightBlue;
                    }


                    squares[row, col].BorderStyle = BorderStyle.FixedSingle;

                    mainForm.Controls["boardPanel"].Controls.Add(squares[row, col]);
                }
            }
            mainForm.Controls["controlPanel"].Location = new Point(mainForm.Controls["boardPanel"].Location.X, mainForm.Controls["boardPanel"].Location.Y + mainForm.Controls["boardPanel"].Height + 20);
        }

        public int getMaxColNo()
        {
            return maxCol-1; //Last Column No is 19, not 20
        }

        public int getMaxRowNo()
        {
            return maxRow-1; //Last Row No is 9, not 10
        }

        public int getMinColNo()
        {
            return 0;       // 0 is the smallest Col number of the board
        }

        public int getMinRowNo()
        {
            return 0;       // 0 is the smallest Row number of the board
        }

        public void draw()
        {
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    squares[row, col].Image = null ;
                }
            }
        }

        public void draw(Position p, Image pic)
        {
            squares[p.getRowNo(), p.getColNo()].Image = pic;
        }
    }
}
