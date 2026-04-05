using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reaction_time_game
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovaHra_Click(object sender, EventArgs e)
        {

            Form1 hra = new Form1();


            hra.Show();


            this.Hide();


            hra.FormClosed += (s, args) => this.Show();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            FormScore score = new FormScore();


            score.Show();


            this.Hide();


            score.FormClosed += (s, args) => this.Show();
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            FormHint hint = new FormHint();


            hint.Show();


            this.Hide();


            hint.FormClosed += (s, args) => this.Show();
        }
    }
}
