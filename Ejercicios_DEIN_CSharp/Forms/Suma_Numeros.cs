using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ejercicios_DEIN_CSharp.Forms
{
    public partial class Suma_Numeros : Form
    {
        Form parentFrm;
        public Suma_Numeros(Form parentFrm)
        {
            this.parentFrm = parentFrm;
            InitializeComponent();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            res.Text = (Convert.ToDouble(txtN1.Text) + Convert.ToDouble(txtN2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            res.Text = (Convert.ToDouble(txtN1.Text) - Convert.ToDouble(txtN2.Text)).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            parentFrm.Show();
            this.Dispose();
        }
    }
}
