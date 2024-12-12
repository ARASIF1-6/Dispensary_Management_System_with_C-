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
    public partial class Product : UserControl
    {
        private DataAccess Da { get; set; }
        public Product()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
            this.dgvProduct.ClearSelection();

        }

        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductInfo where ProductName = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data or Zero(0) value is not acceptable.");
                    return;
                }
                var sql = @"insert into ProductInfo values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtGroupName.Text + "', '" + this.txtCompanyName.Text + "', '" + this.txtQuantity.Text + "', '" + this.txtPrice.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Added properly");
                else
                    MessageBox.Show("Data insertion failed");

                this.PopulateGridView();
                this.ClearAll();
                
            }
            
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                var query = "select * from ProductInfo where ProductId = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update ProductInfo
                                set ProductName = '" + this.txtName.Text + @"',
                                GroupName = '" + this.txtGroupName.Text + @"',
                                CompanyName = '" + this.txtCompanyName.Text + @"',
                                Quantity = '" + this.txtQuantity.Text + @"',
                                Price = '" + this.txtPrice.Text + @"'
                                where ProductId = '" + this.txtId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                    MessageBox.Show("No data found");
                this.ClearAll();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtGroupName.Text) || String.IsNullOrEmpty(this.txtCompanyName.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text) || String.IsNullOrEmpty(this.txtPrice.Text) || 
                Convert.ToInt32(this.txtQuantity.Text) == 0 || Convert.ToInt32(this.txtPrice.Text) == 0)
                return false;
            else
                return true;
        }

        private void ptrClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtGroupName.Clear();
            this.txtCompanyName.Clear();
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();
            this.PopulateGridView();
            this.dgvProduct.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
                var sql = "delete from ProductInfo where Productid = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed properly");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            this.txtName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtGroupName.Text = this.dgvProduct.CurrentRow.Cells["GroupName"].Value.ToString();
            this.txtCompanyName.Text = this.dgvProduct.CurrentRow.Cells["CompanyName"].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["AvailableQuantity"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where GroupName like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
        private int idCount = 0;
        private String[] productId;
        private void AutoIdGenerate()
        {
            try
            {
                String sql = "select * from ProductInfo order by ProductId desc;";
                var dt = this.Da.ExecuteQuery(sql);
                if (dt.Tables[0].Rows.Count <= 0)
                {
                    this.txtId.Text = "P-22-1";
                }
                else
                {
                    productId = dt.Tables[0].Rows[0][0].ToString().Split('-');
                    idCount = Convert.ToInt32(productId[2]);
                    this.txtId.Text = "P-22-" + (++idCount).ToString();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
