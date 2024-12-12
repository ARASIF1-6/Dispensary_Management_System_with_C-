using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispensaryManagementSystem
{
    public partial class Salary : UserControl
    {
        private DataAccess Da { get; set; }
        public Salary()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.setSalary();
            this.PopulateGridView();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            this.setSalary();
            this.PopulateGridView();
            this.dgvSalary.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from SalarySheet;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvSalary.AutoGenerateColumns = false;
            this.dgvSalary.DataSource = ds.Tables[0];
            this.dgvSalary.ClearSelection();
        }
        private void setSalary()
        {
            try
            {
                String sql = "Select * from Salary;";
                var dt = this.Da.ExecuteQuery(sql);
                this.txtManagerSalary.Text = dt.Tables[0].Rows[0][1].ToString();
                this.txtSalesmanSalary.Text = dt.Tables[0].Rows[1][1].ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has Occured. Please try Again!" + exc.Message);
            }
        }

        private void cmbEmployeePost_TextChanged(object sender, EventArgs e)
        {
            if(cmbEmployeePost.Text == "Manager" || cmbEmployeePost.Text == "Salesman")
            {
                this.lblVarifyPost.Visible = false;
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.cmbEmployeePost.Text == "")
            {
                this.lblVarifyPost.Visible = true;                
            }
            else if(this.txtSalary.Text == "" || Convert.ToInt32(this.txtSalary.Text) == 0)
            {
                this.lblVarifySalary.Visible = true;
            }
            else
            {
                try
                {
                    String sql = "Update Salary set Salary = '" + this.txtSalary.Text + "' where EmployeePost = '" + this.cmbEmployeePost.Text + "';";
                    this.Da.ExecuteDMLQuery(sql);

                    String sql1 = "Update SalarySheet set EmployeeSalary='" + this.txtSalary.Text + "' where EmployeePost = '" + this.cmbEmployeePost.Text + "';";
                    this.Da.ExecuteDMLQuery(sql1);

                    this.setSalary();
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has Occured. Please try Again!" + exc.Message);
                }
            }
            
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (cmbEmployeePost.Text == "")
            {
                this.lblVarifyPost.Visible = true;
            }
            else
            {
                this.lblVarifyPost.Visible = false;
                this.lblVarifySalary.Visible = false;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
