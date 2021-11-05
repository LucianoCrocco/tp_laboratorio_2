
namespace Formularios
{
    partial class FrmPilotoEstadistica
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
            this.rchEstadisticas = new System.Windows.Forms.RichTextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchEstadisticas
            // 
            this.rchEstadisticas.Enabled = false;
            this.rchEstadisticas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchEstadisticas.Location = new System.Drawing.Point(9, 41);
            this.rchEstadisticas.Name = "rchEstadisticas";
            this.rchEstadisticas.Size = new System.Drawing.Size(593, 165);
            this.rchEstadisticas.TabIndex = 0;
            this.rchEstadisticas.Text = "";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(524, 12);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnMaximo
            // 
            this.btnMaximo.Location = new System.Drawing.Point(443, 12);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(75, 23);
            this.btnMaximo.TabIndex = 2;
            this.btnMaximo.Text = "Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Location = new System.Drawing.Point(362, 12);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(75, 23);
            this.btnMinimo.TabIndex = 3;
            this.btnMinimo.Text = "Minimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
            // 
            // FrmPilotoEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 240);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.rchEstadisticas);
            this.Name = "FrmPilotoEstadistica";
            this.Text = "FrmPilotoEstadistica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchEstadisticas;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnMinimo;
    }
}