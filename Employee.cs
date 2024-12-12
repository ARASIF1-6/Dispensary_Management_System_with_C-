using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DispensaryManagementSystem
{
    public partial class Employee : UserControl
    {
        private DataAccess Da { get; set; }
        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
            this.dgvEmployee.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from EmployeeInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from EmployeeInfo where EmployeeId = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from EmployeeInfo where EmployeeName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private String manager, salesman;
        private void btnInsert_Click(object sender, EventArgs e)
        {           
            
            try
            {
                Regex regex = new Regex(@"^[0-9]{11}$");
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }
                if(regex.IsMatch(this.txtMobileNumber.Text))
                {
                    String sql = @"insert into EmployeeInfo values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.cmbGender.Text + "', '" + this.txtMobileNumber.Text + "','" + this.txtAddress.Text + "',  '" + this.cmbEmployeePost.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);
                }
                else
                {
                    MessageBox.Show("Mobile Number only Contain 11 digit(0-9)");
                    return;
                }

                String sql1 = @"insert into Login values('" + this.txtId.Text + "','" + this.txtUserName.Text + "','" + cmbEmployeePost.Text + "', '" + this.txtPassword.Text + "');";
                int count2 = this.Da.ExecuteDMLQuery(sql1);
                
                if(cmbEmployeePost.Text == "Manager")
                {
                    String sql2 = "select * from Salary where EmployeePost = '" + this.cmbEmployeePost.Text + "';";
                    var dt = this.Da.ExecuteQuery(sql2);
                    manager = dt.Tables[0].Rows[0][1].ToString();

                    String sql3 = "insert into SalarySheet values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.cmbEmployeePost.Text + "', '" + manager + "');";
                    this.Da.ExecuteDMLQuery(sql3);
                }
                else if (cmbEmployeePost.Text == "Salesman")
                {
                    String sql4 = "select * from Salary where EmployeePost = '" + this.cmbEmployeePost.Text + "';";
                    var dt = this.Da.ExecuteQuery(sql4);
                    salesman = dt.Tables[0].Rows[0][1].ToString();

                    String sql5 = "insert into SalarySheet values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.cmbEmployeePost.Text + "', '" + salesman + "');";
                    this.Da.ExecuteDMLQuery(sql5);
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }
        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeId"].Value.ToString();
            this.txtName.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
            this.txtMobileNumber.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeNumber"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeAddress"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeGender"].Value.ToString();
            this.cmbEmployeePost.Text = this.dgvEmployee.CurrentRow.Cells["EmployeePost"].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                var query = "select * from EmployeeInfo where EmployeeId = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update EmployeeInfo
                                set EmployeeName = '" + this.txtName.Text + @"',
                                EmployeeNumber = '" + this.txtMobileNumber.Text + @"',
                                EmployeePost = '" + this.cmbEmployeePost.Text + @"',
                                EmployeeGender = '" + this.cmbGender.Text + @"',
                                EmployeeAddress = '" + this.txtAddress.Text + @"'
                                where EmployeeId = '" + this.txtId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                    MessageBox.Show("No data found");

                this.PopulateGridView();
                this.ClearAll();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.cmbGender.Text) ||
                String.IsNullOrEmpty(this.cmbEmployeePost.Text) || String.IsNullOrEmpty(this.txtMobileNumber.Text))
                return false;
            else
                return true;
        }

        private void ptrClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

         private void ClearAll()
         {
            this.txtName.Clear();
            this.txtMobileNumber.Clear();
            this.txtAddress.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbEmployeePost.SelectedIndex = -1;
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();
            this.dgvEmployee.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployee.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please, select a row first to delete.");
                    return;
                }

                var id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();

                var sql = "delete from EmployeeInfo where EmployeeId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                var sql1 = "delete from Login where UserId = '" + id + "';";
                this.Da.ExecuteDMLQuery(sql1);

                var sql2 = "delete from SalarySheet where EmployeeId = '" + id + "';";
                this.Da.ExecuteDMLQuery(sql2);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed properly");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.AutoIdGenerate();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }        
        private int idCount = 0;
        private String[] userId;

        private void Employee_Load(object sender, EventArgs e)
        {
            this.dgvEmployee.ClearSelection();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AutoIdGenerate()
        {
            try
            {
                String sql = "select * from EmployeeInfo order by EmployeeId desc;";
                var dt = this.Da.ExecuteQuery(sql);
                if(dt.Tables[0].Rows.Count <= 0)
                {
                    this.txtId.Text = "E-22-1";
                }
                else
                {
                    userId = dt.Tables[0].Rows[0][0].ToString().Split('-');
                    idCount = Convert.ToInt32(userId[2]);
                    this.txtId.Text = "E-22-" + (++idCount).ToString();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }
        
    }
}
