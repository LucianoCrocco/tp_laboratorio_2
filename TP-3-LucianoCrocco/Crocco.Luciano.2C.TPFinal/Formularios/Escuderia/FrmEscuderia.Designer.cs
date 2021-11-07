
namespace Formularios
{
    partial class FrmEscuderia
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
            this.lstEscuderias = new System.Windows.Forms.ListBox();
            this.lblListaEscuderia = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnGenerarEscuderia = new System.Windows.Forms.Button();
            this.btnGuardarLista = new System.Windows.Forms.Button();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEscuderias
            // 
            this.lstEscuderias.FormattingEnabled = true;
            this.lstEscuderias.ItemHeight = 15;
            this.lstEscuderias.Location = new System.Drawing.Point(12, 52);
            this.lstEscuderias.Name = "lstEscuderias";
            this.lstEscuderias.Size = new System.Drawing.Size(647, 214);
            this.lstEscuderias.TabIndex = 3;
            // 
            // lblListaEscuderia
            // 
            this.lblListaEscuderia.AutoSize = true;
            this.lblListaEscuderia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaEscuderia.Location = new System.Drawing.Point(12, 9);
            this.lblListaEscuderia.Name = "lblListaEscuderia";
            this.lblListaEscuderia.Size = new System.Drawing.Size(483, 30);
            this.lblListaEscuderia.TabIndex = 4;
            this.lblListaEscuderia.Text = "LISTA DE ESCUDERIAS CARGADAS EN EL SISTEMA";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(665, 61);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(138, 45);
            this.btnEstadisticas.TabIndex = 7;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarEscuderia
            // 
            this.btnGenerarEscuderia.Location = new System.Drawing.Point(665, 112);
            this.btnGenerarEscuderia.Name = "btnGenerarEscuderia";
            this.btnGenerarEscuderia.Size = new System.Drawing.Size(138, 45);
            this.btnGenerarEscuderia.TabIndex = 8;
            this.btnGenerarEscuderia.Text = "Generar Nueva Escuderia";
            this.btnGenerarEscuderia.UseVisualStyleBackColor = true;
            // 
            // btnGuardarLista
            // 
            this.btnGuardarLista.Location = new System.Drawing.Point(665, 163);
            this.btnGuardarLista.Name = "btnGuardarLista";
            this.btnGuardarLista.Size = new System.Drawing.Size(138, 45);
            this.btnGuardarLista.TabIndex = 9;
            this.btnGuardarLista.Text = "Guardar Lista de Escuderias";
            this.btnGuardarLista.UseVisualStyleBackColor = true;
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Location = new System.Drawing.Point(665, 214);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(138, 45);
            this.btnCargarLista.TabIndex = 10;
            this.btnCargarLista.Text = "Cargar Lista de Escuderias";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            // 
            // FrmEscuderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 274);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.btnGuardarLista);
            this.Controls.Add(this.btnGenerarEscuderia);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lblListaEscuderia);
            this.Controls.Add(this.lstEscuderias);
            this.Name = "FrmEscuderia";
            this.Text = "FrmEscuderia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEscuderias;
        private System.Windows.Forms.Label lblListaEscuderia;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnGenerarEscuderia;
        private System.Windows.Forms.Button btnGuardarLista;
        private System.Windows.Forms.Button btnCargarLista;
    }
}