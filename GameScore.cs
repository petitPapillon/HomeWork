using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domasno
{
    public partial class GameScore : Form
    {
        string text;
        public GameScore()
        {
            InitializeComponent();
            lblText.Text = string.Format("{0,-15}{1,-15}{2,-15}", "Name", "Score", "Best Word");
            this.Location = new Point(250, 170);
        }

        public void AddScores(string s)
        {
            lblText.Text = string.Format("{0,-15}{1,-15}{2,-15}", "Name", "Score", "Best Word");
            text = s;
            lblText.Text += text;
        }
        private void GameScore_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
