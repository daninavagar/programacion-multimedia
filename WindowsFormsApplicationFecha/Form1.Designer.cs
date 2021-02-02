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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1DIA = new System.Windows.Forms.Button();
            this.buttonMES = new System.Windows.Forms.Button();
            this.buttonAÑO = new System.Windows.Forms.Button();
            this.label1Texto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Dia = new System.Windows.Forms.TextBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2Texto = new System.Windows.Forms.Label();
            this.textBox2CambiarAño = new System.Windows.Forms.TextBox();
            this.textBoxCambiarMes = new System.Windows.Forms.TextBox();
            this.textBoxCambiarDia = new System.Windows.Forms.TextBox();
            this.button1DiaSiguiente = new System.Windows.Forms.Button();
            this.buttonENVIAR = new System.Windows.Forms.Button();
            this.labelSALIDA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1DIA
            // 
            resources.ApplyResources(this.button1DIA, "button1DIA");
            this.button1DIA.Name = "button1DIA";
            this.button1DIA.UseVisualStyleBackColor = true;
            this.button1DIA.Click += new System.EventHandler(this.button1DIA_Click);
            // 
            // buttonMES
            // 
            resources.ApplyResources(this.buttonMES, "buttonMES");
            this.buttonMES.Name = "buttonMES";
            this.buttonMES.UseVisualStyleBackColor = true;
            this.buttonMES.Click += new System.EventHandler(this.buttonMES_Click);
            // 
            // buttonAÑO
            // 
            resources.ApplyResources(this.buttonAÑO, "buttonAÑO");
            this.buttonAÑO.Name = "buttonAÑO";
            this.buttonAÑO.UseVisualStyleBackColor = true;
            this.buttonAÑO.Click += new System.EventHandler(this.buttonAÑO_Click);
            // 
            // label1Texto
            // 
            resources.ApplyResources(this.label1Texto, "label1Texto");
            this.label1Texto.Name = "label1Texto";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1Dia
            // 
            resources.ApplyResources(this.textBox1Dia, "textBox1Dia");
            this.textBox1Dia.Name = "textBox1Dia";
            // 
            // textBoxMes
            // 
            resources.ApplyResources(this.textBoxMes, "textBoxMes");
            this.textBoxMes.Name = "textBoxMes";
            // 
            // textBoxAño
            // 
            resources.ApplyResources(this.textBoxAño, "textBoxAño");
            this.textBoxAño.Name = "textBoxAño";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2Texto
            // 
            resources.ApplyResources(this.label2Texto, "label2Texto");
            this.label2Texto.Name = "label2Texto";
            // 
            // textBox2CambiarAño
            // 
            resources.ApplyResources(this.textBox2CambiarAño, "textBox2CambiarAño");
            this.textBox2CambiarAño.Name = "textBox2CambiarAño";
            // 
            // textBoxCambiarMes
            // 
            resources.ApplyResources(this.textBoxCambiarMes, "textBoxCambiarMes");
            this.textBoxCambiarMes.Name = "textBoxCambiarMes";
            // 
            // textBoxCambiarDia
            // 
            resources.ApplyResources(this.textBoxCambiarDia, "textBoxCambiarDia");
            this.textBoxCambiarDia.Name = "textBoxCambiarDia";
            // 
            // button1DiaSiguiente
            // 
            resources.ApplyResources(this.button1DiaSiguiente, "button1DiaSiguiente");
            this.button1DiaSiguiente.Name = "button1DiaSiguiente";
            this.button1DiaSiguiente.UseVisualStyleBackColor = true;
            this.button1DiaSiguiente.Click += new System.EventHandler(this.button1DiaSiguiente_Click);
            // 
            // buttonENVIAR
            // 
            resources.ApplyResources(this.buttonENVIAR, "buttonENVIAR");
            this.buttonENVIAR.Name = "buttonENVIAR";
            this.buttonENVIAR.UseVisualStyleBackColor = true;
            this.buttonENVIAR.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // labelSALIDA
            // 
            this.labelSALIDA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.labelSALIDA, "labelSALIDA");
            this.labelSALIDA.Name = "labelSALIDA";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.labelSALIDA);
            this.Controls.Add(this.textBox2CambiarAño);
            this.Controls.Add(this.textBoxCambiarMes);
            this.Controls.Add(this.textBoxCambiarDia);
            this.Controls.Add(this.label2Texto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBox1Dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Texto);
            this.Controls.Add(this.buttonAÑO);
            this.Controls.Add(this.buttonMES);
            this.Controls.Add(this.button1DIA);
            this.Controls.Add(this.button1DiaSiguiente);
            this.Controls.Add(this.buttonENVIAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1DIA;
        private System.Windows.Forms.Button buttonMES;
        private System.Windows.Forms.Button buttonAÑO;
        private System.Windows.Forms.Label label1Texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Dia;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2Texto;
        private System.Windows.Forms.TextBox textBox2CambiarAño;
        private System.Windows.Forms.TextBox textBoxCambiarMes;
        private System.Windows.Forms.TextBox textBoxCambiarDia;
        private System.Windows.Forms.Button button1DiaSiguiente;
        private System.Windows.Forms.Button buttonENVIAR;
        private System.Windows.Forms.Label labelSALIDA;
    }
}

