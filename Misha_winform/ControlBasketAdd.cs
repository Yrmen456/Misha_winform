using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misha_winform
{
    public partial class ControlBasketAdd : UserControl
    {
        int ProductId;
        string ProductName;
        decimal ProductUnit;
        public ControlBasketAdd(int ProductId)
        {
            InitializeComponent();
            this.ProductId = ProductId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.main.DostypControlerContener.Controls[0].Show();
        }

        DataTable ProductTable;
        
        private void ControlBasketAdd_Load(object sender, EventArgs e)
        {

            ProductTable = SQL.table($@"Select Product.ProductId, Product.ProductName , Product.ProductUnit, Product.ProductDescription,
            Product.ProductPhoto, Product.ProductQuantityInStock, (CASE WHEN Product.ProductQuantityInStock > 0 THEN 'В наличие' ELSE 'Кончилось' END) AS status,
            Category.Category, CompanyManufacturer.CompanyName as 'CompanyManufacturer',
            CompanySupplier.CompanyName as 'CompanySupplier', Product.ProductCost
            FROM Product
            Inner Join Category Category on Category.Id = Product.ProductCategoryId
            Inner Join Company CompanyManufacturer on CompanyManufacturer.Id = Product.ProductManufacturerId
            Inner Join Company CompanySupplier on CompanySupplier.Id = Product.ProductSupplierId
            where Product.ProductId = {ProductId} ").Tables[0];
            var ProductrArr = ProductTable.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            label1.Text = "Название:" + ProductrArr[1];
            label2.Text = "Цена:" + ProductrArr[10]+ " руб.";
            label3.Text = "Ост. кол.:" + ProductrArr[5] + ""+ ProductrArr[2];

            DataTable CategoryTable = SQL.table($"Select * from dbo.[Order] Orders where  Orders.UserId = '{User.UsersId}'").Tables[0];
            comboBox1.DataSource = CategoryTable.Rows.OfType<DataRow>().Select(k => k[6].ToString()).ToArray();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            //
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            SQL.Query($@"INSERT INTO [dbo].[Order]
           ([OrderStatusId]
           ,[OrderPickupPointId]
           ,[UserId]
           ,[OrderBeginDate]
           ,[OrderDeliveryDate]
           ,[TakeCode])
             VALUES
                  ('1'
                  ,'1'
                  ,'{User.UsersId}'
                  ,'19-05-2022 00:00:10'
                  ,'25-05-2022 00:00:10'
                  ,'{random.Next(1, 10000)}')");
            DataTable CategoryTable = SQL.table($"Select * from dbo.[Order] Orders where  Orders.UserId = '{User.UsersId}'").Tables[0];
        
            comboBox1.DataSource = CategoryTable.Rows.OfType<DataRow>().Select(k => k[6].ToString()).ToArray();
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable CategoryTable = SQL.table($"Select * from dbo.[Order] Orders where  Orders.UserId = '{User.UsersId}'").Tables[0];
            string IdOrder = CategoryTable.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray()[comboBox1.SelectedIndex];
            SQL.Query($@"INSERT INTO [dbo].[OrderProduct]
           ([OrderID]
           ,[ProductArticleNumber]
           ,[CountInOrder])
             VALUES
                   ('{IdOrder}'
                   ,'{ProductId}'
                   ,'{int.Parse(numericUpDown1.Value.ToString())}')");
        }
    }
}
