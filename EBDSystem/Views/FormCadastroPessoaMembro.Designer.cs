namespace EBDSystem.Views
{
    partial class FormCadastroPessoaMembro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.richTextComentario = new System.Windows.Forms.RichTextBox();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.labelTelPrincipal = new System.Windows.Forms.Label();
            this.maskedTelPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelSecundario = new System.Windows.Forms.MaskedTextBox();
            this.labelTelSecundario = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.comboBoxEstCivil = new System.Windows.Forms.ComboBox();
            this.labelNro = new System.Windows.Forms.Label();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.maskedCep = new System.Windows.Forms.MaskedTextBox();
            this.labelMae = new System.Windows.Forms.Label();
            this.labelPai = new System.Windows.Forms.Label();
            this.searchPai = new EBDSystem.Components.Search();
            this.searchMae = new EBDSystem.Components.Search();
            this.controlConfirmCancel = new EBDSystem.Components.ControlConfirmCancel();
            this.searchBairro = new EBDSystem.Components.Search();
            this.controlActions = new EBDSystem.Components.ControlActions();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelConjuge = new System.Windows.Forms.Label();
            this.searchConjuge = new EBDSystem.Components.Search();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(15, 121);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.AccessibleName = "Nome";
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(89, 117);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(794, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(15, 147);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(64, 13);
            this.labelDataNasc.TabIndex = 3;
            this.labelDataNasc.Text = "Data Nasc.:";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.AccessibleName = "Data Nascimento";
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(89, 143);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(105, 20);
            this.dateTimeNascimento.TabIndex = 6;
            this.dateTimeNascimento.TabStop = false;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(293, 173);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 7;
            this.labelEndereco.Text = "Endereço:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.AccessibleName = "Endereço";
            this.textBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEndereco.Location = new System.Drawing.Point(355, 170);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(528, 20);
            this.textBoxEndereco.TabIndex = 14;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(15, 173);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(37, 13);
            this.labelBairro.TabIndex = 5;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(15, 278);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(63, 13);
            this.labelComentario.TabIndex = 8;
            this.labelComentario.Text = "Comentário:";
            // 
            // richTextComentario
            // 
            this.richTextComentario.AccessibleName = "Comentário";
            this.richTextComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextComentario.Location = new System.Drawing.Point(89, 275);
            this.richTextComentario.MaxLength = 600;
            this.richTextComentario.Name = "richTextComentario";
            this.richTextComentario.Size = new System.Drawing.Size(794, 86);
            this.richTextComentario.TabIndex = 28;
            this.richTextComentario.Text = "";
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.AllowUserToResizeRows = false;
            this.gridDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Location = new System.Drawing.Point(17, 367);
            this.gridDados.Name = "gridDados";
            this.gridDados.Size = new System.Drawing.Size(866, 147);
            this.gridDados.TabIndex = 19;
            // 
            // labelTelPrincipal
            // 
            this.labelTelPrincipal.AutoSize = true;
            this.labelTelPrincipal.Location = new System.Drawing.Point(15, 252);
            this.labelTelPrincipal.Name = "labelTelPrincipal";
            this.labelTelPrincipal.Size = new System.Drawing.Size(71, 13);
            this.labelTelPrincipal.TabIndex = 8;
            this.labelTelPrincipal.Text = "Tel. Principal:";
            // 
            // maskedTelPrincipal
            // 
            this.maskedTelPrincipal.AccessibleName = "Telefone Principal";
            this.maskedTelPrincipal.Location = new System.Drawing.Point(91, 249);
            this.maskedTelPrincipal.Mask = "(00)000000000";
            this.maskedTelPrincipal.Name = "maskedTelPrincipal";
            this.maskedTelPrincipal.Size = new System.Drawing.Size(199, 20);
            this.maskedTelPrincipal.TabIndex = 24;
            // 
            // maskedTelSecundario
            // 
            this.maskedTelSecundario.AccessibleName = "Telefone Secundário";
            this.maskedTelSecundario.Location = new System.Drawing.Point(391, 249);
            this.maskedTelSecundario.Mask = "(00)000000000";
            this.maskedTelSecundario.Name = "maskedTelSecundario";
            this.maskedTelSecundario.Size = new System.Drawing.Size(199, 20);
            this.maskedTelSecundario.TabIndex = 26;
            // 
            // labelTelSecundario
            // 
            this.labelTelSecundario.AutoSize = true;
            this.labelTelSecundario.Location = new System.Drawing.Point(300, 252);
            this.labelTelSecundario.Name = "labelTelSecundario";
            this.labelTelSecundario.Size = new System.Drawing.Size(85, 13);
            this.labelTelSecundario.TabIndex = 10;
            this.labelTelSecundario.Text = "Tel. Secundário:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(201, 149);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 16;
            this.labelSexo.Text = "Sexo:";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.AccessibleName = "Sexo";
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.comboBoxSexo.Location = new System.Drawing.Point(241, 144);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(52, 21);
            this.comboBoxSexo.TabIndex = 8;
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Location = new System.Drawing.Point(299, 149);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(50, 13);
            this.labelEstadoCivil.TabIndex = 18;
            this.labelEstadoCivil.Text = "Est. Civil:";
            // 
            // comboBoxEstCivil
            // 
            this.comboBoxEstCivil.AccessibleName = "Est. Civil";
            this.comboBoxEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstCivil.FormattingEnabled = true;
            this.comboBoxEstCivil.Location = new System.Drawing.Point(355, 144);
            this.comboBoxEstCivil.Name = "comboBoxEstCivil";
            this.comboBoxEstCivil.Size = new System.Drawing.Size(182, 21);
            this.comboBoxEstCivil.TabIndex = 10;
            // 
            // labelNro
            // 
            this.labelNro.AutoSize = true;
            this.labelNro.Location = new System.Drawing.Point(16, 199);
            this.labelNro.Name = "labelNro";
            this.labelNro.Size = new System.Drawing.Size(30, 13);
            this.labelNro.TabIndex = 42;
            this.labelNro.Text = "Nro.:";
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(89, 196);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(119, 20);
            this.textBoxNro.TabIndex = 16;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(214, 199);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 13);
            this.labelCep.TabIndex = 44;
            this.labelCep.Text = "CEP:";
            // 
            // maskedCep
            // 
            this.maskedCep.Location = new System.Drawing.Point(251, 196);
            this.maskedCep.Mask = "00000-000";
            this.maskedCep.Name = "maskedCep";
            this.maskedCep.Size = new System.Drawing.Size(180, 20);
            this.maskedCep.TabIndex = 18;
            // 
            // labelMae
            // 
            this.labelMae.AutoSize = true;
            this.labelMae.Location = new System.Drawing.Point(16, 226);
            this.labelMae.Name = "labelMae";
            this.labelMae.Size = new System.Drawing.Size(31, 13);
            this.labelMae.TabIndex = 46;
            this.labelMae.Text = "Mãe:";
            // 
            // labelPai
            // 
            this.labelPai.AutoSize = true;
            this.labelPai.Location = new System.Drawing.Point(469, 226);
            this.labelPai.Name = "labelPai";
            this.labelPai.Size = new System.Drawing.Size(25, 13);
            this.labelPai.TabIndex = 48;
            this.labelPai.Text = "Pai:";
            // 
            // searchPai
            // 
            this.searchPai.Entidade = null;
            this.searchPai.Identificador = 0;
            this.searchPai.Location = new System.Drawing.Point(506, 222);
            this.searchPai.Name = "searchPai";
            this.searchPai.Size = new System.Drawing.Size(377, 20);
            this.searchPai.TabIndex = 22;
            // 
            // searchMae
            // 
            this.searchMae.Entidade = null;
            this.searchMae.Identificador = 0;
            this.searchMae.Location = new System.Drawing.Point(89, 222);
            this.searchMae.Name = "searchMae";
            this.searchMae.Size = new System.Drawing.Size(377, 20);
            this.searchMae.TabIndex = 20;
            // 
            // controlConfirmCancel
            // 
            this.controlConfirmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlConfirmCancel.Location = new System.Drawing.Point(17, 520);
            this.controlConfirmCancel.Name = "controlConfirmCancel";
            this.controlConfirmCancel.Size = new System.Drawing.Size(866, 36);
            this.controlConfirmCancel.TabIndex = 40;
            // 
            // searchBairro
            // 
            this.searchBairro.Entidade = null;
            this.searchBairro.Identificador = 0;
            this.searchBairro.Location = new System.Drawing.Point(89, 169);
            this.searchBairro.Name = "searchBairro";
            this.searchBairro.Size = new System.Drawing.Size(204, 20);
            this.searchBairro.TabIndex = 12;
            // 
            // controlActions
            // 
            this.controlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlActions.Location = new System.Drawing.Point(12, 12);
            this.controlActions.Name = "controlActions";
            this.controlActions.Size = new System.Drawing.Size(871, 76);
            this.controlActions.Status = 0;
            this.controlActions.TabIndex = 0;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(15, 93);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.AccessibleName = "Tipo";
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(91, 90);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(157, 21);
            this.comboBoxTipo.TabIndex = 3;
            // 
            // labelConjuge
            // 
            this.labelConjuge.AutoSize = true;
            this.labelConjuge.Location = new System.Drawing.Point(543, 147);
            this.labelConjuge.Name = "labelConjuge";
            this.labelConjuge.Size = new System.Drawing.Size(49, 13);
            this.labelConjuge.TabIndex = 49;
            this.labelConjuge.Text = "Cônjuge:";
            // 
            // searchConjuge
            // 
            this.searchConjuge.Entidade = null;
            this.searchConjuge.Identificador = 0;
            this.searchConjuge.Location = new System.Drawing.Point(598, 145);
            this.searchConjuge.Name = "searchConjuge";
            this.searchConjuge.Size = new System.Drawing.Size(285, 20);
            this.searchConjuge.TabIndex = 50;
            // 
            // FormCadastroPessoaMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 561);
            this.Controls.Add(this.searchConjuge);
            this.Controls.Add(this.labelConjuge);
            this.Controls.Add(this.searchPai);
            this.Controls.Add(this.labelPai);
            this.Controls.Add(this.searchMae);
            this.Controls.Add(this.labelMae);
            this.Controls.Add(this.maskedCep);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.textBoxNro);
            this.Controls.Add(this.labelNro);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.comboBoxEstCivil);
            this.Controls.Add(this.labelEstadoCivil);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.maskedTelSecundario);
            this.Controls.Add(this.labelTelSecundario);
            this.Controls.Add(this.maskedTelPrincipal);
            this.Controls.Add(this.labelTelPrincipal);
            this.Controls.Add(this.controlConfirmCancel);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.richTextComentario);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.searchBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.labelDataNasc);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.controlActions);
            this.Name = "FormCadastroPessoaMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Membros/Pessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ControlActions controlActions;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelBairro;
        private Components.Search searchBairro;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.RichTextBox richTextComentario;
        private System.Windows.Forms.DataGridView gridDados;
        private Components.ControlConfirmCancel controlConfirmCancel;
        private System.Windows.Forms.Label labelTelPrincipal;
        private System.Windows.Forms.MaskedTextBox maskedTelPrincipal;
        private System.Windows.Forms.MaskedTextBox maskedTelSecundario;
        private System.Windows.Forms.Label labelTelSecundario;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label labelEstadoCivil;
        private System.Windows.Forms.ComboBox comboBoxEstCivil;
        private System.Windows.Forms.Label labelNro;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.MaskedTextBox maskedCep;
        private System.Windows.Forms.Label labelMae;
        private Components.Search searchMae;
        private Components.Search searchPai;
        private System.Windows.Forms.Label labelPai;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label labelConjuge;
        private Components.Search searchConjuge;
    }
}