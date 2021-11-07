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
    public partial class FrmGenerarEscuderiaTC : Form
    {
        List<Escuderia> escuderias;
        public FrmGenerarEscuderiaTC(List<Escuderia> escuderias)
        {
            InitializeComponent();
            this.escuderias = escuderias;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text is not null && nroAsientos is not null && cmbFabricante.SelectedIndex is not -1)
            {
                try
                {
                    Escuderia escuderia = new EscuderiaTC(txtBoxNombre.Text, (int)nroAsientos.Value, (EMarcaVehiculoTC)cmbFabricante.SelectedIndex);
                    escuderias += escuderia;
                    FrmEscuderia<Escuderia>.Refrescar(escuderias);
                }
                catch(EscuderiaRepetidaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Rellene todos los campos antes de continuar!");
            }
        }
    }
}
