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
    public partial class ManagerHome : UserControl
    {
        DataAccess Da { get; set; }
        public ManagerHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.PopulateGridViewSell();
            this.dgvSellDetails.ClearSelection();
            this.dgvNoticeBoard.ClearSelection();
        }
        private void PopulateGridViewSell(string sql = "select * from Cart;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvSellDetails.AutoGenerateColumns = false;
            this.dgvSellDetails.DataSource = ds.Tables[0];
        }
        private void PopulateGridView(string sql = "select * from NoticeBoard;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvNoticeBoard.AutoGenerateColumns = false;
            this.dgvNoticeBoard.DataSource = ds.Tables[0];
        }

        private void lblSetNotice_Click(object sender, EventArgs e)
        {
            Notice notice = new Notice();
            notice.Visible = true;
        }
    }
}
