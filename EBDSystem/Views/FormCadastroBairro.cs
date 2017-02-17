using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.BD;
using EBDSystem.Model;
using EBDSystem.Util;
using EBDSystem.Components;
using System.Windows.Forms;

namespace EBDSystem.Views
{
    public partial class FormCadastroBairro : Form
    {
        private BairroDAO dao = new BairroDAO();
        private BairroEntity bairro = new BairroEntity();
        private bool isSubCadastro = false;
        public FormCadastroBairro(bool isSubCadastro)
        {
            InitializeComponent();
            this.isSubCadastro = isSubCadastro;
            configTela();
            configEvents();
        }

        private void configTela()
        {
            CidadeDAO daoCidade = new CidadeDAO();
            searchCidades.setDao(daoCidade);
            searchCidades.setTitleForm("Busca de Cidades");
            searchCidades.setFormAdd(new FormCadastroCidade(true));
            setFieldsEnable(false);
            setEditarExcluirEnable(false);
            searchCidades.TextField.AccessibleName = "Cidade";
        }

        private void configEvents()
        {
            controlActions.BtnIncluir.Click += new EventHandler(btnIncluir_Click);
            controlActions.BtnEditar.Click += new EventHandler(btnEditar_Click);
            controlActions.BtnExcluir.Click += new EventHandler(btnExcluir_Click);
            controlConfirmCancel.BtnCancelar.Click += new EventHandler(btnCancelar_Click);
            controlConfirmCancel.BtnConfirmar.Click += new EventHandler(btnConfirmar_Click);
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
            gridDados.Click += new EventHandler(gridDados_Click);
        }

        private void setFieldsEnable(bool enable)
        {
            textBoxNome.Enabled = enable;
            searchCidades.Enabled = enable;
        }

        private void setEditarExcluirEnable(bool enable)
        {
            controlActions.BtnEditar.Enabled = enable;
            controlActions.BtnExcluir.Enabled = enable;
        }

        private void getDadosRow()
        {
            bairro.Id = Int32.Parse((gridDados.CurrentRow.Cells[0].Value).ToString());
            bairro.Nome = (gridDados.CurrentRow.Cells[1].Value).ToString();
            bairro.IdCidade = Int32.Parse((gridDados.CurrentRow.Cells[2].Value).ToString());
            bairro.NomeCidade = (gridDados.CurrentRow.Cells[3].Value).ToString();
            textBoxNome.Text = bairro.Nome;
            searchCidades.TextField.Text = bairro.NomeCidade;
        }

        private void getDadosTable()
        {
            gridDados.DataSource = dao.getBairros();
            gridDados.Columns[2].Visible = false;
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Nome")
                    column.Width = 300; 
            }
            gridDados.Refresh();
        }

        private void reset()
        {
            if (gridDados.RowCount > 0)
            {
                textBoxNome.Text = "";
                searchCidades.TextField.Text = "";
                gridDados.CurrentRow.Selected = false;
                bairro = new BairroEntity();
                setEditarExcluirEnable(false);
                gridDados.Enabled = true;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            reset();
            setFieldsEnable(true);
            controlActions.setButtonsEnable(false);
            textBoxNome.Focus();
            gridDados.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setFieldsEnable(true);
            controlActions.setButtonsEnable(false);
            gridDados.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridDados.CurrentRow != null)
            {
                DialogResult option = MessageBox.Show("Deseja mesmo excluir este bairro?", "Excluir Bairro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    getDadosRow();
                    if (dao.excluir(bairro.Id))
                    {
                        gridDados.Rows.Remove(gridDados.CurrentRow);
                        reset();
                        controlActions.Status = ControlActions.STAND_BY;
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bairro.Nome = textBoxNome.Text;
            CidadeEntity cidade = (CidadeEntity)searchCidades.Entidade;
            if (cidade != null)
            {
                bairro.IdCidade = cidade.Id;
            }
            if (controlActions.Status != ControlActions.STAND_BY)
                if (Validator.validaCampos(new Object[] { textBoxNome, searchCidades.TextField }))
                {
                    bool sucess = false;
                    if (controlActions.Status == ControlActions.INSERIR)
                    {
                        sucess = dao.inserir(bairro);
                        if (sucess)
                        {
                            setFieldsEnable(false);
                            getDadosTable();
                            controlActions.setButtonsEnable(true);
                            reset();
                            controlActions.Status = ControlActions.STAND_BY;
                        }
                    }
                    else if (controlActions.Status == ControlActions.EDITAR)
                    {
                        sucess = dao.editar(bairro);
                        if (sucess)
                        {
                            setFieldsEnable(false);
                            getDadosTable();
                            controlActions.setButtonsEnable(true);
                            reset();
                            controlActions.Status = ControlActions.STAND_BY;
                        }
                    }
                    else
                    {
                        controlActions.Status = ControlActions.STAND_BY;
                    }
                    if (isSubCadastro && sucess)
                    {
                        this.Close();
                    }
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setFieldsEnable(false);
            controlActions.setButtonsEnable(true);
            reset();
            controlActions.Status = ControlActions.STAND_BY;
        }

        private void gridDados_Click(object sender, EventArgs e)
        {
            if (gridDados.CurrentRow != null)
            {
                getDadosRow();
                setEditarExcluirEnable(true);
            }
        }
        private void FormCadastroBairro_Load(object sender, EventArgs e)
        {
            getDadosTable();
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (isSubCadastro)
            {
                reset();
            }
        }
    }
}
