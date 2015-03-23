using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;
        public DataView catView;
        public DataView treatmentView;
        public DataView ownerView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

        private OleDbDataAdapter oddaTreatment;
        private DataSet dsTreatment;

        public DataModule()
        {
            InitializeComponent();
            DSGlendene.EnforceConstraints = false;
            daCat.Fill(DSGlendene);
            daTreatment.Fill(DSGlendene);
            daOwner.Fill(DSGlendene);
            daVisit.Fill(DSGlendene);
            daVeterinarian.Fill(DSGlendene);
            daVisitTreatment.Fill(DSGlendene);
            dtCat = DSGlendene.Tables["Cat"];
            dtTreatment = DSGlendene.Tables["Treatment"];
            dtOwner = DSGlendene.Tables["Owner"];
            dtVeterinarian = DSGlendene.Tables["Veterinarian"];
            dtVisit = DSGlendene.Tables["Visit"];
            dtVisitTreatment = DSGlendene.Tables["VisitTreatment"];

            catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";

            DSGlendene.EnforceConstraints = true;

        }

        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }

        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        public void UpdateVeterinarian()
        {
            daVeterinarian.Update(dtVeterinarian);
        }

        public void UpdateVisitTreatment()
        {
            daVisitTreatment.Update(dtVisitTreatment);
        }

        public void UpdateCat()
        {
            daCat.Update(dtCat);
        }

        public void UpdateVisit()
        {
            daVisit.Update(dtVisit);
        }

        /// <summary>
        /// Based on form to retrieve each forms' table data and reload them into DataSet DSGlendene
        /// </summary>
        public void refreshDs(string form)
        {
            /*
            oddaTreatment = new OleDbDataAdapter("SELECT * from Treatment", getOleDbConnection());
            
            dtTreatment.Clear();
            oddaTreatment.Fill(dtTreatment);
             */
            if(form == null)
            {
                return;
            }

            if (form.Equals("Treatment"))
            {
                dtTreatment.Clear();
                daTreatment.Fill(DSGlendene, "Treatment");
            }
            else if(form.Equals("Owner"))
            {
                dtOwner.Clear();
                daOwner.Fill(DSGlendene, "Owner");
            }
            else if (form.Equals("Veterinarian"))
            {
                dtVeterinarian.Clear();
                daVeterinarian.Fill(DSGlendene, "Veterinarian");
            }

        }
        
        public int getMaxTreatmentId()
        {
            int maxId = 0;
                        
            // Initalize a DataAdapter with a select command and a OleDbConnection
            oddaTreatment = new OleDbDataAdapter("SELECT max(TreatmentID) from Treatment", getOleDbConnection());

            dsTreatment = new DataSet(); //Initalize a DataSet
            oddaTreatment.Fill(dsTreatment);
            
            System.Data.DataRow drTreatment = dsTreatment.Tables[0].Rows[0];
            maxId = Int32.Parse(drTreatment[0].ToString());

            return maxId;
        }

        #region 
        /// <summary>
        /// Instantiate the OleDbConnection
        /// </summary>
        /// <returns> OleDbConnection </returns>
        private OleDbConnection getOleDbConnection()
        {
            string myConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=c:\Temp\Glendene.mdb";
            return new OleDbConnection(myConnectionString);
        }
        #endregion

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TreatmentID"] = newID;

            }
        }
    }
}
