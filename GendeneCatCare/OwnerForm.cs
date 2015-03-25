using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GendeneCatCare
{
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public OwnerForm()
        {
            InitializeComponent();
        }

        public void BindControls()
        {
            lblOwnerID.DataBindings.Add("Text", DM.DSGlendene, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.DSGlendene, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGlendene, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.DSGlendene, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.DSGlendene, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.DSGlendene, "Owner.PhoneNumber");

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;

            lstOwners.DataSource = DM.DSGlendene;
            lstOwners.DisplayMember = "Owner.LastName";
            lstOwners.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager) this.BindingContext[DM.DSGlendene, "OWNER"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            disableOwnerFormElements();
            resetOwnerPanelVal();

            lblPnlOwnerNo.Visible = false;
            lblPnlOwnerID.Visible = false;

            pnlOwner.Show();
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] CatRow = DM.dtCat.Select("OwnerID = " + lblOwnerID.Text);
            if (CatRow.Length != 0)
            {
                MessageBox.Show("You may only delete owners who do not have cats", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this records?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner();
                }
            }
            return;
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            disableOwnerFormElements();
            lblPnlOwnerID.Visible = true;
            lblPnlOwnerNo.Visible = true;
            resetOwnerPanelVal();

            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            lblPnlOwnerID.Text = updateOwnerRow["OwnerID"].ToString();
            txtPnlLastName.Text = updateOwnerRow["LastName"].ToString();
            txtPnlFirstName.Text = updateOwnerRow["FirstName"].ToString();
            txtPnlStreetAddress.Text = updateOwnerRow["StreetAddress"].ToString();
            txtPnlSuburb.Text = updateOwnerRow["Suburb"].ToString();
            txtPnlPhoneNumber.Text = updateOwnerRow["PhoneNumber"].ToString();

            pnlOwner.Show();
        }
        
        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            enableOwnerFormElements();

            pnlOwner.Hide();
        }

        private void btnPnlSaveOwner_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow ownerRow;

            //If any of the text areas are empty then do not write data and return
            if ((txtPnlLastName.Text == "") || (txtPnlFirstName.Text == "") ||
                (txtPnlStreetAddress.Text == "") || (txtPnlSuburb.Text == "") || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                if (lblPnlOwnerID.Text == null || lblPnlOwnerID.Text.Equals(""))
                {
                    ownerRow = DM.dtOwner.NewRow();
                    ownerRow["LastName"] = txtPnlLastName.Text;
                    ownerRow["FirstName"] = txtPnlFirstName.Text;
                    ownerRow["StreetAddress"] = txtPnlStreetAddress.Text;
                    ownerRow["Suburb"] = txtPnlSuburb.Text;
                    ownerRow["PhoneNumber"] = txtPnlPhoneNumber.Text;

                    //Add the new row to the Table
                    DM.dtOwner.Rows.Add(ownerRow);
                    DM.UpdateOwner();

                    enableOwnerFormElements();
                    pnlOwner.Hide();

                    //Give the user a success message
                    MessageBox.Show("Owner added successfully", "Success");
                }
                else
                {
                    ownerRow = DM.dtOwner.Rows[currencyManager.Position];
                    //Add the text areas
                    ownerRow["LastName"] = txtPnlLastName.Text;
                    ownerRow["FirstName"] = txtPnlFirstName.Text;
                    ownerRow["StreetAddress"] = txtPnlStreetAddress.Text;
                    ownerRow["Suburb"] = txtPnlSuburb.Text;
                    ownerRow["PhoneNumber"] = txtPnlPhoneNumber.Text;
                    //update the database
                    currencyManager.EndCurrentEdit();
                    DM.UpdateOwner();

                    enableOwnerFormElements();
                    pnlOwner.Hide();

                    //Give the user a success message
                    MessageBox.Show("Owner updated successfully", "Success");
                }
            }
        }

        private void disableOwnerFormElements()
        {
            lstOwners.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddOwner.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnDeleteOwner.Enabled = false;
            btnReturn.Enabled = false;
            txtStreetAddress.Visible = false;
        }

        private void enableOwnerFormElements()
        {
            lstOwners.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddOwner.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnDeleteOwner.Enabled = true;
            btnReturn.Enabled = true;
            txtStreetAddress.Visible = true;
        }

        private void resetOwnerPanelVal()
        {
            lblPnlOwnerID.Text = null;
            txtPnlLastName.Text = "";
            txtPnlFirstName.Text = "";
            txtPnlStreetAddress.Text = "";
            txtPnlSuburb.Text = "";
            txtPnlPhoneNumber.Text = "";
        }        
    }
}
