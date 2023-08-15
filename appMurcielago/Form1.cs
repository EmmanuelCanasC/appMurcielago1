using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMurcielago
{
    public partial class Form1 : Form
    {
        private string semillaCifrado = "MURCIELAGO";
        public Form1()
        {
            InitializeComponent();
        }
        private string CifrarMensaje(string mensaje)
        {
            string cifrado = "";

            foreach (char letra in mensaje)
            {
                int posicion = semillaCifrado.IndexOf(letra);
                if (posicion != -1)
                {
                    cifrado += posicion.ToString();
                }
                else
                {
                    cifrado += letra;
                }
            }

            return cifrado;
        }

        private string DescifrarMensaje(string mensajeCifrado)
        {
            string descifrado = "";
            int posicion = 0;

            foreach (char caracter in mensajeCifrado)
            {
                if (char.IsDigit(caracter))
                {
                    int valor = int.Parse(caracter.ToString());
                    if (valor >= 0 && valor < semillaCifrado.Length)
                    {
                        descifrado += semillaCifrado[valor];
                    }
                }
                else
                {
                    descifrado += caracter;
                }
            }

            return descifrado;
        }

        

      

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            string mensaje = MensajeTextBox.Text;
            string mensajeCifrado = CifrarMensaje(mensaje);
            MensajeCifradoTextBox.Text = mensajeCifrado;
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            string mensajeCifrado = MensajeCifradoTextBox.Text;
            string mensajeDescifrado = DescifrarMensaje(mensajeCifrado);
            MensajeDescifradoTextBox.Text = mensajeDescifrado;
        }
    }
}

     