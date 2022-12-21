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
    public partial class ControlProducts : UserControl
    {
        public ControlProducts()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var senderListView = (ListView)sender;
        
        }

        private void ControlProducts_Load(object sender, EventArgs e)
        {
            DataTable CategoryTable = SQL.table("SELECT * FROM Category").Tables[0];
            for (int i = 0; i < CategoryTable.Rows.Count; i++)
            {
                var CategoryArr = CategoryTable.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                Button button = new Button();
                button.Name = $"CategoryBtn" + CategoryArr[0];
                button.Text = CategoryArr[1];
                button.Height = 40;
                button.Dock = DockStyle.Top;
                button.Click += eror;
                button.Tag = CategoryArr[0];
                panel1.SuspendLayout();
                panel1.Controls.Add(button);
                panel1.Controls.SetChildIndex(button, 0);
                panel1.ResumeLayout();
            }

        }
        string startupPath = Environment.CurrentDirectory;
        public void eror(object sender, EventArgs e)
        {
            object TAG = (sender as Button).Tag;
            MessageBox.Show("Вы выбрали "+ (sender as Button).Text);
            DataTable ProductsTable = SQL.table($@"Select Product.ProductId, Product.ProductName , Product.ProductUnit, Product.ProductDescription,
            Product.ProductPhoto, Product.ProductQuantityInStock, (CASE WHEN Product.ProductQuantityInStock > 0 THEN 'В наличие' ELSE 'Кончилось' END) AS status,
            Category.Category, CompanyManufacturer.CompanyName as 'CompanyManufacturer',
            CompanySupplier.CompanyName as 'CompanySupplier', Product.ProductCost
            FROM Product
            Inner Join Category Category on Category.Id = Product.ProductCategoryId
            Inner Join Company CompanyManufacturer on CompanyManufacturer.Id = Product.ProductManufacturerId
            Inner Join Company CompanySupplier on CompanySupplier.Id = Product.ProductSupplierId
            where Product.ProductCategoryId = {TAG} ").Tables[0];
            listView1.Items.Clear();
            imageList1.Images.Clear();


            for (int i = 0; i < ProductsTable.Rows.Count; i++)
            {
                var ProductrArr = ProductsTable.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                ListViewGroup categoryGroup = new ListViewGroup(ProductrArr[1], HorizontalAlignment.Left);
                listView1.Groups.Add(categoryGroup);
                imageList1.Images.Add(Image.FromFile(startupPath+ $@"\Image\Products\{ProductrArr[4]}"));
                listView1.Items.Add("Items"+i);
     
                listView1.Items[i].Text = ProductrArr[3];
                listView1.Items[i].Group = categoryGroup;
                listView1.Items[i].Tag = ProductrArr[0];
        
                listView1.Items[i].SubItems.Add(ProductrArr[10]+" руб.");
                listView1.Items[i].UseItemStyleForSubItems = false;
                CheckBox checkBox = new CheckBox();
                listView1.Items[i].SubItems[1].ForeColor = Color.DarkGray;
                if (int.Parse(ProductrArr[0].ToString()) >0)
                {
                    
                    listView1.Items[i].SubItems.Add("В наличие");
                    listView1.Items[i].SubItems[2].ForeColor = Color.DarkGreen;
                }
                else
                {
                    listView1.Items[i].SubItems.Add("Нет в наличие");
                    listView1.Items[i].SubItems[2].ForeColor = Color.DarkRed;
                }
                
                listView1.Items[i].ImageIndex= i;
            

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("" + listView1.SelectedItems[0].Tag);
            ControlBasketAdd controlBasketAdd = new ControlBasketAdd(int.Parse(listView1.SelectedItems[0].Tag.ToString()));
            controlBasketAdd.Name = "ControlBasketAdd";

          
            this.Hide();

            Program.main.DostypControlerContener.Controls.Add(controlBasketAdd);
        }

    }
}
