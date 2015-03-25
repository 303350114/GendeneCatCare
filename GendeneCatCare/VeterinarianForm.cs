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
    public partial class VeterinarianForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public VeterinarianForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public VeterinarianForm()
        {
            InitializeComponent();
        }

        public void BindControls()
        {
            lblVeterinarianID.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.VeterinarianID"); 
            txtLastName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.LastName"); 
            txtFirstName.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.FirstName"); 
            txtRate.DataBindings.Add("Text", DM.DSGlendene, "Veterinarian.Rate");

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtRate.Enabled = false;

            lstVeterinarians.DataSource = DM.DSGlendene; 
            lstVeterinarians.DisplayMember = "Veterinarian.LastName"; 
            lstVeterinarians.ValueMember = "Veterinarian.LastName"; 
            
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"]; 
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

        private void btnAddVeterinarian_Click(object sender, EventArgs e)
        {
            resetPanelElementsVal();

            disableVetFormElements();

            lblPnlVeterinarianNo.Visible = false;
            lblPnlVeterinarianID.Visible = false;

            pnlVeterinarian.Show();
        }

        private void btnDeleteVeterinarian_Click(object sender, EventArgs e)
        {
            DataRow deleteVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            DataRow[] VisitRow = DM.dtVisit.Select("VeterinarianID = " + lblVeterinarianID.Text);
            if (VisitRow.Length != 0)
            {
                MessageBox.Show("You may only delete Veterinarians who do not have visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVeterinarianRow.Delete(); DM.UpdateVeterinarian();
                }
            }
            return;
        }

        private void btnUpdateVeterinarian_Click(object sender, EventArgs e)
        {
            disableVetFormElements();
            resetPanelElementsVal();
            lblPnlVeterinarianNo.Visible = true;
            lblPnlVeterinarianID.Visible = true;

            DataRow updateVeterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
            lblPnlVeterinarianID.Text = updateVeterinarianRow["VeterinarianID"].ToString();
            txtPnlLastName.Text = updateVeterinarianRow["LastName"].ToString();
            txtPnlFirstName.Text = updateVeterinarianRow["FirstName"].ToString();
            txtPnlRate.Text = updateVeterinarianRow["Rate"].ToString();

            pnlVeterinarian.Show();
        }

        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            enableVetFormElements();
            pnlVeterinarian.Hide();
        }

        private void btnPnlSaveVet_Click(object sender, EventArgs e)
        {
            //If any of the text areas are empty then do not write data and return
            if ((txtPnlLastName.Text == "") || (txtPnlFirstName.Text == "") || (txtPnlRate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                DataRow veterinarianRow;

                if (lblPnlVeterinarianID.Text == null || lblPnlVeterinarianID.Text.Equals(""))
                {
                    //Create a new row that the variables will be added into
                    veterinarianRow = DM.dtVeterinarian.NewRow();
                    veterinarianRow["LastName"] = txtPnlLastName.Text;
                    veterinarianRow["FirstName"] = txtPnlFirstName.Text;
                    veterinarianRow["Rate"] = Convert.ToDouble(txtPnlRate.Text);
                    //Add the new row to the Table
                    DM.dtVeterinarian.Rows.Add(veterinarianRow);
                    DM.UpdateVeterinarian();

                    enableVetFormElements();
                    pnlVeterinarian.Hide();

                    //Give the user a success message
                    MessageBox.Show("Veterinarian added successfully", "Success");
                }
                else
                {
                    veterinarianRow = DM.dtVeterinarian.Rows[currencyManager.Position];
                    //Add the text areas
                    veterinarianRow["LastName"] = txtPnlLastName.Text;
                    veterinarianRow["FirstName"] = txtPnlFirstName.Text;
                    veterinarianRow["Rate"] = Convert.ToDouble(txtPnlRate.Text);
                    //Update the database
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVeterinarian();

                    enableVetFormElements();
                    pnlVeterinarian.Hide();

                    //Give the user a success message
                    MessageBox.Show("Veterinarian updated successfully", "Success");
                }
            }
        }

        private void disableVetFormElements()
        {
            lstVeterinarians.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVeterinarian.Enabled = false;
            btnUpdateVeterinarian.Enabled = false;
            btnDeleteVeterinarian.Enabled = false;
            btnReturn.Enabled = false;

        }

        private void enableVetFormElements()
        {
            lstVeterinarians.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVeterinarian.Enabled = true;
            btnUpdateVeterinarian.Enabled = true;
            btnDeleteVeterinarian.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void resetPanelElementsVal()
        {
            lblPnlVeterinarianID.Text = null;
            txtPnlRate.Text = "";
            txtPnlFirstName.Text = "";
            txtPnlLastName.Text = "";
        }

    }
}
