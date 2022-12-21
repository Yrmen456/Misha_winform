using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Misha_winform
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Program.Authorization = this;
        }
        DataTable users;
        private void Authorization_Load(object sender, EventArgs e)
        {
            
            users = SQL.table("Select UserLogin, UserPassword  from dbo.[User]").Tables[0];
            dataGridView1.DataSource = users;



        }
       
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void LoginUpBtn_Click(object sender, EventArgs e)
        {
            DataTable user = SQL.table($@"Select Users.Id as 'UsersId', Users.UserLogin , Users.UserPassword , 
            Users.UserSurname , Users.UserName, Users.UserPatronymic, 
            Role.RoleID as 'RoleId' , Role.RoleName as 'RoleName'
            from dbo.[User] Users 
            Inner Join Role Role on Users.UserRole = Role.RoleID
            where UserLogin='{LoginTextbox.Text}' and UserPassword='{PasswordTextbox.Text}' ").Tables[0];
            if (user.Rows.Count > 0)
            {
                var userArr = user.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                User.UsersId = int.Parse(userArr[0]);
                User.UserLogin = (userArr[1]);
                User.UserPassword = (userArr[2]);
                User.UserSurname = (userArr[3]);
                User.UserName = (userArr[4]);
                User.UserPatronymic = (userArr[5]);
                User.RoleID = int.Parse(userArr[6]);
                User.RoleName = (userArr[7]);
                Main main = new Main();
                MessageBox.Show($"Добро подаловать \n {User.UserSurname} {User.UserName[0]}. {User.UserPatronymic[0]}. \n ({User.RoleName})");
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Нет такого ползователя");
            }
        }

        private void LoginOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataTable Data_Table = users;
            if (e.RowIndex >= 0)
            {
                LoginTextbox.Text = Data_Table.Rows[e.RowIndex][0].ToString();
                PasswordTextbox.Text = Data_Table.Rows[e.RowIndex][1].ToString();
            }
        }

        private void OpenProduct_Click(object sender, EventArgs e)
        {

            User.RoleID = 0;

            Main main = new Main();
            MessageBox.Show($"Добро подаловать \n  \n (Гость)");
            main.Show();
            this.Hide();
        }
    }
}
