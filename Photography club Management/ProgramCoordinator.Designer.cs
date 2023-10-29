namespace Photography_club_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlNavMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlActiveMenu = new System.Windows.Forms.Panel();
            this.btnResources = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnMembers = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.pnlWindowControl = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnNotifications = new FontAwesome.Sharp.IconButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.notificationsWindow = new Photography_club_Management.notificationsWindow();
            this.resourcesWindow = new Photography_club_Management.ResourcesWindow();
            this.customersWindow = new Photography_club_Management.CustomersWindow();
            this.eventsWindows = new Photography_club_Management.EventsWindows();
            this.membersWindow = new Photography_club_Management.Members();
            this.homeWindow = new Photography_club_Management.Home();
            this.btnPaySlip = new FontAwesome.Sharp.IconButton();
            this.pnlNavMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlNavMenu.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlActiveMenu);
            this.pnlMenu.Controls.Add(this.btnResources);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnEvents);
            this.pnlMenu.Controls.Add(this.btnMembers);
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
            this.pnlActiveMenu.Location = new System.Drawing.Point(0, 131);
            this.pnlActiveMenu.Name = "pnlActiveMenu";
            this.pnlActiveMenu.Size = new System.Drawing.Size(10, 40);
            this.pnlActiveMenu.TabIndex = 7;
            // 
            // btnResources
            // 
            this.btnResources.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResources.ForeColor = System.Drawing.Color.White;
            this.btnResources.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnResources.IconColor = System.Drawing.Color.White;
            this.btnResources.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResources.IconSize = 32;
            this.btnResources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResources.Location = new System.Drawing.Point(12, 395);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(182, 36);
            this.btnResources.TabIndex = 6;
            this.btnResources.Text = "Resources";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCustomer.IconColor = System.Drawing.Color.White;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 32;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(12, 329);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(182, 36);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Clients";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
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
            this.btnEvents.Location = new System.Drawing.Point(12, 263);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(182, 36);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnMembers.IconColor = System.Drawing.Color.White;
            this.btnMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMembers.IconSize = 32;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(12, 197);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(182, 36);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
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
            this.btnHome.Location = new System.Drawing.Point(12, 131);
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
            this.lblUserWelcome.Text = "Welcome, Program Coordinator";
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
            this.pnlWindowControl.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Black;
            this.lblDashboard.Location = new System.Drawing.Point(220, 28);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(1080, 43);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
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
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.Black;
            this.btnNotifications.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotifications.IconColor = System.Drawing.Color.Black;
            this.btnNotifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotifications.IconSize = 32;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(1113, 35);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(44, 36);
            this.btnNotifications.TabIndex = 6;
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBottomBorder);
            this.pnlMain.Controls.Add(this.notificationsWindow);
            this.pnlMain.Controls.Add(this.resourcesWindow);
            this.pnlMain.Controls.Add(this.customersWindow);
            this.pnlMain.Controls.Add(this.eventsWindows);
            this.pnlMain.Controls.Add(this.membersWindow);
            this.pnlMain.Controls.Add(this.homeWindow);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(220, 91);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 730);
            this.pnlMain.TabIndex = 7;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(0, 714);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(1080, 16);
            this.pnlBottomBorder.TabIndex = 3;
            // 
            // notificationsWindow
            // 
            this.notificationsWindow.BackColor = System.Drawing.Color.SeaShell;
            this.notificationsWindow.Location = new System.Drawing.Point(468, 3);
            this.notificationsWindow.Name = "notificationsWindow";
            this.notificationsWindow.Size = new System.Drawing.Size(600, 479);
            this.notificationsWindow.TabIndex = 5;
            // 
            // resourcesWindow
            // 
            this.resourcesWindow.BackColor = System.Drawing.Color.White;
            this.resourcesWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesWindow.Location = new System.Drawing.Point(0, 0);
            this.resourcesWindow.Name = "resourcesWindow";
            this.resourcesWindow.Size = new System.Drawing.Size(1080, 730);
            this.resourcesWindow.TabIndex = 4;
            // 
            // customersWindow
            // 
            this.customersWindow.BackColor = System.Drawing.Color.White;
            this.customersWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersWindow.Location = new System.Drawing.Point(0, -21);
            this.customersWindow.Margin = new System.Windows.Forms.Padding(6);
            this.customersWindow.Name = "customersWindow";
            this.customersWindow.Size = new System.Drawing.Size(1080, 752);
            this.customersWindow.TabIndex = 3;
            // 
            // eventsWindows
            // 
            this.eventsWindows.BackColor = System.Drawing.Color.White;
            this.eventsWindows.Location = new System.Drawing.Point(0, -21);
            this.eventsWindows.Name = "eventsWindows";
            this.eventsWindows.Size = new System.Drawing.Size(1080, 752);
            this.eventsWindows.TabIndex = 2;
            // 
            // membersWindow
            // 
            this.membersWindow.BackColor = System.Drawing.Color.White;
            this.membersWindow.Location = new System.Drawing.Point(0, -21);
            this.membersWindow.Name = "membersWindow";
            this.membersWindow.Size = new System.Drawing.Size(1080, 752);
            this.membersWindow.TabIndex = 1;
            // 
            // homeWindow
            // 
            this.homeWindow.BackColor = System.Drawing.Color.White;
            this.homeWindow.Location = new System.Drawing.Point(0, -21);
            this.homeWindow.Name = "homeWindow";
            this.homeWindow.Size = new System.Drawing.Size(1080, 752);
            this.homeWindow.TabIndex = 0;
            // 
            // btnPaySlip
            // 
            this.btnPaySlip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaySlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaySlip.FlatAppearance.BorderSize = 0;
            this.btnPaySlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaySlip.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySlip.ForeColor = System.Drawing.Color.Black;
            this.btnPaySlip.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnPaySlip.IconColor = System.Drawing.Color.Black;
            this.btnPaySlip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaySlip.IconSize = 32;
            this.btnPaySlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaySlip.Location = new System.Drawing.Point(226, 28);
            this.btnPaySlip.Name = "btnPaySlip";
            this.btnPaySlip.Size = new System.Drawing.Size(142, 42);
            this.btnPaySlip.TabIndex = 8;
            this.btnPaySlip.Text = "PaySlip";
            this.btnPaySlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaySlip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaySlip.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 821);
            this.Controls.Add(this.btnPaySlip);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlWindowControl);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.pnlNavMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlNavMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavMenu;
        private System.Windows.Forms.Panel pnlWindowControl;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.PictureBox picBoxUser;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnNotifications;
        private FontAwesome.Sharp.IconButton btnResources;
        private System.Windows.Forms.Panel pnlActiveMenu;
        private System.Windows.Forms.Panel pnlMain;
        private Members membersWindow;
        private Home homeWindow;
        private EventsWindows eventsWindows;
        private ResourcesWindow resourcesWindow;
        private CustomersWindow customersWindow;
        private notificationsWindow notificationsWindow;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private FontAwesome.Sharp.IconButton btnPaySlip;
    }
}