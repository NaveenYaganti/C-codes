
namespace StudentDatabaseProject
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
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.insertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(23, 117);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(78, 17);
            this.contactLabel.TabIndex = 11;
            this.contactLabel.Text = "Contact No";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(129, 112);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(139, 22);
            this.contactNoTextBox.TabIndex = 7;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(64, 176);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Age";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(129, 171);
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(139, 22);
            this.ageNumericUpDown.TabIndex = 13;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 17);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Student Name";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(129, 57);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.studentNameTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(27, 13);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(74, 17);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "Student ID";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(129, 8);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(139, 22);
            this.studentIdTextBox.TabIndex = 5;
            // 
            // insertPanel
            // 
            this.insertPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insertPanel.Controls.Add(this.genderComboBox);
            this.insertPanel.Controls.Add(this.genderLabel);
            this.insertPanel.Controls.Add(this.studentIdTextBox);
            this.insertPanel.Controls.Add(this.idLabel);
            this.insertPanel.Controls.Add(this.studentNameTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Controls.Add(this.ageNumericUpDown);
            this.insertPanel.Controls.Add(this.ageLabel);
            this.insertPanel.Controls.Add(this.contactNoTextBox);
            this.insertPanel.Controls.Add(this.contactLabel);
            this.insertPanel.Location = new System.Drawing.Point(3, 71);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(279, 275);
            this.insertPanel.TabIndex = 17;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(129, 224);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(139, 24);
            this.genderComboBox.TabIndex = 15;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(41, 231);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 14;
            this.genderLabel.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student Details";
            // 
            // insertButton
            // 
            this.insertButton.ForeColor = System.Drawing.Color.Black;
            this.insertButton.Location = new System.Drawing.Point(103, 371);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 29);
            this.insertButton.TabIndex = 20;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(319, 371);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 29);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(534, 371);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 29);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(757, 371);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.MinimumWidth = 6;
            this.Contact.Name = "Contact";
            this.Contact.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Age,
            this.Contact});
            this.dataGridView1.Location = new System.Drawing.Point(298, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 275);
            this.dataGridView1.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1115, 371);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 29);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(924, 374);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(185, 22);
            this.searchTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 468);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertPanel);
            this.Name = "Form1";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private Student_DataDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private Student_DataDataSet2 student_DataDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

