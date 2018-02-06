using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo3
{
    public partial class Imagenes3 : Form
    {
        public Imagenes3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Imagenes2 pantallatest = new Imagenes2();
            pantallatest.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 pantallatest = new Form2();
            pantallatest.ShowDialog();
            this.Show();
        }
    }
}
