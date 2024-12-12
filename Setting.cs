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
    public partial class Setting : UserControl
    {
        private DataAccess Da { get; set; }
        
        public Setting()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private String Usernname { get; set; }
        public Setting(String username):this()
        {
            this.Usernname = username;
        }
        private void PopulateGridView(string sql = "select * from Login;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvSetting.AutoGenerateColumns = false;
            this.dgvSetting.DataSource = ds.Tables[0];
            this.dgvSetting.ClearSelection();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange(this.Usernname);
            passwordChange.Visible = true;
        }

        private void ptrRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.dgvSetting.ClearSelection();
        }
    }
}
