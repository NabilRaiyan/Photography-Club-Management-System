namespace Photography_club_Management
{
    partial class ClientWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWindow));
            this.pnlClientWindow = new System.Windows.Forms.Panel();
            this.pnlNavMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlActiveMenu = new System.Windows.Forms.Panel();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.pnlWindowControl = new System.Windows.Forms.Panel();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.clientHome = new Photography_club_Management.ClientHome();
            this.photographerEventsShow = new Photography_club_Management.PhotographerEventsShow();
            this.pnlClientWindow.SuspendLayout();
            this.pnlNavMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientWindow
            // 
            this.pnlClientWindow.Controls.Add(this.photographerEventsShow);
            this.pnlClientWindow.Controls.Add(this.clientHome);
            this.pnlClientWindow.Controls.Add(this.btnLogout);
            this.pnlClientWindow.Controls.Add(this.lblDashboard);
            this.pnlClientWindow.Controls.Add(this.pnlBottomBorder);
            this.pnlClientWindow.Controls.Add(this.pnlWindowControl);
            this.pnlClientWindow.Controls.Add(this.pnlNavMenu);
            this.pnlClientWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlClientWindow.Name = "pnlClientWindow";
            this.pnlClientWindow.Size = new System.Drawing.Size(1300, 821);
            this.pnlClientWindow.TabIndex = 0;
            // 
            // pnlNavMenu
            // 
            this.pnlNavMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlNavMenu.Controls.Add(this.pnlMenu);
            this.pnlNavMenu.Controls.Add(this.pnlProfile);
            this.pnlNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlNavMenu.Name = "pnlNavMenu";
            this.pnlNavMenu.Size = new System.Drawing.Size(220, 821);
            this.pnlNavMenu.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlActiveMenu);
            this.pnlMenu.Controls.Add(this.btnEvents);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 171);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 650);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlActiveMenu
            // 
            this.pnlActiveMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlActiveMenu.Location = new System.Drawing.Point(0, 215);
            this.pnlActiveMenu.Name = "pnlActiveMenu";
            this.pnlActiveMenu.Size = new System.Drawing.Size(10, 40);
            this.pnlActiveMenu.TabIndex = 7;
            // 
            // btnEvents
            // 
            this.btnEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnEvents.IconColor = System.Drawing.Color.White;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.IconSize = 32;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(15, 274);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(182, 36);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 215);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblUserWelcome);
            this.pnlProfile.Controls.Add(this.picBoxUser);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(220, 171);
            this.pnlProfile.TabIndex = 0;
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.Color.White;
            this.lblUserWelcome.Location = new System.Drawing.Point(12, 128);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(199, 40);
            this.lblUserWelcome.TabIndex = 1;
            this.lblUserWelcome.Text = "Welcome,Client";
            this.lblUserWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(61, 34);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(86, 78);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // pnlWindowControl
            // 
            this.pnlWindowControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowControl.Location = new System.Drawing.Point(220, 0);
            this.pnlWindowControl.Name = "pnlWindowControl";
            this.pnlWindowControl.Size = new System.Drawing.Size(1080, 28);
            this.pnlWindowControl.TabIndex = 3;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(220, 805);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(1080, 16);
            this.pnlBottomBorder.TabIndex = 14;
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Black;
            this.lblDashboard.Location = new System.Drawing.Point(220, 28);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(1059, 43);
            this.lblDashboard.TabIndex = 15;
            this.lblDashboard.Text = "Welcome to AIUB Photography Club";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1163, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 40);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // clientHome
            // 
            this.clientHome.BackColor = System.Drawing.Color.White;
            this.clientHome.Location = new System.Drawing.Point(226, 70);
            this.clientHome.Name = "clientHome";
            this.clientHome.Size = new System.Drawing.Size(1071, 729);
            this.clientHome.TabIndex = 17;
            // 
            // photographerEventsShow
            // 
            this.photographerEventsShow.BackColor = System.Drawing.Color.White;
            this.photographerEventsShow.Location = new System.Drawing.Point(226, 70);
            this.photographerEventsShow.Name = "photographerEventsShow";
            this.photographerEventsShow.Size = new System.Drawing.Size(1071, 729);
            this.photographerEventsShow.TabIndex = 18;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 821);
            this.Controls.Add(this.pnlClientWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client";
            this.pnlClientWindow.ResumeLayout(false);
            this.pnlNavMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientWindow;
        private System.Windows.Forms.Panel pnlNavMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlActiveMenu;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Panel pnlWindowControl;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private System.Windows.Forms.Label lblDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
        private ClientHome clientHome;
        private PhotographerEventsShow photographerEventsShow;
    }
}