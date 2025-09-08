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
    public partial class ejercicioN12: Form
    {
        public ejercicioN12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int E1, E2;

            int DE;

            E1 = int.Parse(TXTE1.Text);
            E2 = int.Parse(TXTE2.Text);

            if (E1 > E2)
            {
                DE = E1 - E2;
                TXT_DIF.Text = "El primer hermano es el mayor por " + DE + " años.";
            }
            else if (E2 > E1)
            {
                DE = E2 - E1;
                TXT_DIF.Text = "El segundo hermano es el mayor por " + DE + " años.";
            }
            else
            {
                TXT_DIF.Text = "Ambos hermanos tienen la misma edad.";
            }
        }

        private void TXE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTE2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_DIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTE1.Clear();
            TXTE2.Clear();
            TXT_DIF.Clear();
            TXTE1.Focus();
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
