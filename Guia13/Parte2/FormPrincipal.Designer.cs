namespace Parte2
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
            this.btnVerResultadosPorLote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEmpresaResumen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtención
            // 
            this.btnAtención.Location = new System.Drawing.Point(207, 18);
            this.btnAtención.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtención.Name = "btnAtención";
            this.btnAtención.Size = new System.Drawing.Size(172, 83);
            this.btnAtención.TabIndex = 3;
            this.btnAtención.Text = "Atención al Cliente";
            this.btnAtención.UseVisualStyleBackColor = true;
            this.btnAtención.Click += new System.EventHandler(this.btnAtención_Click);
            // 
            // btnVerResultadosPorLote
            // 
            this.btnVerResultadosPorLote.Location = new System.Drawing.Point(189, 29);
            this.btnVerResultadosPorLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerResultadosPorLote.Name = "btnVerResultadosPorLote";
            this.btnVerResultadosPorLote.Size = new System.Drawing.Size(172, 83);
            this.btnVerResultadosPorLote.TabIndex = 4;
            this.btnVerResultadosPorLote.Text = "Ver Resultados";
            this.btnVerResultadosPorLote.UseVisualStyleBackColor = true;
            this.btnVerResultadosPorLote.Click += new System.EventHandler(this.btnVerResultadosPorLote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbEmpresaResumen);
            this.groupBox1.Controls.Add(this.btnVerResultadosPorLote);
            this.groupBox1.Location = new System.Drawing.Point(18, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(386, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Empresa de distribución";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "Preparar Distribución";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmpresaResumen
            // 
            this.tbEmpresaResumen.Location = new System.Drawing.Point(19, 57);
            this.tbEmpresaResumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmpresaResumen.Name = "tbEmpresaResumen";
            this.tbEmpresaResumen.Size = new System.Drawing.Size(148, 26);
            this.tbEmpresaResumen.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtención);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtención;
        private System.Windows.Forms.Button btnVerResultadosPorLote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmpresaResumen;
        private System.Windows.Forms.Button button1;
    }
}

