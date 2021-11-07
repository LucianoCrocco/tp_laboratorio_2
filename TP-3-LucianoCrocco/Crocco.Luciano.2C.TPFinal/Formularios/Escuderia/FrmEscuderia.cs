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
    public partial class FrmEscuderia : Form
    {
        List<Escuderia> escuderias;
        List<Piloto> pilotos;
        public FrmEscuderia(List<Escuderia> escuderias, List<Piloto> pilotos)
        {
            InitializeComponent();
            this.escuderias = escuderias;
            this.pilotos = pilotos;
        }
    }
}
