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
    public partial class SalesmanNotice : MetroForm
    {
        private DataAccess Da { get; set; }
        public SalesmanNotice()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from NoticeBoard;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvNoticeBoard.AutoGenerateColumns = false;
            this.dgvNoticeBoard.DataSource = ds.Tables[0];
        }
    }
}
