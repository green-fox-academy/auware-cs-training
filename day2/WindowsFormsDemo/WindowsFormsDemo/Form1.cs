using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        Person person;

        delegate void PrintDelegate(string text);

        delegate int MathOperation(int a, int b);

        public Form1()
        {
            InitializeComponent();

            person = new Person();

            PrintDelegate print = Print;

            print("hi");

            person.NameChanged += Person_NameChanged;

            int[] numbers = new int[] { 1, 2, 3, 4 };

            Sum(numbers);
            Product(numbers);

            Operation(numbers, 0, Add);
            Operation(numbers, 1, Multiply);

            Add(1, 2);
            Add(b: 2, a: 1);
        }

        int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        int Product(int[] numbers)
        {
            int sum = 1;

            foreach (var number in numbers)
            {
                sum *= number;
            }

            return sum;
        }

        int Operation(int[] numbers, int start, MathOperation operation)
        {
            int sum = start;

            foreach (var number in numbers)
            {
                operation(sum, number);
            }

            return sum;
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        private void Person_NameChanged(object sender, EventArgs e)
        {
            txtName.Text = "Name Changed";
            var f2 = new Form1();
            f2.Show();
        }

        private void BtnClickMe_MouseHover(object sender, EventArgs e)
        {
            txtName.Text = "Hover";
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            person.Name = "My new name";
        }
    }

    class Person
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                NameChanged(this, new EventArgs());
            }
        }

        public event EventHandler NameChanged;
    }
}
