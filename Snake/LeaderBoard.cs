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
    public partial class LeaderBoard : Form
    {
        List<Score> myscores = new List<Score>();
        private void refreshDGV()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < myscores.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = myscores[i].getName();
                dataGridView1.Rows[i].Cells[1].Value = myscores[i].getScore();
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Descending); //List the scores in descending order
        }

        public LeaderBoard()
        {

            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Name"; //title of columns in dgv
            dataGridView1.Columns[1].HeaderText = "Score";
            StreamReader sr = new StreamReader("C:\\tmp\\leaderboard.txt", true);
            string oneline;
            Score s;
            oneline = sr.ReadLine();
            while (oneline != null) //leaderboard.txt must have data
            {
                string[] split = oneline.Split(',');
                s = new Score(split[0], Convert.ToInt32(split[1]));
                myscores.Add(s);
                oneline = sr.ReadLine();

            }
            sr.Close();
            refreshDGV();
            
            StreamWriter sw = new StreamWriter("C:\\tmp\\leaderboard.txt", true);
            sw.Close();
        }


        private void LeaderBoard_Load(object sender, EventArgs e)
        {

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
