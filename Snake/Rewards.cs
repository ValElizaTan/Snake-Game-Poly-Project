using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Rewards
    {
        List<Position> primoList;
        Board mainBoard;

        public Rewards(int size, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            primoList = new List<Position>();
            for (int i=0;i< size;i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo()+1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo()+1);

                } while (isDuplicate(rowNo, colNo) == true);

                primoList.Add(new Position(rowNo, colNo));
            }
        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< primoList.Count;i++)
            {
                if (primoList[i].getRowNo() == row && primoList[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < primoList.Count; i++)
            {
                mainBoard.draw(primoList[i], Properties.Resources.Primogem);
            }     
        }

        public Boolean checkIFSnakeHeadEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < primoList.Count; i++)
            {
                if (snakeHead.getRowNo() == primoList[i].getRowNo() && snakeHead.getColNo() == primoList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public Boolean checkIFSnakeEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < primoList.Count; i++)
            {
                if (snakeHead.getRowNo() == primoList[i].getRowNo() && snakeHead.getColNo() == primoList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int eatPrimoAtPostion(Position p)
        {
            // Remove the apple at Position p from primoList
            for (int i = 0; i < primoList.Count; i++)
            {
                if (p.getRowNo() == primoList[i].getRowNo() && p.getColNo() == primoList[i].getColNo())
                    primoList.RemoveAt(i);
            }

            return 160;  //160 points per primo
        }

        public Boolean noMorePrimo()
        {
            if (primoList.Count > 0)
                return false;
            else
                return true;
        }
    }
}
