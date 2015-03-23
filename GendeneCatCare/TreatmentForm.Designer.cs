namespace GendeneCatCare
{
    partial class TreatmentForm
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
            this.lstBoxTreatments = new System.Windows.Forms.ListBox();
            this.lblTreatmentNo = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlTreatment = new System.Windows.Forms.Panel();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPnlCost = new System.Windows.Forms.TextBox();
            this.txtPnlDescription = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblUpdateTreatmentNo = new System.Windows.Forms.Label();
            this.lblUpdateTreatmentID = new System.Windows.Forms.Label();
            this.pnlTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxTreatments
            // 
            this.lstBoxTreatments.FormattingEnabled = true;
            this.lstBoxTreatments.ItemHeight = 20;
            this.lstBoxTreatments.Location = new System.Drawing.Point(91, 93);
            this.lstBoxTreatments.Name = "lstBoxTreatments";
            this.lstBoxTreatments.Size = new System.Drawing.Size(289, 424);
            this.lstBoxTreatments.TabIndex = 0;
            // 
            // lblTreatmentNo
            // 
            this.lblTreatmentNo.AutoSize = true;
            this.lblTreatmentNo.Location = new System.Drawing.Point(438, 93);
            this.lblTreatmentNo.Name = "lblTreatmentNo";
            this.lblTreatmentNo.Size = new System.Drawing.Size(107, 20);
            this.lblTreatmentNo.TabIndex = 1;
            this.lblTreatmentNo.Text = "Treatment ID:";
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.AutoSize = true;
            this.lblTreatmentID.Location = new System.Drawing.Point(555, 93);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(78, 20);
            this.lblTreatmentID.TabIndex = 2;
            this.lblTreatmentID.Text = "treatment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(452, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(499, 191);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(559, 139);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 26);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(559, 191);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(115, 26);
            this.txtCost.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(91, 590);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(161, 37);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(863, 672);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 37);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(863, 590);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(161, 37);
            this.btnDeleteTreatment.TabIndex = 9;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(670, 590);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(161, 37);
            this.btnUpdateTreatment.TabIndex = 10;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(477, 590);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(161, 37);
            this.btnAddTreatment.TabIndex = 11;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(284, 590);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 37);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlTreatment
            // 
            this.pnlTreatment.Controls.Add(this.lblUpdateTreatmentID);
            this.pnlTreatment.Controls.Add(this.lblUpdateTreatmentNo);
            this.pnlTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlTreatment.Controls.Add(this.btnCancel);
            this.pnlTreatment.Controls.Add(this.txtPnlCost);
            this.pnlTreatment.Controls.Add(this.txtPnlDescription);
            this.pnlTreatment.Controls.Add(this.lblAddCost);
            this.pnlTreatment.Controls.Add(this.lblAddDescription);
            this.pnlTreatment.Location = new System.Drawing.Point(456, 331);
            this.pnlTreatment.Name = "pnlTreatment";
            this.pnlTreatment.Size = new System.Drawing.Size(464, 186);
            this.pnlTreatment.TabIndex = 13;
            this.pnlTreatment.Visible = false;
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(142, 138);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(152, 34);
            this.btnSaveTreatment.TabIndex = 5;
            this.btnSaveTreatment.Text = "Save Treatment";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(43, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPnlCost
            // 
            this.txtPnlCost.Location = new System.Drawing.Point(149, 87);
            this.txtPnlCost.Name = "txtPnlCost";
            this.txtPnlCost.Size = new System.Drawing.Size(100, 26);
            this.txtPnlCost.TabIndex = 3;
            // 
            // txtPnlDescription
            // 
            this.txtPnlDescription.Location = new System.Drawing.Point(149, 46);
            this.txtPnlDescription.Name = "txtPnlDescription";
            this.txtPnlDescription.Size = new System.Drawing.Size(145, 26);
            this.txtPnlDescription.TabIndex = 2;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(97, 90);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(46, 20);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(17, 49);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(126, 20);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Add Description:";
            // 
            // lblUpdateTreatmentNo
            // 
            this.lblUpdateTreatmentNo.AutoSize = true;
            this.lblUpdateTreatmentNo.Location = new System.Drawing.Point(36, 13);
            this.lblUpdateTreatmentNo.Name = "lblUpdateTreatmentNo";
            this.lblUpdateTreatmentNo.Size = new System.Drawing.Size(107, 20);
            this.lblUpdateTreatmentNo.TabIndex = 6;
            this.lblUpdateTreatmentNo.Text = "Treatment ID:";
            // 
            // lblUpdateTreatmentID
            // 
            this.lblUpdateTreatmentID.AutoSize = true;
            this.lblUpdateTreatmentID.Location = new System.Drawing.Point(148, 13);
            this.lblUpdateTreatmentID.Name = "lblUpdateTreatmentID";
            this.lblUpdateTreatmentID.Size = new System.Drawing.Size(78, 20);
            this.lblUpdateTreatmentID.TabIndex = 7;
            this.lblUpdateTreatmentID.Text = "treatment";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 740);
            this.Controls.Add(this.pnlTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblTreatmentNo);
            this.Controls.Add(this.lstBoxTreatments);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.pnlTreatment.ResumeLayout(false);
            this.pnlTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxTreatments;
        private System.Windows.Forms.Label lblTreatmentNo;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlTreatment;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPnlCost;
        private System.Windows.Forms.TextBox txtPnlDescription;
        private System.Windows.Forms.Label lblUpdateTreatmentID;
        private System.Windows.Forms.Label lblUpdateTreatmentNo;
    }
}