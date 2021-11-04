
namespace Formularios
{
    partial class FrmPiloto
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
            this.dataGridPilotos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPiloto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPilotos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPilotos
            // 
            this.dataGridPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPilotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Sexo,
            this.Numero,
            this.Extranjero});
            this.dataGridPilotos.Location = new System.Drawing.Point(12, 12);
            this.dataGridPilotos.Name = "dataGridPilotos";
            this.dataGridPilotos.RowTemplate.Height = 25;
            this.dataGridPilotos.Size = new System.Drawing.Size(647, 210);
            this.dataGridPilotos.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero de Competicion";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Extranjero
            // 
            this.Extranjero.HeaderText = "Extranjero";
            this.Extranjero.Name = "Extranjero";
            this.Extranjero.ReadOnly = true;
            // 
            // btnGenerarPiloto
            // 
            this.btnGenerarPiloto.Location = new System.Drawing.Point(665, 12);
            this.btnGenerarPiloto.Name = "btnGenerarPiloto";
            this.btnGenerarPiloto.Size = new System.Drawing.Size(138, 45);
            this.btnGenerarPiloto.TabIndex = 1;
            this.btnGenerarPiloto.Text = "Cargar Nuevo Piloto";
            this.btnGenerarPiloto.UseVisualStyleBackColor = true;
            this.btnGenerarPiloto.Click += new System.EventHandler(this.btnGenerarPiloto_Click);
            // 
            // FrmPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 232);
            this.Controls.Add(this.btnGenerarPiloto);
            this.Controls.Add(this.dataGridPilotos);
            this.Name = "FrmPiloto";
            this.Text = "FrmPiloto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPilotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPilotos;
        private System.Windows.Forms.Button btnGenerarPiloto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extranjero;
    }
}