using System;
using System.Windows.Forms;

namespace Ejercicios_DEIN_CSharp.Forms
{
    public partial class Area_Triangulo : Form
    {
        Form parentFrm;
        public Area_Triangulo(Form parentFrm)
        {
            this.parentFrm = parentFrm;
            InitializeComponent();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            txtBase2.Text = txtBase.Text;
            txtArea.Text = String.Empty;
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            txtAltura2.Text = txtAltura.Text;
            txtArea.Text = String.Empty;
        }

        private void notNumber(Exception ex)
        {
            MessageBox.Show($"Uno de los campos no es un numero:\n\n{ex}");
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                txtArea.Text = ((Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtBase.Text)) / 2).ToString();
            }
            catch (Exception ex)
            {
                notNumber(ex);
            }
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
