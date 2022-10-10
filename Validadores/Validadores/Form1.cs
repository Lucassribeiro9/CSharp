using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validadores.Services;

namespace Validadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBoxCPF.Text = "";
            maskedTextBoxCPF.Mask = "000,000,000-00";
            maskedTextBoxCPF.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
        }

        private void btnValidarCPF_Click(object sender, EventArgs e)
        {
            string valor = maskedTextBoxCPF.Text;
            string mensagem;
            if (Validador.IsCpf(valor))
            {
                mensagem = "CPF válido";
            }
            else
            {
                mensagem = "CPF inválido";
            }
            MessageBox.Show(mensagem);
        }
    }
}
