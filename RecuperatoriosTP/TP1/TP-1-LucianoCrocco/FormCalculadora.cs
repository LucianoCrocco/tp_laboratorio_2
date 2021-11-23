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


        /// <summary>
        /// Muestra la operacion entre los numeros ingresados y su operando a traves del label Resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                btnConvertirADecimal.Enabled = false;
                btnConvertirABinario.Enabled = true;
                lblResultado.Text = Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, operador).ToString();
                lstOperaciones.Items.Add(txtBoxNumero1.Text + " " + cmbOperador.SelectedItem.ToString() + " " + txtBoxNumero2.Text + " " + "=" + " " + lblResultado.Text);
            }
            
        }

        /// <summary>
        /// Realiza la operacion entre ambos numeros recibidos, segun el operador seleccionado
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operandoUno = new Operando(numero1);
            Operando operandoDos = new Operando(numero2);
            char.TryParse(operador, out char miOperador);

            return Calculadora.Operar(operandoUno, operandoDos, miOperador);
        }

        /// <summary>
        /// Limpia la informacion en pantalla de la calculadora, devuelve sus valores al estado inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea limpiar la informacion de la calculadora?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Limpiar();
            }
        }
        /// <summary>
        /// Realiza la accion de limpieza de la calculadora
        /// </summary>
        private void Limpiar()
        {
            txtBoxNumero1.Text = "";
            txtBoxNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "RESULTADO";
            lstOperaciones.Items.Clear();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Convierte, si es posible, el numero Decimal en el label Resultado a Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = Operando.DecimalBinario(lblResultado.Text);
            if(double.TryParse(resultado, out double auxNumero))
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Convierte, si es posible, el numero Binario en el label Resultado a Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = Operando.BinarioDecimal(lblResultado.Text);
            if(double.TryParse(resultado, out double auxNumero))
            {
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }

        /// <summary>
        /// Si se acciona el boton preguntara al usuario si realmente quiere cerrar la calculadora. Dependiendo de su respuesta (YESNO) cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        /// <summary>
        /// Si se sucede el evento de que el usuario quiera salir de la UI a través de la barra superior del sistema, pregunta si realmente quiere salir de la calculadora. Dependiendo de su respuesta (YESNO) cierra el form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            } else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Carga el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
