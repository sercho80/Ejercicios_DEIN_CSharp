using System;
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
            try
            {
                res.Text = (Convert.ToDouble(txtN1.Text) + Convert.ToDouble(txtN2.Text)).ToString();
            }
            catch (Exception ex)
            {
                notNumber(ex);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                res.Text = (Convert.ToDouble(txtN1.Text) - Convert.ToDouble(txtN2.Text)).ToString();
            }
            catch (Exception ex)
            {
                notNumber(ex);
            }
        }

        private void notNumber(Exception ex)
        {
            MessageBox.Show($"Uno de los campos no es un numero:\n\n{ex}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            parentFrm.Show();
            this.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            btnSalir.PerformClick();
        }
    }
}
