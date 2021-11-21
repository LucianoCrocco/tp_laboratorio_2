using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Formularios
{
    public partial class FrmEditarPiloto : Form
    {
        private Piloto piloto;
        private List<Piloto> pilotos;
        public FrmEditarPiloto(List<Piloto> pilotos, Piloto piloto)
        {
            InitializeComponent();
            this.piloto = piloto;
            this.pilotos = pilotos;
        }

        private void FrmEditarPiloto_Load(object sender, EventArgs e)
        {
            this.txtBoxNombre.Text = this.piloto.Nombre;
            this.txtBoxApellido.Text = this.piloto.Apellido;
            this.nroEdad.Value = this.piloto.Edad;
            this.cmbSexo.SelectedIndex = (int)this.piloto.Sexo;
            this.nroCompeticion.Value = this.piloto.NumeroCompeticion;
            if (this.piloto.CompetidorNacional)
            {
                this.cmbNacionalidad.SelectedIndex = 0;
            }
            else
            {
                this.cmbNacionalidad.SelectedIndex = 1;
            }
            
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbNacionalidad.SelectedItem is not null && cmbSexo.SelectedItem is not null && txtBoxNombre.Text is not null && txtBoxApellido.Text is not null)
            {
                bool nacionalidad = false;
                if (cmbNacionalidad.SelectedIndex == 0)
                {
                    nacionalidad = true;
                }

                Piloto aux = new Piloto(txtBoxNombre.Text, txtBoxApellido.Text, (int)nroEdad.Value, (ESexo)cmbSexo.SelectedIndex, (int)nroCompeticion.Value, nacionalidad);
                
                if(this.pilotos == aux && aux != this.piloto)
                {
                    MessageBox.Show("El numero de piloto seleccionado ya se encuentra en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    this.piloto.Nombre = this.txtBoxNombre.Text;
                    this.piloto.Apellido = this.txtBoxApellido.Text;
                    this.piloto.Edad = (int)this.nroEdad.Value;
                    this.piloto.Sexo = (ESexo)cmbSexo.SelectedIndex;
                    this.piloto.NumeroCompeticion = (int)this.nroCompeticion.Value;
                    this.piloto.CompetidorNacional = nacionalidad;
                }
            }
        }
    }
}
