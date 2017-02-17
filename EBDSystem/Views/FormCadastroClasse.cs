using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBDSystem.Components;
using EBDSystem.BD;
using EBDSystem.Model;
using EBDSystem.Util;

namespace EBDSystem.Views
{
    public partial class FormCadastroClasse : Form
    {
        private FormSearch formSearchProfessores;
        private ClasseDAO dao;
        private ProfessorDAO daoProfessor;
        private ClasseEntity classe;
        private List<int> idProfessoresExcluir;
        private bool isSubCadastro;
        public FormCadastroClasse(bool isSubCadastro)
        {
            InitializeComponent();
            this.isSubCadastro = isSubCadastro;
            dao = new ClasseDAO();
            daoProfessor = new ProfessorDAO();
            formSearchProfessores = new FormSearch(daoProfessor);
            formSearchProfessores.FormAdd = new FormCadastroPessoaMembro(true);
            classe = new ClasseEntity();
            idProfessoresExcluir = new List<int>();
            configTela();
            configEvents();
        }

        private void configTela()
        {
            setFieldsEnable(false);
            setEditarExcluirEnable(false);
        }

        private void configEvents()
        {
            controlActions.BtnIncluir.Click += new EventHandler(btnIncluir_Click);
            controlActions.BtnEditar.Click += new EventHandler(btnEditar_Click);
            controlActions.BtnExcluir.Click += new EventHandler(btnExcluir_Click);
            controlConfirmCancel.BtnCancelar.Click += new EventHandler(btnCancelar_Click);
            controlConfirmCancel.BtnConfirmar.Click += new EventHandler(btnConfirmar_Click);
            formSearchProfessores.FormClosing += new FormClosingEventHandler(Form_Closing);
            gridDados.Click += new EventHandler(gridDados_Click);
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
                    if (dao.excluir(classe.Id))
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
            if (controlActions.Status != ControlActions.STAND_BY)
                if (Validator.validaCampos(new Object[] {textBoxNome}))
                {
                    bool sucess = false;
                    classe.Nome = textBoxNome.Text;
                    if (controlActions.Status == ControlActions.INSERIR)
                    {
                        sucess = dao.inserir(classe);
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
                        sucess = dao.editar(classe, idProfessoresExcluir);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setFieldsEnable(false);
            controlActions.setButtonsEnable(true);
            reset();
            controlActions.Status = ControlActions.STAND_BY;
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (formSearchProfessores.IdentificadorID != -1)
            {
                if (!classe.Professores.ContainsKey(formSearchProfessores.IdentificadorID))
                {
                    PessoaEntity professor = (PessoaEntity)daoProfessor.getEntityByIdentificador(formSearchProfessores.IdentificadorID);
                    classe.Professores.Add(professor.Id, professor);
                    gridProfessores.Rows.Add(new Object[] { professor.Id, professor.Nome, professor.DataNascimento.ToString("dd/MM/yyyy") });
                    gridProfessores.Refresh();
                }else
                {
                    MessageBox.Show("Professor já está na lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridDados_Click(object sender, EventArgs e)
        {
            if (gridDados.CurrentRow != null)
            {
                getDadosRow();
                setEditarExcluirEnable(true);
            }
        }
        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            formSearchProfessores.ShowDialog();
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if(gridProfessores.CurrentRow != null)
            {
                int idProfessorSlecionado = 0;
                if (controlActions.Status == ControlActions.EDITAR && gridDados.Rows.Count>0)
                {
                    foreach(DataGridViewColumn column in gridProfessores.Columns)
                    {
                        if (column.Name == "codigo")
                            idProfessorSlecionado = Int32.Parse(gridProfessores.CurrentRow.Cells[column.Index].Value.ToString());
                            idProfessoresExcluir.Add(idProfessorSlecionado);
                    }
                }
                gridProfessores.Rows.Remove(gridProfessores.CurrentRow);
                classe.Professores.Remove(idProfessorSlecionado);
            }
        }

        private void FormCadastroClasse_Load(object sender, EventArgs e)
        {
            getDadosTable();
            setEditarExcluirEnable(false);
        }

        private void getDadosTable()
        {
            gridDados.DataSource = dao.getClasses();
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Código")
                    column.Width = 60;
                if (column.DataPropertyName == "Nome")
                    column.Width = 300;
            }
            gridDados.Refresh();
        }

        private void setFieldsEnable(bool enable)
        {
            textBoxNome.Enabled = enable;
            btnAddProfessor.Enabled = enable;
            btnRemoveProfessor.Enabled = enable;
            gridProfessores.Enabled = enable;
        }

        private void setEditarExcluirEnable(bool enable)
        {
            controlActions.BtnEditar.Enabled = enable;
            controlActions.BtnExcluir.Enabled = enable;
        }

        private void reset()
        {
            if (gridDados.RowCount > 0)
            {
                textBoxNome.Text = "";
                gridDados.CurrentRow.Selected = false;
                classe = new ClasseEntity();
                gridDados.Enabled = true;
                gridProfessores.Rows.Clear();
                setEditarExcluirEnable(false);
                idProfessoresExcluir = new List<int>();
            }
        }

        private void getDadosRow()
        {
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Código")
                {
                    int id = Int32.Parse((gridDados.CurrentRow.Cells[column.DisplayIndex].Value).ToString());
                    classe = dao.getClasseComProfessores(id);
                    textBoxNome.Text = classe.Nome;
                    gridProfessores.Rows.Clear();
                    foreach(PessoaEntity professor in classe.Professores.Values)
                    {
                        gridProfessores.Rows.Add(new Object[] {professor.Id, professor.Nome, professor.DataNascimento.ToString("dd/MM/yyyy") });
                    }
                    gridProfessores.Refresh();
                }
            }
        }
    }
}
