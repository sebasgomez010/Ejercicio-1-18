using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_18.Interface
{
    public partial class ejercicioN7: Form
    {
        public ejercicioN7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // valor del box a numero
                double n1 = Convert.ToDouble(HL.Text);
                double n2 = Convert.ToDouble(TH.Text);

                //multiplicar
                double resultado = n1 * n2;

                P.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números en los cuadros de texto.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HL.Clear();
            TH.Clear();
            P.Clear();
            HL.Focus();
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
