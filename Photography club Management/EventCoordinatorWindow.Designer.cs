namespace Photography_club_Management
{
    partial class EventCoordinatorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCoordinatorWindow));
            this.pnlEventCoordinatorWindow = new System.Windows.Forms.Panel();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnNotifications = new FontAwesome.Sharp.IconButton();
            this.btnPaySlip = new FontAwesome.Sharp.IconButton();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlWindowControl = new System.Windows.Forms.Panel();
            this.pnlNavMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlActiveMenu = new System.Windows.Forms.Panel();
            this.btnTrackAttendance = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnEventsBudget = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.attendance = new Photography_club_Management.Attendance();
            this.eventsBudget = new Photography_club_Management.EventsBudget();
            this.eventsWindows = new Photography_club_Management.EventsWindows();
            this.notificationsWindow = new Photography_club_Management.notificationsWindow();
            this.eventCoordinatorHome = new Photography_club_Management.EventCoordinatorHome();
            this.pnlEventCoordinatorWindow.SuspendLayout();
            this.pnlNavMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEventCoordinatorWindow
            // 
            this.pnlEventCoordinatorWindow.Controls.Add(this.attendance);
            this.pnlEventCoordinatorWindow.Controls.Add(this.eventsBudget);
            this.pnlEventCoordinatorWindow.Controls.Add(this.eventsWindows);
            this.pnlEventCoordinatorWindow.Controls.Add(this.notificationsWindow);
            this.pnlEventCoordinatorWindow.Controls.Add(this.eventCoordinatorHome);
            this.pnlEventCoordinatorWindow.Controls.Add(this.pnlBottomBorder);
            this.pnlEventCoordinatorWindow.Controls.Add(this.btnLogout);
            this.pnlEventCoordinatorWindow.Controls.Add(this.btnNotifications);
            this.pnlEventCoordinatorWindow.Controls.Add(this.btnPaySlip);
            this.pnlEventCoordinatorWindow.Controls.Add(this.lblDashboard);
            this.pnlEventCoordinatorWindow.Controls.Add(this.pnlWindowControl);
            this.pnlEventCoordinatorWindow.Controls.Add(this.pnlNavMenu);
            this.pnlEventCoordinatorWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEventCoordinatorWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlEventCoordinatorWindow.Name = "pnlEventCoordinatorWindow";
            this.pnlEventCoordinatorWindow.Size = new System.Drawing.Size(1300, 821);
            this.pnlEventCoordinatorWindow.TabIndex = 0;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(220, 805);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(1080, 16);
            this.pnlBottomBorder.TabIndex = 12;
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
            this.btnLogout.TabIndex = 11;
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
            this.btnNotifications.TabIndex = 10;
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
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
            this.btnPaySlip.TabIndex = 9;
            this.btnPaySlip.Text = "PaySlip";
            this.btnPaySlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaySlip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaySlip.UseVisualStyleBackColor = false;
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
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWindowControl
            // 
            this.pnlWindowControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowControl.Location = new System.Drawing.Point(220, 0);
            this.pnlWindowControl.Name = "pnlWindowControl";
            this.pnlWindowControl.Size = new System.Drawing.Size(1080, 28);
            this.pnlWindowControl.TabIndex = 2;
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
            this.pnlNavMenu.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlActiveMenu);
            this.pnlMenu.Controls.Add(this.btnTrackAttendance);
            this.pnlMenu.Controls.Add(this.btnEvents);
            this.pnlMenu.Controls.Add(this.btnEventsBudget);
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
            this.pnlActiveMenu.Location = new System.Drawing.Point(0, 167);
            this.pnlActiveMenu.Name = "pnlActiveMenu";
            this.pnlActiveMenu.Size = new System.Drawing.Size(10, 40);
            this.pnlActiveMenu.TabIndex = 7;
            // 
            // btnTrackAttendance
            // 
            this.btnTrackAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrackAttendance.FlatAppearance.BorderSize = 0;
            this.btnTrackAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackAttendance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackAttendance.ForeColor = System.Drawing.Color.White;
            this.btnTrackAttendance.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnTrackAttendance.IconColor = System.Drawing.Color.White;
            this.btnTrackAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrackAttendance.IconSize = 32;
            this.btnTrackAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackAttendance.Location = new System.Drawing.Point(12, 365);
            this.btnTrackAttendance.Name = "btnTrackAttendance";
            this.btnTrackAttendance.Size = new System.Drawing.Size(228, 36);
            this.btnTrackAttendance.TabIndex = 5;
            this.btnTrackAttendance.Text = "Attendance";
            this.btnTrackAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrackAttendance.UseVisualStyleBackColor = true;
            this.btnTrackAttendance.Click += new System.EventHandler(this.btnTrackAttendance_Click);
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
            this.btnEvents.Location = new System.Drawing.Point(12, 299);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(182, 36);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnEventsBudget
            // 
            this.btnEventsBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEventsBudget.FlatAppearance.BorderSize = 0;
            this.btnEventsBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsBudget.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsBudget.ForeColor = System.Drawing.Color.White;
            this.btnEventsBudget.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnEventsBudget.IconColor = System.Drawing.Color.White;
            this.btnEventsBudget.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEventsBudget.IconSize = 32;
            this.btnEventsBudget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventsBudget.Location = new System.Drawing.Point(12, 233);
            this.btnEventsBudget.Name = "btnEventsBudget";
            this.btnEventsBudget.Size = new System.Drawing.Size(205, 36);
            this.btnEventsBudget.TabIndex = 3;
            this.btnEventsBudget.Text = "Events Budget";
            this.btnEventsBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventsBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEventsBudget.UseVisualStyleBackColor = true;
            this.btnEventsBudget.Click += new System.EventHandler(this.btnEventsBudget_Click);
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
            this.btnHome.Location = new System.Drawing.Point(12, 167);
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
            this.lblUserWelcome.Text = "Welcome, Event Coordinator";
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
            // attendance
            // 
            this.attendance.BackColor = System.Drawing.Color.White;
            this.attendance.Location = new System.Drawing.Point(220, 70);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(1080, 729);
            this.attendance.TabIndex = 17;
            // 
            // eventsBudget
            // 
            this.eventsBudget.BackColor = System.Drawing.Color.White;
            this.eventsBudget.Location = new System.Drawing.Point(223, 70);
            this.eventsBudget.Name = "eventsBudget";
            this.eventsBudget.Size = new System.Drawing.Size(1072, 729);
            this.eventsBudget.TabIndex = 16;
            // 
            // eventsWindows
            // 
            this.eventsWindows.BackColor = System.Drawing.Color.White;
            this.eventsWindows.Location = new System.Drawing.Point(225, 70);
            this.eventsWindows.Name = "eventsWindows";
            this.eventsWindows.Size = new System.Drawing.Size(1072, 729);
            this.eventsWindows.TabIndex = 15;
            // 
            // notificationsWindow
            // 
            this.notificationsWindow.BackColor = System.Drawing.Color.SeaShell;
            this.notificationsWindow.Location = new System.Drawing.Point(652, 88);
            this.notificationsWindow.Name = "notificationsWindow";
            this.notificationsWindow.Size = new System.Drawing.Size(600, 500);
            this.notificationsWindow.TabIndex = 14;
            // 
            // eventCoordinatorHome
            // 
            this.eventCoordinatorHome.BackColor = System.Drawing.Color.White;
            this.eventCoordinatorHome.Location = new System.Drawing.Point(220, 74);
            this.eventCoordinatorHome.Name = "eventCoordinatorHome";
            this.eventCoordinatorHome.Size = new System.Drawing.Size(1077, 729);
            this.eventCoordinatorHome.TabIndex = 13;
            // 
            // EventCoordinatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 821);
            this.Controls.Add(this.pnlEventCoordinatorWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventCoordinatorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlEventCoordinatorWindow.ResumeLayout(false);
            this.pnlNavMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEventCoordinatorWindow;
        private System.Windows.Forms.Panel pnlNavMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlActiveMenu;
        private FontAwesome.Sharp.IconButton btnTrackAttendance;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnEventsBudget;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Panel pnlWindowControl;
        private System.Windows.Forms.Label lblDashboard;
        private FontAwesome.Sharp.IconButton btnPaySlip;
        private FontAwesome.Sharp.IconButton btnNotifications;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private EventCoordinatorHome eventCoordinatorHome;
        private notificationsWindow notificationsWindow;
        private EventsWindows eventsWindows;
        private EventsBudget eventsBudget;
        private Attendance attendance;
    }
}