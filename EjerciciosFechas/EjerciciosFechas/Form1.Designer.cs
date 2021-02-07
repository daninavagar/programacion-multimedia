namespace EjerciciosFechas
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
            this.label1TITULO = new System.Windows.Forms.Label();
            this.label1Dia = new System.Windows.Forms.Label();
            this.label1Mes = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.label1Formato = new System.Windows.Forms.Label();
            this.labelSALIDA = new System.Windows.Forms.Label();
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.textBoxFormato = new System.Windows.Forms.TextBox();
            this.button1SALIDA = new System.Windows.Forms.Button();
            this.buttonBisiesto = new System.Windows.Forms.Button();
            this.buttonDiaSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1TITULO
            // 
            this.label1TITULO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1TITULO.AutoSize = true;
            this.label1TITULO.Font = new System.Drawing.Font("Segoe UI Historic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1TITULO.Location = new System.Drawing.Point(271, 9);
            this.label1TITULO.Name = "label1TITULO";
            this.label1TITULO.Size = new System.Drawing.Size(328, 47);
            this.label1TITULO.TabIndex = 0;
            this.label1TITULO.Text = "EJERCICIO FECHAS";
            this.label1TITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1Dia
            // 
            this.label1Dia.AutoSize = true;
            this.label1Dia.Location = new System.Drawing.Point(44, 89);
            this.label1Dia.Name = "label1Dia";
            this.label1Dia.Size = new System.Drawing.Size(59, 13);
            this.label1Dia.TabIndex = 1;
            this.label1Dia.Text = "Dime el dia";
            // 
            // label1Mes
            // 
            this.label1Mes.AutoSize = true;
            this.label1Mes.Location = new System.Drawing.Point(44, 120);
            this.label1Mes.Name = "label1Mes";
            this.label1Mes.Size = new System.Drawing.Size(64, 13);
            this.label1Mes.TabIndex = 1;
            this.label1Mes.Text = "Dime el mes";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Location = new System.Drawing.Point(44, 151);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(63, 13);
            this.labelAño.TabIndex = 1;
            this.labelAño.Text = "Dime el año";
            // 
            // label1Formato
            // 
            this.label1Formato.AutoSize = true;
            this.label1Formato.Location = new System.Drawing.Point(45, 184);
            this.label1Formato.Name = "label1Formato";
            this.label1Formato.Size = new System.Drawing.Size(80, 13);
            this.label1Formato.TabIndex = 1;
            this.label1Formato.Text = "Dime el formato";
            // 
            // labelSALIDA
            // 
            this.labelSALIDA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSALIDA.Location = new System.Drawing.Point(551, 222);
            this.labelSALIDA.Name = "labelSALIDA";
            this.labelSALIDA.Size = new System.Drawing.Size(296, 139);
            this.labelSALIDA.TabIndex = 2;
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(137, 86);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDia.TabIndex = 4;
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(137, 117);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(100, 20);
            this.textBoxMes.TabIndex = 4;
            // 
            // textBoxAño
            // 
            this.textBoxAño.Location = new System.Drawing.Point(137, 148);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(100, 20);
            this.textBoxAño.TabIndex = 4;
            // 
            // textBoxFormato
            // 
            this.textBoxFormato.Location = new System.Drawing.Point(137, 181);
            this.textBoxFormato.Name = "textBoxFormato";
            this.textBoxFormato.Size = new System.Drawing.Size(100, 20);
            this.textBoxFormato.TabIndex = 4;
            // 
            // button1SALIDA
            // 
            this.button1SALIDA.Location = new System.Drawing.Point(554, 174);
            this.button1SALIDA.Name = "button1SALIDA";
            this.button1SALIDA.Size = new System.Drawing.Size(146, 27);
            this.button1SALIDA.TabIndex = 5;
            this.button1SALIDA.Text = "MOSTRAR DATOS";
            this.button1SALIDA.UseVisualStyleBackColor = true;
            this.button1SALIDA.Click += new System.EventHandler(this.button1SALIDA_Click);
            // 
            // buttonBisiesto
            // 
            this.buttonBisiesto.Location = new System.Drawing.Point(552, 77);
            this.buttonBisiesto.Name = "buttonBisiesto";
            this.buttonBisiesto.Size = new System.Drawing.Size(148, 29);
            this.buttonBisiesto.TabIndex = 6;
            this.buttonBisiesto.Text = "BISIESTO?";
            this.buttonBisiesto.UseVisualStyleBackColor = true;
            this.buttonBisiesto.Click += new System.EventHandler(this.buttonBisiesto_Click);
            // 
            // buttonDiaSumar
            // 
            this.buttonDiaSumar.Location = new System.Drawing.Point(554, 120);
            this.buttonDiaSumar.Name = "buttonDiaSumar";
            this.buttonDiaSumar.Size = new System.Drawing.Size(146, 32);
            this.buttonDiaSumar.TabIndex = 7;
            this.buttonDiaSumar.Text = "SUMAR DIA";
            this.buttonDiaSumar.UseVisualStyleBackColor = true;
            this.buttonDiaSumar.Click += new System.EventHandler(this.buttonDiaSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 370);
            this.Controls.Add(this.buttonDiaSumar);
            this.Controls.Add(this.buttonBisiesto);
            this.Controls.Add(this.button1SALIDA);
            this.Controls.Add(this.textBoxFormato);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBoxDia);
            this.Controls.Add(this.labelSALIDA);
            this.Controls.Add(this.label1Formato);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.label1Mes);
            this.Controls.Add(this.label1Dia);
            this.Controls.Add(this.label1TITULO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1TITULO;
        private System.Windows.Forms.Label label1Dia;
        private System.Windows.Forms.Label label1Mes;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label label1Formato;
        private System.Windows.Forms.Label labelSALIDA;
        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBoxFormato;
        private System.Windows.Forms.Button button1SALIDA;
        private System.Windows.Forms.Button buttonBisiesto;
        private System.Windows.Forms.Button buttonDiaSumar;
    }
}

