
namespace Formularios
{
    partial class FrmHistorialPilotos
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
            this.lstPilotos = new System.Windows.Forms.ListBox();
            this.lblListaPilotos = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAgregarPiloto = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPilotos
            // 
            this.lstPilotos.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPilotos.FormattingEnabled = true;
            this.lstPilotos.ItemHeight = 16;
            this.lstPilotos.Location = new System.Drawing.Point(12, 42);
            this.lstPilotos.Name = "lstPilotos";
            this.lstPilotos.Size = new System.Drawing.Size(799, 372);
            this.lstPilotos.TabIndex = 3;
            // 
            // lblListaPilotos
            // 
            this.lblListaPilotos.AutoSize = true;
            this.lblListaPilotos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaPilotos.Location = new System.Drawing.Point(164, 7);
            this.lblListaPilotos.Name = "lblListaPilotos";
            this.lblListaPilotos.Size = new System.Drawing.Size(231, 30);
            this.lblListaPilotos.TabIndex = 4;
            this.lblListaPilotos.Text = "HISTORIAL DE PILOTOS";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(28, 420);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(230, 32);
            this.btnEstadisticas.TabIndex = 7;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAgregarPiloto
            // 
            this.btnAgregarPiloto.Location = new System.Drawing.Point(296, 420);
            this.btnAgregarPiloto.Name = "btnAgregarPiloto";
            this.btnAgregarPiloto.Size = new System.Drawing.Size(230, 32);
            this.btnAgregarPiloto.TabIndex = 8;
            this.btnAgregarPiloto.Text = "Agregar piloto a la lista actual";
            this.btnAgregarPiloto.UseVisualStyleBackColor = true;
            this.btnAgregarPiloto.Click += new System.EventHandler(this.btnAgregarPiloto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(563, 420);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 32);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar piloto del historial";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmHistorialPilotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 458);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarPiloto);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lblListaPilotos);
            this.Controls.Add(this.lstPilotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorialPilotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Pilotos";
            this.Load += new System.EventHandler(this.FrmHistorialPilotos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPilotos;
        private System.Windows.Forms.Label lblListaPilotos;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAgregarPiloto;
        private System.Windows.Forms.Button btnEditar;
    }
}