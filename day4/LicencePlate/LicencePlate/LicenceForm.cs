using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LicencePlate
{
    public partial class LicenceForm : Form
    {
        private LicencePlate licencePlate;
        private BindingList<LicencePlate> licences;

        private delegate int MathDelegate(int a, int b);

        public LicenceForm()
        {
            licencePlate = new LicencePlate();
            licences = new BindingList<LicencePlate>();
            InitializeComponent();

            txtLicencePlate.DataBindings.Add(nameof(txtLicencePlate.Text), licencePlate, nameof(licencePlate.Licence), false, DataSourceUpdateMode.OnPropertyChanged);
            lblLicencePlateIsValid.DataBindings.Add("Text", licencePlate, "ValidText");
            lblLicencePlateIsValid.DataBindings.Add("ForeColor", licencePlate, "Color");
            btnAdd.DataBindings.Add("Enabled", licencePlate, "IsValid");

            licences.Add(new LicencePlate { Licence = "ABC-123" });

            licencesBindingSource.DataSource = licences;
            //lbLicences.DataSource = licences;
            lbLicences.DisplayMember = nameof(licencePlate.Licence);
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //licencePlate.Licence = txtLicencePlate.Text;

            //if(licencePlate.IsValid)
            //{
            //    lblLicencePlateIsValid.Text = "valid";
            //    lblLicencePlateIsValid.ForeColor = Color.Green;
            //}
            //else
            //{
            //    lblLicencePlateIsValid.Text = "invalid";
            //    lblLicencePlateIsValid.ForeColor = Color.Red;
            //}
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            licences.Add(licencePlate.Clone());
            licencePlate.Licence = "";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var current = (LicencePlate)licencesBindingSource.Current;
            licences.Remove(current);
        }
    }
}
