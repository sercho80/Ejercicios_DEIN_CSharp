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
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            txtAltura2.Text = txtAltura.Text;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            txtArea.Text = ((Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtBase.Text)) / 2).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            parentFrm.Show();
            this.Dispose();
        }
    }
}
