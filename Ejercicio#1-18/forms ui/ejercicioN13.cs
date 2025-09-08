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
    public partial class ejercicioN13: Form
    {
        public ejercicioN13()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double PL, PMa, PMi, PJ, PV, PS;
            double PT, PP;
            string MSG;

            PL = double.Parse(TXTPL.Text);
            PMa = double.Parse(TXTPMA.Text);
            PMi = double.Parse(TXTPMI.Text);
            PJ = double.Parse(TXTPJ.Text);
            PV = double.Parse(TXTPV.Text);
            PS = double.Parse(TXTPS.Text);

            PT = PL + PMa + PMi + PJ + PV + PS;
            PP = PT / 6;

            if (PP >= 100)
            {
                MSG = "Recibirá Incentivos";
            }
            else
            {
                MSG = "No Recibirá Incentivos";
            }

            TXTMSG.Text = MSG;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTPL.Clear();
            TXTPMA.Clear();
            TXTPMI.Clear();
            TXTPJ.Clear();
            TXTPV.Clear();
            TXTPS.Clear();
            TXTMSG.Clear();
            TXTPL.Focus();
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
