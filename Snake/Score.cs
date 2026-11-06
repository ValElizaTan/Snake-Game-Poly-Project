using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Score
    {
        private string name;
        private int score;

        public Score(string n, int s)
        {
            name = n;
            score = s;
        }

        public string getName()
        {
            return name;
        }
        public int getScore()
        {
            return score;
        }
    }
}
