namespace Photography_club_Management
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginFormPanel = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCloseWindow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.lblLoginPasswordInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtLoginInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLogin = new System.Windows.Forms.Label();
            this.loginImagePanel = new System.Windows.Forms.Panel();
            this.loginLeftPicture = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.loginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).BeginInit();
            this.loginImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLeftPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.loginFormPanel);
            this.loginPanel.Controls.Add(this.loginImagePanel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(920, 650);
            this.loginPanel.TabIndex = 0;
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.BackColor = System.Drawing.Color.White;
            this.loginFormPanel.Controls.Add(this.picLogo);
            this.loginFormPanel.Controls.Add(this.btnCloseWindow);
            this.loginFormPanel.Controls.Add(this.label1);
            this.loginFormPanel.Controls.Add(this.btnLogin);
            this.loginFormPanel.Controls.Add(this.lblLoginPasswordInput);
            this.loginFormPanel.Controls.Add(this.txtLoginInput);
            this.loginFormPanel.Controls.Add(this.lblLogin);
            this.loginFormPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginFormPanel.Location = new System.Drawing.Point(459, 0);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(461, 650);
            this.loginFormPanel.TabIndex = 1;
            this.loginFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginFormPanel_Paint);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(175, 47);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(431, 3);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(27, 26);
            this.btnCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(65, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Forgot Password?";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(69, 448);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(336, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginPasswordInput
            // 
            this.lblLoginPasswordInput.AnimateReadOnly = false;
            this.lblLoginPasswordInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblLoginPasswordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lblLoginPasswordInput.Depth = 0;
            this.lblLoginPasswordInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPasswordInput.HideSelection = true;
            this.lblLoginPasswordInput.Hint = "Enter your password";
            this.lblLoginPasswordInput.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("lblLoginPasswordInput.LeadingIcon")));
            this.lblLoginPasswordInput.LeaveOnEnterKey = true;
            this.lblLoginPasswordInput.Location = new System.Drawing.Point(69, 331);
            this.lblLoginPasswordInput.MaxLength = 32767;
            this.lblLoginPasswordInput.MouseState = MaterialSkin.MouseState.OUT;
            this.lblLoginPasswordInput.Name = "lblLoginPasswordInput";
            this.lblLoginPasswordInput.PasswordChar = '●';
            this.lblLoginPasswordInput.PrefixSuffixText = null;
            this.lblLoginPasswordInput.ReadOnly = false;
            this.lblLoginPasswordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoginPasswordInput.SelectedText = "";
            this.lblLoginPasswordInput.SelectionLength = 0;
            this.lblLoginPasswordInput.SelectionStart = 0;
            this.lblLoginPasswordInput.ShortcutsEnabled = true;
            this.lblLoginPasswordInput.Size = new System.Drawing.Size(336, 48);
            this.lblLoginPasswordInput.TabIndex = 4;
            this.lblLoginPasswordInput.TabStop = false;
            this.lblLoginPasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblLoginPasswordInput.TrailingIcon = null;
            this.lblLoginPasswordInput.UseSystemPasswordChar = true;
            // 
            // txtLoginInput
            // 
            this.txtLoginInput.AnimateReadOnly = false;
            this.txtLoginInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLoginInput.Depth = 0;
            this.txtLoginInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginInput.HideSelection = true;
            this.txtLoginInput.Hint = "Enter your user id";
            this.txtLoginInput.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtLoginInput.LeadingIcon")));
            this.txtLoginInput.LeaveOnEnterKey = true;
            this.txtLoginInput.Location = new System.Drawing.Point(69, 244);
            this.txtLoginInput.MaxLength = 32767;
            this.txtLoginInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginInput.Name = "txtLoginInput";
            this.txtLoginInput.PasswordChar = '\0';
            this.txtLoginInput.PrefixSuffixText = null;
            this.txtLoginInput.ReadOnly = false;
            this.txtLoginInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginInput.SelectedText = "";
            this.txtLoginInput.SelectionLength = 0;
            this.txtLoginInput.SelectionStart = 0;
            this.txtLoginInput.ShortcutsEnabled = true;
            this.txtLoginInput.Size = new System.Drawing.Size(336, 48);
            this.txtLoginInput.TabIndex = 3;
            this.txtLoginInput.TabStop = false;
            this.txtLoginInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginInput.TrailingIcon = null;
            this.txtLoginInput.UseSystemPasswordChar = false;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(180, 164);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(110, 54);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginImagePanel
            // 
            this.loginImagePanel.BackColor = System.Drawing.Color.White;
            this.loginImagePanel.Controls.Add(this.loginLeftPicture);
            this.loginImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginImagePanel.Location = new System.Drawing.Point(0, 0);
            this.loginImagePanel.Name = "loginImagePanel";
            this.loginImagePanel.Size = new System.Drawing.Size(460, 650);
            this.loginImagePanel.TabIndex = 0;
            // 
            // loginLeftPicture
            // 
            this.loginLeftPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginLeftPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginLeftPicture.Image")));
            this.loginLeftPicture.Location = new System.Drawing.Point(0, 0);
            this.loginLeftPicture.Name = "loginLeftPicture";
            this.loginLeftPicture.Size = new System.Drawing.Size(460, 650);
            this.loginLeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginLeftPicture.TabIndex = 0;
            this.loginLeftPicture.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).EndInit();
            this.loginImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginLeftPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel loginImagePanel;
        private System.Windows.Forms.PictureBox loginLeftPicture;
        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.Label lblLogin;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginInput;
        private MaterialSkin.Controls.MaterialTextBox2 lblLoginPasswordInput;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private System.Windows.Forms.PictureBox btnCloseWindow;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

