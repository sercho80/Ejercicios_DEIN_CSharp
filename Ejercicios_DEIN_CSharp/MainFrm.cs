using System;
using System.Windows.Forms;
using Ejercicios_DEIN_CSharp.Forms;

namespace Ejercicios_DEIN_CSharp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Area_Triangulo areafrm = new Area_Triangulo(this);
            areafrm.Show();
            this.Hide();
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            Comprobar_Valores valoresfrm = new Comprobar_Valores(this);
            valoresfrm.Show();
            this.Hide();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma_Numeros numerosfrm = new Suma_Numeros(this);
            numerosfrm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
