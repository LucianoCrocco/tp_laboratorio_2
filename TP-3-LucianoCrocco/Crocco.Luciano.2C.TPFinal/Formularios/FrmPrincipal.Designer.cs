
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
            this.btnEscuderias = new System.Windows.Forms.Button();
            this.btnPilotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscuderias
            // 
            this.btnEscuderias.Location = new System.Drawing.Point(120, 110);
            this.btnEscuderias.Name = "btnEscuderias";
            this.btnEscuderias.Size = new System.Drawing.Size(75, 23);
            this.btnEscuderias.TabIndex = 0;
            this.btnEscuderias.Text = "Escuderias";
            this.btnEscuderias.UseVisualStyleBackColor = true;
            // 
            // btnPilotos
            // 
            this.btnPilotos.Location = new System.Drawing.Point(318, 110);
            this.btnPilotos.Name = "btnPilotos";
            this.btnPilotos.Size = new System.Drawing.Size(75, 23);
            this.btnPilotos.TabIndex = 1;
            this.btnPilotos.Text = "Pilotos";
            this.btnPilotos.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPilotos);
            this.Controls.Add(this.btnEscuderias);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEscuderias;
        private System.Windows.Forms.Button btnPilotos;
    }
}

