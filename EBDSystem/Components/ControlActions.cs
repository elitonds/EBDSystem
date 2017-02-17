using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBDSystem.Components
{
    public partial class ControlActions : UserControl
    {
        public static int STAND_BY = 0, INSERIR = 1, EDITAR = 2, EXCLUIR = 3;
        private int status = STAND_BY;
        public ControlActions()
        {
            InitializeComponent();
        }

        public Button BtnIncluir
        {
            get { return btnIncluir; }
        }

        public Button BtnEditar
        {
            get { return btnEditar; }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            status = INSERIR;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            status = EDITAR;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            status = EXCLUIR;
        }

        public Button BtnExcluir
        {
            get { return btnExcluir; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public void setButtonsEnable(bool enable)
        {
            btnIncluir.Enabled = enable;
            btnEditar.Enabled = enable;
            btnExcluir.Enabled = enable;
        }
    }
}
