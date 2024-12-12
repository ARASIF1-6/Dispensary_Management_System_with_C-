namespace DispensaryManagementSystem
{
    partial class Notice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVarify = new MetroFramework.Controls.MetroLabel();
            this.btnNotice = new MetroFramework.Controls.MetroButton();
            this.txtNotice = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblVarify);
            this.metroPanel1.Controls.Add(this.btnNotice);
            this.metroPanel1.Controls.Add(this.txtNotice);
            this.metroPanel1.Controls.Add(this.lblDate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(398, 431);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblVarify
            // 
            this.lblVarify.AutoSize = true;
            this.lblVarify.ForeColor = System.Drawing.Color.Red;
            this.lblVarify.Location = new System.Drawing.Point(15, 275);
            this.lblVarify.Name = "lblVarify";
            this.lblVarify.Size = new System.Drawing.Size(248, 20);
            this.lblVarify.Style = MetroFramework.MetroColorStyle.Green;
            this.lblVarify.TabIndex = 5;
            this.lblVarify.Text = "Please Write Something to send notice";
            this.lblVarify.UseCustomBackColor = true;
            this.lblVarify.UseCustomForeColor = true;
            this.lblVarify.UseStyleColors = true;
            this.lblVarify.Visible = false;
            // 
            // btnNotice
            // 
            this.btnNotice.Location = new System.Drawing.Point(133, 339);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(118, 41);
            this.btnNotice.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNotice.TabIndex = 4;
            this.btnNotice.Text = "Send Notice";
            this.btnNotice.UseSelectable = true;
            this.btnNotice.UseStyleColors = true;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // txtNotice
            // 
            // 
            // 
            // 
            this.txtNotice.CustomButton.Image = null;
            this.txtNotice.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.txtNotice.CustomButton.Name = "";
            this.txtNotice.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.txtNotice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotice.CustomButton.TabIndex = 1;
            this.txtNotice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotice.CustomButton.UseSelectable = true;
            this.txtNotice.CustomButton.Visible = false;
            this.txtNotice.Lines = new string[0];
            this.txtNotice.Location = new System.Drawing.Point(15, 69);
            this.txtNotice.MaxLength = 32767;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.PasswordChar = '\0';
            this.txtNotice.PromptText = "Write Notice here";
            this.txtNotice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotice.SelectedText = "";
            this.txtNotice.SelectionLength = 0;
            this.txtNotice.SelectionStart = 0;
            this.txtNotice.ShortcutsEnabled = true;
            this.txtNotice.Size = new System.Drawing.Size(368, 200);
            this.txtNotice.TabIndex = 3;
            this.txtNotice.UseSelectable = true;
            this.txtNotice.WaterMark = "Write Notice here";
            this.txtNotice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNotice.TextChanged += new System.EventHandler(this.txtNotice_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 20);
            this.lblDate.Style = MetroFramework.MetroColorStyle.Green;
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            this.lblDate.UseCustomBackColor = true;
            this.lblDate.UseStyleColors = true;
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 511);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Notice";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnNotice;
        private MetroFramework.Controls.MetroTextBox txtNotice;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblVarify;
    }
}