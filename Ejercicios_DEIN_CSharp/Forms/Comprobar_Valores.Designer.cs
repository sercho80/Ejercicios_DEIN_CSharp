
namespace Ejercicios_DEIN_CSharp.Forms
{
    partial class Comprobar_Valores
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
            this.txtAprobado = new System.Windows.Forms.TextBox();
            this.btnAprobado = new System.Windows.Forms.Button();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnABC = new System.Windows.Forms.Button();
            this.lblABCResul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAprobado
            // 
            this.txtAprobado.Location = new System.Drawing.Point(12, 41);
            this.txtAprobado.Name = "txtAprobado";
            this.txtAprobado.Size = new System.Drawing.Size(100, 20);
            this.txtAprobado.TabIndex = 0;
            // 
            // btnAprobado
            // 
            this.btnAprobado.Location = new System.Drawing.Point(22, 76);
            this.btnAprobado.Name = "btnAprobado";
            this.btnAprobado.Size = new System.Drawing.Size(75, 23);
            this.btnAprobado.TabIndex = 1;
            this.btnAprobado.Text = "Comprobar";
            this.btnAprobado.UseVisualStyleBackColor = true;
            this.btnAprobado.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(52, 115);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(0, 13);
            this.lblCondicion.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(100, 173);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Aprobado?";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(198, 77);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(105, 20);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(198, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(105, 20);
            this.txtB.TabIndex = 8;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(198, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(105, 20);
            this.txtA.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "C";
            // 
            // btnABC
            // 
            this.btnABC.Location = new System.Drawing.Point(164, 132);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(139, 23);
            this.btnABC.TabIndex = 13;
            this.btnABC.Text = "Comprobar numeros";
            this.btnABC.UseVisualStyleBackColor = true;
            this.btnABC.Click += new System.EventHandler(this.btnABC_Click);
            // 
            // lblABCResul
            // 
            this.lblABCResul.AutoSize = true;
            this.lblABCResul.Location = new System.Drawing.Point(195, 108);
            this.lblABCResul.Name = "lblABCResul";
            this.lblABCResul.Size = new System.Drawing.Size(0, 13);
            this.lblABCResul.TabIndex = 14;
            // 
            // Comprobar_Valores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 218);
            this.Controls.Add(this.lblABCResul);
            this.Controls.Add(this.btnABC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.btnAprobado);
            this.Controls.Add(this.txtAprobado);
            this.Name = "Comprobar_Valores";
            this.Text = "Comprobar Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAprobado;
        private System.Windows.Forms.Button btnAprobado;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Label lblABCResul;
    }
}

