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
    public partial class Manager : MetroForm
    {
        private Login log { get; set; }
        public Manager()
        {
            InitializeComponent();
        }
        private String userName;
         public Manager(String userName, Login log):this()
        { 
            this.log = log;
            this.userName = userName;
            this.lblUser.Text ="User: "+ userName;
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.log.Visible = true;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Clear();
            this.pnlControl.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.addUserControl(product);
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.addUserControl(emp);
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange(this.userName);
            passwordChange.Visible = true;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            ManagerHome mHome = new ManagerHome();
            this.addUserControl(mHome);            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            ManagerHome mHome = new ManagerHome();
            this.addUserControl(mHome);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(userName);
            this.addUserControl(userInfo);
        }

        private void lblHome_MouseHover(object sender, EventArgs e)
        {
            this.lblHome.BackColor = Color.LimeGreen;
            this.ptrHome.BackColor = Color.LimeGreen;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            this.lblHome.BackColor = Color.Transparent;
            this.ptrHome.BackColor = Color.Transparent;
        }

        private void lblProducts_MouseHover(object sender, EventArgs e)
        {
            this.lblProducts.BackColor = Color.LimeGreen;
            this.ptrProducts.BackColor = Color.LimeGreen;
        }

        private void lblProducts_MouseLeave(object sender, EventArgs e)
        {
            this.lblProducts.BackColor = Color.Transparent;
            this.ptrProducts.BackColor = Color.Transparent;
        }

        private void lblEmployee_MouseHover(object sender, EventArgs e)
        {
            this.lblEmployee.BackColor = Color.LimeGreen;
            this.ptrEmployees.BackColor = Color.LimeGreen;
        }

        private void lblEmployee_MouseLeave(object sender, EventArgs e)
        {
            this.lblEmployee.BackColor = Color.Transparent;
            this.ptrEmployees.BackColor = Color.Transparent;
        }

        private void lblSettings_MouseHover(object sender, EventArgs e)
        {
            this.lblSettings.BackColor = Color.LimeGreen;
            this.ptrSettings.BackColor = Color.LimeGreen;
        }

        private void lblSettings_MouseLeave(object sender, EventArgs e)
        {
            this.lblSettings.BackColor = Color.Transparent;
            this.ptrSettings.BackColor = Color.Transparent;
        }

        private void pbLogOut_MouseHover(object sender, EventArgs e)
        {
            this.pbLogOut.BackColor = Color.Gainsboro;
        }

        private void pbLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.pbLogOut.BackColor = Color.Transparent;
        }
    }
}
