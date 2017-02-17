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
using EBDSystem.Components;
using EBDSystem.Util;
using System.Windows.Forms;

namespace EBDSystem.Views
{
    public partial class FormCadastroCidade :Form
    {
        private CidadeDAO dao = new CidadeDAO();
        private CidadeEntity cidade = new CidadeEntity();
        private bool isSubCadastro = false;
        public FormCadastroCidade(bool isSubCadastro)
        {
            InitializeComponent();
            this.isSubCadastro = isSubCadastro;
            configTela();
            configEvents();
        }

        private void configTela()
        {
            setFieldsEnable(false);
            setEditarExcluirEnable(false);
            comboBoxUf.Items.Add("Selecione");
            comboBoxUf.Items.AddRange(dao.getUfs().ToArray());
            comboBoxUf.SelectedItem = "Selecione";
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

        private void gridDados_Click(object sender, EventArgs e)
        {
            if(gridDados.CurrentRow != null)
            {
                getDadosRow();
                setEditarExcluirEnable(true);
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
                DialogResult option = MessageBox.Show("Deseja mesmo excluir esta cidade?", "Excluir Cidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    getDadosRow();
                    if (dao.excluir(cidade.Id))
                    {
                        gridDados.Rows.Remove(gridDados.CurrentRow);
                        reset();
                        controlActions.Status = ControlActions.STAND_BY;
                    }
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cidade.Nome = textBoxNome.Text;
            cidade.Uf = comboBoxUf.Text;
            if (controlActions.Status != ControlActions.STAND_BY)
                if (Validator.validaCampos(new Object[] { textBoxNome, comboBoxUf }))
                {
                    bool sucess = false;
                    if (controlActions.Status == ControlActions.INSERIR)
                    {
                        sucess = dao.inserir(cidade);
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
                        sucess = dao.editar(cidade);
                        if (sucess)
                        {
                            setFieldsEnable(false);
                            getDadosTable();
                            controlActions.setButtonsEnable(true);
                            reset();
                            controlActions.Status = ControlActions.STAND_BY;
                        }
                    }else
                    {
                        controlActions.Status = ControlActions.STAND_BY;
                    }
                    if (isSubCadastro && sucess)
                    {
                        this.Close();
                    }
                }

        }

        private void setFieldsEnable(bool enable)
        {
            textBoxNome.Enabled = enable;
            comboBoxUf.Enabled = enable;
        }

        private void setEditarExcluirEnable(bool enable)
        {
            controlActions.BtnEditar.Enabled = enable;
            controlActions.BtnExcluir.Enabled = enable;
        }

       
        private void FormCadastroCidade_Load(object sender, EventArgs e)
        {
            getDadosTable();
            if(isSubCadastro)
            {
                gridDados.Enabled = false;
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (isSubCadastro)
            {
                reset();
            }
        }

        private void getDadosTable()
        {
            gridDados.DataSource = dao.getCidades();
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Nome")
                    column.Width = 300;
            }
            gridDados.Refresh();
        }

        private void getDadosRow()
        {
            cidade.Id = Int32.Parse((gridDados.CurrentRow.Cells[0].Value).ToString());
            cidade.Nome = (gridDados.CurrentRow.Cells[1].Value).ToString();
            cidade.Uf = (gridDados.CurrentRow.Cells[2].Value).ToString();
            textBoxNome.Text = cidade.Nome;
            comboBoxUf.SelectedItem = cidade.Uf;
        }

        private void reset()
        {
            if (gridDados.RowCount > 0)
            {
                textBoxNome.Text = "";
                comboBoxUf.SelectedItem = "Selecione";
                gridDados.CurrentRow.Selected = false;
                cidade = new CidadeEntity();
                setEditarExcluirEnable(false);
                gridDados.Enabled = !isSubCadastro;
            }
        }
    }
}
