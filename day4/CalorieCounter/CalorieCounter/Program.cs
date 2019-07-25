using CalorieCounter.BLL;
using CalorieCounter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dataContext = new DataContext();
            var foodService = new FoodService(dataContext);

            Application.Run(new Form1(foodService));
        }
    }
}
