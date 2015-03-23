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
    public partial class MainForm : Form
    {
        private DataModule DM;                   		// the reference to the form that holds the data components
        private CatForm frmCat;            		// the reference to the cat form
        private OwnerForm frmOwner;	 		// the reference to the owner form
        private TreatmentForm frmTreatment;      		// the reference to the treatment form
        private VeterinarianForm frmVet;         		// the reference to the veterinarian form
        private VisitForm frmVisit;       		// the reference to the visit form
        private VisitTreatmentForm frmVisitTreatment;  	// the reference to the visit treatment form
        private InvoiceForm frmInvoice;		  	// the reference to the invoice form


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if (frmTreatment == null)
            {
                frmTreatment = new TreatmentForm(DM, this);
            }
            frmTreatment.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();
        }

        private void btnVeterinarian_Click(object sender, EventArgs e)
        {
            if (frmVet == null)
            {
                frmVet = new VeterinarianForm(DM, this);
            }
            frmVet.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();

        }

        private void btnTreatmentVisit_Click(object sender, EventArgs e)
        {
            if (frmVisitTreatment == null)
            {
                frmVisitTreatment = new VisitTreatmentForm(DM, this);
            }
            frmVisitTreatment.ShowDialog();

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            if (frmCat == null)
            {
                frmCat = new CatForm(DM, this);
            }
            frmCat.ShowDialog();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (frmVisit == null)
            {
                frmVisit = new VisitForm(DM, this);
            }
            frmVisit.ShowDialog();
        }


    }
}
