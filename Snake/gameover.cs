using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snake
{
    public partial class gameover : Form
    {
        int result;
        
        public gameover(int r)
        {
            InitializeComponent();
            this.result = r;
        }

        private void leaderboardBTN_Click(object sender, EventArgs e)
        {
            LeaderBoard lb = new LeaderBoard();
            lb.ShowDialog();
        }


    }
}
