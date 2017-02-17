namespace EBDSystem.Views
{
    partial class FormCadastroCidade
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
            this.labelUf = new System.Windows.Forms.Label();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.controlConfirmCancel = new EBDSystem.Components.ControlConfirmCancel();
            this.controlActions = new EBDSystem.Components.ControlActions();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 94);
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
            this.textBoxNome.Location = new System.Drawing.Point(56, 91);
            this.textBoxNome.MaxLength = 100;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(616, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(12, 119);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(24, 13);
            this.labelUf.TabIndex = 3;
            this.labelUf.Text = "UF:";
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.AccessibleName = "UF";
            this.comboBoxUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Location = new System.Drawing.Point(56, 116);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUf.TabIndex = 4;
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
            this.gridDados.Location = new System.Drawing.Point(12, 143);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.Size = new System.Drawing.Size(660, 268);
            this.gridDados.TabIndex = 5;
            // 
            // controlConfirmCancel
            // 
            this.controlConfirmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlConfirmCancel.Location = new System.Drawing.Point(12, 417);
            this.controlConfirmCancel.Name = "controlConfirmCancel";
            this.controlConfirmCancel.Size = new System.Drawing.Size(660, 36);
            this.controlConfirmCancel.TabIndex = 10;
            // 
            // controlActions
            // 
            this.controlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlActions.Location = new System.Drawing.Point(12, 12);
            this.controlActions.Name = "controlActions";
            this.controlActions.Size = new System.Drawing.Size(660, 79);
            this.controlActions.Status = 0;
            this.controlActions.TabIndex = 0;
            // 
            // FormCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.controlConfirmCancel);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.controlActions);
            this.Controls.Add(this.comboBoxUf);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FormCadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cidade";
            this.Load += new System.EventHandler(this.FormCadastroCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private Components.ControlActions controlActions;
        private Components.ControlConfirmCancel controlConfirmCancel;
        private System.Windows.Forms.DataGridView gridDados;
    }
}