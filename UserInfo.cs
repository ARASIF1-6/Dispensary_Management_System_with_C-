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
    public partial class UserInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public UserInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }
        private String Username { get; set; }
        public UserInfo(String username):this()
        {
            this.Username = username;
            this.getId();
        }
        private string id;
        private void getId()
        {
            try
            {
                String sql = "Select * from Login where UserName='" + this.Username + "';";
                var dt = this.Da.ExecuteQuery(sql);
                id = dt.Tables[0].Rows[0][0].ToString();
                this.employeeInfo();
            }
            catch (Exception exc)
            {
                MessageBox.Show("try again" + exc.Message);
            }
        }

        private void employeeInfo()
        {
            try
            {
                String sql = "Select * from EmployeeInfo where EmployeeId='" + id + "';";
                var dt = this.Da.ExecuteQuery(sql);
                this.txtId.Text = dt.Tables[0].Rows[0][0].ToString();
                this.txtName.Text = dt.Tables[0].Rows[0][1].ToString();
                this.txtGender.Text = dt.Tables[0].Rows[0][2].ToString();
                this.txtNumber.Text = dt.Tables[0].Rows[0][3].ToString();
                this.txtAddress.Text = dt.Tables[0].Rows[0][4].ToString();
                this.txtPost.Text = dt.Tables[0].Rows[0][5].ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show("try again2" + exc.Message);
            }
            
        }
    }
}
