namespace WindowsApp
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
            this.btnCrearProductoyClienteIndividuo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProductoyClienteIndividuo
            // 
            this.btnCrearProductoyClienteIndividuo.Location = new System.Drawing.Point(154, 37);
            this.btnCrearProductoyClienteIndividuo.Name = "btnCrearProductoyClienteIndividuo";
            this.btnCrearProductoyClienteIndividuo.Size = new System.Drawing.Size(418, 168);
            this.btnCrearProductoyClienteIndividuo.TabIndex = 0;
            this.btnCrearProductoyClienteIndividuo.Text = "Crear Producto y Cliente Individuo";
            this.btnCrearProductoyClienteIndividuo.UseVisualStyleBackColor = true;
            this.btnCrearProductoyClienteIndividuo.Click += new System.EventHandler(this.btnCrearProductoyClienteIndividuo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearProductoyClienteIndividuo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProductoyClienteIndividuo;
    }
}

