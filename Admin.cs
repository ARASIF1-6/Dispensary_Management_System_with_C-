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
    public partial class Admin : MetroForm
    {
        private Login log { get; set; }
        public Admin()
        {
            InitializeComponent();
        }
        private String Usernname { get; set; }
        public Admin(String userName, Login log):this()
        { 
            this.log = log;
            this.Usernname = userName;
            this.lblUser.Text ="User: "+ userName;
        }
        private void ptrLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.log.Visible = true;            
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.pnlViewUserControl.Controls.Clear();
            this.pnlViewUserControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            AdminHome adh = new AdminHome();
            this.addUserControl(adh);

        }

        private void ptrHome_Click(object sender, EventArgs e)
        {
            AdminHome adh = new AdminHome();
            this.addUserControl(adh);

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            this.addUserControl(prd);

        }

        private void ptrProducts_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            this.addUserControl(prd);

        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.addUserControl(emp);
        }

        private void ptrEmployees_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.addUserControl(emp);

        }

        private void lblSalarySheet_Click(object sender, EventArgs e)
        {
            Salary ss = new Salary();
            this.addUserControl(ss);

        }

        private void ptrSalarySheet_Click(object sender, EventArgs e)
        {
            Salary ss = new Salary();
            this.addUserControl(ss);

        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            Setting st = new Setting(this.Usernname);
            this.addUserControl(st);
        }

        private void ptrSettings_Click(object sender, EventArgs e)
        {
            Setting st = new Setting();
            this.addUserControl(st);
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

        private void lblSalarySheet_MouseHover(object sender, EventArgs e)
        {
            this.lblSalarySheet.BackColor = Color.LimeGreen;
            this.ptrSalarySheet.BackColor = Color.LimeGreen;
        }

        private void lblSalarySheet_MouseLeave(object sender, EventArgs e)
        {
            this.lblSalarySheet.BackColor = Color.Transparent;
            this.ptrSalarySheet.BackColor = Color.Transparent;
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

        private void ptrLogOut_MouseHover(object sender, EventArgs e)
        {
            this.ptrLogOut.BackColor = Color.Gainsboro;

        }

        private void ptrLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.ptrLogOut.BackColor = Color.Transparent;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminHome adh = new AdminHome();
            this.addUserControl(adh);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(this.Usernname);
            this.addUserControl(userInfo);
        }
    }
}
