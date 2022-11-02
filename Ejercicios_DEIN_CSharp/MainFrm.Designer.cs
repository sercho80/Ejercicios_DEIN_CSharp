
namespace Ejercicios_DEIN_CSharp
{
    partial class MainFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArea = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(17, 44);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(112, 23);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Area Triangulo";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(135, 44);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(112, 23);
            this.btnValores.TabIndex = 1;
            this.btnValores.Text = "Comprobar Valores";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(253, 44);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(112, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Suma Numeros";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(152, 84);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(102, 13);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(173, 13);
            this.lblTxt.TabIndex = 4;
            this.lblTxt.Text = "Ejercicios DEIN en C# 2020 - 2021";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 128);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.btnArea);
            this.Name = "MainFrm";
            this.Text = "Ejercicios C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTxt;
    }
}

