namespace WindowsFormsApplicationFecha
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.Boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFecha.Location = new System.Drawing.Point(102, 58);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(165, 38);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "sdfsfsdf";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(490, 73);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(123, 23);
            this.Boton1.TabIndex = 1;
            this.Boton1.Text = "button1";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 385);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.labelFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button Boton1;
    }
}

