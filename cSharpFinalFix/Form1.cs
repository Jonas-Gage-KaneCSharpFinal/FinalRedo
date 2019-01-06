using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace cSharpFinalFix
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void btnDraw_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(cSharpFinalFix.Properties.Resources.Clashing);
            splayer.Play();
        }

       
    }
}
