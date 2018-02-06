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
    public partial class Nosotros : Form
    {
        private SoundPlayer _soundPlayer;
        public Nosotros()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("btn_regresar.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
