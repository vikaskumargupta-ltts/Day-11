namespace EmployeeManagementApp
{
    partial class frmEmployeesList
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
            this.btnLoadEmployees = new System.Windows.Forms.Button();
            this.dgViewEmployeesList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchByBaseSalary = new System.Windows.Forms.Button();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchByBaseAge = new System.Windows.Forms.Button();
            this.txtBaseAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByEmployeeId = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmployeesList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadEmployees
            // 
            this.btnLoadEmployees.Location = new System.Drawing.Point(23, 97);
            this.btnLoadEmployees.Name = "btnLoadEmployees";
            this.btnLoadEmployees.Size = new System.Drawing.Size(174, 55);
            this.btnLoadEmployees.TabIndex = 0;
            this.btnLoadEmployees.Text = "Load Employees";
            this.btnLoadEmployees.UseVisualStyleBackColor = true;
            this.btnLoadEmployees.Click += new System.EventHandler(this.btnLoadEmployees_Click);
            // 
            // dgViewEmployeesList
            // 
            this.dgViewEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewEmployeesList.Location = new System.Drawing.Point(12, 187);
            this.dgViewEmployeesList.Name = "dgViewEmployeesList";
            this.dgViewEmployeesList.Size = new System.Drawing.Size(427, 168);
            this.dgViewEmployeesList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPDateOfBirth);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.btnAddNewEmployee);
            this.groupBox1.Location = new System.Drawing.Point(479, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Name";
            // 
            // dTPDateOfBirth
            // 
            this.dTPDateOfBirth.Location = new System.Drawing.Point(142, 85);
            this.dTPDateOfBirth.Name = "dTPDateOfBirth";
            this.dTPDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dTPDateOfBirth.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(142, 125);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 3;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(142, 41);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(142, 157);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(134, 25);
            this.btnAddNewEmployee.TabIndex = 0;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchByBaseSalary);
            this.groupBox2.Controls.Add(this.txtBaseSalary);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSearchByBaseAge);
            this.groupBox2.Controls.Add(this.txtBaseAge);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSearchByEmployeeId);
            this.groupBox2.Controls.Add(this.txtEmpId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(313, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employees";
            // 
            // btnSearchByBaseSalary
            // 
            this.btnSearchByBaseSalary.Location = new System.Drawing.Point(213, 83);
            this.btnSearchByBaseSalary.Name = "btnSearchByBaseSalary";
            this.btnSearchByBaseSalary.Size = new System.Drawing.Size(142, 24);
            this.btnSearchByBaseSalary.TabIndex = 8;
            this.btnSearchByBaseSalary.Text = "Search by Base Salary";
            this.btnSearchByBaseSalary.UseVisualStyleBackColor = true;
            this.btnSearchByBaseSalary.Click += new System.EventHandler(this.btnSearchByBaseSalary_Click);
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.Location = new System.Drawing.Point(97, 85);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBaseSalary.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Base Salary";
            // 
            // btnSearchByBaseAge
            // 
            this.btnSearchByBaseAge.Location = new System.Drawing.Point(213, 54);
            this.btnSearchByBaseAge.Name = "btnSearchByBaseAge";
            this.btnSearchByBaseAge.Size = new System.Drawing.Size(142, 22);
            this.btnSearchByBaseAge.TabIndex = 5;
            this.btnSearchByBaseAge.Text = "Search by Base Age";
            this.btnSearchByBaseAge.UseVisualStyleBackColor = true;
            this.btnSearchByBaseAge.Click += new System.EventHandler(this.btnSearchByBaseAge_Click);
            // 
            // txtBaseAge
            // 
            this.txtBaseAge.Location = new System.Drawing.Point(97, 54);
            this.txtBaseAge.Name = "txtBaseAge";
            this.txtBaseAge.Size = new System.Drawing.Size(100, 20);
            this.txtBaseAge.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Base Age";
            // 
            // btnSearchByEmployeeId
            // 
            this.btnSearchByEmployeeId.Location = new System.Drawing.Point(213, 24);
            this.btnSearchByEmployeeId.Name = "btnSearchByEmployeeId";
            this.btnSearchByEmployeeId.Size = new System.Drawing.Size(142, 22);
            this.btnSearchByEmployeeId.TabIndex = 2;
            this.btnSearchByEmployeeId.Text = "Search by Employee Id";
            this.btnSearchByEmployeeId.UseVisualStyleBackColor = true;
            this.btnSearchByEmployeeId.Click += new System.EventHandler(this.btnSearchByEmployeeId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(97, 26);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsLblErrorMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tsLblErrorMessage
            // 
            this.tsLblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.tsLblErrorMessage.Name = "tsLblErrorMessage";
            this.tsLblErrorMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(410, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 66);
            this.panel1.TabIndex = 5;
            // 
            // frmEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgViewEmployeesList);
            this.Controls.Add(this.btnLoadEmployees);
            this.Name = "frmEmployeesList";
            this.Text = "Employees List";
            this.Load += new System.EventHandler(this.frmEmployeesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmployeesList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadEmployees;
        private System.Windows.Forms.DataGridView dgViewEmployeesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPDateOfBirth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchByEmployeeId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblErrorMessage;
        private System.Windows.Forms.Button btnSearchByBaseAge;
        private System.Windows.Forms.TextBox txtBaseAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchByBaseSalary;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

