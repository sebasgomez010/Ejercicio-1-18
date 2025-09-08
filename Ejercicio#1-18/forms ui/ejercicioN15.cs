using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_18.Interface
{
    public partial class ejercicioN15: Form
    {
        public ejercicioN15()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int L1, L2, L3;
            string TT;

            L1 = int.Parse(TXTL1.Text);
            L2 = int.Parse(TXTL2.Text);
            L3 = int.Parse(TXTL3.Text);

            if (L1 == L2 && L2 == L3)
            {
                TT = "Equilátero";
            }
            else if (L1 != L2 && L2 != L3 && L1 != L3)
            {
                TT = "Escaleno";
            }
            else
            {
                TT = "Isósceles";
            }

            TXTTipo.Text = "El triángulo es " + TT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTL1.Clear();
            TXTL2.Clear();
            TXTL3.Clear();
            TXTTipo.Clear();
            TXTL1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Form home = Application.OpenForms["Home"];
                if (home == null) home = new Home();

                home.Show();
                this.Close();
            }
        }
    }
}
