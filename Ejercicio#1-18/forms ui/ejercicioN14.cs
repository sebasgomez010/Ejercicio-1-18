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
    public partial class ejercicioN14: Form
    {
        public ejercicioN14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N1, N2, N3;
            int NM; 

            N1 = int.Parse(TXTN1.Text);
            N2 = int.Parse(TXTN2.Text);
            N3 = int.Parse(TXTN3.Text);

            if (N1 > N2 && N1 > N3)
            {
                NM = N1;
            }
            else if (N2 > N3)
            {
                NM = N2;
            }
            else
            {
                NM = N3;
            }

            TXTNM.Text = "El número mayor es: " + NM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTN1.Clear();
            TXTN2.Clear();
            TXTN3.Clear();
            TXTNM.Clear();
            TXTN1.Focus();
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
