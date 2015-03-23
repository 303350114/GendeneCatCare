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
            //Create a new row that the variables will be added into
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            //If any of the text areas are empty then do not write data and return
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newOwnerRow["LastName"] = txtLastName.Text;
                newOwnerRow["FirstName"] = txtFirstName.Text;
                newOwnerRow["StreetAddress"] = txtStreetAddress.Text;
                newOwnerRow["Suburb"] = txtSuburb.Text;
                newOwnerRow["PhoneNumber"] = txtPhoneNumber.Text;

                //Add the new row to the Table
                DM.dtOwner.Rows.Add(newOwnerRow);
                DM.UpdateOwner();

                DM.refreshDs("Owner");//Refill Owner Dataset

                //Give the user a success message
                MessageBox.Show("Owner added successfully", "Success");
            }
            return;
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
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
                (txtStreetAddress.Text == "") || (txtSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            else
            {
                //Add the text areas
                updateOwnerRow["LastName"] = txtLastName.Text;
                updateOwnerRow["FirstName"] = txtFirstName.Text;
                updateOwnerRow["StreetAddress"] = txtStreetAddress.Text;
                updateOwnerRow["Suburb"] = txtSuburb.Text;
                updateOwnerRow["PhoneNumber"] = txtPhoneNumber.Text;
                //update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                //Give the user a success message
                MessageBox.Show("Owner updated successfully", "Success");
            }
            return;
        }


    }
}
