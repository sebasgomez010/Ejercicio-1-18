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
    public partial class ejercicioN9: Form
    {
        public ejercicioN9()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTGB.Clear();
            TXTMD.Clear();
            TXTGB.Focus();
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
            double GB, MG, MD;

            GB = double.Parse(TXTGB.Text);

            MG = GB * 1024;

            //Math.Ceiling redondear numero
            MD = Math.Ceiling(MG / 1.44);

            TXTMD.Text = MD.ToString();


        }
    }
}
