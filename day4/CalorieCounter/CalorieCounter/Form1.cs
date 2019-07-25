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
    public partial class Form1 : Form
    {
        private FoodService foodService;

        public Form1(FoodService foodService)
        {
            this.foodService = foodService;
            //this.foodService = new FoodService(new DAL.DataContext());
            InitializeComponent();


            foodBindingSource.DataSource = foodService.FoodTable;
            gvFood.AutoGenerateColumns = true;
        }

        private Food foodToAdd;

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            foodToAdd = new Food();
            var foodForm = new FoodForm(foodToAdd);

            foodForm.FormClosed += FoodForm_FormClosed;

            foodForm.ShowDialog();
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foodService.Add(foodToAdd);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)foodBindingSource.Current;
            var food = foodService.GetForRow(dataRowView.Row);

            var foodForm = new FoodForm(food);

            foodForm.ShowDialog();

            foodService.Update(dataRowView.Row, food);
        }

        private void TxtNameFilter_TextChanged(object sender, EventArgs e)
        {
            foodBindingSource.Filter = $"Name LIKE '%{txtNameFilter.Text}%'";
        }
    }
}
