﻿
namespace Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEscuderia = new System.Windows.Forms.Button();
            this.btnPilotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscuderia
            // 
            this.btnEscuderia.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEscuderia.Location = new System.Drawing.Point(12, 118);
            this.btnEscuderia.Name = "btnEscuderia";
            this.btnEscuderia.Size = new System.Drawing.Size(185, 84);
            this.btnEscuderia.TabIndex = 1;
            this.btnEscuderia.Text = "Escuderia";
            this.btnEscuderia.UseVisualStyleBackColor = true;
            this.btnEscuderia.Click += new System.EventHandler(this.btnEscuderia_Click);
            // 
            // btnPilotos
            // 
            this.btnPilotos.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPilotos.Location = new System.Drawing.Point(215, 118);
            this.btnPilotos.Name = "btnPilotos";
            this.btnPilotos.Size = new System.Drawing.Size(185, 84);
            this.btnPilotos.TabIndex = 2;
            this.btnPilotos.Text = "Pilotos";
            this.btnPilotos.UseVisualStyleBackColor = true;
            this.btnPilotos.Click += new System.EventHandler(this.btnPilotos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 214);
            this.Controls.Add(this.btnPilotos);
            this.Controls.Add(this.btnEscuderia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociacion Corredores Turismo Carretera";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscuderia;
        private System.Windows.Forms.Button btnPilotos;
    }
}

