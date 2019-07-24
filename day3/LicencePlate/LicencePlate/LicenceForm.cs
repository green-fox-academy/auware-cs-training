using System;
using System.Drawing;
using System.Windows.Forms;

namespace LicencePlate
{
    public partial class LicenceForm : Form
    {
        private LicencePlate licencePlate;

        private delegate int MathDelegate(int a, int b);

        public LicenceForm()
        {
            licencePlate = new LicencePlate();
            InitializeComponent();

            MathDelegate mymethod;

            mymethod = Add;

            //...

            mymethod(1, 2);
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            licencePlate.Licence = txtLicencePlate.Text;

            if(licencePlate.IsValid)
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
