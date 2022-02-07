using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            //menu sair
            //sender identifica qual é o componente 
            // e indentifica quais operaçoes serão realizadas
            //fazendo fechar a tela
            Application.Exit();
        }

        private void pesssoaMenuCadastro_Click(object sender, EventArgs e)
        {
            //FAZER ABRIR O CADASTR0

            PessoaSelecionar Menu = new PessoaSelecionar();

            Menu.MdiParent = this;
            Menu.Show();

            //Form frmFilho = new Form();
            // frmFilho.MDI_Pai = this;
            // frmFilho.Show();

}

private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}
}
}
