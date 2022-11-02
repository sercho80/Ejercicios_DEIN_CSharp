using System;
using System.Windows.Forms;

namespace Ejercicios_DEIN_CSharp.Forms
{
    public partial class Comprobar_Valores : Form
    {
        Form parentFrm;
        public Comprobar_Valores(Form parentFrm)
        {
            this.parentFrm = parentFrm;
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            lblCondicion.Text = txtAprobado.Text.ToUpper().Contains("A") ? "Aprobado" : "Suspendido";
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            if (txtA.Text == String.Empty || txtB.Text == String.Empty || txtC.Text == String.Empty)
                return;

            if (txtA.Text.Equals(txtB.Text) && txtA.Text.Equals(txtC.Text))
            {
                lblABCResul.Text = "A, B y C son iguales";
            }
            else if (txtA.Text.Equals(txtB.Text))
            {
                lblABCResul.Text = "A y B son iguales";
            }
            else if (txtA.Text.Equals(txtC.Text))
            {
                lblABCResul.Text = "A y C son iguales";
            }
            else if (txtB.Text.Equals(txtC.Text))
            {
                lblABCResul.Text = "B y C son iguales";
            }
            else
            {
                lblABCResul.Text = "A, B y C son diferentes";
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
