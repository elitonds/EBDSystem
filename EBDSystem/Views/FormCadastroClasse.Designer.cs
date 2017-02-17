namespace EBDSystem.Views
{
    partial class FormCadastroClasse
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
            this.groupBoxprofessores = new System.Windows.Forms.GroupBox();
            this.gridProfessores = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.controlConfirmCancel = new EBDSystem.Components.ControlConfirmCancel();
            this.gridDados = new EBDSystem.Components.MyGrid();
            this.controlActions = new EBDSystem.Components.ControlActions();
            this.groupBoxprofessores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 97);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.AccessibleName = "Nome";
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(58, 94);
            this.textBoxNome.MaxLength = 100;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(614, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // groupBoxprofessores
            // 
            this.groupBoxprofessores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxprofessores.Controls.Add(this.gridProfessores);
            this.groupBoxprofessores.Controls.Add(this.btnRemoveProfessor);
            this.groupBoxprofessores.Controls.Add(this.btnAddProfessor);
            this.groupBoxprofessores.Location = new System.Drawing.Point(13, 120);
            this.groupBoxprofessores.Name = "groupBoxprofessores";
            this.groupBoxprofessores.Size = new System.Drawing.Size(659, 148);
            this.groupBoxprofessores.TabIndex = 3;
            this.groupBoxprofessores.TabStop = false;
            this.groupBoxprofessores.Text = "Professores";
            // 
            // gridProfessores
            // 
            this.gridProfessores.AllowUserToAddRows = false;
            this.gridProfessores.AllowUserToDeleteRows = false;
            this.gridProfessores.AllowUserToOrderColumns = true;
            this.gridProfessores.AllowUserToResizeRows = false;
            this.gridProfessores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProfessores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.datanascimento});
            this.gridProfessores.Location = new System.Drawing.Point(6, 48);
            this.gridProfessores.Name = "gridProfessores";
            this.gridProfessores.Size = new System.Drawing.Size(647, 94);
            this.gridProfessores.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 453;
            // 
            // datanascimento
            // 
            this.datanascimento.HeaderText = "Data Nasc.";
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.Width = 90;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Image = global::EBDSystem.Properties.Resources.remove_14x14_fw;
            this.btnRemoveProfessor.Location = new System.Drawing.Point(35, 19);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(28, 23);
            this.btnRemoveProfessor.TabIndex = 1;
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
            this.btnRemoveProfessor.Click += new System.EventHandler(this.btnRemoveProfessor_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Image = global::EBDSystem.Properties.Resources.add_14x14_fw;
            this.btnAddProfessor.Location = new System.Drawing.Point(6, 19);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(28, 23);
            this.btnAddProfessor.TabIndex = 0;
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // controlConfirmCancel
            // 
            this.controlConfirmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlConfirmCancel.Location = new System.Drawing.Point(12, 453);
            this.controlConfirmCancel.Name = "controlConfirmCancel";
            this.controlConfirmCancel.Size = new System.Drawing.Size(660, 36);
            this.controlConfirmCancel.TabIndex = 5;
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.AllowUserToOrderColumns = true;
            this.gridDados.AllowUserToResizeRows = false;
            this.gridDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Identificador = 0;
            this.gridDados.Location = new System.Drawing.Point(13, 274);
            this.gridDados.Name = "gridDados";
            this.gridDados.Size = new System.Drawing.Size(659, 173);
            this.gridDados.TabIndex = 4;
            // 
            // controlActions
            // 
            this.controlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlActions.Location = new System.Drawing.Point(12, 12);
            this.controlActions.Name = "controlActions";
            this.controlActions.Size = new System.Drawing.Size(660, 76);
            this.controlActions.Status = 0;
            this.controlActions.TabIndex = 0;
            // 
            // FormCadastroClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.controlConfirmCancel);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.groupBoxprofessores);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.controlActions);
            this.Name = "FormCadastroClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Classe";
            this.Load += new System.EventHandler(this.FormCadastroClasse_Load);
            this.groupBoxprofessores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ControlActions controlActions;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBoxprofessores;
        private Components.MyGrid gridDados;
        private Components.ControlConfirmCancel controlConfirmCancel;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.DataGridView gridProfessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimento;
    }
}