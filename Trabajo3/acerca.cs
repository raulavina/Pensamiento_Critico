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
    public partial class acerca : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        public acerca()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Introduccion.wav");
            _soundPlayer1 = new SoundPlayer("btn_regresar.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acerca_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
