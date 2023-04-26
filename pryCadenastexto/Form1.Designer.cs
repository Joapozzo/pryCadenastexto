namespace pryCadenastexto
{
    partial class frmCadenas
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
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.txtTex = new System.Windows.Forms.TextBox();
            this.btnUppercase = new System.Windows.Forms.Button();
            this.btnSinespacios = new System.Windows.Forms.Button();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.btnMayorMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Location = new System.Drawing.Point(175, 28);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(75, 23);
            this.btnLowerCase.TabIndex = 0;
            this.btnLowerCase.Text = "Minusculas";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // txtTex
            // 
            this.txtTex.Location = new System.Drawing.Point(29, 28);
            this.txtTex.Name = "txtTex";
            this.txtTex.Size = new System.Drawing.Size(100, 22);
            this.txtTex.TabIndex = 1;
            // 
            // btnUppercase
            // 
            this.btnUppercase.Location = new System.Drawing.Point(175, 75);
            this.btnUppercase.Name = "btnUppercase";
            this.btnUppercase.Size = new System.Drawing.Size(75, 23);
            this.btnUppercase.TabIndex = 3;
            this.btnUppercase.Text = "Mayusculas";
            this.btnUppercase.UseVisualStyleBackColor = true;
            this.btnUppercase.Click += new System.EventHandler(this.btnUppercase_Click);
            // 
            // btnSinespacios
            // 
            this.btnSinespacios.Location = new System.Drawing.Point(175, 121);
            this.btnSinespacios.Name = "btnSinespacios";
            this.btnSinespacios.Size = new System.Drawing.Size(75, 23);
            this.btnSinespacios.TabIndex = 4;
            this.btnSinespacios.Text = "Sin espacios";
            this.btnSinespacios.UseVisualStyleBackColor = true;
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(29, 75);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(100, 22);
            this.txtText2.TabIndex = 5;
            // 
            // btnMayorMenor
            // 
            this.btnMayorMenor.Location = new System.Drawing.Point(175, 159);
            this.btnMayorMenor.Name = "btnMayorMenor";
            this.btnMayorMenor.Size = new System.Drawing.Size(75, 23);
            this.btnMayorMenor.TabIndex = 6;
            this.btnMayorMenor.Text = "><";
            this.btnMayorMenor.UseVisualStyleBackColor = true;
            this.btnMayorMenor.Click += new System.EventHandler(this.btnMayorMenor_Click);
            // 
            // frmCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 224);
            this.Controls.Add(this.btnMayorMenor);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.btnSinespacios);
            this.Controls.Add(this.btnUppercase);
            this.Controls.Add(this.txtTex);
            this.Controls.Add(this.btnLowerCase);
            this.Name = "frmCadenas";
            this.Text = "Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.TextBox txtTex;
        private System.Windows.Forms.Button btnUppercase;
        private System.Windows.Forms.Button btnSinespacios;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Button btnMayorMenor;
    }
}

