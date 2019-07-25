using CalorieCounter.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class FoodForm : Form
    {
        public Food Food { get; set; }

        private FoodValidator foodValidator;

        public FoodForm(Food food)
        {
            foodValidator = new FoodValidator();
            Food = food;
            InitializeComponent();

            txtName.DataBindings.Add("Text", this, "Food.Name");
            txtAmount.DataBindings.Add("Text", this, "Food.Amount");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if(!foodValidator.IsNameValid(Food))
            {
                nameErrorProvider.SetError(txtName, "Please provide a valid name");
                e.Cancel = true;
            }
        }
    }
}
