using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace GendeneCatCare
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertPageBreak()
        {
            //txtInvoices.Selection.Text = "\f";
            //System.Drawing.Point ScrollPosition = new Point(0, txtInvoices..InputPosition.Location.Y);
            //txtInvoices.ScrollLocation = ScrollPosition;
            txtInvoices.Focus();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            string visitText = "";
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.DSGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.DSGlendene, "VETERINARIAN"];

            txtInvoices.Text = "";

            foreach (DataRow drVisit in DM.dtVisit.Rows)
            {
                string visitStatus = drVisit["Status"].ToString();
                if (visitStatus.Equals("Pending") == true)
                {
                    // get the cat record matching the cat ID from the visit record
                    int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
                    cmCat.Position = DM.catView.Find(aCatID);
                    DataRow drCat = DM.dtCat.Rows[cmCat.Position];

                    // get the owner record matching the owner ID from the cat record
                    int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(aCatID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    visitText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    visitText += drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    visitText += drOwner["StreetAddress"] + "\r\n";
                    visitText += drOwner["Suburb"] + "\r\n\r\n\r\n";
                    visitText += "Cat Name: " + drCat["Name"] + " Visit ID: " + drVisit["VisitID"] +
                                " Visit Date: " + drVisit["VisitDate"] + "\r\n\r\n\r\n";

                    // get the veterinarian record matching the veterinarian ID from the visit record
                    int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
                    cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
                    DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

                    visitText += drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"] + "\r\n";
                    visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

                    DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

                    if (drTreatments.Length > 0)
                    {
                        txtInvoices.Text += visitText;
                        foreach (DataRow drVisitTreatment in drTreatments)
                        {
                            string treatmentText = "";
                            int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                            cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                            DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];

                            double treatmentCost;

                            treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                                            Convert.ToDouble(drTreatment["Cost"]);
                            visitTotal += treatmentCost;
                            treatmentText = "\tTreatment Description: " + drTreatment["Description"]
                                        + "\tQuantity: " + drVisitTreatment["Quantity"]
                                        + "\tTreatment Cost: " + Convert.ToString(String.Format("Order Total: {0:C}", treatmentCost))
                                        + "\r\n";
                            txtInvoices.Text += treatmentText;
                        }

                        txtInvoices.Text += "\r\n";
                        txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(String.Format("Order Total: {0:C}",visitTotal));
                        txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    }
                    visitText = "";
                    visitTotal = 0;
                }
            }

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            PrintDialog pdi = new PrintDialog();
            pdi.UseEXDialog = true;
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
