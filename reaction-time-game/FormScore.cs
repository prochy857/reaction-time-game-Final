using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static reaction_time_game.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace reaction_time_game
{



    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
            
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
          
            DGVScores.Rows.Clear();

           
            Statistiky.SeznamSkore.Sort();

            
            foreach (int s in Statistiky.SeznamSkore)
            {
                DGVScores.Rows.Add(s + " ms");
            }
        }
    }

}
