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
    public partial class AdminHome : UserControl
    {
        DataAccess Da { get; set; }
        public AdminHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.SellDetails();
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
        private int quantity = 0, amount = 0;
        private void SellDetails()
        {
            try
            {
                String sql = "select * from Cart;";
                var dt = this.Da.ExecuteQuery(sql);
                if (dt.Tables[0].Rows.Count <= 0)
                {
                    this.lblQuantity.Text = quantity.ToString();
                    this.lblAmount.Text = amount.ToString();
                }
                else
                {
                    int r = 0;
                    while (r < dt.Tables[0].Rows.Count)
                    {
                        quantity += Convert.ToInt32(dt.Tables[0].Rows[r][2].ToString());
                        amount += Convert.ToInt32(dt.Tables[0].Rows[r][3].ToString());
                        r++;
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("An ERROR has Occur! Please Try again."+ exc.Message);
            }
                       
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.lblQuantity.Text = quantity.ToString();
            this.lblAmount.Text = amount.ToString();
        }
    }
}
