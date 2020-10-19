namespace Facturacion2
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
            this.CTR_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CTR_btn
            // 
            this.CTR_btn.Location = new System.Drawing.Point(171, 150);
            this.CTR_btn.Name = "CTR_btn";
            this.CTR_btn.Size = new System.Drawing.Size(131, 43);
            this.CTR_btn.TabIndex = 0;
            this.CTR_btn.Text = "Conexion";
            this.CTR_btn.UseVisualStyleBackColor = true;
            this.CTR_btn.Click += new System.EventHandler(this.CTR_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 256);
            this.Controls.Add(this.CTR_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CTR_btn;
    }
}

