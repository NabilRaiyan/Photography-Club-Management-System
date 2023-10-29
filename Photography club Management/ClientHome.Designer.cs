namespace Photography_club_Management
{
    partial class ClientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtRoadNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.txtHouseNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbRegistrarRole = new MaterialSkin.Controls.MaterialComboBox();
            this.txtRegistrarPhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRegistrarEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMemberAge = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRegistrarPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRegistrationId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRegistrarName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnApplyRegistrar = new System.Windows.Forms.Button();
            this.lblRegistrationForMember = new System.Windows.Forms.Label();
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
            this.pnlClientWindow = new System.Windows.Forms.Panel();
            this.pnlRegistration.SuspendLayout();
            this.pnlUpcommingEvents.SuspendLayout();
            this.pnlShowEvents.SuspendLayout();
            this.pnlEventNews.SuspendLayout();
            this.pnlClientWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlRegistration.Controls.Add(this.btnClearAll);
            this.pnlRegistration.Controls.Add(this.txtRoadNo);
            this.pnlRegistration.Controls.Add(this.cmbCity);
            this.pnlRegistration.Controls.Add(this.txtHouseNo);
            this.pnlRegistration.Controls.Add(this.cmbRegistrarRole);
            this.pnlRegistration.Controls.Add(this.txtRegistrarPhoneNumber);
            this.pnlRegistration.Controls.Add(this.txtRegistrarEmail);
            this.pnlRegistration.Controls.Add(this.txtMemberAge);
            this.pnlRegistration.Controls.Add(this.txtRegistrarPassword);
            this.pnlRegistration.Controls.Add(this.txtRegistrationId);
            this.pnlRegistration.Controls.Add(this.txtRegistrarName);
            this.pnlRegistration.Controls.Add(this.btnApplyRegistrar);
            this.pnlRegistration.Controls.Add(this.lblRegistrationForMember);
            this.pnlRegistration.Location = new System.Drawing.Point(29, 43);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(373, 669);
            this.pnlRegistration.TabIndex = 18;
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
            // 
            // cmbRegistrarRole
            // 
            this.cmbRegistrarRole.AutoResize = false;
            this.cmbRegistrarRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRegistrarRole.Depth = 0;
            this.cmbRegistrarRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRegistrarRole.DropDownHeight = 174;
            this.cmbRegistrarRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegistrarRole.DropDownWidth = 121;
            this.cmbRegistrarRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRegistrarRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegistrarRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRegistrarRole.FormattingEnabled = true;
            this.cmbRegistrarRole.Hint = "APPLY FOR";
            this.cmbRegistrarRole.IntegralHeight = false;
            this.cmbRegistrarRole.ItemHeight = 43;
            this.cmbRegistrarRole.Items.AddRange(new object[] {
            "Photographer"});
            this.cmbRegistrarRole.Location = new System.Drawing.Point(194, 414);
            this.cmbRegistrarRole.MaxDropDownItems = 4;
            this.cmbRegistrarRole.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRegistrarRole.Name = "cmbRegistrarRole";
            this.cmbRegistrarRole.Size = new System.Drawing.Size(156, 49);
            this.cmbRegistrarRole.StartIndex = 0;
            this.cmbRegistrarRole.TabIndex = 21;
            // 
            // txtRegistrarPhoneNumber
            // 
            this.txtRegistrarPhoneNumber.AllowPromptAsInput = true;
            this.txtRegistrarPhoneNumber.AnimateReadOnly = false;
            this.txtRegistrarPhoneNumber.AsciiOnly = false;
            this.txtRegistrarPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrarPhoneNumber.BeepOnError = false;
            this.txtRegistrarPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarPhoneNumber.Depth = 0;
            this.txtRegistrarPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrarPhoneNumber.HidePromptOnLeave = false;
            this.txtRegistrarPhoneNumber.HideSelection = true;
            this.txtRegistrarPhoneNumber.Hint = "ENTER PHONE NUMBER";
            this.txtRegistrarPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRegistrarPhoneNumber.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRegistrarPhoneNumber.LeadingIcon")));
            this.txtRegistrarPhoneNumber.Location = new System.Drawing.Point(23, 350);
            this.txtRegistrarPhoneNumber.Mask = "";
            this.txtRegistrarPhoneNumber.MaxLength = 32767;
            this.txtRegistrarPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrarPhoneNumber.Name = "txtRegistrarPhoneNumber";
            this.txtRegistrarPhoneNumber.PasswordChar = '\0';
            this.txtRegistrarPhoneNumber.PrefixSuffixText = null;
            this.txtRegistrarPhoneNumber.PromptChar = '_';
            this.txtRegistrarPhoneNumber.ReadOnly = false;
            this.txtRegistrarPhoneNumber.RejectInputOnFirstFailure = false;
            this.txtRegistrarPhoneNumber.ResetOnPrompt = true;
            this.txtRegistrarPhoneNumber.ResetOnSpace = true;
            this.txtRegistrarPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrarPhoneNumber.SelectedText = "";
            this.txtRegistrarPhoneNumber.SelectionLength = 0;
            this.txtRegistrarPhoneNumber.SelectionStart = 0;
            this.txtRegistrarPhoneNumber.ShortcutsEnabled = true;
            this.txtRegistrarPhoneNumber.Size = new System.Drawing.Size(327, 48);
            this.txtRegistrarPhoneNumber.SkipLiterals = true;
            this.txtRegistrarPhoneNumber.TabIndex = 20;
            this.txtRegistrarPhoneNumber.TabStop = false;
            this.txtRegistrarPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrarPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarPhoneNumber.TrailingIcon = null;
            this.txtRegistrarPhoneNumber.UseSystemPasswordChar = false;
            this.txtRegistrarPhoneNumber.ValidatingType = null;
            // 
            // txtRegistrarEmail
            // 
            this.txtRegistrarEmail.AllowPromptAsInput = true;
            this.txtRegistrarEmail.AnimateReadOnly = false;
            this.txtRegistrarEmail.AsciiOnly = false;
            this.txtRegistrarEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrarEmail.BeepOnError = false;
            this.txtRegistrarEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarEmail.Depth = 0;
            this.txtRegistrarEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrarEmail.HidePromptOnLeave = false;
            this.txtRegistrarEmail.HideSelection = true;
            this.txtRegistrarEmail.Hint = "ENTER EMAIL";
            this.txtRegistrarEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRegistrarEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRegistrarEmail.LeadingIcon")));
            this.txtRegistrarEmail.Location = new System.Drawing.Point(23, 285);
            this.txtRegistrarEmail.Mask = "";
            this.txtRegistrarEmail.MaxLength = 32767;
            this.txtRegistrarEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrarEmail.Name = "txtRegistrarEmail";
            this.txtRegistrarEmail.PasswordChar = '\0';
            this.txtRegistrarEmail.PrefixSuffixText = null;
            this.txtRegistrarEmail.PromptChar = '_';
            this.txtRegistrarEmail.ReadOnly = false;
            this.txtRegistrarEmail.RejectInputOnFirstFailure = false;
            this.txtRegistrarEmail.ResetOnPrompt = true;
            this.txtRegistrarEmail.ResetOnSpace = true;
            this.txtRegistrarEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrarEmail.SelectedText = "";
            this.txtRegistrarEmail.SelectionLength = 0;
            this.txtRegistrarEmail.SelectionStart = 0;
            this.txtRegistrarEmail.ShortcutsEnabled = true;
            this.txtRegistrarEmail.Size = new System.Drawing.Size(327, 48);
            this.txtRegistrarEmail.SkipLiterals = true;
            this.txtRegistrarEmail.TabIndex = 19;
            this.txtRegistrarEmail.TabStop = false;
            this.txtRegistrarEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrarEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarEmail.TrailingIcon = null;
            this.txtRegistrarEmail.UseSystemPasswordChar = false;
            this.txtRegistrarEmail.ValidatingType = null;
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
            // 
            // txtRegistrarPassword
            // 
            this.txtRegistrarPassword.AllowPromptAsInput = true;
            this.txtRegistrarPassword.AnimateReadOnly = false;
            this.txtRegistrarPassword.AsciiOnly = false;
            this.txtRegistrarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrarPassword.BeepOnError = false;
            this.txtRegistrarPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarPassword.Depth = 0;
            this.txtRegistrarPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrarPassword.HidePromptOnLeave = false;
            this.txtRegistrarPassword.HideSelection = true;
            this.txtRegistrarPassword.Hint = "ENTER PASSWORD";
            this.txtRegistrarPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRegistrarPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRegistrarPassword.LeadingIcon")));
            this.txtRegistrarPassword.Location = new System.Drawing.Point(23, 220);
            this.txtRegistrarPassword.Mask = "";
            this.txtRegistrarPassword.MaxLength = 32767;
            this.txtRegistrarPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrarPassword.Name = "txtRegistrarPassword";
            this.txtRegistrarPassword.PasswordChar = '●';
            this.txtRegistrarPassword.PrefixSuffixText = null;
            this.txtRegistrarPassword.PromptChar = '_';
            this.txtRegistrarPassword.ReadOnly = false;
            this.txtRegistrarPassword.RejectInputOnFirstFailure = false;
            this.txtRegistrarPassword.ResetOnPrompt = true;
            this.txtRegistrarPassword.ResetOnSpace = true;
            this.txtRegistrarPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrarPassword.SelectedText = "";
            this.txtRegistrarPassword.SelectionLength = 0;
            this.txtRegistrarPassword.SelectionStart = 0;
            this.txtRegistrarPassword.ShortcutsEnabled = true;
            this.txtRegistrarPassword.Size = new System.Drawing.Size(327, 48);
            this.txtRegistrarPassword.SkipLiterals = true;
            this.txtRegistrarPassword.TabIndex = 17;
            this.txtRegistrarPassword.TabStop = false;
            this.txtRegistrarPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrarPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarPassword.TrailingIcon = null;
            this.txtRegistrarPassword.UseSystemPasswordChar = true;
            this.txtRegistrarPassword.ValidatingType = null;
            // 
            // txtRegistrationId
            // 
            this.txtRegistrationId.AllowPromptAsInput = true;
            this.txtRegistrationId.AnimateReadOnly = false;
            this.txtRegistrationId.AsciiOnly = false;
            this.txtRegistrationId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrationId.BeepOnError = false;
            this.txtRegistrationId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrationId.Depth = 0;
            this.txtRegistrationId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrationId.HidePromptOnLeave = false;
            this.txtRegistrationId.HideSelection = true;
            this.txtRegistrationId.Hint = "REGISTRATION ID";
            this.txtRegistrationId.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRegistrationId.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRegistrationId.LeadingIcon")));
            this.txtRegistrationId.Location = new System.Drawing.Point(23, 84);
            this.txtRegistrationId.Mask = "";
            this.txtRegistrationId.MaxLength = 32767;
            this.txtRegistrationId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrationId.Name = "txtRegistrationId";
            this.txtRegistrationId.PasswordChar = '\0';
            this.txtRegistrationId.PrefixSuffixText = null;
            this.txtRegistrationId.PromptChar = '_';
            this.txtRegistrationId.ReadOnly = true;
            this.txtRegistrationId.RejectInputOnFirstFailure = false;
            this.txtRegistrationId.ResetOnPrompt = true;
            this.txtRegistrationId.ResetOnSpace = true;
            this.txtRegistrationId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrationId.SelectedText = "";
            this.txtRegistrationId.SelectionLength = 0;
            this.txtRegistrationId.SelectionStart = 0;
            this.txtRegistrationId.ShortcutsEnabled = true;
            this.txtRegistrationId.Size = new System.Drawing.Size(327, 48);
            this.txtRegistrationId.SkipLiterals = true;
            this.txtRegistrationId.TabIndex = 16;
            this.txtRegistrationId.TabStop = false;
            this.txtRegistrationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrationId.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrationId.TrailingIcon = null;
            this.txtRegistrationId.UseSystemPasswordChar = false;
            this.txtRegistrationId.ValidatingType = null;
            // 
            // txtRegistrarName
            // 
            this.txtRegistrarName.AllowPromptAsInput = true;
            this.txtRegistrarName.AnimateReadOnly = false;
            this.txtRegistrarName.AsciiOnly = false;
            this.txtRegistrarName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRegistrarName.BeepOnError = false;
            this.txtRegistrarName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarName.Depth = 0;
            this.txtRegistrarName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRegistrarName.HidePromptOnLeave = false;
            this.txtRegistrarName.HideSelection = true;
            this.txtRegistrarName.Hint = "ENTER NAME";
            this.txtRegistrarName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRegistrarName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtRegistrarName.LeadingIcon")));
            this.txtRegistrarName.Location = new System.Drawing.Point(23, 152);
            this.txtRegistrarName.Mask = "";
            this.txtRegistrarName.MaxLength = 32767;
            this.txtRegistrarName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistrarName.Name = "txtRegistrarName";
            this.txtRegistrarName.PasswordChar = '\0';
            this.txtRegistrarName.PrefixSuffixText = null;
            this.txtRegistrarName.PromptChar = '_';
            this.txtRegistrarName.ReadOnly = false;
            this.txtRegistrarName.RejectInputOnFirstFailure = false;
            this.txtRegistrarName.ResetOnPrompt = true;
            this.txtRegistrarName.ResetOnSpace = true;
            this.txtRegistrarName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrarName.SelectedText = "";
            this.txtRegistrarName.SelectionLength = 0;
            this.txtRegistrarName.SelectionStart = 0;
            this.txtRegistrarName.ShortcutsEnabled = true;
            this.txtRegistrarName.Size = new System.Drawing.Size(327, 48);
            this.txtRegistrarName.SkipLiterals = true;
            this.txtRegistrarName.TabIndex = 15;
            this.txtRegistrarName.TabStop = false;
            this.txtRegistrarName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegistrarName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRegistrarName.TrailingIcon = null;
            this.txtRegistrarName.UseSystemPasswordChar = false;
            this.txtRegistrarName.ValidatingType = null;
            // 
            // btnApplyRegistrar
            // 
            this.btnApplyRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.btnApplyRegistrar.FlatAppearance.BorderSize = 0;
            this.btnApplyRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnApplyRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnApplyRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyRegistrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnApplyRegistrar.Location = new System.Drawing.Point(23, 614);
            this.btnApplyRegistrar.Name = "btnApplyRegistrar";
            this.btnApplyRegistrar.Size = new System.Drawing.Size(161, 38);
            this.btnApplyRegistrar.TabIndex = 9;
            this.btnApplyRegistrar.Text = "APPLY";
            this.btnApplyRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblRegistrationForMember
            // 
            this.lblRegistrationForMember.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationForMember.ForeColor = System.Drawing.Color.Navy;
            this.lblRegistrationForMember.Location = new System.Drawing.Point(32, 13);
            this.lblRegistrationForMember.Name = "lblRegistrationForMember";
            this.lblRegistrationForMember.Size = new System.Drawing.Size(289, 25);
            this.lblRegistrationForMember.TabIndex = 6;
            this.lblRegistrationForMember.Text = "Registration";
            this.lblRegistrationForMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(470, 20);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(140, 34);
            this.lblHome.TabIndex = 19;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpcommingEvents
            // 
            this.lblUpcommingEvents.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcommingEvents.ForeColor = System.Drawing.Color.Navy;
            this.lblUpcommingEvents.Location = new System.Drawing.Point(408, 127);
            this.lblUpcommingEvents.Name = "lblUpcommingEvents";
            this.lblUpcommingEvents.Size = new System.Drawing.Size(185, 25);
            this.lblUpcommingEvents.TabIndex = 20;
            this.lblUpcommingEvents.Text = "UPCOMMING EVENTS";
            // 
            // pnlUpcommingEvents
            // 
            this.pnlUpcommingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlUpcommingEvents.Controls.Add(this.pnlShowEvents);
            this.pnlUpcommingEvents.Controls.Add(this.pnlEventNews);
            this.pnlUpcommingEvents.Location = new System.Drawing.Point(408, 155);
            this.pnlUpcommingEvents.Name = "pnlUpcommingEvents";
            this.pnlUpcommingEvents.Size = new System.Drawing.Size(669, 557);
            this.pnlUpcommingEvents.TabIndex = 21;
            // 
            // pnlShowEvents
            // 
            this.pnlShowEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlShowEvents.Controls.Add(this.btnShowAllUpcommingEvents);
            this.pnlShowEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowEvents.Location = new System.Drawing.Point(0, 522);
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
            // pnlClientWindow
            // 
            this.pnlClientWindow.Controls.Add(this.lblHome);
            this.pnlClientWindow.Controls.Add(this.pnlUpcommingEvents);
            this.pnlClientWindow.Controls.Add(this.lblUpcommingEvents);
            this.pnlClientWindow.Controls.Add(this.pnlRegistration);
            this.pnlClientWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlClientWindow.Name = "pnlClientWindow";
            this.pnlClientWindow.Size = new System.Drawing.Size(1080, 729);
            this.pnlClientWindow.TabIndex = 22;
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlClientWindow);
            this.Name = "ClientHome";
            this.Size = new System.Drawing.Size(1080, 729);
            this.pnlRegistration.ResumeLayout(false);
            this.pnlUpcommingEvents.ResumeLayout(false);
            this.pnlShowEvents.ResumeLayout(false);
            this.pnlEventNews.ResumeLayout(false);
            this.pnlClientWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Button btnClearAll;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRoadNo;
        private MaterialSkin.Controls.MaterialComboBox cmbCity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHouseNo;
        private MaterialSkin.Controls.MaterialComboBox cmbRegistrarRole;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRegistrarPhoneNumber;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRegistrarEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMemberAge;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRegistrarPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRegistrationId;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRegistrarName;
        private System.Windows.Forms.Button btnApplyRegistrar;
        private System.Windows.Forms.Label lblRegistrationForMember;
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
        private System.Windows.Forms.Panel pnlClientWindow;
    }
}
