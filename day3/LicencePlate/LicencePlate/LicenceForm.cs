using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicencePlate
{
    public partial class LicenceForm : Form
    {
        private readonly Regex licenceCheckerRegex;
        public LicenceForm()
        {
            licenceCheckerRegex = new Regex("[A-Z]{3}-\\d{3}", RegexOptions.Compiled);
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string licence = txtLicencePlate.Text;

            if(licenceCheckerRegex.IsMatch(licence))
            {
                lblLicencePlateIsValid.Text = "valid";
                lblLicencePlateIsValid.ForeColor = Color.Green;
            }
            else
            {
                lblLicencePlateIsValid.Text = "invalid";
                lblLicencePlateIsValid.ForeColor = Color.Red;
            }
        }
    }
}
