using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDTO;
using System.Data.SqlClient;

using Negocios;


namespace Apresentacao
{
    public partial class PessoaSelecionar : Form
    {
        public PessoaSelecionar()
        {
            InitializeComponent();
        }

        private void PessoaSelecionar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void BotaoPesquisar_Click(object sender, EventArgs e)
        {
           PessoaNegocio pessoaNegocio =new PessoaNegocio();

            PessoaColecao pessoaColecao = new PessoaColecao();
            pessoaColecao = pessoaNegocio.ConsultarPorNome(PesquisaDigitar.Text);

            dataGridPrincipal.DataSource = null;
            dataGridPrincipal.DataSource = pessoaColecao;

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();
        }

        private void PesquisaDigitar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
