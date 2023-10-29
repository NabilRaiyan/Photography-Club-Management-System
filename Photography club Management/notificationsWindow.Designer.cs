namespace Photography_club_Management
{
    partial class notificationsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificationsWindow));
            this.pnlNotificationHeader = new System.Windows.Forms.Panel();
            this.btnCloseNotification = new FontAwesome.Sharp.IconButton();
            this.lblNotification = new System.Windows.Forms.Label();
            this.pnlEventNews = new System.Windows.Forms.Panel();
            this.lblSendBy = new System.Windows.Forms.Label();
            this.pictureBoxSenderImage = new System.Windows.Forms.PictureBox();
            this.btnDeleteNotification = new FontAwesome.Sharp.IconButton();
            this.lblNotificationTime = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.lblNotificationDate = new System.Windows.Forms.Label();
            this.pnlNotificationHeader.SuspendLayout();
            this.pnlEventNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNotificationHeader
            // 
            this.pnlNotificationHeader.BackColor = System.Drawing.Color.MistyRose;
            this.pnlNotificationHeader.Controls.Add(this.btnCloseNotification);
            this.pnlNotificationHeader.Controls.Add(this.lblNotification);
            this.pnlNotificationHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotificationHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlNotificationHeader.Name = "pnlNotificationHeader";
            this.pnlNotificationHeader.Size = new System.Drawing.Size(600, 44);
            this.pnlNotificationHeader.TabIndex = 0;
            // 
            // btnCloseNotification
            // 
            this.btnCloseNotification.FlatAppearance.BorderSize = 0;
            this.btnCloseNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNotification.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNotification.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCloseNotification.IconColor = System.Drawing.Color.Black;
            this.btnCloseNotification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNotification.IconSize = 32;
            this.btnCloseNotification.Location = new System.Drawing.Point(548, 3);
            this.btnCloseNotification.Name = "btnCloseNotification";
            this.btnCloseNotification.Size = new System.Drawing.Size(49, 38);
            this.btnCloseNotification.TabIndex = 1;
            this.btnCloseNotification.UseVisualStyleBackColor = true;
            this.btnCloseNotification.Click += new System.EventHandler(this.btnCloseNotification_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotification.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(217, 5);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(172, 25);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "Notifications";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEventNews
            // 
            this.pnlEventNews.BackColor = System.Drawing.Color.White;
            this.pnlEventNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventNews.Controls.Add(this.lblSendBy);
            this.pnlEventNews.Controls.Add(this.pictureBoxSenderImage);
            this.pnlEventNews.Controls.Add(this.btnDeleteNotification);
            this.pnlEventNews.Controls.Add(this.lblNotificationTime);
            this.pnlEventNews.Controls.Add(this.lblSenderName);
            this.pnlEventNews.Controls.Add(this.lblEventDetails);
            this.pnlEventNews.Location = new System.Drawing.Point(20, 94);
            this.pnlEventNews.Name = "pnlEventNews";
            this.pnlEventNews.Size = new System.Drawing.Size(569, 124);
            this.pnlEventNews.TabIndex = 1;
            // 
            // lblSendBy
            // 
            this.lblSendBy.BackColor = System.Drawing.Color.Cyan;
            this.lblSendBy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendBy.ForeColor = System.Drawing.Color.Purple;
            this.lblSendBy.Location = new System.Drawing.Point(101, 93);
            this.lblSendBy.Name = "lblSendBy";
            this.lblSendBy.Size = new System.Drawing.Size(75, 21);
            this.lblSendBy.TabIndex = 9;
            this.lblSendBy.Text = "member";
            // 
            // pictureBoxSenderImage
            // 
            this.pictureBoxSenderImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSenderImage.Image")));
            this.pictureBoxSenderImage.Location = new System.Drawing.Point(7, 9);
            this.pictureBoxSenderImage.Name = "pictureBoxSenderImage";
            this.pictureBoxSenderImage.Size = new System.Drawing.Size(87, 68);
            this.pictureBoxSenderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSenderImage.TabIndex = 8;
            this.pictureBoxSenderImage.TabStop = false;
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.BackColor = System.Drawing.Color.White;
            this.btnDeleteNotification.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotification.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteNotification.IconColor = System.Drawing.Color.Black;
            this.btnDeleteNotification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNotification.IconSize = 25;
            this.btnDeleteNotification.Location = new System.Drawing.Point(527, 89);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(30, 28);
            this.btnDeleteNotification.TabIndex = 7;
            this.btnDeleteNotification.UseVisualStyleBackColor = false;
            // 
            // lblNotificationTime
            // 
            this.lblNotificationTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationTime.ForeColor = System.Drawing.Color.Blue;
            this.lblNotificationTime.Location = new System.Drawing.Point(20, 94);
            this.lblNotificationTime.Name = "lblNotificationTime";
            this.lblNotificationTime.Size = new System.Drawing.Size(83, 28);
            this.lblNotificationTime.TabIndex = 2;
            this.lblNotificationTime.Text = "9.00 am";
            // 
            // lblSenderName
            // 
            this.lblSenderName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(100, 9);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(164, 28);
            this.lblSenderName.TabIndex = 1;
            this.lblSenderName.Text = "Sender Name";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(100, 37);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(455, 49);
            this.lblEventDetails.TabIndex = 0;
            this.lblEventDetails.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. Erat pellentesque adipiscing commodo " +
    "elit at imperdiet dui accumsan sit.";
            // 
            // lblNotificationDate
            // 
            this.lblNotificationDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationDate.Location = new System.Drawing.Point(17, 56);
            this.lblNotificationDate.Name = "lblNotificationDate";
            this.lblNotificationDate.Size = new System.Drawing.Size(81, 23);
            this.lblNotificationDate.TabIndex = 8;
            this.lblNotificationDate.Text = "10-2-2023";
            // 
            // notificationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.lblNotificationDate);
            this.Controls.Add(this.pnlEventNews);
            this.Controls.Add(this.pnlNotificationHeader);
            this.Name = "notificationsWindow";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.notificationsWindow_Load);
            this.pnlNotificationHeader.ResumeLayout(false);
            this.pnlEventNews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotificationHeader;
        private System.Windows.Forms.Label lblNotification;
        private FontAwesome.Sharp.IconButton btnCloseNotification;
        private System.Windows.Forms.Panel pnlEventNews;
        private FontAwesome.Sharp.IconButton btnDeleteNotification;
        private System.Windows.Forms.Label lblNotificationTime;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.Label lblNotificationDate;
        private System.Windows.Forms.PictureBox pictureBoxSenderImage;
        private System.Windows.Forms.Label lblSendBy;
    }
}
