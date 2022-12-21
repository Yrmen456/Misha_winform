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
    public partial class ControlBasket : UserControl
    {
        public ControlBasket()
        {
            InitializeComponent();
           
        }
      

        private void ControlBasket_Load(object sender, EventArgs e)
        {
            MessageBox.Show(""+ User.UsersId);
            DataTable CategoryTable = SQL.table($"Select * from dbo.[Order] Orders where  Orders.UserId = '{User.UsersId}'").Tables[0];
            for (int i = 0; i < CategoryTable.Rows.Count; i++)
            {
                var CategoryArr = CategoryTable.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                Button button = new Button();
                button.Name = $"OrderBtn" + CategoryArr[0];
                button.Text ="Заказ №"+ CategoryArr[6];
                button.Height = 40;
                button.Dock = DockStyle.Top;
                button.Click += eror;
                button.Tag = CategoryArr[0];
                panel4.SuspendLayout();
                panel4.Controls.Add(button);
                panel4.Controls.SetChildIndex(button, 0);
                panel4.ResumeLayout();
            }
            panel4.HorizontalScroll.Maximum = 0;
            panel4.AutoScroll = false;
            panel4.VerticalScroll.Maximum = 0;
            panel4.AutoScroll = true;
        }
        public void eror(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            object TAG = (sender as Button).Tag;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            DataTable table = SQL.table($@"Select Product.ProductPhoto,Product.ProductName as 'Название',  Product.ProductDescription as 'Описание', Product.ProductCost as 'Цена',
            OrderProduct.CountInOrder as 'Кол-во', Product.ProductId
            from OrderProduct
            INNER Join Product Product on Product.ProductId = OrderProduct.ProductArticleNumber
            where OrderProduct.OrderID = '{TAG}'").Tables[0];
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            
            imgColumn.Name = "Images";
            btnColumn.Name = "btnColumn";
            dataGridView1.Columns.Insert(0, imgColumn);
            dataGridView1.Columns.Add(btnColumn);

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 50;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Image image ;
                try
                {
                    image = new Bitmap($@"C:\Users\User\Downloads\Telegram Desktop\Misha_winform\Misha_winform\bin\Debug\Image\Products\{dataGridView1[1, i].Value.ToString()}");
                }
                catch
                {
                    image = new Bitmap($@"C:\Users\User\Downloads\Telegram Desktop\Misha_winform\Misha_winform\bin\Debug\Image\Products\{dataGridView1[1, i].Value.ToString()}");
                }
               
                image = resizeImage(image, new Size(100, 100));
                Button btn = new Button();
     
                btn.Text = "Изменить";
                dataGridView1.Rows[i].Height = 100;
                dataGridView1.Rows[i].Cells["Images"].Value = image;
                dataGridView1.Rows[i].Cells["btnColumn"].Value = btn;
       

            }
           
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[4].Width = 35;
            dataGridView1.Columns[5].Width = 25;
          
            dataGridView1.Columns["btnColumn"].Width = 50;
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                  ,'{random.Next(1,10000)}')");
            DataTable CategoryTable = SQL.table($"Select * from dbo.[Order] Orders where  Orders.UserId = '{User.UsersId}'").Tables[0];
            for (int i = 0; i < CategoryTable.Rows.Count; i++)
            {
                var CategoryArr = CategoryTable.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                Button button = new Button();
                button.Name = $"OrderBtn" + CategoryArr[0];
                button.Text = "Заказ №" + CategoryArr[6];
                button.Height = 40;
                button.Dock = DockStyle.Top;
                button.Click += eror;
                button.Tag = CategoryArr[0];
                panel4.SuspendLayout();
                panel4.Controls.Add(button);
                panel4.Controls.SetChildIndex(button, 0);
                panel4.ResumeLayout();
            }

        }
    }
}