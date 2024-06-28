namespace Parte4
{
    partial class FormDespacho
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTipoEnvio = new System.Windows.Forms.CheckBox();
            this.tbPesoEnGramos = new System.Windows.Forms.TextBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(222, 230);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(40, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkTipoEnvio);
            this.groupBox1.Controls.Add(this.tbPesoEnGramos);
            this.groupBox1.Controls.Add(this.tbCodigoPostal);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(364, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbEmpresa.Location = new System.Drawing.Point(182, 122);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(148, 21);
            this.cbEmpresa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso en gramos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código Postal";
            // 
            // chkTipoEnvio
            // 
            this.chkTipoEnvio.AutoSize = true;
            this.chkTipoEnvio.Location = new System.Drawing.Point(186, 171);
            this.chkTipoEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTipoEnvio.Name = "chkTipoEnvio";
            this.chkTipoEnvio.Size = new System.Drawing.Size(97, 17);
            this.chkTipoEnvio.TabIndex = 3;
            this.chkTipoEnvio.Text = "Es Certificada?";
            this.chkTipoEnvio.UseVisualStyleBackColor = true;
            // 
            // tbPesoEnGramos
            // 
            this.tbPesoEnGramos.Location = new System.Drawing.Point(182, 83);
            this.tbPesoEnGramos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPesoEnGramos.Name = "tbPesoEnGramos";
            this.tbPesoEnGramos.Size = new System.Drawing.Size(148, 20);
            this.tbPesoEnGramos.TabIndex = 1;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(182, 43);
            this.tbCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(148, 20);
            this.tbCodigoPostal.TabIndex = 0;
            // 
            // FormDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDespacho";
            this.Text = "FormDespacho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox chkTipoEnvio;
        public System.Windows.Forms.TextBox tbPesoEnGramos;
        public System.Windows.Forms.TextBox tbCodigoPostal;
    }
}