namespace GendeneCatCare
{
    partial class OwnerForm
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
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlOwner = new System.Windows.Forms.Panel();
            this.lblPnlOwnerNo = new System.Windows.Forms.Label();
            this.lblPnlOwnerID = new System.Windows.Forms.Label();
            this.lblPnlLastName = new System.Windows.Forms.Label();
            this.lblPnlFirstName = new System.Windows.Forms.Label();
            this.lblPnlStreetAddress = new System.Windows.Forms.Label();
            this.lblPnlSuburb = new System.Windows.Forms.Label();
            this.txtPnlLastName = new System.Windows.Forms.TextBox();
            this.txtPnlFirstName = new System.Windows.Forms.TextBox();
            this.txtPnlStreetAddress = new System.Windows.Forms.TextBox();
            this.txtPnlSuburb = new System.Windows.Forms.TextBox();
            this.lblPnlPhoneNumber = new System.Windows.Forms.Label();
            this.txtPnlPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPnlCancel = new System.Windows.Forms.Button();
            this.btnPnlSaveOwner = new System.Windows.Forms.Button();
            this.pnlOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwners
            // 
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.ItemHeight = 20;
            this.lstOwners.Location = new System.Drawing.Point(78, 50);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(214, 284);
            this.lstOwners.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(78, 375);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(95, 46);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(197, 375);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Location = new System.Drawing.Point(369, 60);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(80, 20);
            this.lblOwnerNo.TabIndex = 3;
            this.lblOwnerNo.Text = "Owner ID:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(448, 59);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(33, 20);
            this.lblOwnerID.TabIndex = 4;
            this.lblOwnerID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(359, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(453, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(128, 26);
            this.txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(359, 148);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(329, 192);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(120, 20);
            this.lblStreetAddress.TabIndex = 8;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(384, 236);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(65, 20);
            this.lblSuburb.TabIndex = 9;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(330, 280);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(453, 147);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 26);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(453, 192);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(363, 26);
            this.txtStreetAddress.TabIndex = 12;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(453, 236);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(128, 26);
            this.txtSuburb.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(453, 280);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(106, 26);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(364, 377);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(133, 46);
            this.btnAddOwner.TabIndex = 15;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(521, 375);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(133, 46);
            this.btnUpdateOwner.TabIndex = 16;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(678, 377);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(133, 46);
            this.btnDeleteOwner.TabIndex = 17;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(678, 471);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(133, 46);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlOwner
            // 
            this.pnlOwner.Controls.Add(this.btnPnlSaveOwner);
            this.pnlOwner.Controls.Add(this.btnPnlCancel);
            this.pnlOwner.Controls.Add(this.txtPnlPhoneNumber);
            this.pnlOwner.Controls.Add(this.lblPnlPhoneNumber);
            this.pnlOwner.Controls.Add(this.txtPnlSuburb);
            this.pnlOwner.Controls.Add(this.txtPnlStreetAddress);
            this.pnlOwner.Controls.Add(this.txtPnlFirstName);
            this.pnlOwner.Controls.Add(this.txtPnlLastName);
            this.pnlOwner.Controls.Add(this.lblPnlSuburb);
            this.pnlOwner.Controls.Add(this.lblPnlStreetAddress);
            this.pnlOwner.Controls.Add(this.lblPnlFirstName);
            this.pnlOwner.Controls.Add(this.lblPnlLastName);
            this.pnlOwner.Controls.Add(this.lblPnlOwnerID);
            this.pnlOwner.Controls.Add(this.lblPnlOwnerNo);
            this.pnlOwner.Location = new System.Drawing.Point(140, 37);
            this.pnlOwner.Name = "pnlOwner";
            this.pnlOwner.Size = new System.Drawing.Size(504, 332);
            this.pnlOwner.TabIndex = 19;
            this.pnlOwner.Visible = false;
            // 
            // lblPnlOwnerNo
            // 
            this.lblPnlOwnerNo.AutoSize = true;
            this.lblPnlOwnerNo.Location = new System.Drawing.Point(134, 21);
            this.lblPnlOwnerNo.Name = "lblPnlOwnerNo";
            this.lblPnlOwnerNo.Size = new System.Drawing.Size(80, 20);
            this.lblPnlOwnerNo.TabIndex = 0;
            this.lblPnlOwnerNo.Text = "Owner ID:";
            // 
            // lblPnlOwnerID
            // 
            this.lblPnlOwnerID.AutoSize = true;
            this.lblPnlOwnerID.Location = new System.Drawing.Point(209, 21);
            this.lblPnlOwnerID.Name = "lblPnlOwnerID";
            this.lblPnlOwnerID.Size = new System.Drawing.Size(33, 20);
            this.lblPnlOwnerID.TabIndex = 1;
            this.lblPnlOwnerID.Text = "null";
            // 
            // lblPnlLastName
            // 
            this.lblPnlLastName.AutoSize = true;
            this.lblPnlLastName.Location = new System.Drawing.Point(124, 65);
            this.lblPnlLastName.Name = "lblPnlLastName";
            this.lblPnlLastName.Size = new System.Drawing.Size(90, 20);
            this.lblPnlLastName.TabIndex = 2;
            this.lblPnlLastName.Text = "Last Name:";
            // 
            // lblPnlFirstName
            // 
            this.lblPnlFirstName.AutoSize = true;
            this.lblPnlFirstName.Location = new System.Drawing.Point(124, 109);
            this.lblPnlFirstName.Name = "lblPnlFirstName";
            this.lblPnlFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblPnlFirstName.TabIndex = 3;
            this.lblPnlFirstName.Text = "First Name:";
            // 
            // lblPnlStreetAddress
            // 
            this.lblPnlStreetAddress.AutoSize = true;
            this.lblPnlStreetAddress.Location = new System.Drawing.Point(94, 153);
            this.lblPnlStreetAddress.Name = "lblPnlStreetAddress";
            this.lblPnlStreetAddress.Size = new System.Drawing.Size(120, 20);
            this.lblPnlStreetAddress.TabIndex = 4;
            this.lblPnlStreetAddress.Text = "Street Address:";
            // 
            // lblPnlSuburb
            // 
            this.lblPnlSuburb.AutoSize = true;
            this.lblPnlSuburb.Location = new System.Drawing.Point(149, 197);
            this.lblPnlSuburb.Name = "lblPnlSuburb";
            this.lblPnlSuburb.Size = new System.Drawing.Size(65, 20);
            this.lblPnlSuburb.TabIndex = 5;
            this.lblPnlSuburb.Text = "Suburb:";
            // 
            // txtPnlLastName
            // 
            this.txtPnlLastName.Location = new System.Drawing.Point(213, 62);
            this.txtPnlLastName.Name = "txtPnlLastName";
            this.txtPnlLastName.Size = new System.Drawing.Size(128, 26);
            this.txtPnlLastName.TabIndex = 6;
            // 
            // txtPnlFirstName
            // 
            this.txtPnlFirstName.Location = new System.Drawing.Point(213, 106);
            this.txtPnlFirstName.Name = "txtPnlFirstName";
            this.txtPnlFirstName.Size = new System.Drawing.Size(128, 26);
            this.txtPnlFirstName.TabIndex = 7;
            // 
            // txtPnlStreetAddress
            // 
            this.txtPnlStreetAddress.Location = new System.Drawing.Point(213, 150);
            this.txtPnlStreetAddress.Name = "txtPnlStreetAddress";
            this.txtPnlStreetAddress.Size = new System.Drawing.Size(266, 26);
            this.txtPnlStreetAddress.TabIndex = 8;
            // 
            // txtPnlSuburb
            // 
            this.txtPnlSuburb.Location = new System.Drawing.Point(213, 194);
            this.txtPnlSuburb.Name = "txtPnlSuburb";
            this.txtPnlSuburb.Size = new System.Drawing.Size(128, 26);
            this.txtPnlSuburb.TabIndex = 9;
            // 
            // lblPnlPhoneNumber
            // 
            this.lblPnlPhoneNumber.AutoSize = true;
            this.lblPnlPhoneNumber.Location = new System.Drawing.Point(95, 241);
            this.lblPnlPhoneNumber.Name = "lblPnlPhoneNumber";
            this.lblPnlPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPnlPhoneNumber.TabIndex = 10;
            this.lblPnlPhoneNumber.Text = "Phone Number:";
            // 
            // txtPnlPhoneNumber
            // 
            this.txtPnlPhoneNumber.Location = new System.Drawing.Point(213, 239);
            this.txtPnlPhoneNumber.Name = "txtPnlPhoneNumber";
            this.txtPnlPhoneNumber.Size = new System.Drawing.Size(128, 26);
            this.txtPnlPhoneNumber.TabIndex = 11;
            // 
            // btnPnlCancel
            // 
            this.btnPnlCancel.Location = new System.Drawing.Point(133, 284);
            this.btnPnlCancel.Name = "btnPnlCancel";
            this.btnPnlCancel.Size = new System.Drawing.Size(119, 30);
            this.btnPnlCancel.TabIndex = 12;
            this.btnPnlCancel.Text = "Cancel";
            this.btnPnlCancel.UseVisualStyleBackColor = true;
            this.btnPnlCancel.Click += new System.EventHandler(this.btnPnlCancel_Click);
            // 
            // btnPnlSaveOwner
            // 
            this.btnPnlSaveOwner.Location = new System.Drawing.Point(278, 284);
            this.btnPnlSaveOwner.Name = "btnPnlSaveOwner";
            this.btnPnlSaveOwner.Size = new System.Drawing.Size(119, 30);
            this.btnPnlSaveOwner.TabIndex = 13;
            this.btnPnlSaveOwner.Text = "Save Owner";
            this.btnPnlSaveOwner.UseVisualStyleBackColor = true;
            this.btnPnlSaveOwner.Click += new System.EventHandler(this.btnPnlSaveOwner_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 569);
            this.Controls.Add(this.pnlOwner);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblOwnerNo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstOwners);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.pnlOwner.ResumeLayout(false);
            this.pnlOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwners;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblOwnerNo;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlOwner;
        private System.Windows.Forms.TextBox txtPnlPhoneNumber;
        private System.Windows.Forms.Label lblPnlPhoneNumber;
        private System.Windows.Forms.TextBox txtPnlSuburb;
        private System.Windows.Forms.TextBox txtPnlStreetAddress;
        private System.Windows.Forms.TextBox txtPnlFirstName;
        private System.Windows.Forms.TextBox txtPnlLastName;
        private System.Windows.Forms.Label lblPnlSuburb;
        private System.Windows.Forms.Label lblPnlStreetAddress;
        private System.Windows.Forms.Label lblPnlFirstName;
        private System.Windows.Forms.Label lblPnlLastName;
        private System.Windows.Forms.Label lblPnlOwnerID;
        private System.Windows.Forms.Label lblPnlOwnerNo;
        private System.Windows.Forms.Button btnPnlSaveOwner;
        private System.Windows.Forms.Button btnPnlCancel;
    }
}