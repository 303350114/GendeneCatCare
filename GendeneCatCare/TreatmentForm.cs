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
    public partial class TreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlTreatment.Left = 220;
            pnlTreatment.Top = 40;
        }

        public TreatmentForm()
        {
            InitializeComponent();
        }

        public void BindControls()
        {
            lblTreatmentID.DataBindings.Add("Text", DM.DSGlendene, "Treatment.TreatmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Description");
            txtCost.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Cost");

            txtDescription.Enabled = false;
            txtCost.Enabled = false;

            lstBoxTreatments.DataSource = DM.DSGlendene;
            lstBoxTreatments.DisplayMember = "Treatment.Description";
            lstBoxTreatments.ValueMember = "Treatment.Description";
            
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
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

        private void resetPanelTreatment()
        {
            lblUpdateTreatmentID.Text = "";
            txtPnlDescription.Text = "";
            txtPnlCost.Text = "";
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            resetPanelTreatment();

            lstBoxTreatments.Visible = false;
            //lstBoxTreatments.Enabled = false;
            //lstBoxTreatments.SelectedItem = null;
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateTreatment.Enabled = false;
            btnAddTreatment.Enabled = false;
            lblUpdateTreatmentID.Visible = false;
            lblUpdateTreatmentNo.Visible = false;
            pnlTreatment.Show();
        }

        private void oldAddTreatmentMethod()
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");

            }
            else
            {
                newTreatmentRow["Description"] = txtDescription.Text;
                newTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                DM.dtTreatment.Rows.Add(newTreatmentRow);
                DM.UpdateTreatment();

                DM.refreshDs("Treatment");// refresh the data of DataSet DSGlendene

                //Give the user a success message
                MessageBox.Show("Treatment added successfully", "Success");
            }

            return;
        }

        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            DataRow deleteTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.dtVisitTreatment.Select("TreatmentID = " + lblTreatmentID.Text);
            if (VisitTreatmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTreatmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Treatments that are not allocated to visits", "Error");
                return;
            }
            //Update
            DM.UpdateTreatment();
        }

        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            resetPanelTreatment();

            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            txtPnlDescription.Text = updateTreatmentRow["Description"].ToString();
            txtPnlCost.Text = updateTreatmentRow["Cost"].ToString();
            lblUpdateTreatmentID.Text = updateTreatmentRow["TreatmentID"].ToString();

            lstBoxTreatments.Visible = false;
            //lstBoxTreatments.Enabled = false;
            //lstBoxTreatments.SelectedItem = null;
            btnDeleteTreatment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateTreatment.Enabled = false;
            btnAddTreatment.Enabled = false;
            lblUpdateTreatmentID.Visible = true;
            lblUpdateTreatmentNo.Visible = true;
            pnlTreatment.Show();
        }

        private void oldUpdateTreatment()
        {
            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];

            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");

            }
            else
            {
                updateTreatmentRow["Description"] = txtDescription.Text;
                updateTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                currencyManager.EndCurrentEdit();

                DM.UpdateTreatment();
                MessageBox.Show("Treatment updated successfully", "Success");
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hidePnlAddTreatment();
        }

        private void hidePnlAddTreatment()
        {
            pnlTreatment.Hide();
            lstBoxTreatments.Enabled = true;
            lstBoxTreatments.Visible = true;
            btnDeleteTreatment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateTreatment.Enabled = true;
            btnAddTreatment.Enabled = true;
        }

        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();

            if ((txtPnlDescription.Text == "") || (txtPnlCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");

            }
            else
            {
                try
                {
                    newTreatmentRow["Description"] = txtPnlDescription.Text;
                    newTreatmentRow["Cost"] = Convert.ToDouble(txtPnlCost.Text);
                    DM.dtTreatment.Rows.Add(newTreatmentRow);
                    DM.UpdateTreatment();
                    hidePnlAddTreatment(); // Hide the panal of add treatment
                    MessageBox.Show("Treatment added successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for cost", "Error");
                }
            }
            return;

        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {

        }

    }
}
