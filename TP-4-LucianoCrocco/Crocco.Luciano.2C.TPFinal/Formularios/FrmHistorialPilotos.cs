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
    public partial class FrmHistorialPilotos : Form
    {
        private FrmPilotoEstadistica frmEstadisticaPiloto;
        private List<Piloto> pilotosHistorial;
        private List<Piloto> pilotosActuales;
        private PilotoBDD baseDeDatosPiloto;
        public FrmHistorialPilotos(List<Piloto> pilotosActuales)
        {
            InitializeComponent();
            this.pilotosHistorial = new List<Piloto>();
            this.baseDeDatosPiloto = new PilotoBDD();
            this.pilotosActuales = pilotosActuales;
        }

        #region Cargar historial
        private void FrmHistorialPilotos_Load(object sender, EventArgs e)
        {
            try
            {
                this.pilotosHistorial = this.baseDeDatosPiloto.LeerPilotos();
                Refrescar();
            }
            catch(BaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        #endregion

        #region Metodos
        public void Refrescar()
        {
            this.lstPilotos.Items.Clear();
            foreach (Piloto item in this.pilotosHistorial)
            {
                this.lstPilotos.Items.Add(item.MostrarDatos());
            }
        }
        #endregion

        #region Estadisticas
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (this.pilotosHistorial.Count > 0)
            {
                frmEstadisticaPiloto = new FrmPilotoEstadistica(this.pilotosHistorial);
                frmEstadisticaPiloto.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay pilotos cargados en la lista", "Aleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Agregar Piloto
        private void btnAgregarPiloto_Click(object sender, EventArgs e)
        {
            if (pilotosHistorial.Count < 1)
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                try
                {
                    this.pilotosActuales += this.pilotosHistorial[lstPilotos.SelectedIndex];
                }
                catch (PilotoRepetidoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El index seleccionado se encuentra fuera del rango de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Editar Piloto

        #endregion
    }
}
