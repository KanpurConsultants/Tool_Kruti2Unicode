namespace MyTeamApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlFileHeader = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tblLytAddMem = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMobileNo = new System.Windows.Forms.TextBox();
            this.textDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmailID = new System.Windows.Forms.TextBox();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearchExpr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridEmpList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empConstantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlFileHeader.SuspendLayout();
            this.tblLytAddMem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlFileHeader);
            this.tabPage1.Controls.Add(this.tblLytAddMem);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlFileHeader
            // 
            this.pnlFileHeader.Controls.Add(this.btnLoad);
            this.pnlFileHeader.Controls.Add(this.txtFileName);
            this.pnlFileHeader.Controls.Add(this.label13);
            this.pnlFileHeader.Location = new System.Drawing.Point(8, 6);
            this.pnlFileHeader.Name = "pnlFileHeader";
            this.pnlFileHeader.Size = new System.Drawing.Size(512, 44);
            this.pnlFileHeader.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(414, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(185, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(222, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Provide team excel : ";
            // 
            // tblLytAddMem
            // 
            this.tblLytAddMem.ColumnCount = 2;
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.91954F));
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.08046F));
            this.tblLytAddMem.Controls.Add(this.panel1, 0, 0);
            this.tblLytAddMem.Controls.Add(this.panel2, 1, 0);
            this.tblLytAddMem.Controls.Add(this.panel3, 1, 1);
            this.tblLytAddMem.Location = new System.Drawing.Point(6, 53);
            this.tblLytAddMem.Name = "tblLytAddMem";
            this.tblLytAddMem.RowCount = 2;
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.21673F));
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.78327F));
            this.tblLytAddMem.Size = new System.Drawing.Size(515, 263);
            this.tblLytAddMem.TabIndex = 2;
            this.tblLytAddMem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 154);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textMobileNo);
            this.panel2.Controls.Add(this.textDomain);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textEmailID);
            this.panel2.Controls.Add(this.textEmpID);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(187, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 154);
            this.panel2.TabIndex = 1;
            // 
            // textMobileNo
            // 
            this.textMobileNo.Location = new System.Drawing.Point(14, 104);
            this.textMobileNo.Name = "textMobileNo";
            this.textMobileNo.Size = new System.Drawing.Size(208, 23);
            this.textMobileNo.TabIndex = 5;
            // 
            // textDomain
            // 
            this.textDomain.Location = new System.Drawing.Point(169, 77);
            this.textDomain.Name = "textDomain";
            this.textDomain.ReadOnly = true;
            this.textDomain.Size = new System.Drawing.Size(106, 23);
            this.textDomain.TabIndex = 4;
            this.textDomain.Text = "domain.xyz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "@";
            // 
            // textEmailID
            // 
            this.textEmailID.Location = new System.Drawing.Point(14, 77);
            this.textEmailID.Name = "textEmailID";
            this.textEmailID.Size = new System.Drawing.Size(120, 23);
            this.textEmailID.TabIndex = 2;
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(14, 50);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(261, 23);
            this.textEmpID.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(14, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(261, 23);
            this.textName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(187, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 97);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearchExpr);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmbSearch);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridEmpList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearchExpr
            // 
            this.txtSearchExpr.Location = new System.Drawing.Point(422, 32);
            this.txtSearchExpr.Name = "txtSearchExpr";
            this.txtSearchExpr.ReadOnly = true;
            this.txtSearchExpr.Size = new System.Drawing.Size(126, 20);
            this.txtSearchExpr.TabIndex = 4;
            this.txtSearchExpr.TextChanged += new System.EventHandler(this.txtSearchExpr_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(265, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Search Expression : ";
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Email_ID",
            "Employee_ID",
            "Mobile_No",
            "Name"});
            this.cmbSearch.Location = new System.Drawing.Point(122, 32);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.Sorted = true;
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Search By : ";
            // 
            // dataGridEmpList
            // 
            this.dataGridEmpList.AllowUserToOrderColumns = true;
            this.dataGridEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpList.Location = new System.Drawing.Point(28, 92);
            this.dataGridEmpList.Name = "dataGridEmpList";
            this.dataGridEmpList.RowHeadersWidth = 50;
            this.dataGridEmpList.Size = new System.Drawing.Size(520, 210);
            this.dataGridEmpList.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(596, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "chnandakumarreddy@gmail.com";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Contact Details : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(211, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nanda Kumar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Design and Development : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "This application is intended for managing the team information";
            // 
            // empConstantsBindingSource
            // 
            this.empConstantsBindingSource.DataSource = typeof(MyTeamApp.EmpConstants);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TeamApp - Nanda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlFileHeader.ResumeLayout(false);
            this.pnlFileHeader.PerformLayout();
            this.tblLytAddMem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tblLytAddMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textMobileNo;
        private System.Windows.Forms.TextBox textDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmailID;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEmpList;
        private System.Windows.Forms.TextBox txtSearchExpr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource empConstantsBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlFileHeader;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label13;

    }
}

