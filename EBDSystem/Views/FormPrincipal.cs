using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBDSystem.Views;

namespace EBDSystem
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroCidade cadCidade = new FormCadastroCidade(false);
            cadCidade.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroBairro cadBairro = new FormCadastroBairro(false);
            cadBairro.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPessoaMembro cadPessoa = new FormCadastroPessoaMembro(false);
            cadPessoa.ShowDialog();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClasse cadClasse = new FormCadastroClasse(false);
            cadClasse.ShowDialog();
        }
    }
}
