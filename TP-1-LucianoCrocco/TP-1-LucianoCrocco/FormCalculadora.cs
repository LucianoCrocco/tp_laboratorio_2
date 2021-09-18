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

namespace TP_1_LucianoCrocco
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }



        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = "";
            bool operar = true;
            if ((String.IsNullOrWhiteSpace(txtBoxNumero1.Text) || double.TryParse(txtBoxNumero1.Text, out double numeroUno) == false)
               || (String.IsNullOrWhiteSpace(txtBoxNumero2.Text) || double.TryParse(txtBoxNumero2.Text, out double numeroDos) == false))
            {
                MessageBox.Show("Los numeros ingresados son invalidos o la casilla se encuentra vacia. Por favor revea los numeros ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                operar = false;
            }  else if(cmbOperador.SelectedItem == null)
            {
                cmbOperador.Text = "+";
                operador = "+";
                operar = true;
            } else
            {
                operador = cmbOperador.SelectedItem.ToString();
                operar = true;
            }

            if (operar)
            {
                lblResultado.Text = Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, operador).ToString();
                lstOperaciones.Items.Add(txtBoxNumero1.Text + " " + operador + " " + txtBoxNumero2.Text + " " + "=" + " " + lblResultado.Text);
            }
            
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operandoUno = new Operando(numero1);
            Operando operandoDos = new Operando(numero2);
            char.TryParse(operador, out char miOperador);

            return Calculadora.Operar(operandoUno, operandoDos, miOperador);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea limpiar la informacion de la calculadora?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtBoxNumero1.Text = "";
            txtBoxNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "RESULTADO";
            lstOperaciones.Items.Clear();
        }
    }
}
