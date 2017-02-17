using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBDSystem.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            configTela();
        }

        private void configTela()
        {
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.MaxLength = 20;
        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
