using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ArchivosYSerializacion;

namespace Formularios
{
    public partial class FrmPilotoEstadistica : Form
    {
        private EstadisticasPilotos promedio;
        private List<Piloto> pilotos;
        public FrmPilotoEstadistica(List<Piloto> pilotos)
        {
            InitializeComponent();
            promedio = new EstadisticasPilotos(pilotos);
            this.pilotos = pilotos;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.PromedioEdad() + "\n" + promedio.PromedioSexo() + "\n" + promedio.PromedioNacionalidad() + "\n" + promedio.PromedioNumeroElegido();

        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.MaximoEdad() + "\n" + promedio.MaximoNacionalidad() + "\n" + promedio.MaximoSexo() + "\n" + promedio.MaximoNroCompeticion();
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.MinimoEdad() + "\n" + promedio.MinimoNacionalidad() + "\n" + promedio.MinimoSexo() + "\n" + promedio.MinimoNroCompeticion();
        }

        public void Limpiar()
        {
            rchEstadisticas.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string path;
            string dateTime = "\tGuardado generado el " + DateTime.Now + "\n";
            string listaPilotos = Piloto.MostrarTodosListaPilotos(pilotos);
            bool append = !chkSobreescribir.Checked;
            ArchivoTexto archivoTexto = new ArchivoTexto();
            try
            {
                path = $"{Environment.CurrentDirectory}\\EstadisticasPilotos.txt";
                archivoTexto.Guardar(dateTime + rchEstadisticas.Text + "\n" + listaPilotos, path, append);
                
                MessageBox.Show($"Archivo correctamente guardado en: {path}", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
