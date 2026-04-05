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

    

    public partial class FormHint : Form
    {
        public FormHint()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            int score = 0;

            if (checkBoxQ1.Checked) score++;
            if (checkBoxQ2.Checked) score++;
            if (checkBoxQ3.Checked) score++;
            if (checkBoxQ4.Checked) score++;
            if (checkBoxQ5.Checked) score++;

            labelGood.Visible = false;
            labelMid.Visible = false;
            labelBad.Visible = false;  

            if (score == 5)
            {
                labelGood.Visible = true;
            }   
            else if (score >= 3)
            {
                labelMid.Visible = true;
            }
            else
            {
                labelBad.Visible = true;
            }
        }
    }
}
