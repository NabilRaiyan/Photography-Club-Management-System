namespace Photography_club_Management
{
    partial class CustomersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersWindow));
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.pnlSearchClient = new System.Windows.Forms.Panel();
            this.txtSearchCustomer = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlAllCustomers = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCustomerHeading = new System.Windows.Forms.Panel();
            this.lblClientPhoneNumberHeading = new System.Windows.Forms.Label();
            this.lblClientAddressHeading = new System.Windows.Forms.Label();
            this.lblEventDateHeading = new System.Windows.Forms.Label();
            this.lblClientNameHeading = new System.Windows.Forms.Label();
            this.lblClientIdHeading = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.btnDeleteMember = new FontAwesome.Sharp.IconButton();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlCustomers.SuspendLayout();
            this.pnlSearchClient.SuspendLayout();
            this.pnlAllCustomers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomerHeading.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Controls.Add(this.pnlSearchClient);
            this.pnlCustomers.Controls.Add(this.pnlAllCustomers);
            this.pnlCustomers.Controls.Add(this.lblCustomer);
            this.pnlCustomers.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(1080, 735);
            this.pnlCustomers.TabIndex = 0;
            // 
            // pnlSearchClient
            // 
            this.pnlSearchClient.Controls.Add(this.txtSearchCustomer);
            this.pnlSearchClient.Location = new System.Drawing.Point(6, 69);
            this.pnlSearchClient.Name = "pnlSearchClient";
            this.pnlSearchClient.Size = new System.Drawing.Size(711, 48);
            this.pnlSearchClient.TabIndex = 14;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.AnimateReadOnly = false;
            this.txtSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchCustomer.Depth = 0;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.HideSelection = true;
            this.txtSearchCustomer.Hint = "SEARCH CLIENT BY NAME";
            this.txtSearchCustomer.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchCustomer.LeadingIcon")));
            this.txtSearchCustomer.Location = new System.Drawing.Point(0, 0);
            this.txtSearchCustomer.MaxLength = 32767;
            this.txtSearchCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PrefixSuffixText = null;
            this.txtSearchCustomer.ReadOnly = false;
            this.txtSearchCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.SelectionLength = 0;
            this.txtSearchCustomer.SelectionStart = 0;
            this.txtSearchCustomer.ShortcutsEnabled = true;
            this.txtSearchCustomer.Size = new System.Drawing.Size(709, 48);
            this.txtSearchCustomer.TabIndex = 13;
            this.txtSearchCustomer.TabStop = false;
            this.txtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchCustomer.TrailingIcon = null;
            this.txtSearchCustomer.UseSystemPasswordChar = false;
            // 
            // pnlAllCustomers
            // 
            this.pnlAllCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlAllCustomers.Controls.Add(this.panel1);
            this.pnlAllCustomers.Controls.Add(this.pnlCustomerHeading);
            this.pnlAllCustomers.Controls.Add(this.pnlCustomer);
            this.pnlAllCustomers.Location = new System.Drawing.Point(0, 126);
            this.pnlAllCustomers.Name = "pnlAllCustomers";
            this.pnlAllCustomers.Size = new System.Drawing.Size(1080, 603);
            this.pnlAllCustomers.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 41);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "rraiyan77@gmail.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(908, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ph-01";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.iconButton1.Location = new System.Drawing.Point(1033, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 28);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(64, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cl-01";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(654, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dhaka";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(211, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Raiyan Al Sultan";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomerHeading
            // 
            this.pnlCustomerHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlCustomerHeading.Controls.Add(this.lblClientPhoneNumberHeading);
            this.pnlCustomerHeading.Controls.Add(this.lblClientAddressHeading);
            this.pnlCustomerHeading.Controls.Add(this.lblEventDateHeading);
            this.pnlCustomerHeading.Controls.Add(this.lblClientNameHeading);
            this.pnlCustomerHeading.Controls.Add(this.lblClientIdHeading);
            this.pnlCustomerHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerHeading.Name = "pnlCustomerHeading";
            this.pnlCustomerHeading.Size = new System.Drawing.Size(1080, 37);
            this.pnlCustomerHeading.TabIndex = 3;
            // 
            // lblClientPhoneNumberHeading
            // 
            this.lblClientPhoneNumberHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumberHeading.ForeColor = System.Drawing.Color.White;
            this.lblClientPhoneNumberHeading.Location = new System.Drawing.Point(860, 5);
            this.lblClientPhoneNumberHeading.Name = "lblClientPhoneNumberHeading";
            this.lblClientPhoneNumberHeading.Size = new System.Drawing.Size(142, 25);
            this.lblClientPhoneNumberHeading.TabIndex = 6;
            this.lblClientPhoneNumberHeading.Text = "PHONE NUMBER";
            this.lblClientPhoneNumberHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientAddressHeading
            // 
            this.lblClientAddressHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddressHeading.ForeColor = System.Drawing.Color.White;
            this.lblClientAddressHeading.Location = new System.Drawing.Point(642, 5);
            this.lblClientAddressHeading.Name = "lblClientAddressHeading";
            this.lblClientAddressHeading.Size = new System.Drawing.Size(142, 25);
            this.lblClientAddressHeading.TabIndex = 5;
            this.lblClientAddressHeading.Text = "CLIENT ADDRESS";
            this.lblClientAddressHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventDateHeading
            // 
            this.lblEventDateHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDateHeading.ForeColor = System.Drawing.Color.White;
            this.lblEventDateHeading.Location = new System.Drawing.Point(454, 5);
            this.lblEventDateHeading.Name = "lblEventDateHeading";
            this.lblEventDateHeading.Size = new System.Drawing.Size(126, 28);
            this.lblEventDateHeading.TabIndex = 4;
            this.lblEventDateHeading.Text = "CLIENT EMAIL";
            this.lblEventDateHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientNameHeading
            // 
            this.lblClientNameHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameHeading.ForeColor = System.Drawing.Color.White;
            this.lblClientNameHeading.Location = new System.Drawing.Point(255, 5);
            this.lblClientNameHeading.Name = "lblClientNameHeading";
            this.lblClientNameHeading.Size = new System.Drawing.Size(126, 31);
            this.lblClientNameHeading.TabIndex = 3;
            this.lblClientNameHeading.Text = "CLIENT NAME";
            this.lblClientNameHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientIdHeading
            // 
            this.lblClientIdHeading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientIdHeading.ForeColor = System.Drawing.Color.White;
            this.lblClientIdHeading.Location = new System.Drawing.Point(68, 5);
            this.lblClientIdHeading.Name = "lblClientIdHeading";
            this.lblClientIdHeading.Size = new System.Drawing.Size(75, 26);
            this.lblClientIdHeading.TabIndex = 2;
            this.lblClientIdHeading.Text = "CLIENT ID";
            this.lblClientIdHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.lblClientEmail);
            this.pnlCustomer.Controls.Add(this.lblClientPhoneNumber);
            this.pnlCustomer.Controls.Add(this.btnDeleteMember);
            this.pnlCustomer.Controls.Add(this.lblClientId);
            this.pnlCustomer.Controls.Add(this.lblClientAddress);
            this.pnlCustomer.Controls.Add(this.lblClientName);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 63);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1068, 41);
            this.pnlCustomer.TabIndex = 0;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblClientEmail.Location = new System.Drawing.Point(418, 9);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(230, 22);
            this.lblClientEmail.TabIndex = 10;
            this.lblClientEmail.Text = "rraiyan77@gmail.com";
            this.lblClientEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(908, 4);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(49, 28);
            this.lblClientPhoneNumber.TabIndex = 9;
            this.lblClientPhoneNumber.Text = "Ph-01";
            this.lblClientPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnDeleteMember.Location = new System.Drawing.Point(1033, 5);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(30, 28);
            this.btnDeleteMember.TabIndex = 8;
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // lblClientId
            // 
            this.lblClientId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.ForeColor = System.Drawing.Color.Blue;
            this.lblClientId.Location = new System.Drawing.Point(64, 10);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(59, 18);
            this.lblClientId.TabIndex = 6;
            this.lblClientId.Text = "Cl-01";
            this.lblClientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblClientAddress.Location = new System.Drawing.Point(654, 7);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(126, 24);
            this.lblClientAddress.TabIndex = 2;
            this.lblClientAddress.Text = "Dhaka";
            this.lblClientAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientName
            // 
            this.lblClientName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.Blue;
            this.lblClientName.Location = new System.Drawing.Point(211, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(218, 28);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Raiyan Al Sultan";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(470, 12);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(140, 34);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Clients";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomersWindow";
            this.Size = new System.Drawing.Size(1080, 729);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlSearchClient.ResumeLayout(false);
            this.pnlAllCustomers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlCustomerHeading.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlAllCustomers;
        private System.Windows.Forms.Panel pnlCustomerHeading;
        private System.Windows.Forms.Label lblClientPhoneNumberHeading;
        private System.Windows.Forms.Label lblClientAddressHeading;
        private System.Windows.Forms.Label lblEventDateHeading;
        private System.Windows.Forms.Label lblClientNameHeading;
        private System.Windows.Forms.Label lblClientIdHeading;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private FontAwesome.Sharp.IconButton btnDeleteMember;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchCustomer;
        private System.Windows.Forms.Panel pnlSearchClient;
    }
}
