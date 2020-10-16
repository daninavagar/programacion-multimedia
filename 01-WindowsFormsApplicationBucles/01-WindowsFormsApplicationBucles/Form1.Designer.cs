namespace _01_WindowsFormsApplicationBucles
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.button1Suma = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(91, 69);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(237, 20);
            this.textBoxNumero1.TabIndex = 1;
            this.textBoxNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(91, 153);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(237, 20);
            this.textBoxNumero2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(223, 299);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(29, 13);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "label";
            // 
            // button1Suma
            // 
            this.button1Suma.Location = new System.Drawing.Point(447, 60);
            this.button1Suma.Name = "button1Suma";
            this.button1Suma.Size = new System.Drawing.Size(132, 37);
            this.button1Suma.TabIndex = 0;
            this.button1Suma.Text = "SUMA";
            this.button1Suma.UseVisualStyleBackColor = true;
            this.button1Suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "RESTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "MULTIPLACION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "MOSTRAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 526);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button button1Suma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

