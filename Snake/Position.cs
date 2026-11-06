using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Position
    {
        private int rowNo;
        private int colNo;

        public Position(int rowNo, int colNo)
        {
            this.rowNo = rowNo;
            this.colNo = colNo;
        }

        public int getRowNo()
        {
            return this.rowNo;
        }

        public int getColNo()
        {
            return this.colNo;
        }
    }
}
