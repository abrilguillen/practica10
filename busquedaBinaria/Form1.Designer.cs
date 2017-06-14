namespace busquedaBinaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamanioVector = new System.Windows.Forms.TextBox();
            this.cmdLlenar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cmdBusquedaBinaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño:";
            // 
            // txtTamanioVector
            // 
            this.txtTamanioVector.Location = new System.Drawing.Point(138, 47);
            this.txtTamanioVector.Name = "txtTamanioVector";
            this.txtTamanioVector.Size = new System.Drawing.Size(100, 20);
            this.txtTamanioVector.TabIndex = 1;
            // 
            // cmdLlenar
            // 
            this.cmdLlenar.Location = new System.Drawing.Point(48, 84);
            this.cmdLlenar.Name = "cmdLlenar";
            this.cmdLlenar.Size = new System.Drawing.Size(75, 23);
            this.cmdLlenar.TabIndex = 2;
            this.cmdLlenar.Text = "Llenar";
            this.cmdLlenar.UseVisualStyleBackColor = true;
            this.cmdLlenar.Click += new System.EventHandler(this.cmdLlenar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(48, 113);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(147, 84);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(100, 118);
            this.txtMostrar.TabIndex = 4;
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Location = new System.Drawing.Point(48, 142);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenar.TabIndex = 5;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // cmdBusquedaBinaria
            // 
            this.cmdBusquedaBinaria.Location = new System.Drawing.Point(48, 171);
            this.cmdBusquedaBinaria.Name = "cmdBusquedaBinaria";
            this.cmdBusquedaBinaria.Size = new System.Drawing.Size(75, 23);
            this.cmdBusquedaBinaria.TabIndex = 6;
            this.cmdBusquedaBinaria.Text = "Búsqueda binaria";
            this.cmdBusquedaBinaria.UseVisualStyleBackColor = true;
            this.cmdBusquedaBinaria.Click += new System.EventHandler(this.cmdBusquedaBinaria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdBusquedaBinaria);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdLlenar);
            this.Controls.Add(this.txtTamanioVector);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamanioVector;
        private System.Windows.Forms.Button cmdLlenar;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.Button cmdBusquedaBinaria;
    }
}

