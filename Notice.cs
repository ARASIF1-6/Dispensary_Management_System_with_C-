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
    public partial class Notice : MetroForm
    {
        private DataAccess Da { get; set; }
        public Notice()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtNotice.Text == "")
                {
                    this.lblVarify.Visible = true;
                    return;
                }
                String sql = "insert into NoticeBoard Values ('" + DateTime.Now.ToShortDateString() + "','" + this.txtNotice.Text + "');";
                this.Da.ExecuteQuery(sql);
                this.txtNotice.Clear();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }        
        private void txtNotice_TextChanged(object sender, EventArgs e)
        {
            this.lblVarify.Visible = false;
        }
    }
}
