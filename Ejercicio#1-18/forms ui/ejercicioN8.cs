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
    public partial class ejercicioN8: Form
    {
        public ejercicioN8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTLA.Clear();
            TXTLB.Clear();
            TXTLC.Clear();
            TXTAT.Clear();
            TXTLA.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double LA, LB, LC;
            double LS;  
            double AT;  

            
            LA = double.Parse(TXTLA.Text);
            LB = double.Parse(TXTLB.Text);
            LC = double.Parse(TXTLC.Text);

            
            LS = (LA + LB + LC) / 2;

            // Calcular área con fórmula
            AT = Math.Sqrt(LS * (LS - LA) * (LS - LB) * (LS - LC));

            TXTAT.Text = AT.ToString();
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
