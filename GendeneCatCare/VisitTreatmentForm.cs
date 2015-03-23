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
    public partial class VisitTreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmTreatment;
        private CurrencyManager cmVisit;
        private CurrencyManager cmVisitTreatment;
        private CurrencyManager cmVVT;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public VisitTreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Treatment"];
            cmVisit = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Visit"];
            cmVisitTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VisitTreatment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmVVT = (CurrencyManager)this.BindingContext[DM.DSGlendene, "Visit.Visit_VisitTreatment"];
            bindControls();
        }

        public VisitTreatmentForm()
        {
            InitializeComponent();
        }

        public void bindControls()
        {
            dgvVisits.DataSource = DM.DSGlendene;
            dgvVisits.DataMember = "Visit";

            dgvTreatments.DataSource = DM.DSGlendene;
            dgvTreatments.DataMember = "Treatment";

            dgvVisitTreatments.DataSource = DM.DSGlendene;
            dgvVisitTreatments.DataMember = "Visit.Visit_VisitTreatment";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtVisit.Rows[cmVisit.Position]["Status"].ToString() == "Pending")
                {
                    DataRow newVisitTreatment = DM.dtVisitTreatment.NewRow();

                    newVisitTreatment["TreatmentID"] = dgvTreatments["TreatmentID", cmTreatment.Position].Value;
                    newVisitTreatment["VisitID"] = dgvVisits["VisitID", cmVisit.Position].Value;
                    newVisitTreatment["Quantity"] = Convert.ToInt32(txtQuantity.Text);

                    DM.DSGlendene.Tables["VisitTreatment"].Rows.Add(newVisitTreatment);    //add a new row to dataset
                    DM.UpdateVisitTreatment();    //update database
                }
                else
                {
                    MessageBox.Show("Cannot allocate treatments to paid visits.", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This treatment has already been allocated to this visit.", "Error");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DM.dtVisit.Rows[cmVisit.Position]["Status"].ToString() == "Pending")
            {
                string VisitID = DM.dtVisit.Rows[cmVisit.Position]["VisitID"].ToString();
                string TreatmentID = dgvVisitTreatments.Rows[cmVVT.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtVisitTreatment.Rows.Count; i++)
                {
                    string sID = DM.dtVisitTreatment.Rows[i]["VisitID"].ToString();
                    string aID = DM.dtVisitTreatment.Rows[i]["TreatmentID"].ToString();

                    if (VisitID == sID && TreatmentID == aID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.DSGlendene.Tables["VisitTreatment"].Rows[row];
                dr.Delete();
                DM.UpdateVisitTreatment();    //update database
            }
            else
            {
                MessageBox.Show("You may only remove treatments from pending Visits.", "Error");
            }

        }
        
    }
}
