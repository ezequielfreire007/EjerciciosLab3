namespace Aplicacion._04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstNumero = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar un nuevo número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(24, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Tag = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(130, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstNumero);
            this.groupBox2.Location = new System.Drawing.Point(262, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Números";
            // 
            // lstNumero
            // 
            this.lstNumero.FormattingEnabled = true;
            this.lstNumero.Location = new System.Drawing.Point(6, 19);
            this.lstNumero.Name = "lstNumero";
            this.lstNumero.Size = new System.Drawing.Size(188, 186);
            this.lstNumero.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDescendente);
            this.groupBox3.Controls.Add(this.rdbAscendente);
            this.groupBox3.Controls.Add(this.btnOrdenar);
            this.groupBox3.Location = new System.Drawing.Point(22, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orden";
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(24, 53);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdbDescendente.TabIndex = 4;
            this.rdbDescendente.TabStop = true;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Location = new System.Drawing.Point(24, 30);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rdbAscendente.TabIndex = 3;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(130, 40);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Aplicacion._04.Properties.Resources.puerta_3_2;
            this.button3.Location = new System.Drawing.Point(492, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 84);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 253);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ordenamiento por Burbujeo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.RadioButton rdbAscendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstNumero;
    }
}

