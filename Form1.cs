using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Storage storage;

        public Form1()
        {
            InitializeComponent();
            BackColor = Product.BackColor;
            storage = new Storage(new List<FoodProduct>());
            storage.AddProduct(new FoodProduct());
            listBox1.DataSource = storage.Products;
            listBox1.DisplayMember = "Name";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double price;
            if (!double.TryParse(textBox2.Text, out price))
            {
                MessageBox.Show("Incorrect data");
                return;
            }
            FoodProduct foodProduct = new FoodProduct(textBox4.Text, price, textBox5.Text, dateTimePicker1.Value, textBox10.Text);
            // Product product = new Product(textBox4.Text, price, textBox5.Text, dateTimePicker1.Value);
            //storage.AddProduct(product);
            storage.AddProduct(foodProduct);
            listBox1.DataSource = null;
            listBox1.DataSource = storage.Products;
            listBox1.DisplayMember = "Name";
            textBox4.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox10.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var product in storage.Products)
            {
                if (product.Name.ToLower() == textBox6.Text.ToLower() || product.Price.ToString() == textBox7.Text)
                {

                    label1.Text = product.Name;
                    label2.Text = product.Price.ToString();
                    label3.Text = product.Firm;
                    //label4.Text = foodProduct.NutritionInfo.ToString();
                   
                    
                    if (product is FoodProduct foodProduct)
                    {
                        // Дополнительная информация для FoodProduct
                        label13.Text = $"Nutrition Info: {foodProduct.NutritionInfo}";
                    }
                    else
                    {
                        label13.Text = "";
                    }

                    textBox6.Clear();
                    textBox7.Clear();
                    break;

                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= storage.Products.Count || listBox1.SelectedIndex < 0)
                return;
            FoodProduct pr = storage.Products[listBox1.SelectedIndex];
            
            
            
            textBox3.Text = pr.Name;
            textBox8.Text = pr.Price.ToString();
            textBox9.Text = pr.ExpirationDate.ToString();
            textBox11.Text = pr.NutritionInfo.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }



        //Метод записи в текстовый файл
        public void WriteToFile()
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\ASUS\\Desktop\\products.txt");
            foreach (var product in storage.Products)
            {
                if (product is FoodProduct foodProduct)
                {
                    writer.WriteLine($"{foodProduct.Name};{foodProduct.Price};{foodProduct.Firm};{foodProduct.ExpirationDate};{foodProduct.NutritionInfo}");
                }
                else
                {
                    writer.WriteLine($"{product.Name};{product.Price};{product.Firm};{product.ExpirationDate};");
                }
                }
            writer.Close();
        }

        public void ReadFromFile()
        {
            storage.Products.Clear();
            StreamReader reader = new StreamReader("C:\\Users\\ASUS\\Desktop\\products.txt");
            string[] s = reader.ReadToEnd().Split('\n');
            foreach (string line in s)
            {
                string[] args = line.Split(';');
                storage.AddProduct(new FoodProduct(args[0], double.Parse(args[1]), args[2], DateTime.Parse(args[3]), args[4]));

            }

            reader.Close();

            listBox1.DataSource = null;
            listBox1.DataSource = storage.Products;
            listBox1.DisplayMember = "Name";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
