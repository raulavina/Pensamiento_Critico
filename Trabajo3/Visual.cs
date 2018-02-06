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

namespace Trabajo3
{
    public partial class Visual : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        public Visual()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Integral.wav");
            _soundPlayer1 = new SoundPlayer("btn_regresar.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Visual_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
