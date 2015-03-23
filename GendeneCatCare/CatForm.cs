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
            //Create a new row that the variables will be added into
            DataRow newCatRow = DM.dtCat.NewRow();

            //If any of the text areas for required fields are empty then do not write data
            if ((txtCatName.Text == "") ||
                (txtGender.Text == "") || (txtDateOfBirth.Text == "") ||
                (txtNeutered.Text == "") || (txtOwnerID.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newCatRow["Name"] = txtCatName.Text;
                newCatRow["Breed"] = txtBreed.Text;
                newCatRow["Gender"] = txtGender.Text;
                newCatRow["DateOfBirth"] = txtDateOfBirth.Text;
                newCatRow["Neutered"] = txtNeutered.Text;
                newCatRow["OwnerID"] = txtOwnerID.Text;

                //Add the new row to the Table
                DM.dtCat.Rows.Add(newCatRow);
                DM.UpdateCat();
                //Give the user a success message
                MessageBox.Show("Cat added successfully", "Success");
            }
            return;

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
            DataRow updateCatRow = DM.dtCat.Rows[currencyManager.Position];

            //If any of the text areas are empty then do not write data
            if ((txtCatName.Text == "") ||
                (txtGender.Text == "") || (txtDateOfBirth.Text == "") ||
                (txtNeutered.Text == "") || (txtOwnerID.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                updateCatRow["Name"] = txtCatName.Text;
                updateCatRow["Breed"] = txtBreed.Text;
                updateCatRow["Gender"] = txtGender.Text;
                updateCatRow["DateOfBirth"] = txtDateOfBirth.Text;
                updateCatRow["Neutered"] = txtNeutered.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateCat();
                //Give the user a success message
                MessageBox.Show("Cat updated successfully", "Success");
            }
            return;

        }

    }
}
