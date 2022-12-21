
namespace Misha_winform
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InfoContener = new System.Windows.Forms.Panel();
            this.BtnContener = new System.Windows.Forms.Panel();
            this.LoginShowBtn = new System.Windows.Forms.Button();
            this.BasketShowBtn = new System.Windows.Forms.Button();
            this.ProductsAddShowBtn = new System.Windows.Forms.Button();
            this.ProfileShowBtn = new System.Windows.Forms.Button();
            this.OrdersShowBtn = new System.Windows.Forms.Button();
            this.ProductsShowBtn = new System.Windows.Forms.Button();
            this.BottomContener = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.InfoUserContener = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ControllerContener = new System.Windows.Forms.Panel();
            this.InfoContener.SuspendLayout();
            this.BtnContener.SuspendLayout();
            this.BottomContener.SuspendLayout();
            this.InfoUserContener.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoContener
            // 
            this.InfoContener.Controls.Add(this.BtnContener);
            this.InfoContener.Controls.Add(this.BottomContener);
            this.InfoContener.Controls.Add(this.InfoUserContener);
            this.InfoContener.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoContener.Location = new System.Drawing.Point(860, 0);
            this.InfoContener.Name = "InfoContener";
            this.InfoContener.Size = new System.Drawing.Size(280, 639);
            this.InfoContener.TabIndex = 0;
            // 
            // BtnContener
            // 
            this.BtnContener.Controls.Add(this.LoginShowBtn);
            this.BtnContener.Controls.Add(this.BasketShowBtn);
            this.BtnContener.Controls.Add(this.ProductsAddShowBtn);
            this.BtnContener.Controls.Add(this.ProfileShowBtn);
            this.BtnContener.Controls.Add(this.OrdersShowBtn);
            this.BtnContener.Controls.Add(this.ProductsShowBtn);
            this.BtnContener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnContener.Location = new System.Drawing.Point(0, 85);
            this.BtnContener.Name = "BtnContener";
            this.BtnContener.Size = new System.Drawing.Size(280, 498);
            this.BtnContener.TabIndex = 2;
            // 
            // LoginShowBtn
            // 
            this.LoginShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginShowBtn.Location = new System.Drawing.Point(0, 280);
            this.LoginShowBtn.Name = "LoginShowBtn";
            this.LoginShowBtn.Size = new System.Drawing.Size(280, 56);
            this.LoginShowBtn.TabIndex = 9;
            this.LoginShowBtn.Text = "Зарегистрироваться";
            this.LoginShowBtn.UseVisualStyleBackColor = true;
            this.LoginShowBtn.Visible = false;
            this.LoginShowBtn.Click += new System.EventHandler(this.LoginShowBtn_Click);
            // 
            // BasketShowBtn
            // 
            this.BasketShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasketShowBtn.Location = new System.Drawing.Point(0, 224);
            this.BasketShowBtn.Name = "BasketShowBtn";
            this.BasketShowBtn.Size = new System.Drawing.Size(280, 56);
            this.BasketShowBtn.TabIndex = 8;
            this.BasketShowBtn.Text = "Мои заказы";
            this.BasketShowBtn.UseVisualStyleBackColor = true;
            this.BasketShowBtn.Visible = false;
            this.BasketShowBtn.Click += new System.EventHandler(this.BasketShowBtn_Click);
            // 
            // ProductsAddShowBtn
            // 
            this.ProductsAddShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsAddShowBtn.Location = new System.Drawing.Point(0, 168);
            this.ProductsAddShowBtn.Name = "ProductsAddShowBtn";
            this.ProductsAddShowBtn.Size = new System.Drawing.Size(280, 56);
            this.ProductsAddShowBtn.TabIndex = 7;
            this.ProductsAddShowBtn.Text = "Добавить Товар";
            this.ProductsAddShowBtn.UseVisualStyleBackColor = true;
            this.ProductsAddShowBtn.Visible = false;
            // 
            // ProfileShowBtn
            // 
            this.ProfileShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileShowBtn.Location = new System.Drawing.Point(0, 112);
            this.ProfileShowBtn.Name = "ProfileShowBtn";
            this.ProfileShowBtn.Size = new System.Drawing.Size(280, 56);
            this.ProfileShowBtn.TabIndex = 6;
            this.ProfileShowBtn.Text = "Профиль";
            this.ProfileShowBtn.UseVisualStyleBackColor = true;
            this.ProfileShowBtn.Visible = false;
            this.ProfileShowBtn.Click += new System.EventHandler(this.ProfileShowBtn_Click);
            // 
            // OrdersShowBtn
            // 
            this.OrdersShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersShowBtn.Location = new System.Drawing.Point(0, 56);
            this.OrdersShowBtn.Name = "OrdersShowBtn";
            this.OrdersShowBtn.Size = new System.Drawing.Size(280, 56);
            this.OrdersShowBtn.TabIndex = 5;
            this.OrdersShowBtn.Text = "Заказы";
            this.OrdersShowBtn.UseVisualStyleBackColor = true;
            this.OrdersShowBtn.Visible = false;
            this.OrdersShowBtn.Click += new System.EventHandler(this.OrdersShowBtn_Click);
            // 
            // ProductsShowBtn
            // 
            this.ProductsShowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsShowBtn.Location = new System.Drawing.Point(0, 0);
            this.ProductsShowBtn.Name = "ProductsShowBtn";
            this.ProductsShowBtn.Size = new System.Drawing.Size(280, 56);
            this.ProductsShowBtn.TabIndex = 3;
            this.ProductsShowBtn.Text = "Товары";
            this.ProductsShowBtn.UseVisualStyleBackColor = true;
            this.ProductsShowBtn.Visible = false;
            this.ProductsShowBtn.Click += new System.EventHandler(this.ProductsShowBtn_Click);
            // 
            // BottomContener
            // 
            this.BottomContener.Controls.Add(this.LogoutBtn);
            this.BottomContener.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContener.Location = new System.Drawing.Point(0, 583);
            this.BottomContener.Name = "BottomContener";
            this.BottomContener.Size = new System.Drawing.Size(280, 56);
            this.BottomContener.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(280, 56);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Выход";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // InfoUserContener
            // 
            this.InfoUserContener.Controls.Add(this.UserLabel);
            this.InfoUserContener.Controls.Add(this.pictureBox2);
            this.InfoUserContener.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoUserContener.Location = new System.Drawing.Point(0, 0);
            this.InfoUserContener.Name = "InfoUserContener";
            this.InfoUserContener.Size = new System.Drawing.Size(280, 85);
            this.InfoUserContener.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(0, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(195, 85);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Федоров А.В.";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ControllerContener
            // 
            this.ControllerContener.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControllerContener.BackColor = System.Drawing.Color.Transparent;
            this.ControllerContener.Location = new System.Drawing.Point(0, 0);
            this.ControllerContener.Name = "ControllerContener";
            this.ControllerContener.Size = new System.Drawing.Size(854, 639);
            this.ControllerContener.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 639);
            this.Controls.Add(this.ControllerContener);
            this.Controls.Add(this.InfoContener);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Название приложения";
            this.InfoContener.ResumeLayout(false);
            this.BtnContener.ResumeLayout(false);
            this.BottomContener.ResumeLayout(false);
            this.InfoUserContener.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoContener;
        private System.Windows.Forms.Panel ControllerContener;
        private System.Windows.Forms.Panel BottomContener;
        private System.Windows.Forms.Panel InfoUserContener;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BtnContener;
        private System.Windows.Forms.Button ProfileShowBtn;
        private System.Windows.Forms.Button OrdersShowBtn;
        private System.Windows.Forms.Button ProductsShowBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ProductsAddShowBtn;
        private System.Windows.Forms.Button BasketShowBtn;
        private System.Windows.Forms.Button LoginShowBtn;
    }
}

