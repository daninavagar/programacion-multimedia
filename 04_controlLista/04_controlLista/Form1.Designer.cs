namespace _04_controlLista
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
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Edad = new System.Windows.Forms.TextBox();
            this.label1_Nombre = new System.Windows.Forms.Label();
            this.labe_Edad = new System.Windows.Forms.Label();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.listViewPersonas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(133, 63);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // textBox_Edad
            // 
            this.textBox_Edad.Location = new System.Drawing.Point(133, 116);
            this.textBox_Edad.Name = "textBox_Edad";
            this.textBox_Edad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Edad.TabIndex = 1;
            // 
            // label1_Nombre
            // 
            this.label1_Nombre.AutoSize = true;
            this.label1_Nombre.Location = new System.Drawing.Point(54, 65);
            this.label1_Nombre.Name = "label1_Nombre";
            this.label1_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label1_Nombre.TabIndex = 2;
            this.label1_Nombre.Text = "Nombre";
            // 
            // labe_Edad
            // 
            this.labe_Edad.AutoSize = true;
            this.labe_Edad.Location = new System.Drawing.Point(56, 125);
            this.labe_Edad.Name = "labe_Edad";
            this.labe_Edad.Size = new System.Drawing.Size(32, 13);
            this.labe_Edad.TabIndex = 3;
            this.labe_Edad.Text = "Edad";
            // 
            // button_Insertar
            // 
            this.button_Insertar.Location = new System.Drawing.Point(362, 65);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(121, 77);
            this.button_Insertar.TabIndex = 4;
            this.button_Insertar.Text = "Insertar";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(56, 172);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(35, 13);
            this.label_Resultado.TabIndex = 5;
            this.label_Resultado.Text = "label1";
            // 
            // listViewPersonas
            // 
            this.listViewPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPersonas.Location = new System.Drawing.Point(334, 172);
            this.listViewPersonas.Name = "listViewPersonas";
            this.listViewPersonas.Size = new System.Drawing.Size(636, 261);
            this.listViewPersonas.TabIndex = 6;
            this.listViewPersonas.UseCompatibleStateImageBehavior = false;
            this.listViewPersonas.View = System.Windows.Forms.View.Details;
            this.listViewPersonas.SelectedIndexChanged += new System.EventHandler(this.listViewPersonas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Edad";
            this.columnHeader2.Width = 99;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(527, 65);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(121, 77);
            this.buttonBorrar.TabIndex = 7;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonVaciar
            // 
            this.buttonVaciar.Location = new System.Drawing.Point(682, 65);
            this.buttonVaciar.Name = "buttonVaciar";
            this.buttonVaciar.Size = new System.Drawing.Size(121, 77);
            this.buttonVaciar.TabIndex = 8;
            this.buttonVaciar.Text = "Vaciar";
            this.buttonVaciar.UseVisualStyleBackColor = true;
            this.buttonVaciar.Click += new System.EventHandler(this.buttonVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 469);
            this.Controls.Add(this.buttonVaciar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.listViewPersonas);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.button_Insertar);
            this.Controls.Add(this.labe_Edad);
            this.Controls.Add(this.label1_Nombre);
            this.Controls.Add(this.textBox_Edad);
            this.Controls.Add(this.textBox_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Edad;
        private System.Windows.Forms.Label label1_Nombre;
        private System.Windows.Forms.Label labe_Edad;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.ListView listViewPersonas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonVaciar;
    }
}

