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
    public partial class FormCadastroPessoaMembro : Form
    {
        private PessoaDAO dao = new PessoaDAO();
        private PessoaEntity pessoa = new PessoaEntity();
        private bool isSubCadastro;
        private object[] fieldsValidation;
        public FormCadastroPessoaMembro(bool isSubCadastro)
        {
            InitializeComponent();
            this.isSubCadastro = isSubCadastro;
            configTela();
            configEvents();
        }

        private void configTela()
        {
            BairroDAO daoBairro = new BairroDAO();
            searchBairro.setDao(daoBairro);
            searchBairro.setTitleForm("Busca de Bairros");
            searchBairro.TextField.AccessibleName = "Bairro";
            searchBairro.setFormAdd(new FormCadastroBairro(true));
            setFieldsEnable(false);
            PaiDAO daoPai = new PaiDAO();
            searchPai.setDao(daoPai);
            searchPai.setTitleForm("Busca Pai");
            searchPai.TextField.AccessibleName = "Pai";
            ConjugeDAO daoConjuge = new ConjugeDAO();
            searchConjuge.setDao(daoConjuge);
            searchConjuge.setTitleForm("Busca Cônjuge");
            searchConjuge.TextField.AccessibleName ="Cônjuge";
            MaeDAO daoMae = new MaeDAO();
            searchMae.setDao(daoMae);
            searchMae.setTitleForm("Busca Mãe");
            searchMae.TextField.AccessibleName = "Mãe";
            SortedDictionary<int, String> tipoList = new SortedDictionary<int, string>();
            tipoList.Add(0, "Selecione");
            tipoList.Add(PessoaEntity.MEMBRO, "Membro");
            tipoList.Add(PessoaEntity.CADASTRO_SIMPLES, "Não-membro");
            comboBoxTipo.DataSource = new BindingSource(tipoList, null);
            comboBoxTipo.DisplayMember = "Value";
            comboBoxTipo.ValueMember = "Key";
            SortedDictionary<int, String> estadoCivilList = new SortedDictionary<int, string>();
            estadoCivilList.Add(0, "Selecione");
            estadoCivilList.Add(PessoaEntity.SOLTEIRO, "Solteiro(a)");
            estadoCivilList.Add(PessoaEntity.CASADO, "Casado(a)");
            estadoCivilList.Add(PessoaEntity.VIUVO, "Víuvo(a)");
            comboBoxEstCivil.DataSource = new BindingSource(estadoCivilList, null);
            comboBoxEstCivil.DisplayMember = "Value";
            comboBoxEstCivil.ValueMember = "Key";
            fieldsValidation = new Object[] { comboBoxTipo, textBoxNome, dateTimeNascimento, comboBoxSexo
                    ,comboBoxEstCivil,searchBairro.TextField, textBoxEndereco};
        }

        private void configEvents()
        {
            controlActions.BtnIncluir.Click += new EventHandler(btnIncluir_Click);
            controlActions.BtnEditar.Click += new EventHandler(btnEditar_Click);
            controlActions.BtnExcluir.Click += new EventHandler(btnExcluir_Click);
            controlConfirmCancel.BtnCancelar.Click += new EventHandler(btnCancelar_Click);
            controlConfirmCancel.BtnConfirmar.Click += new EventHandler(btnConfirmar_Click);
            comboBoxEstCivil.SelectedIndexChanged += new EventHandler(comboEstadoCivil_Changed);
            gridDados.Click += new EventHandler(gridDados_Click);
        }

        private void setFieldsEnable(bool enable)
        {
            textBoxNome.Enabled = enable;
            textBoxEndereco.Enabled = enable;
            dateTimeNascimento.Enabled = enable;
            searchBairro.Enabled = enable;
            maskedTelPrincipal.Enabled = enable;
            maskedTelSecundario.Enabled = enable;
            richTextComentario.Enabled = enable;
            comboBoxSexo.Enabled = enable;
            comboBoxEstCivil.Enabled = enable;
            comboBoxTipo.Enabled = enable;
            textBoxNro.Enabled = enable;
            maskedCep.Enabled = enable;
            searchPai.Enabled = enable;
            searchMae.Enabled = enable;
            searchConjuge.Enabled = enable && comboBoxEstCivil.SelectedValue.Equals(PessoaEntity.CASADO);
        }

        private void reset()
        {
            if (gridDados.RowCount > 0)
            {
                pessoa = new PessoaEntity();
                textBoxNome.Text = "";
                searchBairro.TextField.Text = "";
                dateTimeNascimento.Text = "";
                textBoxEndereco.Text = "";
                maskedTelPrincipal.Text = "";
                maskedTelSecundario.Text = "";
                richTextComentario.Text = "";
                gridDados.CurrentRow.Selected = false;
                setEditarExcluirEnable(false);
                gridDados.Enabled = true;
                comboBoxSexo.SelectedIndex = 0;
                comboBoxEstCivil.SelectedValue = 0;
                comboBoxTipo.SelectedValue = 0;
                searchMae.TextField.Text = "";
                searchPai.TextField.Text = "";
                searchConjuge.TextField.Text = "";
            }
        }

        private void setEditarExcluirEnable(bool enable)
        {
            controlActions.BtnEditar.Enabled = enable;
            controlActions.BtnExcluir.Enabled = enable;
        }

        private void getDadosTable()
        {
            gridDados.DataSource = dao.getPessoas();
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Nome")
                {
                    column.Width = 300;
                }
                else if (column.DataPropertyName == "Tel. Principal" || column.DataPropertyName == "Tel. Secundário")
                {
                    column.Width = 150;
                }
                else if (column.DataPropertyName == "Código")
                {
                    column.Width = 60;
                }
            }
            gridDados.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            BairroEntity bairro = (BairroEntity)searchBairro.Entidade;
            PessoaEntity mae = (PessoaEntity)searchMae.Entidade;
            PessoaEntity pai = (PessoaEntity)searchPai.Entidade;
            PessoaEntity conjuge = (PessoaEntity)searchConjuge.Entidade;
            if (bairro != null)
            {
                pessoa.IdBairro = bairro.Id;
            }
            if(mae != null)
            {
                pessoa.IdMae = mae.Id;
            }
            if(pai != null)
            {
                pessoa.IdPai = pai.Id;
            }
            if(conjuge != null && conjuge.Id>0)
            {
                pessoa.IdConjuge = conjuge.Id;
            }
            if (controlActions.Status != ControlActions.STAND_BY)
                if (Validator.validaCampos(fieldsValidation))
                {
                    pessoa.Nome = textBoxNome.Text;
                    pessoa.DataNascimento = dateTimeNascimento.Value;
                    pessoa.Endereco = textBoxEndereco.Text;
                    pessoa.TelefonePrincipal = maskedTelPrincipal.Text;
                    pessoa.TelefoneSecundario = maskedTelSecundario.Text;
                    pessoa.Comentario = richTextComentario.Text;
                    pessoa.Sexo = char.Parse(comboBoxSexo.Text);
                    pessoa.EstadoCivil = Int32.Parse(comboBoxEstCivil.SelectedValue.ToString());
                    pessoa.Cep = maskedCep.Text;
                    pessoa.Tipo = Int32.Parse(comboBoxTipo.SelectedValue.ToString());
                    pessoa.Numero = textBoxNro.Text;
                    bool sucess = false;
                    if (controlActions.Status == ControlActions.INSERIR)
                    {
                        sucess = dao.inserir(pessoa);
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
                        sucess = dao.editar(pessoa);
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

        private void getDadosRow()
        {
            foreach (DataGridViewColumn column in gridDados.Columns)
            {
                if (column.DataPropertyName == "Código")
                {
                    int id = Int32.Parse((gridDados.CurrentRow.Cells[column.DisplayIndex].Value).ToString());
                    pessoa = (PessoaEntity)dao.getEntityByIdentificador(id);
                }
            }
            textBoxNome.Text = pessoa.Nome;
            textBoxEndereco.Text = pessoa.Endereco;
            dateTimeNascimento.Value = pessoa.DataNascimento;
            searchBairro.TextField.Text = pessoa.Bairro;
            maskedTelPrincipal.Text = pessoa.TelefonePrincipal;
            maskedTelSecundario.Text = pessoa.TelefoneSecundario;
            richTextComentario.Text = pessoa.Comentario;
            comboBoxTipo.SelectedValue = pessoa.Tipo;
            comboBoxEstCivil.SelectedValue = pessoa.EstadoCivil;
            comboBoxSexo.SelectedItem = pessoa.Sexo.ToString();
            searchPai.TextField.Text = pessoa.Pai;
            searchMae.TextField.Text = pessoa.Mae;
            maskedCep.Text = pessoa.Cep;
            textBoxNro.Text = pessoa.Numero;
            searchConjuge.TextField.Text = pessoa.Conjuge;
            if (pessoa.IdConjuge > 0) {
                searchConjuge.Entidade = (PessoaEntity)dao.getEntityByIdentificador(pessoa.IdConjuge);
            }
        }

        private void comboEstadoCivil_Changed(object sender, EventArgs e)
        {
            if (comboBoxEstCivil.SelectedValue.Equals(PessoaEntity.CASADO))
            {
                searchConjuge.Enabled = controlActions.Status != ControlActions.STAND_BY;
            }else if(comboBoxEstCivil.SelectedValue.Equals(PessoaEntity.SOLTEIRO))
            {
                searchConjuge.TextField.Text = "";
                searchConjuge.Entidade = new PessoaEntity();
                pessoa.IdConjuge = 0;
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
                DialogResult option = MessageBox.Show("Deseja mesmo excluir esta pessoa?", "Excluir Pessoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    getDadosRow();
                    if (dao.excluir(pessoa.Id))
                    {
                        gridDados.Rows.Remove(gridDados.CurrentRow);
                        reset();
                        controlActions.Status = ControlActions.STAND_BY;
                    }
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

        private void FormCadastroPessoa_Load(object sender, EventArgs e)
        {
            getDadosTable();
            setEditarExcluirEnable(false);
        }
    }
}
