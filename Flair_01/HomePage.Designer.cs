namespace Flair_01
{
    partial class HomePage
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
            this.labelHello = new System.Windows.Forms.Label();
            this.lblAccno = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblInquiry = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(46, 37);
            this.labelHello.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(210, 27);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello, {{ username }}";
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // lblAccno
            // 
            this.lblAccno.AutoSize = true;
            this.lblAccno.Location = new System.Drawing.Point(46, 110);
            this.lblAccno.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAccno.Name = "lblAccno";
            this.lblAccno.Size = new System.Drawing.Size(247, 27);
            this.lblAccno.TabIndex = 1;
            this.lblAccno.Text = "Account No: {{ accno }}";
            this.lblAccno.Click += new System.EventHandler(this.lblAccno_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInquiry.Location = new System.Drawing.Point(52, 193);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(163, 48);
            this.btnInquiry.TabIndex = 2;
            this.btnInquiry.Text = "Balance ";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Location = new System.Drawing.Point(52, 274);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(163, 48);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdraw.Location = new System.Drawing.Point(52, 361);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(163, 48);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Location = new System.Drawing.Point(52, 449);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(163, 48);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblInquiry
            // 
            this.lblInquiry.AutoSize = true;
            this.lblInquiry.Location = new System.Drawing.Point(316, 204);
            this.lblInquiry.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblInquiry.Name = "lblInquiry";
            this.lblInquiry.Size = new System.Drawing.Size(317, 27);
            this.lblInquiry.TabIndex = 6;
            this.lblInquiry.Text = "Provides account balance details";
            this.lblInquiry.Click += new System.EventHandler(this.lblInquiry_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(316, 285);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(360, 27);
            this.lblDeposit.TabIndex = 7;
            this.lblDeposit.Text = "Deposit desired amount into account";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(316, 372);
            this.lblWithdraw.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(421, 27);
            this.lblWithdraw.TabIndex = 8;
            this.lblWithdraw.Text = "Withdraw desired amount provided available";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(316, 459);
            this.lblTransfer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(492, 27);
            this.lblTransfer.TabIndex = 9;
            this.lblTransfer.Text = "Transfer amount to account number of your choice";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(46, 542);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 27);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(897, 588);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblInquiry);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.lblAccno);
            this.Controls.Add(this.labelHello);
            this.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label lblAccno;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblInquiry;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}