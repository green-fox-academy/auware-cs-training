using CalorieCounter.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BLL
{
    public class FoodService
    {
        private Random random = new Random();
        private DataContext dataContext;

        public DataTable FoodTable { get => dataContext.FoodTable; }

        public FoodService(DataContext dataContext)
        {
            this.dataContext = dataContext;
            dataContext.Load();
        }

        public void Add(Food food)
        {
            food.Id = random.Next();
            dataContext.FoodTable.Rows.Add(food.Id, food.Name, food.Amount);
            dataContext.Save();
        }

        internal Food GetForRow(DataRow row)
        {
            return new Food {
                Id = row.Field<long>("Id"),
                Name = row.Field<string>("Name"),
                Amount = row.Field<int>("Amount")
            };
        }

        internal void Update(DataRow row, Food food)
        {
            row["Name"] = food.Name;
            row["Amount"] = food.Amount;

            dataContext.Save();
        }
    }
}
