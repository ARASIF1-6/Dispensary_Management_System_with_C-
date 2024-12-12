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

namespace DispensaryManagementSystem
{
    public partial class PasswordChange : MetroForm
    {
        private DataAccess Da { get; set; }
        public PasswordChange()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public PasswordChange(String username):this()
        {
            this.txtUser.Text = username;
        }
       
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "update Login set Password = '"+this.txtPassword.Text+"' where UserName = '" + this.txtUser.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Update Success.");
                }
                else { MessageBox.Show("Can't Update."); }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Has Occur. Please Try Again!" + exc.Message);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbShowPass.Checked == true && this.txtPassword.PasswordChar == '●')
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.PasswordChar = '●';
            }
        }
    }
}
