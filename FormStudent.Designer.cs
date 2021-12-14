
namespace AkademineSistema
{
    partial class FormStudent
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
            this.txtStudentGroup = new System.Windows.Forms.TextBox();
            this.txtStudentLName = new System.Windows.Forms.TextBox();
            this.txtStudentFName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.dataGridGrades = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentGroup
            // 
            this.txtStudentGroup.Location = new System.Drawing.Point(96, 160);
            this.txtStudentGroup.Name = "txtStudentGroup";
            this.txtStudentGroup.ReadOnly = true;
            this.txtStudentGroup.Size = new System.Drawing.Size(136, 22);
            this.txtStudentGroup.TabIndex = 43;
            // 
            // txtStudentLName
            // 
            this.txtStudentLName.Location = new System.Drawing.Point(96, 128);
            this.txtStudentLName.Name = "txtStudentLName";
            this.txtStudentLName.ReadOnly = true;
            this.txtStudentLName.Size = new System.Drawing.Size(136, 22);
            this.txtStudentLName.TabIndex = 42;
            // 
            // txtStudentFName
            // 
            this.txtStudentFName.Location = new System.Drawing.Point(96, 96);
            this.txtStudentFName.Name = "txtStudentFName";
            this.txtStudentFName.ReadOnly = true;
            this.txtStudentFName.Size = new System.Drawing.Size(136, 22);
            this.txtStudentFName.TabIndex = 41;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(96, 64);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(136, 22);
            this.txtStudentID.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Subjects";
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.AllowUserToAddRows = false;
            this.dataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Location = new System.Drawing.Point(16, 232);
            this.dataGridSubjects.MultiSelect = false;
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.ReadOnly = true;
            this.dataGridSubjects.RowHeadersWidth = 51;
            this.dataGridSubjects.RowTemplate.Height = 24;
            this.dataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSubjects.Size = new System.Drawing.Size(312, 120);
            this.dataGridSubjects.TabIndex = 45;
            this.dataGridSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSubjects_CellClick);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(16, 376);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(240, 22);
            this.txtSubject.TabIndex = 46;
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
            this.dataGridGrades.TabIndex = 47;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(336, 648);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 39);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 695);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridGrades);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.dataGridSubjects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentGroup);
            this.Controls.Add(this.txtStudentLName);
            this.Controls.Add(this.txtStudentFName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentGroup;
        private System.Windows.Forms.TextBox txtStudentLName;
        private System.Windows.Forms.TextBox txtStudentFName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.DataGridView dataGridGrades;
        private System.Windows.Forms.Button btnLogout;
    }
}