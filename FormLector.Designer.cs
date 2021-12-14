
namespace AkademineSistema
{
    partial class FormLector
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLectorID = new System.Windows.Forms.TextBox();
            this.txtLectorFName = new System.Windows.Forms.TextBox();
            this.txtLectorLName = new System.Windows.Forms.TextBox();
            this.txtLectorSubject = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.dataGridGrades = new System.Windows.Forms.DataGridView();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtEditGrade = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lastname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Students";
            // 
            // txtLectorID
            // 
            this.txtLectorID.Location = new System.Drawing.Point(96, 64);
            this.txtLectorID.Name = "txtLectorID";
            this.txtLectorID.ReadOnly = true;
            this.txtLectorID.Size = new System.Drawing.Size(136, 22);
            this.txtLectorID.TabIndex = 31;
            // 
            // txtLectorFName
            // 
            this.txtLectorFName.Location = new System.Drawing.Point(96, 96);
            this.txtLectorFName.Name = "txtLectorFName";
            this.txtLectorFName.ReadOnly = true;
            this.txtLectorFName.Size = new System.Drawing.Size(136, 22);
            this.txtLectorFName.TabIndex = 32;
            // 
            // txtLectorLName
            // 
            this.txtLectorLName.Location = new System.Drawing.Point(96, 128);
            this.txtLectorLName.Name = "txtLectorLName";
            this.txtLectorLName.ReadOnly = true;
            this.txtLectorLName.Size = new System.Drawing.Size(136, 22);
            this.txtLectorLName.TabIndex = 33;
            // 
            // txtLectorSubject
            // 
            this.txtLectorSubject.Location = new System.Drawing.Point(96, 160);
            this.txtLectorSubject.Name = "txtLectorSubject";
            this.txtLectorSubject.ReadOnly = true;
            this.txtLectorSubject.Size = new System.Drawing.Size(136, 22);
            this.txtLectorSubject.TabIndex = 34;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(16, 376);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(240, 22);
            this.txtStudent.TabIndex = 35;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(344, 432);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(344, 400);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(16, 232);
            this.dataGridStudents.MultiSelect = false;
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.RowTemplate.Height = 24;
            this.dataGridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudents.Size = new System.Drawing.Size(312, 120);
            this.dataGridStudents.TabIndex = 39;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            // 
            // dataGridGrades
            // 
            this.dataGridGrades.AllowUserToAddRows = false;
            this.dataGridGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrades.Location = new System.Drawing.Point(16, 400);
            this.dataGridGrades.MultiSelect = false;
            this.dataGridGrades.Name = "dataGridGrades";
            this.dataGridGrades.ReadOnly = true;
            this.dataGridGrades.RowHeadersWidth = 51;
            this.dataGridGrades.RowTemplate.Height = 24;
            this.dataGridGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGrades.Size = new System.Drawing.Size(240, 150);
            this.dataGridGrades.TabIndex = 40;
            this.dataGridGrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGrades_CellClick);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(264, 400);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(72, 22);
            this.txtGrade.TabIndex = 41;
            // 
            // txtEditGrade
            // 
            this.txtEditGrade.Location = new System.Drawing.Point(264, 432);
            this.txtEditGrade.Name = "txtEditGrade";
            this.txtEditGrade.Size = new System.Drawing.Size(72, 22);
            this.txtEditGrade.TabIndex = 42;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(264, 376);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.ReadOnly = true;
            this.textBoxGrade.Size = new System.Drawing.Size(40, 22);
            this.textBoxGrade.TabIndex = 43;
            this.textBoxGrade.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(336, 632);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 39);
            this.btnLogout.TabIndex = 44;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 674);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.txtEditGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.dataGridGrades);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.txtLectorSubject);
            this.Controls.Add(this.txtLectorLName);
            this.Controls.Add(this.txtLectorFName);
            this.Controls.Add(this.txtLectorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLector";
            this.Text = "FormLector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLectorID;
        private System.Windows.Forms.TextBox txtLectorFName;
        private System.Windows.Forms.TextBox txtLectorLName;
        private System.Windows.Forms.TextBox txtLectorSubject;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.DataGridView dataGridGrades;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtEditGrade;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Button btnLogout;
    }
}