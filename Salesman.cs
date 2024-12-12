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
    public partial class Salesman : MetroForm
    {
        private DataAccess Da { get; set; }
        private Login log { get; set; }
        public Salesman()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private String Username { get; set; }
        public Salesman(String userName, Login log):this()
        { 
            this.log = log;
            this.lblUser.Text ="User: "+ userName;
            this.Username = userName;
        }
        
        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.log.Visible = true;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.pnlSalesman.Controls.Clear();
            this.pnlSalesman.Controls.Add(userControl);
            userControl.BringToFront();
        }
              
        private void pbSettings_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange(this.Username);
            passwordChange.Visible = true;
        }

        private void pbNotice_Click(object sender, EventArgs e)
        {
           SalesmanNotice salesmanNotice = new SalesmanNotice();
            salesmanNotice.Visible = true;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(this.Username);
            this.addUserControl(userInfo);
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            ProductCart productCart = new ProductCart(this.Username);
            this.addUserControl(productCart);
        }

        private void Salesman_Load(object sender, EventArgs e)
        {
            ProductCart productCart = new ProductCart(this.Username);
            this.addUserControl(productCart);
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

        private void pbNotice_MouseHover(object sender, EventArgs e)
        {
            this.pbNotice.BackColor = Color.Gainsboro;
        }

        private void pbNotice_MouseLeave(object sender, EventArgs e)
        {
            this.pbNotice.BackColor = Color.Transparent;
        }

        private void pbSettings_MouseHover(object sender, EventArgs e)
        {
            this.pbSettings.BackColor = Color.Gainsboro;
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbSettings.BackColor = Color.Transparent;
        }

        private void pbLogout_MouseHover(object sender, EventArgs e)
        {
            this.pbLogout.BackColor = Color.Gainsboro;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            this.pbLogout.BackColor = Color.Transparent;
        }
    }
}
