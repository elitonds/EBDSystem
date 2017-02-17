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
    public partial class ControlConfirmCancel : UserControl
    {
        public ControlConfirmCancel()
        {
            InitializeComponent();
        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        public Button BtnConfirmar
        {
            get { return btnConfirmar; }
        }

        public Button BtnCancelar
        {
            get { return btnCancelar; }
        }
    }
}
