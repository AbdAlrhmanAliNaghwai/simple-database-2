namespace database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblstudentno = new System.Windows.Forms.Label();
            this.txtstudentNo = new System.Windows.Forms.TextBox();
            this.lblstfn = new System.Windows.Forms.Label();
            this.txtstudentfirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentlastname = new System.Windows.Forms.TextBox();
            this.btnstudentadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentno
            // 
            this.lblstudentno.AutoSize = true;
            this.lblstudentno.Location = new System.Drawing.Point(30, 36);
            this.lblstudentno.Name = "lblstudentno";
            this.lblstudentno.Size = new System.Drawing.Size(70, 15);
            this.lblstudentno.TabIndex = 0;
            this.lblstudentno.Text = "Student No.";
            // 
            // txtstudentNo
            // 
            this.txtstudentNo.Location = new System.Drawing.Point(106, 33);
            this.txtstudentNo.Name = "txtstudentNo";
            this.txtstudentNo.Size = new System.Drawing.Size(148, 23);
            this.txtstudentNo.TabIndex = 1;
            // 
            // lblstfn
            // 
            this.lblstfn.AutoSize = true;
            this.lblstfn.Location = new System.Drawing.Point(36, 92);
            this.lblstfn.Name = "lblstfn";
            this.lblstfn.Size = new System.Drawing.Size(64, 15);
            this.lblstfn.TabIndex = 2;
            this.lblstfn.Text = "First Name";
            // 
            // txtstudentfirstname
            // 
            this.txtstudentfirstname.Location = new System.Drawing.Point(106, 89);
            this.txtstudentfirstname.Name = "txtstudentfirstname";
            this.txtstudentfirstname.Size = new System.Drawing.Size(148, 23);
            this.txtstudentfirstname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name ";
            // 
            // txtStudentlastname
            // 
            this.txtStudentlastname.Location = new System.Drawing.Point(368, 89);
            this.txtStudentlastname.Name = "txtStudentlastname";
            this.txtStudentlastname.Size = new System.Drawing.Size(147, 23);
            this.txtStudentlastname.TabIndex = 5;
            // 
            // btnstudentadd
            // 
            this.btnstudentadd.Location = new System.Drawing.Point(296, 28);
            this.btnstudentadd.Name = "btnstudentadd";
            this.btnstudentadd.Size = new System.Drawing.Size(87, 23);
            this.btnstudentadd.TabIndex = 6;
            this.btnstudentadd.Text = "Add Student";
            this.btnstudentadd.UseVisualStyleBackColor = true;
            this.btnstudentadd.Click += new System.EventHandler(this.btnstudentadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 379);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(400, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 497);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnstudentadd);
            this.Controls.Add(this.txtStudentlastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstudentfirstname);
            this.Controls.Add(this.lblstfn);
            this.Controls.Add(this.txtstudentNo);
            this.Controls.Add(this.lblstudentno);
            this.Name = "Form1";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblstudentno;
        private TextBox txtstudentNo;
        private Label lblstfn;
        private TextBox txtstudentfirstname;
        private Label label3;
        private TextBox txtStudentlastname;
        private Button btnstudentadd;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
    }
}