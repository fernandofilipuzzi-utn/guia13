namespace Parte3
{
    partial class FormVerResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 20;
            this.lbResultados.Location = new System.Drawing.Point(11, 14);
            this.lbResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(339, 284);
            this.lbResultados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.Location = new System.Drawing.Point(122, 308);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormVerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 350);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbResultados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVerResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormVerResultados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.ListBox lbResultados;
    }
}