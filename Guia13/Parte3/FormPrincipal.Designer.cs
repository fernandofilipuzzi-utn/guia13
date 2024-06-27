namespace Parte3
{
    partial class FormPrincipal
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
            this.btnAtención = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtención
            // 
            this.btnAtención.Location = new System.Drawing.Point(216, 26);
            this.btnAtención.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtención.Name = "btnAtención";
            this.btnAtención.Size = new System.Drawing.Size(172, 83);
            this.btnAtención.TabIndex = 4;
            this.btnAtención.Text = "Atención al Cliente";
            this.btnAtención.UseVisualStyleBackColor = true;
            this.btnAtención.Click += new System.EventHandler(this.btnAtención_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 271);
            this.Controls.Add(this.btnAtención);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtención;
    }
}

