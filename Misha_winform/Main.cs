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
    public partial class Main : Form
    {
        string[,] Role = new string[,] 
        {
        {"0","LoginShowBtn"},{"0","ProductsShowBtn"},
        {"2","ProductsShowBtn"},{"2","BasketShowBtn"},{"2","ProfileShowBtn"},
        {"3","ProductsShowBtn"},{"3","BasketShowBtn"},{"3","OrdersShowBtn"},{"3","ProfileShowBtn"},
        {"4","ProductsShowBtn"},{"4","BasketShowBtn"},{"4","ProductsAddShowBtn"},{"4","OrdersShowBtn"},{"4","ProfileShowBtn"},
        };
        public Main()
        {
            InitializeComponent();
            BtnContener.HorizontalScroll.Maximum = 0;
            BtnContener.AutoScroll = false;
            BtnContener.VerticalScroll.Maximum = 0;
            BtnContener.AutoScroll = true;
            for (int i = 0; i < Role.GetLength(0); i++)
            {
                if (User.RoleID.ToString() == Role[i, 0])
                {
                    BtnContener.Controls[Role[i, 1]].Visible = true;
                }
            }
            if (User.RoleID == 0)
            {
                UserLabel.Text = $"Гость";
            }
            else
            {
                UserLabel.Text = $"{User.UserSurname} {User.UserName[0]}. {User.UserPatronymic[0]}.";
            }

            Program.main = this;
        }

        private void ProductsShowBtn_Click(object sender, EventArgs e)
        {
            ControllerContener.Controls.Clear();
            ControlProducts controlProducts = new ControlProducts();
            controlProducts.Name = "abonent_CRM_control";
            controlProducts.Dock = DockStyle.Fill;
            ControllerContener.Controls.Add(controlProducts);
        }

        private void OrdersShowBtn_Click(object sender, EventArgs e)
        {
    
        }

        private void ProfileShowBtn_Click(object sender, EventArgs e)
        {

        }

        private void BasketShowBtn_Click(object sender, EventArgs e)
        {
            ControllerContener.Controls.Clear();
            ControlBasket сontrolBasket = new ControlBasket();
            сontrolBasket.Name = "abonent_CRM_control";
            сontrolBasket.Dock = DockStyle.Fill;
            ControllerContener.Controls.Add(сontrolBasket);
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
  
            Program.Authorization.Show();
            this.Close();
        }
        public Panel DostypControlerContener
        {
            get { return ControllerContener; }
            set { ControllerContener = value; }
        }

        private void LoginShowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
