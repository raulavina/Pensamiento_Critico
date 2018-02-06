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
    public partial class PantallaInicial : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        private SoundPlayer _soundPlayer2;
        private SoundPlayer _soundPlayer3;
        public PantallaInicial()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("btn_hypertech.wav");
            _soundPlayer1 = new SoundPlayer("btn_Introduccion.wav");
            _soundPlayer2 = new SoundPlayer("btn_test_enfoque.wav");
            _soundPlayer3 = new SoundPlayer("btn_acercaDe.wav");
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {
            //ObtenerConexion.Conexion();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auditivo pantallatest = new Auditivo();
            pantallatest.ShowDialog();
            this.Show();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            this.Hide();
            acerca intro = new acerca();
            intro.ShowDialog();
            this.Show();
        }

        private void btnacerca_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nosotros acerca = new Nosotros();
            acerca.ShowDialog();
            this.Show();
        }

        private void duelStateButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}