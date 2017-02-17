namespace EBDSystem.Components
{
    partial class FormSearch
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
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.controlConfirmCancel = new EBDSystem.Components.ControlConfirmCancel();
            this.gridSearch = new EBDSystem.Components.MyGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxField
            // 
            this.textBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxField.Location = new System.Drawing.Point(12, 12);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(722, 20);
            this.textBoxField.TabIndex = 2;
            this.textBoxField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxField_KeyPressed);
            // 
            // controlConfirmCancel
            // 
            this.controlConfirmCancel.Location = new System.Drawing.Point(12, 413);
            this.controlConfirmCancel.Name = "controlConfirmCancel";
            this.controlConfirmCancel.Size = new System.Drawing.Size(785, 36);
            this.controlConfirmCancel.TabIndex = 5;
            // 
            // gridSearch
            // 
            this.gridSearch.AllowUserToAddRows = false;
            this.gridSearch.AllowUserToDeleteRows = false;
            this.gridSearch.AllowUserToResizeRows = false;
            this.gridSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearch.Identificador = 0;
            this.gridSearch.Location = new System.Drawing.Point(12, 38);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.ReadOnly = true;
            this.gridSearch.Size = new System.Drawing.Size(785, 369);
            this.gridSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EBDSystem.Properties.Resources.add_12x12_fw;
            this.btnAdd.Location = new System.Drawing.Point(769, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 21);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::EBDSystem.Properties.Resources.research_12x12_fw;
            this.btnSearch.Location = new System.Drawing.Point(740, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.controlConfirmCancel);
            this.Controls.Add(this.gridSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxField;
        private MyGrid gridSearch;
        private ControlConfirmCancel controlConfirmCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}