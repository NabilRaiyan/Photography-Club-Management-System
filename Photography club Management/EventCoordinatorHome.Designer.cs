namespace Photography_club_Management
{
    partial class EventCoordinatorHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCoordinatorHome));
            this.pnlEventCoordinatorHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblUpcommingEvents = new System.Windows.Forms.Label();
            this.pnlUpcommingEvents = new System.Windows.Forms.Panel();
            this.pnlShowEvents = new System.Windows.Forms.Panel();
            this.btnShowAllUpcommingEvents = new System.Windows.Forms.Button();
            this.pnlEventNews = new System.Windows.Forms.Panel();
            this.btnShowEventDetails = new FontAwesome.Sharp.IconButton();
            this.lblEventTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.lblMemberNumber = new System.Windows.Forms.Label();
            this.lblActiveMember = new System.Windows.Forms.Label();
            this.pictureBoxTotalMembers = new System.Windows.Forms.PictureBox();
            this.pnlEventBudget = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblEventBudget = new System.Windows.Forms.Label();
            this.txtEventName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEventId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblEventOrganizeDate = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtRoadNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.txtHouseNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEventBudgetDetails = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnSendEventBudget = new System.Windows.Forms.Button();
            this.lblEventBudgetDetails = new System.Windows.Forms.Label();
            this.pnlEventCoordinatorHome.SuspendLayout();
            this.pnlUpcommingEvents.SuspendLayout();
            this.pnlShowEvents.SuspendLayout();
            this.pnlEventNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalMembers)).BeginInit();
            this.pnlEventBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEventCoordinatorHome
            // 
            this.pnlEventCoordinatorHome.Controls.Add(this.pnlEventBudget);
            this.pnlEventCoordinatorHome.Controls.Add(this.lblMemberNumber);
            this.pnlEventCoordinatorHome.Controls.Add(this.lblActiveMember);
            this.pnlEventCoordinatorHome.Controls.Add(this.pictureBoxTotalMembers);
            this.pnlEventCoordinatorHome.Controls.Add(this.lblUpcommingEvents);
            this.pnlEventCoordinatorHome.Controls.Add(this.pnlUpcommingEvents);
            this.pnlEventCoordinatorHome.Controls.Add(this.lblHome);
            this.pnlEventCoordinatorHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEventCoordinatorHome.Location = new System.Drawing.Point(0, 0);
            this.pnlEventCoordinatorHome.Name = "pnlEventCoordinatorHome";
            this.pnlEventCoordinatorHome.Size = new System.Drawing.Size(1080, 729);
            this.pnlEventCoordinatorHome.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(470, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(140, 34);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpcommingEvents
            // 
            this.lblUpcommingEvents.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcommingEvents.ForeColor = System.Drawing.Color.Navy;
            this.lblUpcommingEvents.Location = new System.Drawing.Point(385, 303);
            this.lblUpcommingEvents.Name = "lblUpcommingEvents";
            this.lblUpcommingEvents.Size = new System.Drawing.Size(185, 25);
            this.lblUpcommingEvents.TabIndex = 6;
            this.lblUpcommingEvents.Text = "UPCOMMING EVENTS";
            // 
            // pnlUpcommingEvents
            // 
            this.pnlUpcommingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlUpcommingEvents.Controls.Add(this.pnlShowEvents);
            this.pnlUpcommingEvents.Controls.Add(this.pnlEventNews);
            this.pnlUpcommingEvents.Location = new System.Drawing.Point(389, 331);
            this.pnlUpcommingEvents.Name = "pnlUpcommingEvents";
            this.pnlUpcommingEvents.Size = new System.Drawing.Size(669, 378);
            this.pnlUpcommingEvents.TabIndex = 7;
            // 
            // pnlShowEvents
            // 
            this.pnlShowEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlShowEvents.Controls.Add(this.btnShowAllUpcommingEvents);
            this.pnlShowEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowEvents.Location = new System.Drawing.Point(0, 343);
            this.pnlShowEvents.Name = "pnlShowEvents";
            this.pnlShowEvents.Size = new System.Drawing.Size(669, 35);
            this.pnlShowEvents.TabIndex = 2;
            // 
            // btnShowAllUpcommingEvents
            // 
            this.btnShowAllUpcommingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnShowAllUpcommingEvents.FlatAppearance.BorderSize = 0;
            this.btnShowAllUpcommingEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllUpcommingEvents.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllUpcommingEvents.ForeColor = System.Drawing.Color.White;
            this.btnShowAllUpcommingEvents.Location = new System.Drawing.Point(291, 3);
            this.btnShowAllUpcommingEvents.Name = "btnShowAllUpcommingEvents";
            this.btnShowAllUpcommingEvents.Size = new System.Drawing.Size(105, 29);
            this.btnShowAllUpcommingEvents.TabIndex = 1;
            this.btnShowAllUpcommingEvents.Text = "SHOW ALL";
            this.btnShowAllUpcommingEvents.UseVisualStyleBackColor = false;
            // 
            // pnlEventNews
            // 
            this.pnlEventNews.BackColor = System.Drawing.Color.White;
            this.pnlEventNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventNews.Controls.Add(this.btnShowEventDetails);
            this.pnlEventNews.Controls.Add(this.lblEventTime);
            this.pnlEventNews.Controls.Add(this.lblDate);
            this.pnlEventNews.Controls.Add(this.lblEventName);
            this.pnlEventNews.Controls.Add(this.lblEventDetails);
            this.pnlEventNews.Location = new System.Drawing.Point(9, 16);
            this.pnlEventNews.Name = "pnlEventNews";
            this.pnlEventNews.Size = new System.Drawing.Size(646, 123);
            this.pnlEventNews.TabIndex = 0;
            // 
            // btnShowEventDetails
            // 
            this.btnShowEventDetails.BackColor = System.Drawing.Color.White;
            this.btnShowEventDetails.FlatAppearance.BorderSize = 0;
            this.btnShowEventDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEventDetails.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnShowEventDetails.IconColor = System.Drawing.Color.Navy;
            this.btnShowEventDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowEventDetails.IconSize = 32;
            this.btnShowEventDetails.Location = new System.Drawing.Point(578, 78);
            this.btnShowEventDetails.Name = "btnShowEventDetails";
            this.btnShowEventDetails.Size = new System.Drawing.Size(39, 40);
            this.btnShowEventDetails.TabIndex = 7;
            this.btnShowEventDetails.UseVisualStyleBackColor = false;
            // 
            // lblEventTime
            // 
            this.lblEventTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTime.ForeColor = System.Drawing.Color.Blue;
            this.lblEventTime.Location = new System.Drawing.Point(4, 86);
            this.lblEventTime.Name = "lblEventTime";
            this.lblEventTime.Size = new System.Drawing.Size(139, 18);
            this.lblEventTime.TabIndex = 6;
            this.lblEventTime.Text = "9.00 am-10.00 am";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(109, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "11-2-2024";
            // 
            // lblEventName
            // 
            this.lblEventName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(3, 9);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(105, 28);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(3, 37);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(625, 49);
            this.lblEventDetails.TabIndex = 0;
            this.lblEventDetails.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua. Erat pellentesque adipiscing commodo " +
    "elit at imperdiet dui accumsan sit.";
            // 
            // lblMemberNumber
            // 
            this.lblMemberNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.lblMemberNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMemberNumber.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberNumber.Location = new System.Drawing.Point(871, 113);
            this.lblMemberNumber.Name = "lblMemberNumber";
            this.lblMemberNumber.Size = new System.Drawing.Size(85, 79);
            this.lblMemberNumber.TabIndex = 10;
            this.lblMemberNumber.Text = "50";
            this.lblMemberNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveMember
            // 
            this.lblActiveMember.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMember.ForeColor = System.Drawing.Color.Navy;
            this.lblActiveMember.Location = new System.Drawing.Point(835, 50);
            this.lblActiveMember.Name = "lblActiveMember";
            this.lblActiveMember.Size = new System.Drawing.Size(170, 25);
            this.lblActiveMember.TabIndex = 9;
            this.lblActiveMember.Text = "ACTIVE MEMBERS";
            // 
            // pictureBoxTotalMembers
            // 
            this.pictureBoxTotalMembers.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTotalMembers.Image")));
            this.pictureBoxTotalMembers.Location = new System.Drawing.Point(840, 89);
            this.pictureBoxTotalMembers.Name = "pictureBoxTotalMembers";
            this.pictureBoxTotalMembers.Size = new System.Drawing.Size(146, 130);
            this.pictureBoxTotalMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTotalMembers.TabIndex = 8;
            this.pictureBoxTotalMembers.TabStop = false;
            // 
            // pnlEventBudget
            // 
            this.pnlEventBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnlEventBudget.Controls.Add(this.lblEventBudgetDetails);
            this.pnlEventBudget.Controls.Add(this.btnSendEventBudget);
            this.pnlEventBudget.Controls.Add(this.txtEventBudgetDetails);
            this.pnlEventBudget.Controls.Add(this.txtRoadNo);
            this.pnlEventBudget.Controls.Add(this.cmbCity);
            this.pnlEventBudget.Controls.Add(this.txtHouseNo);
            this.pnlEventBudget.Controls.Add(this.lblEventOrganizeDate);
            this.pnlEventBudget.Controls.Add(this.dtpEventDate);
            this.pnlEventBudget.Controls.Add(this.txtEventId);
            this.pnlEventBudget.Controls.Add(this.txtEventName);
            this.pnlEventBudget.Controls.Add(this.btnClearAll);
            this.pnlEventBudget.Controls.Add(this.lblEventBudget);
            this.pnlEventBudget.Location = new System.Drawing.Point(11, 55);
            this.pnlEventBudget.Name = "pnlEventBudget";
            this.pnlEventBudget.Size = new System.Drawing.Size(368, 654);
            this.pnlEventBudget.TabIndex = 11;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(232, 605);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 32);
            this.btnClearAll.TabIndex = 20;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // lblEventBudget
            // 
            this.lblEventBudget.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventBudget.ForeColor = System.Drawing.Color.Navy;
            this.lblEventBudget.Location = new System.Drawing.Point(31, 17);
            this.lblEventBudget.Name = "lblEventBudget";
            this.lblEventBudget.Size = new System.Drawing.Size(289, 25);
            this.lblEventBudget.TabIndex = 7;
            this.lblEventBudget.Text = "EVENT BUDGET";
            this.lblEventBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEventName
            // 
            this.txtEventName.AllowPromptAsInput = true;
            this.txtEventName.AnimateReadOnly = false;
            this.txtEventName.AsciiOnly = false;
            this.txtEventName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEventName.BeepOnError = false;
            this.txtEventName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEventName.Depth = 0;
            this.txtEventName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEventName.HidePromptOnLeave = false;
            this.txtEventName.HideSelection = true;
            this.txtEventName.Hint = "ENTER EVENT NAME";
            this.txtEventName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEventName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEventName.LeadingIcon")));
            this.txtEventName.Location = new System.Drawing.Point(35, 142);
            this.txtEventName.Mask = "";
            this.txtEventName.MaxLength = 32767;
            this.txtEventName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.PasswordChar = '\0';
            this.txtEventName.PrefixSuffixText = null;
            this.txtEventName.PromptChar = '_';
            this.txtEventName.ReadOnly = false;
            this.txtEventName.RejectInputOnFirstFailure = false;
            this.txtEventName.ResetOnPrompt = true;
            this.txtEventName.ResetOnSpace = true;
            this.txtEventName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEventName.SelectedText = "";
            this.txtEventName.SelectionLength = 0;
            this.txtEventName.SelectionStart = 0;
            this.txtEventName.ShortcutsEnabled = true;
            this.txtEventName.Size = new System.Drawing.Size(277, 48);
            this.txtEventName.SkipLiterals = true;
            this.txtEventName.TabIndex = 21;
            this.txtEventName.TabStop = false;
            this.txtEventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEventName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEventName.TrailingIcon = null;
            this.txtEventName.UseSystemPasswordChar = false;
            this.txtEventName.ValidatingType = null;
            // 
            // txtEventId
            // 
            this.txtEventId.AllowPromptAsInput = true;
            this.txtEventId.AnimateReadOnly = false;
            this.txtEventId.AsciiOnly = false;
            this.txtEventId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEventId.BeepOnError = false;
            this.txtEventId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEventId.Depth = 0;
            this.txtEventId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEventId.HidePromptOnLeave = false;
            this.txtEventId.HideSelection = true;
            this.txtEventId.Hint = "EVENT ID";
            this.txtEventId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEventId.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEventId.LeadingIcon")));
            this.txtEventId.Location = new System.Drawing.Point(35, 75);
            this.txtEventId.Mask = "";
            this.txtEventId.MaxLength = 32767;
            this.txtEventId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.PasswordChar = '\0';
            this.txtEventId.PrefixSuffixText = null;
            this.txtEventId.PromptChar = '_';
            this.txtEventId.ReadOnly = true;
            this.txtEventId.RejectInputOnFirstFailure = false;
            this.txtEventId.ResetOnPrompt = true;
            this.txtEventId.ResetOnSpace = true;
            this.txtEventId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEventId.SelectedText = "";
            this.txtEventId.SelectionLength = 0;
            this.txtEventId.SelectionStart = 0;
            this.txtEventId.ShortcutsEnabled = true;
            this.txtEventId.Size = new System.Drawing.Size(277, 48);
            this.txtEventId.SkipLiterals = true;
            this.txtEventId.TabIndex = 22;
            this.txtEventId.TabStop = false;
            this.txtEventId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEventId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEventId.TrailingIcon = null;
            this.txtEventId.UseSystemPasswordChar = false;
            this.txtEventId.ValidatingType = null;
            // 
            // lblEventOrganizeDate
            // 
            this.lblEventOrganizeDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventOrganizeDate.ForeColor = System.Drawing.Color.Black;
            this.lblEventOrganizeDate.Location = new System.Drawing.Point(31, 212);
            this.lblEventOrganizeDate.Name = "lblEventOrganizeDate";
            this.lblEventOrganizeDate.Size = new System.Drawing.Size(109, 22);
            this.lblEventOrganizeDate.TabIndex = 29;
            this.lblEventOrganizeDate.Text = "EVENT DATE";
            this.lblEventOrganizeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.CustomFormat = "";
            this.dtpEventDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(172, 209);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(140, 30);
            this.dtpEventDate.TabIndex = 30;
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
            this.txtRoadNo.Location = new System.Drawing.Point(176, 258);
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
            this.txtRoadNo.Size = new System.Drawing.Size(136, 48);
            this.txtRoadNo.SkipLiterals = true;
            this.txtRoadNo.TabIndex = 33;
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
            this.cmbCity.Location = new System.Drawing.Point(35, 325);
            this.cmbCity.MaxDropDownItems = 4;
            this.cmbCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(277, 49);
            this.cmbCity.StartIndex = 0;
            this.cmbCity.TabIndex = 32;
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
            this.txtHouseNo.Location = new System.Drawing.Point(35, 258);
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
            this.txtHouseNo.TabIndex = 31;
            this.txtHouseNo.TabStop = false;
            this.txtHouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHouseNo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtHouseNo.TrailingIcon = null;
            this.txtHouseNo.UseSystemPasswordChar = false;
            this.txtHouseNo.ValidatingType = null;
            // 
            // txtEventBudgetDetails
            // 
            this.txtEventBudgetDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEventBudgetDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEventBudgetDetails.Depth = 0;
            this.txtEventBudgetDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventBudgetDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEventBudgetDetails.Hint = "WRITE ABOUT EVENT BUDGET";
            this.txtEventBudgetDetails.Location = new System.Drawing.Point(35, 418);
            this.txtEventBudgetDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEventBudgetDetails.Name = "txtEventBudgetDetails";
            this.txtEventBudgetDetails.Size = new System.Drawing.Size(277, 152);
            this.txtEventBudgetDetails.TabIndex = 34;
            this.txtEventBudgetDetails.Text = "";
            // 
            // btnSendEventBudget
            // 
            this.btnSendEventBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnSendEventBudget.FlatAppearance.BorderSize = 0;
            this.btnSendEventBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEventBudget.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEventBudget.ForeColor = System.Drawing.Color.White;
            this.btnSendEventBudget.Location = new System.Drawing.Point(40, 605);
            this.btnSendEventBudget.Name = "btnSendEventBudget";
            this.btnSendEventBudget.Size = new System.Drawing.Size(109, 32);
            this.btnSendEventBudget.TabIndex = 35;
            this.btnSendEventBudget.Text = "SEND BUDGET";
            this.btnSendEventBudget.UseVisualStyleBackColor = false;
            // 
            // lblEventBudgetDetails
            // 
            this.lblEventBudgetDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventBudgetDetails.ForeColor = System.Drawing.Color.Black;
            this.lblEventBudgetDetails.Location = new System.Drawing.Point(32, 393);
            this.lblEventBudgetDetails.Name = "lblEventBudgetDetails";
            this.lblEventBudgetDetails.Size = new System.Drawing.Size(158, 18);
            this.lblEventBudgetDetails.TabIndex = 36;
            this.lblEventBudgetDetails.Text = "WRITE ABOUT EVENT BUDGET";
            this.lblEventBudgetDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventCoordinatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlEventCoordinatorHome);
            this.Name = "EventCoordinatorHome";
            this.Size = new System.Drawing.Size(1080, 729);
            this.pnlEventCoordinatorHome.ResumeLayout(false);
            this.pnlUpcommingEvents.ResumeLayout(false);
            this.pnlShowEvents.ResumeLayout(false);
            this.pnlEventNews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalMembers)).EndInit();
            this.pnlEventBudget.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEventCoordinatorHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblUpcommingEvents;
        private System.Windows.Forms.Panel pnlUpcommingEvents;
        private System.Windows.Forms.Panel pnlShowEvents;
        private System.Windows.Forms.Button btnShowAllUpcommingEvents;
        private System.Windows.Forms.Panel pnlEventNews;
        private FontAwesome.Sharp.IconButton btnShowEventDetails;
        private System.Windows.Forms.Label lblEventTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.Label lblMemberNumber;
        private System.Windows.Forms.Label lblActiveMember;
        private System.Windows.Forms.PictureBox pictureBoxTotalMembers;
        private System.Windows.Forms.Panel pnlEventBudget;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblEventBudget;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEventName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEventId;
        private System.Windows.Forms.Label lblEventOrganizeDate;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRoadNo;
        private MaterialSkin.Controls.MaterialComboBox cmbCity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHouseNo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtEventBudgetDetails;
        private System.Windows.Forms.Button btnSendEventBudget;
        private System.Windows.Forms.Label lblEventBudgetDetails;
    }
}
