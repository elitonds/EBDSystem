using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.BD;
using System.Windows.Forms;

namespace EBDSystem.Components
{
    public partial class FormSearch : Form
    {
        private DAO dao;
        private int identificadorId=-1;
        private Form formAdd;
        public FormSearch(DAO dao)
        {
            this.dao = dao;
            InitializeComponent();
            btnAdd.Enabled = false;
            controlConfirmCancel.BtnCancelar.Visible = false;
            gridSearch.DataSource = dao.getSource(null);
            gridSearch.Refresh();
            gridSearch.DoubleClick += new EventHandler(doubleClikGrid);
            controlConfirmCancel.BtnConfirmar.Click += new EventHandler(Confirm);
        }

        public void RefreshGrid(String text)
        {
            gridSearch.DataSource = dao.getSource(text.Trim());
            gridSearch.Refresh();
        }

        private int getCurrentIdentidicador()
        {
            return gridSearch.getCurrentIdentificador();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid(textBoxField.Text);
        }
        
        private void doubleClikGrid(object sender, EventArgs e)
        {
            getLinha();
        }

        private void Confirm(object sender, EventArgs e)
        {
            getLinha();
        }

        private void getLinha()
        {
            if (gridSearch.CurrentRow != null)
            {
                identificadorId = getCurrentIdentidicador();
                this.Close();
            }
            else
            {
                identificadorId = -1;
            }
        }

        public int IdentificadorID
        {
            get { return identificadorId; }
        }

        public MyGrid Grid
        {
            get { return gridSearch; }
        }

        public Form FormAdd
        {
            get { return formAdd; }
            set {
                formAdd = value;
                btnAdd.Enabled = formAdd != null;
            }
        }

        private void textBoxField_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            RefreshGrid(textBoxField.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (formAdd != null)
            {
                formAdd.ShowDialog();
                RefreshGrid(textBoxField.Text);
            }
        }
    }
}
