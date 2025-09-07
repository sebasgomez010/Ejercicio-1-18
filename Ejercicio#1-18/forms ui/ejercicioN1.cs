using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_18
{
    public partial class ejercicioN1: Form
    {
        public ejercicioN1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            rta.Clear();
            num1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // valor del box a numero
                double n1 = Convert.ToDouble(num1.Text);
                double n2 = Convert.ToDouble(num2.Text);

                //multiplicar
                double resultado = n1 * n2;

                rta.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números en los cuadros de texto.");
            }
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form home = Application.OpenForms["Home"];
            if (home == null) home = new Home(); 

            home.Show();   
            this.Close();  
        }
    }
}
