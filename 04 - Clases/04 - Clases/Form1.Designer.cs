namespace _04___Clases
{
    partial class Form1
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
            this.buttonCirculo = new System.Windows.Forms.Button();
            this.label1Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCirculo
            // 
            this.buttonCirculo.Location = new System.Drawing.Point(70, 54);
            this.buttonCirculo.Name = "buttonCirculo";
            this.buttonCirculo.Size = new System.Drawing.Size(202, 81);
            this.buttonCirculo.TabIndex = 0;
            this.buttonCirculo.Text = "CrearCirculo";
            this.buttonCirculo.UseVisualStyleBackColor = true;
            this.buttonCirculo.Click += new System.EventHandler(this.buttonCirculo_Click);
            // 
            // label1Resultado
            // 
            this.label1Resultado.AutoSize = true;
            this.label1Resultado.Location = new System.Drawing.Point(344, 82);
            this.label1Resultado.Name = "label1Resultado";
            this.label1Resultado.Size = new System.Drawing.Size(144, 24);
            this.label1Resultado.TabIndex = 1;
            this.label1Resultado.Text = "El resultado es: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 482);
            this.Controls.Add(this.label1Resultado);
            this.Controls.Add(this.buttonCirculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCirculo;
        private System.Windows.Forms.Label label1Resultado;
    }
}

