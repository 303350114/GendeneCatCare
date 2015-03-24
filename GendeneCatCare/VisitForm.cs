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

            txtCatID.Enabled = false;
            txtVeterinarianID.Enabled = false;
            txtVisitDate.Enabled = false;
            txtStatus.Enabled = false;

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
            showVisitPanel();

            resetVisitPanel();

            pnlVisit.Show();
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
                lblPnlVisitID.Text = updateVisitRow["VisitID"].ToString();
                txtPnlCatID.Text = updateVisitRow["CatID"].ToString();
                txtPnlVetID.Text = updateVisitRow["VeterinarianID"].ToString();
                txtPnlVisitDate.Text = updateVisitRow["VisitDate"].ToString();
                txtPnlStatus.Text = visitStatus;

                showVisitPanel();
                lblPnlVisitNo.Visible = true;
                lblPnlVisitID.Visible = true;
                pnlVisit.Show();
            }
            
        }

        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            hidePanel();
        }        

        private void btnPnlSaveVisit_Click(object sender, EventArgs e)
        {
            //If any of the text areas for required fields are empty then do not write data
            if ((txtPnlCatID.Text == "") ||
                (txtPnlVetID.Text == "") || (txtPnlVisitDate.Text == "") ||
                (txtPnlStatus.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                
                DataRow visitRow;
                if (lblPnlVisitID.Text == null || lblPnlVisitID.Text.Equals(""))
                {
                    visitRow = DM.dtVisit.NewRow();//Create a new row that the variables will be added into
                    visitRow["CatID"] = txtPnlCatID.Text;
                    visitRow["VeterinarianID"] = txtPnlVetID.Text;
                    visitRow["VisitDate"] = Convert.ToDateTime(txtPnlVisitDate.Text);
                    visitRow["Status"] = txtPnlStatus.Text;
                    //Add the new row to the Table
                    DM.dtVisit.Rows.Add(visitRow);

                    DM.UpdateVisit();
                    hidePanel();
                    //Give the user a success message
                    MessageBox.Show("Visit added successfully", "Success");
                }
                else
                {
                    visitRow = DM.dtVisit.Rows[currencyManager.Position];
                    visitRow["CatID"] = txtPnlCatID.Text;
                    visitRow["VeterinarianID"] = txtPnlVetID.Text;
                    visitRow["VisitDate"] = Convert.ToDateTime(txtPnlVisitDate.Text);
                    visitRow["Status"] = txtPnlStatus.Text;
                    currencyManager.EndCurrentEdit();

                    DM.UpdateVisit();
                    hidePanel();
                    //Give the user a success message
                    MessageBox.Show("Visit updated successfully", "Success");
                }
                
            }
        }

        private void resetVisitPanel()
        {
            lblPnlVisitID.Text = null;
            txtPnlCatID.Text = "";
            txtPnlVetID.Text = "";
            txtPnlVisitDate.Text = "";
            txtPnlStatus.Text = "";
        }

        private void hidePanel()
        {
            lstVisits.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVisit.Enabled = true;
            btnUpdateVisit.Enabled = true;
            btnDeleteVisit.Enabled = true;
            btnReturn.Enabled = true;


            pnlVisit.Hide();
        }

        private void showVisitPanel()
        {
            lstVisits.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVisit.Enabled = false;
            btnUpdateVisit.Enabled = false;
            btnDeleteVisit.Enabled = false;
            btnReturn.Enabled = false;
            lblPnlVisitNo.Visible = false;
            lblPnlVisitID.Visible = false;
        }
    }
}
