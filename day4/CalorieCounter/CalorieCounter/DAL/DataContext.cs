using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.DAL
{
    public class DataContext
    {
        private const string CsvFilePath = "food.csv";

        public DataTable FoodTable { get; private set; }

        public DataContext()
        {
            FoodTable = new DataTable();

            FoodTable.Columns.Add("Id", typeof(long));
            FoodTable.Columns.Add("Name", typeof(string));
            FoodTable.Columns.Add("Amount", typeof(int));
        }

        public void Load()
        {
            using (StreamReader reader = new StreamReader(CsvFilePath))
            {
                var line = reader.ReadLine();

                while(line != null)
                {
                    string[] parts = line.Split(',');

                    if(parts.Length != 3)
                    {
                        throw new FormatException("CSV file not i a correct format.");
                    }

                    FoodTable.Rows.Add(parts[0], parts[1], parts[2]);

                    line = reader.ReadLine();
                }
            }
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(CsvFilePath))
            {
                foreach (DataRow row in FoodTable.Rows)
                {
                    writer.WriteLine($"{row["id"]},{row["Name"]},{row["Amount"]}");
                }

                writer.Flush();
            }
        }
    }
}
