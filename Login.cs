using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DispensaryManagementSystem
{
    public partial class Login : MetroForm
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            { MessageBox.Show("Please provide Both username And password."); }
            else
            {
                try
                {
                    string sql = "select * from Login where UserName = '" + this.txtUser.Text + "' and Password = '" + this.txtPassword.Text + "';";
                    var dt = this.Da.ExecuteQuery(sql);
                    if (dt.Tables[0].Rows.Count == 1)
                    {
                        if (dt.Tables[0].Rows[0][2].ToString() == "Admin")
                        {
                            Admin admin = new Admin(this.txtUser.Text, this);
                            admin.Visible = true;
                            this.Visible = false;
                        }
                        else if (dt.Tables[0].Rows[0][2].ToString() == "Manager")
                        {
                            Manager manager = new Manager(this.txtUser.Text, this);
                            manager.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            Salesman salesman = new Salesman(this.txtUser.Text, this);
                            salesman.Visible = true;
                            this.Visible = false;
                        }
                    }
                    else { MessageBox.Show("Invalid User."); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please try again!" + ex.Message);
                }
            }            
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbShowPass.Checked == true && this.txtPassword.PasswordChar == '●')
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.PasswordChar = '●';
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
