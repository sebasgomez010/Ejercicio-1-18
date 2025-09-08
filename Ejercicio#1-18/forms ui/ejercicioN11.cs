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
    public partial class ejercicioN11: Form
    {
        public ejercicioN11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int AN; 
            int AA; 

            int E;  

            AN = int.Parse(TXAN.Text);
            AA = int.Parse(TXAA.Text);


            E = AA - AN;

            if (E >= 18)
                TXTSalida.Text = "Debe inscribirse en el SMO.";
            else
                TXTSalida.Text = "No debe inscribirse en el SMO.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXAN.Clear();
            TXAA.Clear();
            TXTSalida.Clear();
            TXAN.Focus();
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

        private void TXAN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
