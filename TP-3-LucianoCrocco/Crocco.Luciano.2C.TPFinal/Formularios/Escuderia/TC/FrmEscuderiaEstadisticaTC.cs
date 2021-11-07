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
using ArchivosYSerializacion;

namespace Formularios
{
    public partial class FrmEscuderiaEstadisticaTC : Form
    {
        private PromedioTC promedio;
        private List<Escuderia> escuderia;
        public FrmEscuderiaEstadisticaTC(List<Escuderia> escuderia)
        {
            InitializeComponent();
            this.escuderia = escuderia;
            promedio = new PromedioTC(this.escuderia);
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.MaximoAsientosDisponiblesPiloto() + "\n" + promedio.MaximoAsientosOcupadosPiloto() + "\n" + promedio.AutosMasUtilizado();

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            rchEstadisticas.Text = promedio.PromedioAsientosDisponiblesPiloto() + "\n" + promedio.PromedioAsientosOcupadosPiloto() + "\n" + promedio.PromedioAutosUtilizados();
        }
        private void btnMinimo_Click(object sender, EventArgs e)
        {
            rchEstadisticas.Text = promedio.MinimoAsientosDisponiblesPiloto() + "\n" + promedio.MinimoAsientosOcupadosPiloto() + "\n" + promedio.AutosMenosUtilizado();
        }

        #region Metodos
        public void Limpiar()
        {
            rchEstadisticas.Clear();
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string path;
            string dateTime = "\tGuardado generado el " + DateTime.Now + "\n";
            string listaEscuderia = Escuderia.MostrarTodosListaEscuderia(escuderia, "escuderias del Turismo Carretera");
            bool append = !chkSobreescribir.Checked;
            ArchivoTexto archivoTexto = new ArchivoTexto();
            try
            {
                path = $"{Environment.CurrentDirectory}\\EstadisticasEscuderia.txt";
                archivoTexto.Guardar(dateTime + listaEscuderia + "\n" + rchEstadisticas.Text + "\n", path, append);

                MessageBox.Show($"Archivo correctamente guardado en: {path}", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
