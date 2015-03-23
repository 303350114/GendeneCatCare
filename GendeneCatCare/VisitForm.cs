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
    public partial class VisitForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        CurrencyManager currencyManager;

        public VisitForm()
        {
            InitializeComponent();
        }

        public VisitForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            BindControls();
        }

        public void BindControls()
        {
            lblVisitID.DataBindings.Add("Text", DM.DSGlendene, "Visit.VisitID");
            txtCatID.DataBindings.Add("Text", DM.DSGlendene, "Visit.CatID");
            txtVeterinarianID.DataBindings.Add("Text", DM.DSGlendene, "Visit.VeterinarianID");
            txtVisitDate.DataBindings.Add("Text", DM.DSGlendene, "Visit.VisitDate");
            txtStatus.DataBindings.Add("Text", DM.DSGlendene, "Visit.Status");
            lstVisits.DataSource = DM.DSGlendene;
            lstVisits.DisplayMember = "Visit.VisitID";
            lstVisits.ValueMember = "Visit.VisitID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VISIT"];
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

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow newVisitRow = DM.dtVisit.NewRow();

            //If any of the text areas for required fields are empty then do not write data
            if ((txtCatID.Text == "") ||
                (txtVeterinarianID.Text == "") || (txtVisitDate.Text == "") ||
                (txtStatus.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newVisitRow["CatID"] = txtCatID.Text;
                newVisitRow["VeterinarianID"] = txtVeterinarianID.Text;
                newVisitRow["VisitDate"] = txtVisitDate.Text;
                newVisitRow["Status"] = txtStatus.Text;
                //Add the new row to the Table
                DM.dtVisit.Rows.Add(newVisitRow);
                DM.UpdateVisit();
                //Give the user a success message
                MessageBox.Show("Visit added successfully", "Success");
            }
            return;

        }

        private void btnDeleteVisit_Click(object sender, EventArgs e)
        {
            DataRow deleteVisitRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = deleteVisitRow["Status"].ToString();
            if (visitStatus.Equals("Pending") == true)
            {
                MessageBox.Show("You may only delete paid visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVisitRow.Delete();
                    DM.UpdateVisit();
                }
            }
            return;

        }

        private void btnUpdateVisit_Click(object sender, EventArgs e)
        {
            DataRow updateVisitRow = DM.dtVisit.Rows[currencyManager.Position];
            string visitStatus = updateVisitRow["Status"].ToString();
            if (visitStatus.Equals("Paid") == true)
            {
                MessageBox.Show("You may only update pending visits", "Error");
            }
            else
            {
                //If any of the text areas for required fields are empty then do not write data
                if ((txtVeterinarianID.Text == "") || (txtVisitDate.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    updateVisitRow["VeterinarianID"] = txtVeterinarianID.Text;
                    updateVisitRow["VisitDate"] = txtVisitDate.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVisit();
                    //Give the user a success message
                    MessageBox.Show("Visit updated successfully", "Success");
                }
            }
            return;

        }

    }
}
