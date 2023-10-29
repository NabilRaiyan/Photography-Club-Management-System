namespace Photography_club_Management
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.txtSearchMembers = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pnlBottomBorder = new System.Windows.Forms.Panel();
            this.pnlAllMembers = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMembersHeading = new System.Windows.Forms.Panel();
            this.lblMemberCurrentWorkingHeading = new System.Windows.Forms.Label();
            this.lblMemberRoleHeading = new System.Windows.Forms.Label();
            this.lblMemberNameHeading = new System.Windows.Forms.Label();
            this.lblMemberIdHeading = new System.Windows.Forms.Label();
            this.pnlEventNews = new System.Windows.Forms.Panel();
            this.lblMemberCurrentWork = new System.Windows.Forms.Label();
            this.btnDeleteMember = new FontAwesome.Sharp.IconButton();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblMemberRole = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pnlAddMember = new System.Windows.Forms.Panel();
            this.lblMemberJoiningDate = new System.Windows.Forms.Label();
            this.dtpMemberJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtRoadNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.txtHouseNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbBoxMemberRole = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMemberPhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberAge = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.pnlMember.SuspendLayout();
            this.pnlAllMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMembersHeading.SuspendLayout();
            this.pnlEventNews.SuspendLayout();
            this.pnlAddMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(470, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(140, 34);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Members";
            // 
            // pnlMember
            // 
            this.pnlMember.Controls.Add(this.txtSearchMembers);
            this.pnlMember.Controls.Add(this.pnlBottomBorder);
            this.pnlMember.Controls.Add(this.pnlAllMembers);
            this.pnlMember.Controls.Add(this.pnlAddMember);
            this.pnlMember.Controls.Add(this.lblHome);
            this.pnlMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMember.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMember.Location = new System.Drawing.Point(0, 0);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(1080, 729);
            this.pnlMember.TabIndex = 2;
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.AllowPromptAsInput = true;
            this.txtSearchMembers.AnimateReadOnly = false;
            this.txtSearchMembers.AsciiOnly = false;
            this.txtSearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchMembers.BeepOnError = false;
            this.txtSearchMembers.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearchMembers.Depth = 0;
            this.txtSearchMembers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMembers.HidePromptOnLeave = false;
            this.txtSearchMembers.HideSelection = true;
            this.txtSearchMembers.Hint = "SEARCH MEMBERS BY NAME";
            this.txtSearchMembers.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSearchMembers.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchMembers.LeadingIcon")));
            this.txtSearchMembers.Location = new System.Drawing.Point(790, 50);
            this.txtSearchMembers.Mask = "";
            this.txtSearchMembers.MaxLength = 32767;
            this.txtSearchMembers.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.PasswordChar = '\0';
            this.txtSearchMembers.PrefixSuffixText = null;
            this.txtSearchMembers.PromptChar = '_';
            this.txtSearchMembers.ReadOnly = false;
            this.txtSearchMembers.RejectInputOnFirstFailure = false;
            this.txtSearchMembers.ResetOnPrompt = true;
            this.txtSearchMembers.ResetOnSpace = true;
            this.txtSearchMembers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchMembers.SelectedText = "";
            this.txtSearchMembers.SelectionLength = 0;
            this.txtSearchMembers.SelectionStart = 0;
            this.txtSearchMembers.ShortcutsEnabled = true;
            this.txtSearchMembers.Size = new System.Drawing.Size(287, 48);
            this.txtSearchMembers.SkipLiterals = true;
            this.txtSearchMembers.TabIndex = 22;
            this.txtSearchMembers.TabStop = false;
            this.txtSearchMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchMembers.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearchMembers.TrailingIcon = null;
            this.txtSearchMembers.UseSystemPasswordChar = false;
            this.txtSearchMembers.ValidatingType = null;
            // 
            // pnlBottomBorder
            // 
            this.pnlBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBorder.Location = new System.Drawing.Point(0, 715);
            this.pnlBottomBorder.Name = "pnlBottomBorder";
            this.pnlBottomBorder.Size = new System.Drawing.Size(1080, 14);
            this.pnlBottomBorder.TabIndex = 11;
            // 
            // pnlAllMembers
            // 
            this.pnlAllMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlAllMembers.Controls.Add(this.panel1);
            this.pnlAllMembers.Controls.Add(this.pnlMembersHeading);
            this.pnlAllMembers.Controls.Add(this.pnlEventNews);
            this.pnlAllMembers.Location = new System.Drawing.Point(397, 104);
            this.pnlAllMembers.Name = "pnlAllMembers";
            this.pnlAllMembers.Size = new System.Drawing.Size(680, 606);
            this.pnlAllMembers.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 41);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(550, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ev-01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(639, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 27);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ph-01";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(340, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Photographer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Raiyan Al Sultan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMembersHeading
            // 
            this.pnlMembersHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlMembersHeading.Controls.Add(this.lblMemberCurrentWorkingHeading);
            this.pnlMembersHeading.Controls.Add(this.lblMemberRoleHeading);
            this.pnlMembersHeading.Controls.Add(this.lblMemberNameHeading);
            this.pnlMembersHeading.Controls.Add(this.lblMemberIdHeading);
            this.pnlMembersHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMembersHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlMembersHeading.Name = "pnlMembersHeading";
            this.pnlMembersHeading.Size = new System.Drawing.Size(680, 37);
            this.pnlMembersHeading.TabIndex = 3;
            // 
            // lblMemberCurrentWorkingHeading
            // 
            this.lblMemberCurrentWorkingHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberCurrentWorkingHeading.ForeColor = System.Drawing.Color.White;
            this.lblMemberCurrentWorkingHeading.Location = new System.Drawing.Point(505, 3);
            this.lblMemberCurrentWorkingHeading.Name = "lblMemberCurrentWorkingHeading";
            this.lblMemberCurrentWorkingHeading.Size = new System.Drawing.Size(142, 31);
            this.lblMemberCurrentWorkingHeading.TabIndex = 5;
            this.lblMemberCurrentWorkingHeading.Text = "CURRENT WORK";
            this.lblMemberCurrentWorkingHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberRoleHeading
            // 
            this.lblMemberRoleHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberRoleHeading.ForeColor = System.Drawing.Color.White;
            this.lblMemberRoleHeading.Location = new System.Drawing.Point(333, 3);
            this.lblMemberRoleHeading.Name = "lblMemberRoleHeading";
            this.lblMemberRoleHeading.Size = new System.Drawing.Size(126, 31);
            this.lblMemberRoleHeading.TabIndex = 4;
            this.lblMemberRoleHeading.Text = "MEMEBR ROLE";
            this.lblMemberRoleHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberNameHeading
            // 
            this.lblMemberNameHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberNameHeading.ForeColor = System.Drawing.Color.White;
            this.lblMemberNameHeading.Location = new System.Drawing.Point(161, 3);
            this.lblMemberNameHeading.Name = "lblMemberNameHeading";
            this.lblMemberNameHeading.Size = new System.Drawing.Size(126, 31);
            this.lblMemberNameHeading.TabIndex = 3;
            this.lblMemberNameHeading.Text = "MEMEBR NAME";
            this.lblMemberNameHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberIdHeading
            // 
            this.lblMemberIdHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberIdHeading.ForeColor = System.Drawing.Color.White;
            this.lblMemberIdHeading.Location = new System.Drawing.Point(20, 5);
            this.lblMemberIdHeading.Name = "lblMemberIdHeading";
            this.lblMemberIdHeading.Size = new System.Drawing.Size(95, 26);
            this.lblMemberIdHeading.TabIndex = 2;
            this.lblMemberIdHeading.Text = "MEMBER ID";
            this.lblMemberIdHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEventNews
            // 
            this.pnlEventNews.BackColor = System.Drawing.Color.White;
            this.pnlEventNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventNews.Controls.Add(this.lblMemberCurrentWork);
            this.pnlEventNews.Controls.Add(this.btnDeleteMember);
            this.pnlEventNews.Controls.Add(this.lblMemberId);
            this.pnlEventNews.Controls.Add(this.lblMemberRole);
            this.pnlEventNews.Controls.Add(this.lblMemberName);
            this.pnlEventNews.Location = new System.Drawing.Point(3, 63);
            this.pnlEventNews.Name = "pnlEventNews";
            this.pnlEventNews.Size = new System.Drawing.Size(674, 41);
            this.pnlEventNews.TabIndex = 0;
            // 
            // lblMemberCurrentWork
            // 
            this.lblMemberCurrentWork.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberCurrentWork.ForeColor = System.Drawing.Color.Blue;
            this.lblMemberCurrentWork.Location = new System.Drawing.Point(550, 9);
            this.lblMemberCurrentWork.Name = "lblMemberCurrentWork";
            this.lblMemberCurrentWork.Size = new System.Drawing.Size(49, 18);
            this.lblMemberCurrentWork.TabIndex = 9;
            this.lblMemberCurrentWork.Text = "Ev-01";
            this.lblMemberCurrentWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.White;
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteMember.IconColor = System.Drawing.Color.Black;
            this.btnDeleteMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteMember.IconSize = 25;
            this.btnDeleteMember.Location = new System.Drawing.Point(639, 9);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(30, 27);
            this.btnDeleteMember.TabIndex = 8;
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // lblMemberId
            // 
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.ForeColor = System.Drawing.Color.Blue;
            this.lblMemberId.Location = new System.Drawing.Point(16, 9);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(59, 18);
            this.lblMemberId.TabIndex = 6;
            this.lblMemberId.Text = "Ph-01";
            this.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberRole
            // 
            this.lblMemberRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberRole.ForeColor = System.Drawing.Color.Blue;
            this.lblMemberRole.Location = new System.Drawing.Point(340, 9);
            this.lblMemberRole.Name = "lblMemberRole";
            this.lblMemberRole.Size = new System.Drawing.Size(126, 18);
            this.lblMemberRole.TabIndex = 2;
            this.lblMemberRole.Text = "Photographer";
            this.lblMemberRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberName
            // 
            this.lblMemberName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(157, 9);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(139, 18);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Raiyan Al Sultan";
            this.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAddMember
            // 
            this.pnlAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlAddMember.Controls.Add(this.lblMemberJoiningDate);
            this.pnlAddMember.Controls.Add(this.dtpMemberJoiningDate);
            this.pnlAddMember.Controls.Add(this.btnClearAll);
            this.pnlAddMember.Controls.Add(this.txtRoadNo);
            this.pnlAddMember.Controls.Add(this.cmbCity);
            this.pnlAddMember.Controls.Add(this.txtHouseNo);
            this.pnlAddMember.Controls.Add(this.cmbBoxMemberRole);
            this.pnlAddMember.Controls.Add(this.txtMemberPhoneNumber);
            this.pnlAddMember.Controls.Add(this.txtMemberEmail);
            this.pnlAddMember.Controls.Add(this.txtMemberAge);
            this.pnlAddMember.Controls.Add(this.txtMemberPassword);
            this.pnlAddMember.Controls.Add(this.txtMemberId);
            this.pnlAddMember.Controls.Add(this.txtMemberName);
            this.pnlAddMember.Controls.Add(this.btnAddMember);
            this.pnlAddMember.Controls.Add(this.lblAddMember);
            this.pnlAddMember.Location = new System.Drawing.Point(18, 44);
            this.pnlAddMember.Name = "pnlAddMember";
            this.pnlAddMember.Size = new System.Drawing.Size(373, 666);
            this.pnlAddMember.TabIndex = 9;
            this.pnlAddMember.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddMember_Paint);
            // 
            // lblMemberJoiningDate
            // 
            this.lblMemberJoiningDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberJoiningDate.ForeColor = System.Drawing.Color.Black;
            this.lblMemberJoiningDate.Location = new System.Drawing.Point(170, 84);
            this.lblMemberJoiningDate.Name = "lblMemberJoiningDate";
            this.lblMemberJoiningDate.Size = new System.Drawing.Size(105, 22);
            this.lblMemberJoiningDate.TabIndex = 6;
            this.lblMemberJoiningDate.Text = "JOINING DATE";
            this.lblMemberJoiningDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpMemberJoiningDate
            // 
            this.dtpMemberJoiningDate.CustomFormat = "";
            this.dtpMemberJoiningDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMemberJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMemberJoiningDate.Location = new System.Drawing.Point(173, 106);
            this.dtpMemberJoiningDate.Name = "dtpMemberJoiningDate";
            this.dtpMemberJoiningDate.Size = new System.Drawing.Size(177, 26);
            this.dtpMemberJoiningDate.TabIndex = 28;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(262, 614);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 38);
            this.btnClearAll.TabIndex = 27;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // txtRoadNo
            // 
            this.txtRoadNo.AllowPromptAsInput = true;
            this.txtRoadNo.AnimateReadOnly = false;
            this.txtRoadNo.AsciiOnly = false;
            this.txtRoadNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRoadNo.BeepOnError = false;
            this.txtRoadNo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRoadNo.Depth = 0;
            this.txtRoadNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoadNo.HidePromptOnLeave = false;
            this.txtRoadNo.HideSelection = true;
            this.txtRoadNo.Hint = "ROAD NO";
            this.txtRoadNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRoadNo.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRoadNo.LeadingIcon")));
            this.txtRoadNo.Location = new System.Drawing.Point(194, 479);
            this.txtRoadNo.Mask = "";
            this.txtRoadNo.MaxLength = 32767;
            this.txtRoadNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRoadNo.Name = "txtRoadNo";
            this.txtRoadNo.PasswordChar = '\0';
            this.txtRoadNo.PrefixSuffixText = null;
            this.txtRoadNo.PromptChar = '_';
            this.txtRoadNo.ReadOnly = false;
            this.txtRoadNo.RejectInputOnFirstFailure = false;
            this.txtRoadNo.ResetOnPrompt = true;
            this.txtRoadNo.ResetOnSpace = true;
            this.txtRoadNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRoadNo.SelectedText = "";
            this.txtRoadNo.SelectionLength = 0;
            this.txtRoadNo.SelectionStart = 0;
            this.txtRoadNo.ShortcutsEnabled = true;
            this.txtRoadNo.Size = new System.Drawing.Size(156, 48);
            this.txtRoadNo.SkipLiterals = true;
            this.txtRoadNo.TabIndex = 26;
            this.txtRoadNo.TabStop = false;
            this.txtRoadNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRoadNo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRoadNo.TrailingIcon = null;
            this.txtRoadNo.UseSystemPasswordChar = false;
            this.txtRoadNo.ValidatingType = null;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoResize = false;
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCity.Depth = 0;
            this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCity.DropDownHeight = 174;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.DropDownWidth = 121;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Hint = "CHOSE CITY";
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.ItemHeight = 43;
            this.cmbCity.Items.AddRange(new object[] {
            "Dhaka",
            "Narayangonj",
            "Khulna",
            "Rajshahi"});
            this.cmbCity.Location = new System.Drawing.Point(23, 543);
            this.cmbCity.MaxDropDownItems = 4;
            this.cmbCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(327, 49);
            this.cmbCity.StartIndex = 0;
            this.cmbCity.TabIndex = 25;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.AllowPromptAsInput = true;
            this.txtHouseNo.AnimateReadOnly = false;
            this.txtHouseNo.AsciiOnly = false;
            this.txtHouseNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHouseNo.BeepOnError = false;
            this.txtHouseNo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtHouseNo.Depth = 0;
            this.txtHouseNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHouseNo.HidePromptOnLeave = false;
            this.txtHouseNo.HideSelection = true;
            this.txtHouseNo.Hint = "HOUSE NO";
            this.txtHouseNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtHouseNo.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtHouseNo.LeadingIcon")));
            this.txtHouseNo.Location = new System.Drawing.Point(23, 480);
            this.txtHouseNo.Mask = "";
            this.txtHouseNo.MaxLength = 32767;
            this.txtHouseNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.PasswordChar = '\0';
            this.txtHouseNo.PrefixSuffixText = null;
            this.txtHouseNo.PromptChar = '_';
            this.txtHouseNo.ReadOnly = false;
            this.txtHouseNo.RejectInputOnFirstFailure = false;
            this.txtHouseNo.ResetOnPrompt = true;
            this.txtHouseNo.ResetOnSpace = true;
            this.txtHouseNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHouseNo.SelectedText = "";
            this.txtHouseNo.SelectionLength = 0;
            this.txtHouseNo.SelectionStart = 0;
            this.txtHouseNo.ShortcutsEnabled = true;
            this.txtHouseNo.Size = new System.Drawing.Size(135, 48);
            this.txtHouseNo.SkipLiterals = true;
            this.txtHouseNo.TabIndex = 22;
            this.txtHouseNo.TabStop = false;
            this.txtHouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHouseNo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtHouseNo.TrailingIcon = null;
            this.txtHouseNo.UseSystemPasswordChar = false;
            this.txtHouseNo.ValidatingType = null;
            this.txtHouseNo.Click += new System.EventHandler(this.txtHouseNo_Click);
            // 
            // cmbBoxMemberRole
            // 
            this.cmbBoxMemberRole.AutoResize = false;
            this.cmbBoxMemberRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxMemberRole.Depth = 0;
            this.cmbBoxMemberRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxMemberRole.DropDownHeight = 174;
            this.cmbBoxMemberRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMemberRole.DropDownWidth = 121;
            this.cmbBoxMemberRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxMemberRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxMemberRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxMemberRole.FormattingEnabled = true;
            this.cmbBoxMemberRole.Hint = "CHOSE ROLE";
            this.cmbBoxMemberRole.IntegralHeight = false;
            this.cmbBoxMemberRole.ItemHeight = 43;
            this.cmbBoxMemberRole.Items.AddRange(new object[] {
            "Photographer",
            "Advisor",
            "Event Coordinator",
            "Marketing"});
            this.cmbBoxMemberRole.Location = new System.Drawing.Point(194, 414);
            this.cmbBoxMemberRole.MaxDropDownItems = 4;
            this.cmbBoxMemberRole.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxMemberRole.Name = "cmbBoxMemberRole";
            this.cmbBoxMemberRole.Size = new System.Drawing.Size(156, 49);
            this.cmbBoxMemberRole.StartIndex = 0;
            this.cmbBoxMemberRole.TabIndex = 21;
            // 
            // txtMemberPhoneNumber
            // 
            this.txtMemberPhoneNumber.AllowPromptAsInput = true;
            this.txtMemberPhoneNumber.AnimateReadOnly = false;
            this.txtMemberPhoneNumber.AsciiOnly = false;
            this.txtMemberPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberPhoneNumber.BeepOnError = false;
            this.txtMemberPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberPhoneNumber.Depth = 0;
            this.txtMemberPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberPhoneNumber.HidePromptOnLeave = false;
            this.txtMemberPhoneNumber.HideSelection = true;
            this.txtMemberPhoneNumber.Hint = "ENTER MEMBER PHONE NUMBER";
            this.txtMemberPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberPhoneNumber.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberPhoneNumber.LeadingIcon")));
            this.txtMemberPhoneNumber.Location = new System.Drawing.Point(23, 350);
            this.txtMemberPhoneNumber.Mask = "";
            this.txtMemberPhoneNumber.MaxLength = 32767;
            this.txtMemberPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberPhoneNumber.Name = "txtMemberPhoneNumber";
            this.txtMemberPhoneNumber.PasswordChar = '\0';
            this.txtMemberPhoneNumber.PrefixSuffixText = null;
            this.txtMemberPhoneNumber.PromptChar = '_';
            this.txtMemberPhoneNumber.ReadOnly = false;
            this.txtMemberPhoneNumber.RejectInputOnFirstFailure = false;
            this.txtMemberPhoneNumber.ResetOnPrompt = true;
            this.txtMemberPhoneNumber.ResetOnSpace = true;
            this.txtMemberPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberPhoneNumber.SelectedText = "";
            this.txtMemberPhoneNumber.SelectionLength = 0;
            this.txtMemberPhoneNumber.SelectionStart = 0;
            this.txtMemberPhoneNumber.ShortcutsEnabled = true;
            this.txtMemberPhoneNumber.Size = new System.Drawing.Size(327, 48);
            this.txtMemberPhoneNumber.SkipLiterals = true;
            this.txtMemberPhoneNumber.TabIndex = 20;
            this.txtMemberPhoneNumber.TabStop = false;
            this.txtMemberPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberPhoneNumber.TrailingIcon = null;
            this.txtMemberPhoneNumber.UseSystemPasswordChar = false;
            this.txtMemberPhoneNumber.ValidatingType = null;
            this.txtMemberPhoneNumber.Click += new System.EventHandler(this.txtMemberPhoneNumber_Click);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.AllowPromptAsInput = true;
            this.txtMemberEmail.AnimateReadOnly = false;
            this.txtMemberEmail.AsciiOnly = false;
            this.txtMemberEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberEmail.BeepOnError = false;
            this.txtMemberEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberEmail.Depth = 0;
            this.txtMemberEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberEmail.HidePromptOnLeave = false;
            this.txtMemberEmail.HideSelection = true;
            this.txtMemberEmail.Hint = "ENTER MEMBER EMAIL";
            this.txtMemberEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberEmail.LeadingIcon")));
            this.txtMemberEmail.Location = new System.Drawing.Point(23, 285);
            this.txtMemberEmail.Mask = "";
            this.txtMemberEmail.MaxLength = 32767;
            this.txtMemberEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.PasswordChar = '\0';
            this.txtMemberEmail.PrefixSuffixText = null;
            this.txtMemberEmail.PromptChar = '_';
            this.txtMemberEmail.ReadOnly = false;
            this.txtMemberEmail.RejectInputOnFirstFailure = false;
            this.txtMemberEmail.ResetOnPrompt = true;
            this.txtMemberEmail.ResetOnSpace = true;
            this.txtMemberEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberEmail.SelectedText = "";
            this.txtMemberEmail.SelectionLength = 0;
            this.txtMemberEmail.SelectionStart = 0;
            this.txtMemberEmail.ShortcutsEnabled = true;
            this.txtMemberEmail.Size = new System.Drawing.Size(327, 48);
            this.txtMemberEmail.SkipLiterals = true;
            this.txtMemberEmail.TabIndex = 19;
            this.txtMemberEmail.TabStop = false;
            this.txtMemberEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberEmail.TrailingIcon = null;
            this.txtMemberEmail.UseSystemPasswordChar = false;
            this.txtMemberEmail.ValidatingType = null;
            this.txtMemberEmail.Click += new System.EventHandler(this.txtMemberEmail_Click);
            // 
            // txtMemberAge
            // 
            this.txtMemberAge.AllowPromptAsInput = true;
            this.txtMemberAge.AnimateReadOnly = false;
            this.txtMemberAge.AsciiOnly = false;
            this.txtMemberAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberAge.BeepOnError = false;
            this.txtMemberAge.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberAge.Depth = 0;
            this.txtMemberAge.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberAge.HidePromptOnLeave = false;
            this.txtMemberAge.HideSelection = true;
            this.txtMemberAge.Hint = "AGE";
            this.txtMemberAge.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberAge.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberAge.LeadingIcon")));
            this.txtMemberAge.Location = new System.Drawing.Point(23, 415);
            this.txtMemberAge.Mask = "";
            this.txtMemberAge.MaxLength = 32767;
            this.txtMemberAge.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberAge.Name = "txtMemberAge";
            this.txtMemberAge.PasswordChar = '\0';
            this.txtMemberAge.PrefixSuffixText = null;
            this.txtMemberAge.PromptChar = '_';
            this.txtMemberAge.ReadOnly = false;
            this.txtMemberAge.RejectInputOnFirstFailure = false;
            this.txtMemberAge.ResetOnPrompt = true;
            this.txtMemberAge.ResetOnSpace = true;
            this.txtMemberAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberAge.SelectedText = "";
            this.txtMemberAge.SelectionLength = 0;
            this.txtMemberAge.SelectionStart = 0;
            this.txtMemberAge.ShortcutsEnabled = true;
            this.txtMemberAge.Size = new System.Drawing.Size(135, 48);
            this.txtMemberAge.SkipLiterals = true;
            this.txtMemberAge.TabIndex = 18;
            this.txtMemberAge.TabStop = false;
            this.txtMemberAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberAge.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberAge.TrailingIcon = null;
            this.txtMemberAge.UseSystemPasswordChar = false;
            this.txtMemberAge.ValidatingType = null;
            this.txtMemberAge.Click += new System.EventHandler(this.txtMemberAge_Click);
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.AllowPromptAsInput = true;
            this.txtMemberPassword.AnimateReadOnly = false;
            this.txtMemberPassword.AsciiOnly = false;
            this.txtMemberPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberPassword.BeepOnError = false;
            this.txtMemberPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberPassword.Depth = 0;
            this.txtMemberPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberPassword.HidePromptOnLeave = false;
            this.txtMemberPassword.HideSelection = true;
            this.txtMemberPassword.Hint = "ENTER MEMBER PASSWORD";
            this.txtMemberPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberPassword.LeadingIcon")));
            this.txtMemberPassword.Location = new System.Drawing.Point(23, 220);
            this.txtMemberPassword.Mask = "";
            this.txtMemberPassword.MaxLength = 32767;
            this.txtMemberPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.PasswordChar = '●';
            this.txtMemberPassword.PrefixSuffixText = null;
            this.txtMemberPassword.PromptChar = '_';
            this.txtMemberPassword.ReadOnly = false;
            this.txtMemberPassword.RejectInputOnFirstFailure = false;
            this.txtMemberPassword.ResetOnPrompt = true;
            this.txtMemberPassword.ResetOnSpace = true;
            this.txtMemberPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberPassword.SelectedText = "";
            this.txtMemberPassword.SelectionLength = 0;
            this.txtMemberPassword.SelectionStart = 0;
            this.txtMemberPassword.ShortcutsEnabled = true;
            this.txtMemberPassword.Size = new System.Drawing.Size(327, 48);
            this.txtMemberPassword.SkipLiterals = true;
            this.txtMemberPassword.TabIndex = 17;
            this.txtMemberPassword.TabStop = false;
            this.txtMemberPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberPassword.TrailingIcon = null;
            this.txtMemberPassword.UseSystemPasswordChar = true;
            this.txtMemberPassword.ValidatingType = null;
            this.txtMemberPassword.Click += new System.EventHandler(this.txtMemberPassword_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.AllowPromptAsInput = true;
            this.txtMemberId.AnimateReadOnly = false;
            this.txtMemberId.AsciiOnly = false;
            this.txtMemberId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberId.BeepOnError = false;
            this.txtMemberId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberId.Depth = 0;
            this.txtMemberId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberId.HidePromptOnLeave = false;
            this.txtMemberId.HideSelection = true;
            this.txtMemberId.Hint = "MEMBER ID";
            this.txtMemberId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberId.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberId.LeadingIcon")));
            this.txtMemberId.Location = new System.Drawing.Point(23, 84);
            this.txtMemberId.Mask = "";
            this.txtMemberId.MaxLength = 32767;
            this.txtMemberId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.PasswordChar = '\0';
            this.txtMemberId.PrefixSuffixText = null;
            this.txtMemberId.PromptChar = '_';
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.RejectInputOnFirstFailure = false;
            this.txtMemberId.ResetOnPrompt = true;
            this.txtMemberId.ResetOnSpace = true;
            this.txtMemberId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberId.SelectedText = "";
            this.txtMemberId.SelectionLength = 0;
            this.txtMemberId.SelectionStart = 0;
            this.txtMemberId.ShortcutsEnabled = true;
            this.txtMemberId.Size = new System.Drawing.Size(141, 48);
            this.txtMemberId.SkipLiterals = true;
            this.txtMemberId.TabIndex = 16;
            this.txtMemberId.TabStop = false;
            this.txtMemberId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberId.TrailingIcon = null;
            this.txtMemberId.UseSystemPasswordChar = false;
            this.txtMemberId.ValidatingType = null;
            this.txtMemberId.Click += new System.EventHandler(this.txtMemberId_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.AllowPromptAsInput = true;
            this.txtMemberName.AnimateReadOnly = false;
            this.txtMemberName.AsciiOnly = false;
            this.txtMemberName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMemberName.BeepOnError = false;
            this.txtMemberName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberName.Depth = 0;
            this.txtMemberName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemberName.HidePromptOnLeave = false;
            this.txtMemberName.HideSelection = true;
            this.txtMemberName.Hint = "ENTER MEMBER NAME";
            this.txtMemberName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMemberName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtMemberName.LeadingIcon")));
            this.txtMemberName.Location = new System.Drawing.Point(23, 152);
            this.txtMemberName.Mask = "";
            this.txtMemberName.MaxLength = 32767;
            this.txtMemberName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PasswordChar = '\0';
            this.txtMemberName.PrefixSuffixText = null;
            this.txtMemberName.PromptChar = '_';
            this.txtMemberName.ReadOnly = false;
            this.txtMemberName.RejectInputOnFirstFailure = false;
            this.txtMemberName.ResetOnPrompt = true;
            this.txtMemberName.ResetOnSpace = true;
            this.txtMemberName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberName.SelectedText = "";
            this.txtMemberName.SelectionLength = 0;
            this.txtMemberName.SelectionStart = 0;
            this.txtMemberName.ShortcutsEnabled = true;
            this.txtMemberName.Size = new System.Drawing.Size(327, 48);
            this.txtMemberName.SkipLiterals = true;
            this.txtMemberName.TabIndex = 15;
            this.txtMemberName.TabStop = false;
            this.txtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemberName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMemberName.TrailingIcon = null;
            this.txtMemberName.UseSystemPasswordChar = false;
            this.txtMemberName.ValidatingType = null;
            this.txtMemberName.Click += new System.EventHandler(this.txtMemberName_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(23, 614);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(161, 38);
            this.btnAddMember.TabIndex = 9;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.UseVisualStyleBackColor = false;
            // 
            // lblAddMember
            // 
            this.lblAddMember.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.ForeColor = System.Drawing.Color.Navy;
            this.lblAddMember.Location = new System.Drawing.Point(32, 13);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(289, 25);
            this.lblAddMember.TabIndex = 6;
            this.lblAddMember.Text = "ADD MEMBER";
            this.lblAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMember);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(1080, 729);
            this.pnlMember.ResumeLayout(false);
            this.pnlAllMembers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMembersHeading.ResumeLayout(false);
            this.pnlEventNews.ResumeLayout(false);
            this.pnlAddMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Panel pnlAddMember;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberId;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberName;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblAddMember;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberAge;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberPhoneNumber;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxMemberRole;
        private System.Windows.Forms.Panel pnlAllMembers;
        private System.Windows.Forms.Panel pnlEventNews;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblMemberRole;
        private System.Windows.Forms.Label lblMemberName;
        private FontAwesome.Sharp.IconButton btnDeleteMember;
        private System.Windows.Forms.Label lblMemberIdHeading;
        private System.Windows.Forms.Panel pnlMembersHeading;
        private System.Windows.Forms.Label lblMemberCurrentWorkingHeading;
        private System.Windows.Forms.Label lblMemberRoleHeading;
        private System.Windows.Forms.Label lblMemberNameHeading;
        private System.Windows.Forms.Label lblMemberCurrentWork;
        private System.Windows.Forms.Panel pnlBottomBorder;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHouseNo;
        private MaterialSkin.Controls.MaterialComboBox cmbCity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRoadNo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblMemberJoiningDate;
        private System.Windows.Forms.DateTimePicker dtpMemberJoiningDate;
    }
}
