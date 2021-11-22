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
using System.IO;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        private FrmPiloto frmPiloto;
        private List<Piloto> pilotos;
        private List<Escuderia> escuderias;
        private SerializacionXML<List<Piloto>> serializacionPiloto;
        private SerializacionJSON<List<EscuderiaTC>> serializacionEscuderia;
        /// <summary>
        /// Constructor de mi form principal. Inicializo la lista de escuderias y pilotos en memoria
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            pilotos = new List<Piloto>();
            escuderias = new List<Escuderia>();
            serializacionPiloto = new SerializacionXML<List<Piloto>>();
            serializacionEscuderia = new SerializacionJSON<List<EscuderiaTC>>();
        }

        /// <summary>
        /// Genera un formulario para la lista de pilotos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPilotos_Click(object sender, EventArgs e)
        {
            frmPiloto = new FrmPiloto(pilotos);
            frmPiloto.ShowDialog();
        }

        /// <summary>
        /// Genera un formulario para la lista de escuderias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEscuderia_Click(object sender, EventArgs e)
        {
            FrmEscuderia <EscuderiaTC> frmEscuderia = new FrmEscuderia<EscuderiaTC>(escuderias, pilotos);
            frmEscuderia.ShowDialog();
        }

        #region Carga de archivos Serializados.
        /// <summary>
        /// Carga, si existen, los archivos serializados de escuderias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string auxPathPilotos = $"{Environment.CurrentDirectory}\\ListaPilotos.xml";
            string auxPathEscuderias = $"{Environment.CurrentDirectory}\\ListaEscuderiaTC.json";
            List<Piloto> auxPilotos;
            List<EscuderiaTC> auxEscuderias;
            try
            {
                if (File.Exists(auxPathPilotos))
                {
                    auxPilotos = serializacionPiloto.Leer(auxPathPilotos);
                    foreach (Piloto item in auxPilotos)
                    {
                        this.pilotos += item;
                    }
                }
                if (File.Exists(auxPathEscuderias))
                {
                    auxEscuderias = ((IArchivo<List<EscuderiaTC>>)serializacionEscuderia).Leer(auxPathEscuderias);
                    foreach (Escuderia item in auxEscuderias)
                    {
                        this.escuderias += item;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
