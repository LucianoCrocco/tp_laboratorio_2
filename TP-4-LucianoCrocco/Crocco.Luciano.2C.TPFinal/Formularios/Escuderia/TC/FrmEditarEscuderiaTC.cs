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
    public partial class FrmEditarEscuderiaTC : Form
    {
        private EscuderiaTC escuderia;
        private List<EscuderiaTC> listaEscuderias;
        public FrmEditarEscuderiaTC(EscuderiaTC escuderia, List<EscuderiaTC> listaEscuderias)
        {
            InitializeComponent();
            this.escuderia = escuderia;
            this.listaEscuderias = listaEscuderias;
        }

        private void FrmEditarEscuderiaTC_Load(object sender, EventArgs e)
        {
            txtBoxNombre.Text = this.escuderia.NombreEscuderia;
            nroAsientos.Value = this.escuderia.CantidadPilotos;
            cmbFabricante.SelectedIndex = (int)this.escuderia.MarcaVehiculoTC;
        }
    }
}
