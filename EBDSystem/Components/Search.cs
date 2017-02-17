using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.BD;
using EBDSystem.Model;
using System.Windows.Forms;

namespace EBDSystem.Components
{
    public partial class Search : UserControl
    {
        private FormSearch form;
        private Form formAdd;
        private DAO dao;
        private String titleForm;
        private Entity entidade;
        private int identificador;
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new FormSearch(dao);
                form.Text = titleForm;
            }
            form.FormAdd = formAdd;
            form.Grid.Identificador = Identificador;
            form.FormClosing += new FormClosingEventHandler(Form_Closing);
            form.ShowDialog();
        }

        public void setTitleForm(String title)
        {
           titleForm = title;
        }

        public void setFormAdd(Form formAdd)
        {
            this.formAdd = formAdd;
        }

        public void setDao(DAO fonteDados)
        {
            dao = fonteDados;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (form.IdentificadorID != -1)
            {
                entidade = dao.getEntityByIdentificador(form.IdentificadorID);
                textBoxField.Text = entidade.FieldSearch();
            }
        }

        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public Entity Entidade
        {
            get { return entidade; }
            set { entidade = value; }
        }

        public TextBox TextField
        {
            get { return textBoxField; }
            set { textBoxField = value; }
        }
    }
}
