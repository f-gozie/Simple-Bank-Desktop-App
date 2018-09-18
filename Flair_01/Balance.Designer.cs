namespace Flair_01
{
    partial class Balance
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
            this.acctBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.lblAvailableBal = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // acctBalance
            // 
            this.acctBalance.AutoSize = true;
            this.acctBalance.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctBalance.Location = new System.Drawing.Point(234, 9);
            this.acctBalance.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.acctBalance.Name = "acctBalance";
            this.acctBalance.Size = new System.Drawing.Size(172, 27);
            this.acctBalance.TabIndex = 0;
            this.acctBalance.Text = "Account Balance";
            this.acctBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Balance: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Balance: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.Location = new System.Drawing.Point(416, 126);
            this.lblCurrentBal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(24, 27);
            this.lblCurrentBal.TabIndex = 3;
            this.lblCurrentBal.Text = "..";
            this.lblCurrentBal.Click += new System.EventHandler(this.lblCurrentBal_Click);
            // 
            // lblAvailableBal
            // 
            this.lblAvailableBal.AutoSize = true;
            this.lblAvailableBal.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBal.Location = new System.Drawing.Point(416, 254);
            this.lblAvailableBal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAvailableBal.Name = "lblAvailableBal";
            this.lblAvailableBal.Size = new System.Drawing.Size(24, 27);
            this.lblAvailableBal.TabIndex = 4;
            this.lblAvailableBal.Text = "..";
            // 
            // homeLabel
            // 
            this.homeLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.homeLabel.AutoSize = true;
            this.homeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.homeLabel.LinkColor = System.Drawing.Color.Blue;
            this.homeLabel.Location = new System.Drawing.Point(63, 380);
            this.homeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(149, 27);
            this.homeLabel.TabIndex = 5;
            this.homeLabel.TabStop = true;
            this.homeLabel.Text = "Back To Home";
            this.homeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLabel_LinkClicked);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 426);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.lblAvailableBal);
            this.Controls.Add(this.lblCurrentBal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acctBalance);
            this.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acctBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentBal;
        private System.Windows.Forms.Label lblAvailableBal;
        private System.Windows.Forms.LinkLabel homeLabel;
    }
}