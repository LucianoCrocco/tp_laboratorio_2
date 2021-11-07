
namespace Formularios
{
    partial class FrmEscuderia<T>
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
            this.btnEstadisticasGenerales = new System.Windows.Forms.Button();
            this.btnGenerarEscuderia = new System.Windows.Forms.Button();
            this.btnGuardarLista = new System.Windows.Forms.Button();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.btnCargarPilotos = new System.Windows.Forms.Button();
            this.btnEstadisticasIndividuales = new System.Windows.Forms.Button();
            this.btnBorrarPilotos = new System.Windows.Forms.Button();
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
            this.lstEscuderias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEscuderias_MouseDoubleClick);
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
            // btnEstadisticasGenerales
            // 
            this.btnEstadisticasGenerales.Location = new System.Drawing.Point(665, 61);
            this.btnEstadisticasGenerales.Name = "btnEstadisticasGenerales";
            this.btnEstadisticasGenerales.Size = new System.Drawing.Size(138, 45);
            this.btnEstadisticasGenerales.TabIndex = 7;
            this.btnEstadisticasGenerales.Text = "Estadisticas Generales";
            this.btnEstadisticasGenerales.UseVisualStyleBackColor = true;
            // 
            // btnGenerarEscuderia
            // 
            this.btnGenerarEscuderia.Location = new System.Drawing.Point(665, 112);
            this.btnGenerarEscuderia.Name = "btnGenerarEscuderia";
            this.btnGenerarEscuderia.Size = new System.Drawing.Size(138, 45);
            this.btnGenerarEscuderia.TabIndex = 8;
            this.btnGenerarEscuderia.Text = "Generar Nueva Escuderia";
            this.btnGenerarEscuderia.UseVisualStyleBackColor = true;
            this.btnGenerarEscuderia.Click += new System.EventHandler(this.btnGenerarEscuderia_Click);
            // 
            // btnGuardarLista
            // 
            this.btnGuardarLista.Location = new System.Drawing.Point(665, 163);
            this.btnGuardarLista.Name = "btnGuardarLista";
            this.btnGuardarLista.Size = new System.Drawing.Size(138, 45);
            this.btnGuardarLista.TabIndex = 9;
            this.btnGuardarLista.Text = "Guardar Lista de Escuderias";
            this.btnGuardarLista.UseVisualStyleBackColor = true;
            this.btnGuardarLista.Click += new System.EventHandler(this.btnGuardarLista_Click);
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Location = new System.Drawing.Point(665, 214);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(138, 45);
            this.btnCargarLista.TabIndex = 10;
            this.btnCargarLista.Text = "Cargar Lista de Escuderias";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
            // 
            // btnCargarPilotos
            // 
            this.btnCargarPilotos.Location = new System.Drawing.Point(809, 112);
            this.btnCargarPilotos.Name = "btnCargarPilotos";
            this.btnCargarPilotos.Size = new System.Drawing.Size(138, 45);
            this.btnCargarPilotos.TabIndex = 11;
            this.btnCargarPilotos.Text = "Cargar pilotos a una escuderia";
            this.btnCargarPilotos.UseVisualStyleBackColor = true;
            this.btnCargarPilotos.Click += new System.EventHandler(this.btnCargarPilotos_Click);
            // 
            // btnEstadisticasIndividuales
            // 
            this.btnEstadisticasIndividuales.Location = new System.Drawing.Point(809, 61);
            this.btnEstadisticasIndividuales.Name = "btnEstadisticasIndividuales";
            this.btnEstadisticasIndividuales.Size = new System.Drawing.Size(138, 45);
            this.btnEstadisticasIndividuales.TabIndex = 13;
            this.btnEstadisticasIndividuales.Text = "Estadisticas Individuales";
            this.btnEstadisticasIndividuales.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPilotos
            // 
            this.btnBorrarPilotos.Location = new System.Drawing.Point(809, 163);
            this.btnBorrarPilotos.Name = "btnBorrarPilotos";
            this.btnBorrarPilotos.Size = new System.Drawing.Size(138, 45);
            this.btnBorrarPilotos.TabIndex = 12;
            this.btnBorrarPilotos.Text = "Borrar pilotos de una escuderia";
            this.btnBorrarPilotos.UseVisualStyleBackColor = true;
            // 
            // FrmEscuderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 274);
            this.Controls.Add(this.btnEstadisticasIndividuales);
            this.Controls.Add(this.btnBorrarPilotos);
            this.Controls.Add(this.btnCargarPilotos);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.btnGuardarLista);
            this.Controls.Add(this.btnGenerarEscuderia);
            this.Controls.Add(this.btnEstadisticasGenerales);
            this.Controls.Add(this.lblListaEscuderia);
            this.Controls.Add(this.lstEscuderias);
            this.Name = "FrmEscuderia";
            this.Text = "FrmEscuderia";
            this.Load += new System.EventHandler(this.FrmEscuderia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEscuderias;
        private System.Windows.Forms.Label lblListaEscuderia;
        private System.Windows.Forms.Button btnEstadisticasGenerales;
        private System.Windows.Forms.Button btnGenerarEscuderia;
        private System.Windows.Forms.Button btnGuardarLista;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.Button btnCargarPilotos;
        private System.Windows.Forms.Button btnEstadisticasIndividuales;
        private System.Windows.Forms.Button btnBorrarPilotos;
    }
}