using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyTeamApp;

namespace MyTeamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs args)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            if (string.IsNullOrEmpty(MyExcel.DB_PATH))
            {
                MessageBox.Show(" Please provide the team excel file ..", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc.SelectedIndex == 1)
            {
                dataGridEmpList.DataSource = (BindingList<Employee>)MyExcel.EmpList;
                dataGridEmpList.AutoResizeColumns();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Employee emp = new Employee {  Name = textName.Text.ToString(),
                                           Employee_ID = textEmpID.Text.ToString(),
                                           Email_ID = textEmailID.Text.ToString() + "@" + 
                                                      textDomain.Text.ToString(),
                                           Number = textMobileNo.Text.ToString()
                                        };
            MyExcel.WriteToExcel(emp);
            clearAllFields();
            MessageBox.Show("Details were successfully added to the excel !!", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textName.Focus();
        }

        public void clearAllFields()
        { 
            textName.Text = "";
            textEmailID.Text = "";
            textEmpID.Text = "";
            textMobileNo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected  override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if(!string.IsNullOrEmpty(MyExcel.DB_PATH))
            MyExcel.CloseExcel();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchExpr.ReadOnly = false;
        }

        private void txtSearchExpr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchExpr.Text))
            {
                dataGridEmpList.DataSource = MyExcel.FilterEmpList(cmbSearch.Text.ToString(), txtSearchExpr.Text.ToLower());
            }
            else
            {
                dataGridEmpList.DataSource = MyExcel.EmpList;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExcelDialog = new OpenFileDialog();
            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"C:\";
            ExcelDialog.Title = "Select your team excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MyExcel.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;
                txtFileName.Click -= btnLoad_Click;
                tabControl1.Selecting -= tabControl1_Selecting;
                btnLoad.Enabled = false;
                MyExcel.InitializeExcel();
                dataGridEmpList.DataSource = MyExcel.ReadMyExcel();
                tblLytAddMem.Visible = true;
            }
        }

    }
}
