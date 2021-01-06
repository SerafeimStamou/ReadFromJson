
namespace WinFormsUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PeopleTable = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SortByBtn = new System.Windows.Forms.Button();
            this.LastNameRadio = new System.Windows.Forms.RadioButton();
            this.AgeRadio = new System.Windows.Forms.RadioButton();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleTable
            // 
            this.PeopleTable.AutoGenerateColumns = false;
            this.PeopleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.PeopleTable.DataSource = this.personBindingSource;
            this.PeopleTable.Location = new System.Drawing.Point(-1, 68);
            this.PeopleTable.Name = "PeopleTable";
            this.PeopleTable.RowHeadersWidth = 51;
            this.PeopleTable.RowTemplate.Height = 24;
            this.PeopleTable.Size = new System.Drawing.Size(943, 443);
            this.PeopleTable.TabIndex = 0;
            this.PeopleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleTable_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DataLibrary.Person);
            // 
            // SortByBtn
            // 
            this.SortByBtn.Location = new System.Drawing.Point(-1, 12);
            this.SortByBtn.Name = "SortByBtn";
            this.SortByBtn.Size = new System.Drawing.Size(88, 37);
            this.SortByBtn.TabIndex = 1;
            this.SortByBtn.Text = "Sort By";
            this.SortByBtn.UseVisualStyleBackColor = true;
            this.SortByBtn.Click += new System.EventHandler(this.SortByBtn_Click);
            // 
            // LastNameRadio
            // 
            this.LastNameRadio.AutoSize = true;
            this.LastNameRadio.Location = new System.Drawing.Point(105, 20);
            this.LastNameRadio.Name = "LastNameRadio";
            this.LastNameRadio.Size = new System.Drawing.Size(93, 21);
            this.LastNameRadio.TabIndex = 2;
            this.LastNameRadio.TabStop = true;
            this.LastNameRadio.Text = "LastName";
            this.LastNameRadio.UseVisualStyleBackColor = true;
            this.LastNameRadio.CheckedChanged += new System.EventHandler(this.LastNameRadio_CheckedChanged);
            // 
            // AgeRadio
            // 
            this.AgeRadio.AutoSize = true;
            this.AgeRadio.Location = new System.Drawing.Point(216, 20);
            this.AgeRadio.Name = "AgeRadio";
            this.AgeRadio.Size = new System.Drawing.Size(54, 21);
            this.AgeRadio.TabIndex = 3;
            this.AgeRadio.TabStop = true;
            this.AgeRadio.Text = "Age";
            this.AgeRadio.UseVisualStyleBackColor = true;
            this.AgeRadio.CheckedChanged += new System.EventHandler(this.AgeRadio_CheckedChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(287, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(89, 37);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search By";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(600, 21);
            this.SearchTxtBox.Multiline = true;
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(159, 22);
            this.SearchTxtBox.TabIndex = 6;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // LastNameCheckBox
            // 
            this.LastNameCheckBox.AutoSize = true;
            this.LastNameCheckBox.Location = new System.Drawing.Point(393, 23);
            this.LastNameCheckBox.Name = "LastNameCheckBox";
            this.LastNameCheckBox.Size = new System.Drawing.Size(94, 21);
            this.LastNameCheckBox.TabIndex = 7;
            this.LastNameCheckBox.Text = "LastName";
            this.LastNameCheckBox.UseVisualStyleBackColor = true;
            this.LastNameCheckBox.CheckedChanged += new System.EventHandler(this.LastNameCheckBox_CheckedChanged);
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.AutoSize = true;
            this.EmailCheckBox.Location = new System.Drawing.Point(506, 23);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(64, 21);
            this.EmailCheckBox.TabIndex = 8;
            this.EmailCheckBox.Text = "Email";
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            this.EmailCheckBox.CheckedChanged += new System.EventHandler(this.EmailCheckBox_CheckedChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(803, 12);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 37);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 563);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.EmailCheckBox);
            this.Controls.Add(this.LastNameCheckBox);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AgeRadio);
            this.Controls.Add(this.LastNameRadio);
            this.Controls.Add(this.SortByBtn);
            this.Controls.Add(this.PeopleTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeopleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button SortByBtn;
        private System.Windows.Forms.RadioButton LastNameRadio;
        private System.Windows.Forms.RadioButton AgeRadio;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.CheckBox LastNameCheckBox;
        private System.Windows.Forms.CheckBox EmailCheckBox;
        private System.Windows.Forms.Button ResetBtn;
    }
}

