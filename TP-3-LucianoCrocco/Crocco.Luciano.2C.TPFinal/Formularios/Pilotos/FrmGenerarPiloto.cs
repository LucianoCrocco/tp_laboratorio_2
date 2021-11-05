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
using Excepciones;

namespace Formularios
{
    public partial class FrmGenerarPiloto : Form
    {
        List<Piloto> pilotosLista;
        public FrmGenerarPiloto(List<Piloto> pilotos)
        {
            InitializeComponent();
            pilotosLista = pilotos;
        }

        #region Agregar Piloto
        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool nacionalidad = false;
            if(cmbNacionalidad.SelectedItem is not null && cmbSexo.SelectedItem is not null && txtBoxNombre.Text is not null && txtBoxApellido.Text is not null)
            {
                if(cmbNacionalidad.SelectedIndex == 0)
                {
                    nacionalidad = true;
                }

                try
                {
                    Piloto piloto = new Piloto(txtBoxNombre.Text, txtBoxApellido.Text, (int)nroEdad.Value, (ESexo)cmbSexo.SelectedIndex, (int)nroCompeticion.Value, nacionalidad);
                    pilotosLista += piloto;
                    FrmPiloto.Refrescar(pilotosLista);
                }
                catch (CaracteresInvalidoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (PilotoRepetidoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Rellene todos los campos antes de continuar!");
            }
        }
        #endregion

        private void FrmGenerarPiloto_Load(object sender, EventArgs e)
        {
            if(pilotosLista.Count > nroCompeticion.Maximum)
            {
                MessageBox.Show("Se alcanzo el maximo de pilotos posibles para cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
