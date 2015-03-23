namespace GendeneCatCare
{
    partial class VisitForm
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
            this.lstVisits = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblVisitNo = new System.Windows.Forms.Label();
            this.lblVisitID = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblVeterinarianID = new System.Windows.Forms.Label();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtVeterinarianID = new System.Windows.Forms.TextBox();
            this.txtVisitDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.btnUpdateVisit = new System.Windows.Forms.Button();
            this.btnDeleteVisit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVisits
            // 
            this.lstVisits.FormattingEnabled = true;
            this.lstVisits.ItemHeight = 20;
            this.lstVisits.Location = new System.Drawing.Point(86, 65);
            this.lstVisits.Name = "lstVisits";
            this.lstVisits.Size = new System.Drawing.Size(210, 284);
            this.lstVisits.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(86, 378);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 35);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(194, 378);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblVisitNo
            // 
            this.lblVisitNo.AutoSize = true;
            this.lblVisitNo.Location = new System.Drawing.Point(383, 65);
            this.lblVisitNo.Name = "lblVisitNo";
            this.lblVisitNo.Size = new System.Drawing.Size(64, 20);
            this.lblVisitNo.TabIndex = 3;
            this.lblVisitNo.Text = "Visit ID:";
            // 
            // lblVisitID
            // 
            this.lblVisitID.AutoSize = true;
            this.lblVisitID.Location = new System.Drawing.Point(445, 65);
            this.lblVisitID.Name = "lblVisitID";
            this.lblVisitID.Size = new System.Drawing.Size(33, 20);
            this.lblVisitID.TabIndex = 4;
            this.lblVisitID.Text = "null";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(388, 125);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(59, 20);
            this.lblCatID.TabIndex = 5;
            this.lblCatID.Text = "Cat ID:";
            // 
            // lblVeterinarianID
            // 
            this.lblVeterinarianID.AutoSize = true;
            this.lblVeterinarianID.Location = new System.Drawing.Point(327, 185);
            this.lblVeterinarianID.Name = "lblVeterinarianID";
            this.lblVeterinarianID.Size = new System.Drawing.Size(120, 20);
            this.lblVeterinarianID.TabIndex = 6;
            this.lblVeterinarianID.Text = "Veterinarian ID:";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.AutoSize = true;
            this.lblVisitDate.Location = new System.Drawing.Point(365, 245);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(82, 20);
            this.lblVisitDate.TabIndex = 7;
            this.lblVisitDate.Text = "Visit Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(387, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(449, 119);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(100, 26);
            this.txtCatID.TabIndex = 9;
            // 
            // txtVeterinarianID
            // 
            this.txtVeterinarianID.Location = new System.Drawing.Point(449, 179);
            this.txtVeterinarianID.Name = "txtVeterinarianID";
            this.txtVeterinarianID.Size = new System.Drawing.Size(100, 26);
            this.txtVeterinarianID.TabIndex = 10;
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Location = new System.Drawing.Point(449, 239);
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.Size = new System.Drawing.Size(100, 26);
            this.txtVisitDate.TabIndex = 11;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(449, 299);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 26);
            this.txtStatus.TabIndex = 12;
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Location = new System.Drawing.Point(331, 378);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(102, 35);
            this.btnAddVisit.TabIndex = 13;
            this.btnAddVisit.Text = "Add Visit";
            this.btnAddVisit.UseVisualStyleBackColor = true;
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);
            // 
            // btnUpdateVisit
            // 
            this.btnUpdateVisit.Location = new System.Drawing.Point(447, 378);
            this.btnUpdateVisit.Name = "btnUpdateVisit";
            this.btnUpdateVisit.Size = new System.Drawing.Size(111, 35);
            this.btnUpdateVisit.TabIndex = 14;
            this.btnUpdateVisit.Text = "Update Visit";
            this.btnUpdateVisit.UseVisualStyleBackColor = true;
            this.btnUpdateVisit.Click += new System.EventHandler(this.btnUpdateVisit_Click);
            // 
            // btnDeleteVisit
            // 
            this.btnDeleteVisit.Location = new System.Drawing.Point(571, 378);
            this.btnDeleteVisit.Name = "btnDeleteVisit";
            this.btnDeleteVisit.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteVisit.TabIndex = 15;
            this.btnDeleteVisit.Text = "Delete Visit";
            this.btnDeleteVisit.UseVisualStyleBackColor = true;
            this.btnDeleteVisit.Click += new System.EventHandler(this.btnDeleteVisit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(571, 436);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 35);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 483);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVisit);
            this.Controls.Add(this.btnUpdateVisit);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtVisitDate);
            this.Controls.Add(this.txtVeterinarianID);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.lblVeterinarianID);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblVisitID);
            this.Controls.Add(this.lblVisitNo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstVisits);
            this.Name = "VisitForm";
            this.Text = "Visit Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVisits;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblVisitNo;
        private System.Windows.Forms.Label lblVisitID;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblVeterinarianID;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtVeterinarianID;
        private System.Windows.Forms.TextBox txtVisitDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.Button btnUpdateVisit;
        private System.Windows.Forms.Button btnDeleteVisit;
        private System.Windows.Forms.Button btnReturn;
    }
}