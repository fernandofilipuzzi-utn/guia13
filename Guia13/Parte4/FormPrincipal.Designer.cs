﻿namespace Parte4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEmpresaResumen = new System.Windows.Forms.TextBox();
            this.btnVerResultadosPorLote = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnVerResumenFinal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbEmpresaResumen);
            this.groupBox1.Controls.Add(this.btnVerResultadosPorLote);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(432, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Empresa de distribución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de empresa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Preparar Distribución";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmpresaResumen
            // 
            this.tbEmpresaResumen.Location = new System.Drawing.Point(201, 35);
            this.tbEmpresaResumen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbEmpresaResumen.Name = "tbEmpresaResumen";
            this.tbEmpresaResumen.Size = new System.Drawing.Size(220, 26);
            this.tbEmpresaResumen.TabIndex = 5;
            // 
            // btnVerResultadosPorLote
            // 
            this.btnVerResultadosPorLote.Location = new System.Drawing.Point(50, 77);
            this.btnVerResultadosPorLote.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVerResultadosPorLote.Name = "btnVerResultadosPorLote";
            this.btnVerResultadosPorLote.Size = new System.Drawing.Size(109, 57);
            this.btnVerResultadosPorLote.TabIndex = 4;
            this.btnVerResultadosPorLote.Text = "Ver Resultados";
            this.btnVerResultadosPorLote.UseVisualStyleBackColor = true;
            this.btnVerResultadosPorLote.Click += new System.EventHandler(this.btnVerResultadosPorLote_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(33, 14);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(163, 57);
            this.btnAtender.TabIndex = 6;
            this.btnAtender.Text = "Atención al Cliente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnVerResumenFinal
            // 
            this.btnVerResumenFinal.Location = new System.Drawing.Point(216, 14);
            this.btnVerResumenFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerResumenFinal.Name = "btnVerResumenFinal";
            this.btnVerResumenFinal.Size = new System.Drawing.Size(210, 57);
            this.btnVerResumenFinal.TabIndex = 8;
            this.btnVerResumenFinal.Text = "Ver resumen final";
            this.btnVerResumenFinal.UseVisualStyleBackColor = true;
            this.btnVerResumenFinal.Click += new System.EventHandler(this.btnVerResumenFinal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbIdentificador);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(13, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(434, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar correspondencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número identificación";
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(179, 52);
            this.tbIdentificador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(205, 26);
            this.tbIdentificador.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(196, 88);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerResumenFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtender);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEmpresaResumen;
        private System.Windows.Forms.Button btnVerResultadosPorLote;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerResumenFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Button btnBuscar;
    }
}

