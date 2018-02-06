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
    public partial class Auditivo : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        public Auditivo()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Estructurada.wav");
            _soundPlayer1 = new SoundPlayer("btn_regresar.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Auditivo_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Play";
                _soundPlayer.Stop();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Imagenes2 pantallatest = new Imagenes2();
            pantallatest.ShowDialog();
            this.Show();
        }
    }
}
