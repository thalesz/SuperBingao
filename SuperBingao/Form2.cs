using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBingao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TextoPremio_Click(object sender, EventArgs e)
        {

        }

        private void BotaoSalvarForm_Click(object sender, EventArgs e)
        {
            String evento = CaixaEvento.Text;
            String edicao = CaixaEdicao.Text;
            String numero = CaixaNumero.Text;
            String descricao = CaixaDescricao.Text;

            Form1 Mform1 = (Form1)Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (Mform1 != null && evento!="" && edicao!="" && descricao!="")
            {
                Mform1.AtualizarInfo(evento, edicao, numero, descricao);
                this.Close();
            }
            else
            {
                MessageBox.Show("Insira todas as informações");
            }   
        }
    } 
}
