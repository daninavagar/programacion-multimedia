using System;
using System.Windows.Forms;

namespace Primer_ventana
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
            this.button1Suma = new System.Windows.Forms.Button();
            this.textBox1Titulo = new System.Windows.Forms.TextBox();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.label1Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Resta = new System.Windows.Forms.Button();
            this.button2Multiplicacion = new System.Windows.Forms.Button();
            this.button3Division = new System.Windows.Forms.Button();
            this.button1Borrar = new System.Windows.Forms.Button();
            this.button1_POTENCIA = new System.Windows.Forms.Button();
            this.button1_RAIZ_CUADRADA = new System.Windows.Forms.Button();
            this.button2_FACTORIAL = new System.Windows.Forms.Button();
            this.button1_RAIZ_CUBICA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Suma
            // 
            this.button1Suma.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.button1Suma, "button1Suma");
            this.button1Suma.Name = "button1Suma";
            this.button1Suma.UseVisualStyleBackColor = false;
            this.button1Suma.Click += new System.EventHandler(this.button1Suma_Click);
            // 
            // textBox1Titulo
            // 
            this.textBox1Titulo.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1Titulo, "textBox1Titulo");
            this.textBox1Titulo.Name = "textBox1Titulo";
            // 
            // textBoxNumero1
            // 
            resources.ApplyResources(this.textBoxNumero1, "textBoxNumero1");
            this.textBoxNumero1.Name = "textBoxNumero1";
            // 
            // textBoxNumero2
            // 
            resources.ApplyResources(this.textBoxNumero2, "textBoxNumero2");
            this.textBoxNumero2.Name = "textBoxNumero2";
            // 
            // label1Resultado
            // 
            resources.ApplyResources(this.label1Resultado, "label1Resultado");
            this.label1Resultado.Name = "label1Resultado";
            this.label1Resultado.Click += new System.EventHandler(this.label1Resultado_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1Resta
            // 
            this.button1Resta.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.button1Resta, "button1Resta");
            this.button1Resta.Name = "button1Resta";
            this.button1Resta.UseVisualStyleBackColor = false;
            this.button1Resta.Click += new System.EventHandler(this.button1Resta_Click);
            // 
            // button2Multiplicacion
            // 
            this.button2Multiplicacion.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.button2Multiplicacion, "button2Multiplicacion");
            this.button2Multiplicacion.Name = "button2Multiplicacion";
            this.button2Multiplicacion.UseVisualStyleBackColor = false;
            this.button2Multiplicacion.Click += new System.EventHandler(this.button1Multiplicacion_Click);
            // 
            // button3Division
            // 
            this.button3Division.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.button3Division, "button3Division");
            this.button3Division.Name = "button3Division";
            this.button3Division.UseVisualStyleBackColor = false;
            this.button3Division.Click += new System.EventHandler(this.button1Division_Click);
            // 
            // button1Borrar
            // 
            this.button1Borrar.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.button1Borrar, "button1Borrar");
            this.button1Borrar.Name = "button1Borrar";
            this.button1Borrar.UseVisualStyleBackColor = false;
            this.button1Borrar.Click += new System.EventHandler(this.button1Borrar_Click);
            // 
            // button1_POTENCIA
            // 
            resources.ApplyResources(this.button1_POTENCIA, "button1_POTENCIA");
            this.button1_POTENCIA.Name = "button1_POTENCIA";
            this.button1_POTENCIA.UseVisualStyleBackColor = true;
            this.button1_POTENCIA.Click += new System.EventHandler(this.button1_POTENCIA_Click);
            // 
            // button1_RAIZ_CUADRADA
            // 
            resources.ApplyResources(this.button1_RAIZ_CUADRADA, "button1_RAIZ_CUADRADA");
            this.button1_RAIZ_CUADRADA.Name = "button1_RAIZ_CUADRADA";
            this.button1_RAIZ_CUADRADA.UseVisualStyleBackColor = true;
            this.button1_RAIZ_CUADRADA.Click += new System.EventHandler(this.button1_RAIZ_CUADRADA_Click);
            // 
            // button2_FACTORIAL
            // 
            resources.ApplyResources(this.button2_FACTORIAL, "button2_FACTORIAL");
            this.button2_FACTORIAL.Name = "button2_FACTORIAL";
            this.button2_FACTORIAL.UseVisualStyleBackColor = true;
            this.button2_FACTORIAL.Click += new System.EventHandler(this.button2_FACTORIAL_Click);
            // 
            // button1_RAIZ_CUBICA
            // 
            resources.ApplyResources(this.button1_RAIZ_CUBICA, "button1_RAIZ_CUBICA");
            this.button1_RAIZ_CUBICA.Name = "button1_RAIZ_CUBICA";
            this.button1_RAIZ_CUBICA.UseVisualStyleBackColor = true;
            this.button1_RAIZ_CUBICA.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button1_RAIZ_CUBICA);
            this.Controls.Add(this.button2_FACTORIAL);
            this.Controls.Add(this.button1_RAIZ_CUADRADA);
            this.Controls.Add(this.button1_POTENCIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Resultado);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.textBox1Titulo);
            this.Controls.Add(this.button1Borrar);
            this.Controls.Add(this.button3Division);
            this.Controls.Add(this.button2Multiplicacion);
            this.Controls.Add(this.button1Resta);
            this.Controls.Add(this.button1Suma);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1Resultado_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.Button button1Suma;
        private System.Windows.Forms.TextBox textBox1Titulo;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label label1Resultado;
        private Label label1;
        private Label label2;
        private Button button1Resta;
        private Button button2Multiplicacion;
        private Button button3Division;
        private Button button1Borrar;
        private Button button1_POTENCIA;
        private Button button1_RAIZ_CUADRADA;
        private Button button2_FACTORIAL;
        private Button button1_RAIZ_CUBICA;
    }
}

