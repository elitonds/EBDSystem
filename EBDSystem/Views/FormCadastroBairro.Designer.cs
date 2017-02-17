namespace EBDSystem.Views
{
    partial class FormCadastroBairro
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
            this.labelCidade = new System.Windows.Forms.Label();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.searchCidades = new EBDSystem.Components.Search();
            this.controlActions = new EBDSystem.Components.ControlActions();
            this.controlConfirmCancel = new EBDSystem.Components.ControlConfirmCancel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 99);
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
            this.textBoxNome.Location = new System.Drawing.Point(58, 95);
            this.textBoxNome.MaxLength = 100;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(614, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(13, 125);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 3;
            this.labelCidade.Text = "Cidade:";
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
            this.gridDados.Location = new System.Drawing.Point(16, 147);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.Size = new System.Drawing.Size(656, 260);
            this.gridDados.TabIndex = 5;
            // 
            // searchCidades
            // 
            this.searchCidades.Entidade = null;
            this.searchCidades.Identificador = 0;
            this.searchCidades.Location = new System.Drawing.Point(58, 121);
            this.searchCidades.Name = "searchCidades";
            this.searchCidades.Size = new System.Drawing.Size(310, 20);
            this.searchCidades.TabIndex = 4;
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
            // controlConfirmCancel
            // 
            this.controlConfirmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlConfirmCancel.Location = new System.Drawing.Point(16, 413);
            this.controlConfirmCancel.Name = "controlConfirmCancel";
            this.controlConfirmCancel.Size = new System.Drawing.Size(656, 36);
            this.controlConfirmCancel.TabIndex = 6;
            // 
            // FormCadastroBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.controlConfirmCancel);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.searchCidades);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.controlActions);
            this.Name = "FormCadastroBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Bairro";
            this.Load += new System.EventHandler(this.FormCadastroBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ControlActions controlActions;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCidade;
        private Components.Search searchCidades;
        private System.Windows.Forms.DataGridView gridDados;
        private Components.ControlConfirmCancel controlConfirmCancel;
    }
}