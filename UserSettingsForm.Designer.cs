namespace DSVN
{
    partial class UserSettingsForm
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
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRights = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonSaveUserSettings = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNumberRows = new System.Windows.Forms.TextBox();
            this.buttonRowsLeft = new System.Windows.Forms.Button();
            this.buttonRowsRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnLogin,
            this.ColumnPassword,
            this.ColumnRights});
            this.dataGridViewUserList.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.RowTemplate.Height = 24;
            this.dataGridViewUserList.Size = new System.Drawing.Size(776, 363);
            this.dataGridViewUserList.TabIndex = 0;
            this.dataGridViewUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUserList_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Ид";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Логин";
            this.ColumnLogin.Name = "ColumnLogin";
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Пароль";
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // ColumnRights
            // 
            this.ColumnRights.HeaderText = "Права";
            this.ColumnRights.Items.AddRange(new object[] {
            "admin",
            "user",
            "guest"});
            this.ColumnRights.Name = "ColumnRights";
            // 
            // buttonSaveUserSettings
            // 
            this.buttonSaveUserSettings.Location = new System.Drawing.Point(537, 415);
            this.buttonSaveUserSettings.Name = "buttonSaveUserSettings";
            this.buttonSaveUserSettings.Size = new System.Drawing.Size(239, 23);
            this.buttonSaveUserSettings.TabIndex = 1;
            this.buttonSaveUserSettings.Text = "Сохранить изменения";
            this.buttonSaveUserSettings.UseVisualStyleBackColor = true;
            this.buttonSaveUserSettings.Click += new System.EventHandler(this.ButtonSaveUserSettings_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::DSVN.Properties.Resources.cross;
            this.buttonDelete.Location = new System.Drawing.Point(257, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 26);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textBoxNumberRows
            // 
            this.textBoxNumberRows.Location = new System.Drawing.Point(80, 14);
            this.textBoxNumberRows.Name = "textBoxNumberRows";
            this.textBoxNumberRows.Size = new System.Drawing.Size(58, 22);
            this.textBoxNumberRows.TabIndex = 3;
            // 
            // buttonRowsLeft
            // 
            this.buttonRowsLeft.BackgroundImage = global::DSVN.Properties.Resources.left;
            this.buttonRowsLeft.Location = new System.Drawing.Point(42, 12);
            this.buttonRowsLeft.Name = "buttonRowsLeft";
            this.buttonRowsLeft.Size = new System.Drawing.Size(32, 26);
            this.buttonRowsLeft.TabIndex = 4;
            this.buttonRowsLeft.UseVisualStyleBackColor = true;
            this.buttonRowsLeft.Click += new System.EventHandler(this.ButtonRowsLeft_Click);
            // 
            // buttonRowsRight
            // 
            this.buttonRowsRight.BackgroundImage = global::DSVN.Properties.Resources.right;
            this.buttonRowsRight.Location = new System.Drawing.Point(144, 12);
            this.buttonRowsRight.Name = "buttonRowsRight";
            this.buttonRowsRight.Size = new System.Drawing.Size(32, 26);
            this.buttonRowsRight.TabIndex = 5;
            this.buttonRowsRight.UseVisualStyleBackColor = true;
            this.buttonRowsRight.Click += new System.EventHandler(this.ButtonRowsRight_Click);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRowsRight);
            this.Controls.Add(this.buttonRowsLeft);
            this.Controls.Add(this.textBoxNumberRows);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaveUserSettings);
            this.Controls.Add(this.dataGridViewUserList);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.Button buttonSaveUserSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnRights;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNumberRows;
        private System.Windows.Forms.Button buttonRowsLeft;
        private System.Windows.Forms.Button buttonRowsRight;
    }
}