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
    public partial class CatForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public CatForm()
        {
            InitializeComponent();
        }

        public CatForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;
            BindControls();
        }

        public void BindControls()
        {
            lblCatID.DataBindings.Add("Text", DM.DSGlendene, "Cat.CatID");
            txtCatName.DataBindings.Add("Text", DM.DSGlendene, "Cat.Name");
            txtBreed.DataBindings.Add("Text", DM.DSGlendene, "Cat.Breed");
            txtGender.DataBindings.Add("Text", DM.DSGlendene, "Cat.Gender");
            txtDateOfBirth.DataBindings.Add("Text", DM.DSGlendene, "Cat.DateOfBirth");
            txtNeutered.DataBindings.Add("Text", DM.DSGlendene, "Cat.Neutered");
            txtOwnerID.DataBindings.Add("Text", DM.DSGlendene, "Cat.OwnerID");

            txtCatName.Enabled = false;
            txtBreed.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtGender.Enabled = false;
            txtNeutered.Enabled = false;
            txtOwnerID.Enabled = false;

            lstCats.DataSource = DM.DSGlendene;
            lstCats.DisplayMember = "Cat.Name";
            lstCats.ValueMember = "Cat.Name";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];
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

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            disableCatFormElements();
            resetCatPanelVal();

            lblPnlCatID.Visible = false;
            lblPnlCatNo.Visible = false;

            pnlCat.Show();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            DataRow deleteCatRow = DM.dtCat.Rows[currencyManager.Position];
            DataRow[] CatRow = DM.dtVisit.Select("CatID = " + lblCatID.Text);
            if (CatRow.Length != 0)
            {
                MessageBox.Show("You may only delete cats who are not assigned visits", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCatRow.Delete();
                    DM.UpdateCat();
                }
            }
            return;

        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            disableCatFormElements();
            resetCatPanelVal();

            lblPnlCatNo.Visible = true;
            lblPnlCatID.Visible = true;
            DataRow updateCatRow = DM.dtCat.Rows[currencyManager.Position];
            lblPnlCatID.Text = updateCatRow["CatID"].ToString();
            txtPnlOwnerID.Text = updateCatRow["OwnerID"].ToString();
            txtPnlNeutered.Text = updateCatRow["Neutered"].ToString();
            txtPnlGender.Text = updateCatRow["Gender"].ToString();
            txtPnlDOB.Text = updateCatRow["DateOfBirth"].ToString();
            txtPnlCatName.Text = updateCatRow["Name"].ToString();
            txtPnlBreed.Text = updateCatRow["Breed"].ToString();

            pnlCat.Show();
        }
                
        private void btnPnlCancel_Click(object sender, EventArgs e)
        {
            enableCatFormElements();

            pnlCat.Hide();
        }

        private void btnPnlSaveCat_Click(object sender, EventArgs e)
        {
            //If any of the text areas for required fields are empty then do not write data
            if ((txtPnlCatName.Text == "") ||
                (txtPnlGender.Text == "") || (txtPnlDOB.Text == "") ||
                (txtPnlNeutered.Text == "") || (txtPnlOwnerID.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                DataRow catRow;
                if (lblPnlCatID.Text == null || lblPnlCatID.Text.Equals(""))
                {
                    catRow = DM.dtCat.NewRow();//Create a new row that the variables will be added into
                    catRow["Name"] = txtPnlCatName.Text;
                    catRow["Breed"] = txtPnlBreed.Text;
                    catRow["Gender"] = txtPnlGender.Text;
                    catRow["DateOfBirth"] = txtPnlDOB.Text;
                    catRow["Neutered"] = txtPnlNeutered.Text;
                    catRow["OwnerID"] = txtPnlOwnerID.Text;

                    //Add the new row to the Table
                    DM.dtCat.Rows.Add(catRow);
                    DM.UpdateCat();

                    enableCatFormElements();
                    pnlCat.Hide();

                    //Give the user a success message
                    MessageBox.Show("Cat added successfully", "Success");
                }
                else
                {
                    catRow = DM.dtCat.Rows[currencyManager.Position];
                    catRow["Name"] = txtPnlCatName.Text;
                    catRow["Breed"] = txtPnlBreed.Text;
                    catRow["Gender"] = txtPnlGender.Text;
                    catRow["DateOfBirth"] = txtPnlDOB.Text;
                    catRow["Neutered"] = txtPnlNeutered.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateCat();

                    enableCatFormElements();
                    pnlCat.Hide();

                    //Give the user a success message
                    MessageBox.Show("Cat updated successfully", "Success");
                }
            }
        }

        private void disableCatFormElements()
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddCat.Enabled = false;
            btnUpdateCat.Enabled = false;
            btnDeleteCat.Enabled = false;
            btnReturn.Enabled = false;
            lstCats.Visible = false;
        }

        private void enableCatFormElements()
        {
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddCat.Enabled = true;
            btnUpdateCat.Enabled = true;
            btnDeleteCat.Enabled = true;
            btnReturn.Enabled = true;
            lstCats.Visible = true;
        }

        private void resetCatPanelVal()
        {
            lblPnlCatID.Text = null;
            txtPnlBreed.Text = "";
            txtPnlCatName.Text = "";
            txtPnlDOB.Text = "";
            txtPnlGender.Text = "";
            txtPnlNeutered.Text = "";
            txtPnlOwnerID.Text = "";
        }

    }
}
