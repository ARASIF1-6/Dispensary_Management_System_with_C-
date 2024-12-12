using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DispensaryManagementSystem
{
    public partial class ProductCart : UserControl
    {
        private DataAccess Da { get; set; }
        public ProductCart()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private String Username { get; set; }
        public ProductCart(String username):this()
        {
            this.txtSellerName.Text = username;
            this.Username = username;
        }
        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductInfo where ProductName = '" + txtSearch.Text + "';;";
            this.PopulateGridView(sql);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvProduct.ClearSelection();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where GroupName like '" + txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void ProductCart_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
            this.dgvCart.ClearSelection();
        }
        private int quantity = 0;
        private string pID;
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["productName"].Value.ToString();
            this.txtProductPrice.Text = this.dgvProduct.CurrentRow.Cells[5].Value.ToString();
            if (this.txtProductName.Text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToInt32(this.dgvProduct.CurrentRow.Cells["productQuantity"].Value.ToString());
                pID = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void updateQuantity()
        {
            int newQuantity = quantity - Convert.ToInt32(txtProductQuantity.Text);
            try
            {
                var sql = @"update ProductInfo
                            set Quantity = '" + newQuantity + @"'
                            where ProductId = '" + pID + "';";
                Da.ExecuteQuery(sql);
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private int grandTotal = 0;
        private static int serial = 0;
        private int totalQuantity = 0;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (this.txtProductName.Text == "")
            {
                MessageBox.Show("please Select a Product First!");
                return;
            }
            else if (this.txtProductQuantity.Text == "" || Convert.ToInt32(this.txtProductQuantity.Text) == 0)
            {
                MessageBox.Show("please Enter a valid amount of Product Quantity!");
                return;
            }
            else if (Convert.ToInt32(this.txtProductQuantity.Text) >= quantity)
            {
                MessageBox.Show("Sorry, Don't have Enough Product.");
                return;
            }
            else
            {
                int total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                int proQuantity = Convert.ToInt32(txtProductQuantity.Text);
                dgvCart.Rows.Add(++serial, txtProductName.Text, txtProductQuantity.Text, Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text));
                updateQuantity();
                grandTotal += total;
                totalQuantity += proQuantity;
                this.lblTotal.Text = grandTotal.ToString();
                clear();
            }
            this.txtSellerName.Text = this.Username;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtSellerName.Text == "")
                {
                    MessageBox.Show("Please enter seller name!");
                    return;
                }
                else if(this.dgvCart.Rows.Count == 0)
                {
                    MessageBox.Show("Please Add Product in Cart!");
                    return;
                }
                String sql = "Insert into Cart Values('" + DateTime.Now.ToShortDateString() + "','" + this.txtSellerName.Text + "','" + totalQuantity + "','" + grandTotal + "');";
                this.Da.ExecuteQuery(sql);
                pdCart.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                ppdCart.Document = pdCart;
                ppdCart.PrintPreviewControl.Zoom = 1;
                if (ppdCart.ShowDialog() == DialogResult.OK)
                {
                    pdCart.Print();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }
        private int serialnum, productquantity, total, pos = 60;
        private String productName;
        private void pdCart_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Dispensary Shop", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Green, new Point(80));
            e.Graphics.DrawString("Cart Details", new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Green, new Point(80, 25));
            foreach (DataGridViewRow dataGridView in dgvCart.Rows)
            {
                serialnum = Convert.ToInt32(dataGridView.Cells[0].Value);
                productName = "" + dataGridView.Cells[1].Value;
                productquantity = Convert.ToInt32(dataGridView.Cells[2].Value);
                total = Convert.ToInt32(dataGridView.Cells[3].Value);
                e.Graphics.DrawString("" + serialnum, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + productName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + productquantity, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(140, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(190, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Total Amount: BDT " + grandTotal, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Green, new Point(30, pos + 40));
            this.dgvCart.Rows.Clear();
            this.dgvCart.Refresh();
            pos = 100;
            grandTotal = 0;
            totalQuantity = 0;
            this.lblTotal.Text = grandTotal.ToString();
        }
        private void clear()
        {
            this.txtAutoSearch.Clear();
            this.txtSearch.Clear();
            this.txtSellerName.Clear();
            this.txtProductName.Clear();
            this.txtProductPrice.Clear();
            this.txtProductQuantity.Clear();
            this.dgvProduct.ClearSelection();
        }
        private int amount;
        private string cartQuantity;

        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string name;
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.name = this.dgvCart.CurrentRow.Cells[1].Value.ToString();
            this.cartQuantity = this.dgvCart.CurrentRow.Cells[2].Value.ToString();
            this.amount = Convert.ToInt32(this.dgvCart.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "select * from ProductInfo where ProductName = '" + name + "';";
                var Dt = this.Da.ExecuteQuery(sql);
                if (Dt.Tables[0].Rows.Count > 0)
                {
                    String quantity = Dt.Tables[0].Rows[0][4].ToString();
                    int newQuantity = Convert.ToInt32(cartQuantity) + Convert.ToInt32(quantity);
                    try
                    {
                        var sqll = @"update ProductInfo
                            set Quantity = '" + newQuantity + @"'
                            where ProductName = '" + name + "';";
                        Da.ExecuteQuery(sqll);
                        int rowIndex = this.dgvCart.CurrentCell.RowIndex;
                        this.dgvCart.Rows.RemoveAt(rowIndex);
                        this.PopulateGridView();
                        grandTotal -= amount;
                        totalQuantity -= Convert.ToInt32(cartQuantity);
                        lblTotal.Text = grandTotal.ToString();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please try again.\n" + ex.Message);
            }
        }     

    }
}
