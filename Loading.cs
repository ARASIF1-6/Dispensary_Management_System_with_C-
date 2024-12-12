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
    public partial class Loading : MetroForm
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LoadingBar.Value += 4;
            
            if(this.LoadingBar.Value >= 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Visible = true;
                this.Visible = false;
            }            
        }
    }
}
