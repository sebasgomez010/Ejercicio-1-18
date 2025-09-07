using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_1_18.Interface
{
    public partial class ejercicioN10: Form
    {
        public ejercicioN10()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTAA.Clear();
            TXTAB.Clear();
            TXTOA.Clear();
            TXTOB.Clear();
            TXTD.Clear();
            TXTAA.Focus();
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

        private void button2_Click(object sender, EventArgs e)
        {
            double AA, OA, AB, OB, D;

            
            AA = double.Parse(TXTAA.Text); 
            OA = double.Parse(TXTOA.Text); 
            AB = double.Parse(TXTAB.Text); 
            OB = double.Parse(TXTOB.Text); 

            // Calcular distancia(Raiz cuadrada)
            D = Math.Sqrt(Math.Pow(AB - AA, 2) + Math.Pow(OB - OA, 2));

            TXTD.Text = D.ToString();

        }
    }
}
