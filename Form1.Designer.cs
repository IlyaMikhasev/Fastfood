namespace Fastfood
{
    partial class Form1
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
            this.FirstCourse = new System.Windows.Forms.GroupBox();
            this.Pasta = new System.Windows.Forms.CheckBox();
            this.Borsch = new System.Windows.Forms.CheckBox();
            this.Plov = new System.Windows.Forms.CheckBox();
            this.Cezar = new System.Windows.Forms.CheckBox();
            this.HappyM = new System.Windows.Forms.CheckBox();
            this.ChesBurger = new System.Windows.Forms.CheckBox();
            this.Burger = new System.Windows.Forms.CheckBox();
            this.Nuggets = new System.Windows.Forms.GroupBox();
            this.l_nugget = new System.Windows.Forms.Label();
            this.rb_9c = new System.Windows.Forms.RadioButton();
            this.rb_6c = new System.Windows.Forms.RadioButton();
            this.rb_3c = new System.Windows.Forms.RadioButton();
            this.l_drink = new System.Windows.Forms.Label();
            this.drinks = new System.Windows.Forms.ComboBox();
            this.l_sauce = new System.Windows.Forms.Label();
            this.sauce = new System.Windows.Forms.CheckedListBox();
            this.rb_pacet = new System.Windows.Forms.RadioButton();
            this.rb_hall = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_milk = new System.Windows.Forms.RadioButton();
            this.rb_laim = new System.Windows.Forms.RadioButton();
            this.l_check = new System.Windows.Forms.Label();
            this.b_check = new System.Windows.Forms.Button();
            this.ch_sugar = new System.Windows.Forms.CheckBox();
            this.up_burger = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown6 = new System.Windows.Forms.DomainUpDown();
            this.FirstCourse.SuspendLayout();
            this.Nuggets.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstCourse
            // 
            this.FirstCourse.Controls.Add(this.domainUpDown6);
            this.FirstCourse.Controls.Add(this.domainUpDown5);
            this.FirstCourse.Controls.Add(this.domainUpDown4);
            this.FirstCourse.Controls.Add(this.domainUpDown3);
            this.FirstCourse.Controls.Add(this.domainUpDown2);
            this.FirstCourse.Controls.Add(this.domainUpDown1);
            this.FirstCourse.Controls.Add(this.up_burger);
            this.FirstCourse.Controls.Add(this.Pasta);
            this.FirstCourse.Controls.Add(this.Borsch);
            this.FirstCourse.Controls.Add(this.Plov);
            this.FirstCourse.Controls.Add(this.Cezar);
            this.FirstCourse.Controls.Add(this.HappyM);
            this.FirstCourse.Controls.Add(this.ChesBurger);
            this.FirstCourse.Controls.Add(this.Burger);
            this.FirstCourse.Location = new System.Drawing.Point(13, 13);
            this.FirstCourse.Name = "FirstCourse";
            this.FirstCourse.Size = new System.Drawing.Size(204, 189);
            this.FirstCourse.TabIndex = 0;
            this.FirstCourse.TabStop = false;
            this.FirstCourse.Text = "Первоые блюда";
            // 
            // Pasta
            // 
            this.Pasta.AutoSize = true;
            this.Pasta.Location = new System.Drawing.Point(7, 164);
            this.Pasta.Name = "Pasta";
            this.Pasta.Size = new System.Drawing.Size(77, 17);
            this.Pasta.TabIndex = 6;
            this.Pasta.Text = "Pasta 1.2$";
            this.Pasta.UseVisualStyleBackColor = true;
            // 
            // Borsch
            // 
            this.Borsch.AutoSize = true;
            this.Borsch.Location = new System.Drawing.Point(7, 140);
            this.Borsch.Name = "Borsch";
            this.Borsch.Size = new System.Drawing.Size(74, 17);
            this.Borsch.TabIndex = 5;
            this.Borsch.Text = "Borsch 2$";
            this.Borsch.UseVisualStyleBackColor = true;
            // 
            // Plov
            // 
            this.Plov.AutoSize = true;
            this.Plov.Location = new System.Drawing.Point(7, 116);
            this.Plov.Name = "Plov";
            this.Plov.Size = new System.Drawing.Size(62, 17);
            this.Plov.TabIndex = 4;
            this.Plov.Text = "Plov 2$";
            this.Plov.UseVisualStyleBackColor = true;
            // 
            // Cezar
            // 
            this.Cezar.AutoSize = true;
            this.Cezar.Location = new System.Drawing.Point(7, 92);
            this.Cezar.Name = "Cezar";
            this.Cezar.Size = new System.Drawing.Size(68, 17);
            this.Cezar.TabIndex = 3;
            this.Cezar.Text = "Cezar 1$";
            this.Cezar.UseVisualStyleBackColor = true;
            // 
            // HappyM
            // 
            this.HappyM.AutoSize = true;
            this.HappyM.Location = new System.Drawing.Point(7, 68);
            this.HappyM.Name = "HappyM";
            this.HappyM.Size = new System.Drawing.Size(96, 17);
            this.HappyM.TabIndex = 2;
            this.HappyM.Text = "HappyMill 1.5$";
            this.HappyM.UseVisualStyleBackColor = true;
            this.HappyM.CheckedChanged += new System.EventHandler(this.HappyM_CheckedChanged);
            // 
            // ChesBurger
            // 
            this.ChesBurger.AutoSize = true;
            this.ChesBurger.Location = new System.Drawing.Point(7, 44);
            this.ChesBurger.Name = "ChesBurger";
            this.ChesBurger.Size = new System.Drawing.Size(105, 17);
            this.ChesBurger.TabIndex = 1;
            this.ChesBurger.Text = "ChesBurger 1.1$";
            this.ChesBurger.UseVisualStyleBackColor = true;
            this.ChesBurger.CheckedChanged += new System.EventHandler(this.ChesBurger_CheckedChanged);
            // 
            // Burger
            // 
            this.Burger.AutoSize = true;
            this.Burger.Location = new System.Drawing.Point(7, 20);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(72, 17);
            this.Burger.TabIndex = 0;
            this.Burger.Text = "Burger 1$";
            this.Burger.UseVisualStyleBackColor = true;
            this.Burger.CheckedChanged += new System.EventHandler(this.Burger_CheckedChanged);
            // 
            // Nuggets
            // 
            this.Nuggets.Controls.Add(this.l_nugget);
            this.Nuggets.Controls.Add(this.rb_9c);
            this.Nuggets.Controls.Add(this.rb_6c);
            this.Nuggets.Controls.Add(this.rb_3c);
            this.Nuggets.Location = new System.Drawing.Point(13, 209);
            this.Nuggets.Name = "Nuggets";
            this.Nuggets.Size = new System.Drawing.Size(122, 100);
            this.Nuggets.TabIndex = 1;
            this.Nuggets.TabStop = false;
            this.Nuggets.Text = "Nuggets";
            // 
            // l_nugget
            // 
            this.l_nugget.AutoSize = true;
            this.l_nugget.Location = new System.Drawing.Point(77, 22);
            this.l_nugget.Name = "l_nugget";
            this.l_nugget.Size = new System.Drawing.Size(0, 13);
            this.l_nugget.TabIndex = 3;
            // 
            // rb_9c
            // 
            this.rb_9c.AutoSize = true;
            this.rb_9c.Location = new System.Drawing.Point(7, 68);
            this.rb_9c.Name = "rb_9c";
            this.rb_9c.Size = new System.Drawing.Size(58, 17);
            this.rb_9c.TabIndex = 2;
            this.rb_9c.TabStop = true;
            this.rb_9c.Text = "9 штук";
            this.rb_9c.UseVisualStyleBackColor = true;
            // 
            // rb_6c
            // 
            this.rb_6c.AutoSize = true;
            this.rb_6c.Location = new System.Drawing.Point(7, 44);
            this.rb_6c.Name = "rb_6c";
            this.rb_6c.Size = new System.Drawing.Size(58, 17);
            this.rb_6c.TabIndex = 1;
            this.rb_6c.TabStop = true;
            this.rb_6c.Text = "6 штук";
            this.rb_6c.UseVisualStyleBackColor = true;
            // 
            // rb_3c
            // 
            this.rb_3c.AutoSize = true;
            this.rb_3c.Location = new System.Drawing.Point(7, 20);
            this.rb_3c.Name = "rb_3c";
            this.rb_3c.Size = new System.Drawing.Size(64, 17);
            this.rb_3c.TabIndex = 0;
            this.rb_3c.TabStop = true;
            this.rb_3c.Text = "3 штуки";
            this.rb_3c.UseVisualStyleBackColor = true;
            // 
            // l_drink
            // 
            this.l_drink.AutoSize = true;
            this.l_drink.Location = new System.Drawing.Point(223, 23);
            this.l_drink.Name = "l_drink";
            this.l_drink.Size = new System.Drawing.Size(48, 13);
            this.l_drink.TabIndex = 2;
            this.l_drink.Text = "напитки";
            // 
            // drinks
            // 
            this.drinks.FormattingEnabled = true;
            this.drinks.Items.AddRange(new object[] {
            "чай",
            "кофе"});
            this.drinks.Location = new System.Drawing.Point(226, 40);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(103, 21);
            this.drinks.TabIndex = 3;
            // 
            // l_sauce
            // 
            this.l_sauce.AutoSize = true;
            this.l_sauce.Location = new System.Drawing.Point(156, 218);
            this.l_sauce.Name = "l_sauce";
            this.l_sauce.Size = new System.Drawing.Size(39, 13);
            this.l_sauce.TabIndex = 4;
            this.l_sauce.Text = "Соусы";
            // 
            // sauce
            // 
            this.sauce.FormattingEnabled = true;
            this.sauce.Items.AddRange(new object[] {
            "кетчуп",
            "майонез"});
            this.sauce.Location = new System.Drawing.Point(144, 235);
            this.sauce.Name = "sauce";
            this.sauce.Size = new System.Drawing.Size(102, 34);
            this.sauce.TabIndex = 6;
            // 
            // rb_pacet
            // 
            this.rb_pacet.AutoSize = true;
            this.rb_pacet.Location = new System.Drawing.Point(14, 17);
            this.rb_pacet.Name = "rb_pacet";
            this.rb_pacet.Size = new System.Drawing.Size(65, 17);
            this.rb_pacet.TabIndex = 0;
            this.rb_pacet.TabStop = true;
            this.rb_pacet.Text = "С собой";
            this.rb_pacet.UseVisualStyleBackColor = true;
            // 
            // rb_hall
            // 
            this.rb_hall.AutoSize = true;
            this.rb_hall.Location = new System.Drawing.Point(14, 41);
            this.rb_hall.Name = "rb_hall";
            this.rb_hall.Size = new System.Drawing.Size(58, 17);
            this.rb_hall.TabIndex = 1;
            this.rb_hall.TabStop = true;
            this.rb_hall.Text = "в зале";
            this.rb_hall.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_hall);
            this.panel1.Controls.Add(this.rb_pacet);
            this.panel1.Location = new System.Drawing.Point(362, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 75);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_milk);
            this.panel2.Controls.Add(this.rb_laim);
            this.panel2.Location = new System.Drawing.Point(226, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 69);
            this.panel2.TabIndex = 8;
            // 
            // rb_milk
            // 
            this.rb_milk.AutoSize = true;
            this.rb_milk.Location = new System.Drawing.Point(15, 39);
            this.rb_milk.Name = "rb_milk";
            this.rb_milk.Size = new System.Drawing.Size(63, 17);
            this.rb_milk.TabIndex = 1;
            this.rb_milk.TabStop = true;
            this.rb_milk.Text = "молоко";
            this.rb_milk.UseVisualStyleBackColor = true;
            // 
            // rb_laim
            // 
            this.rb_laim.AutoSize = true;
            this.rb_laim.Location = new System.Drawing.Point(15, 16);
            this.rb_laim.Name = "rb_laim";
            this.rb_laim.Size = new System.Drawing.Size(57, 17);
            this.rb_laim.TabIndex = 0;
            this.rb_laim.TabStop = true;
            this.rb_laim.Text = "лимон";
            this.rb_laim.UseVisualStyleBackColor = true;
            // 
            // l_check
            // 
            this.l_check.AutoSize = true;
            this.l_check.Location = new System.Drawing.Point(362, 153);
            this.l_check.Name = "l_check";
            this.l_check.Size = new System.Drawing.Size(29, 13);
            this.l_check.TabIndex = 9;
            this.l_check.Text = "счет";
            // 
            // b_check
            // 
            this.b_check.Location = new System.Drawing.Point(365, 129);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(118, 23);
            this.b_check.TabIndex = 10;
            this.b_check.Text = "заказать";
            this.b_check.UseVisualStyleBackColor = true;
            this.b_check.Click += new System.EventHandler(this.b_check_Click);
            // 
            // ch_sugar
            // 
            this.ch_sugar.AutoSize = true;
            this.ch_sugar.Location = new System.Drawing.Point(241, 78);
            this.ch_sugar.Name = "ch_sugar";
            this.ch_sugar.Size = new System.Drawing.Size(56, 17);
            this.ch_sugar.TabIndex = 11;
            this.ch_sugar.Text = "Сахар";
            this.ch_sugar.UseVisualStyleBackColor = true;
            // 
            // up_burger
            // 
            this.up_burger.Items.Add("1");
            this.up_burger.Items.Add("2");
            this.up_burger.Items.Add("3");
            this.up_burger.Items.Add("4");
            this.up_burger.Items.Add("5");
            this.up_burger.Location = new System.Drawing.Point(131, 19);
            this.up_burger.Name = "up_burger";
            this.up_burger.Size = new System.Drawing.Size(35, 20);
            this.up_burger.TabIndex = 7;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Location = new System.Drawing.Point(131, 44);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown1.TabIndex = 7;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("4");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Location = new System.Drawing.Point(131, 68);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown2.TabIndex = 7;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("1");
            this.domainUpDown3.Items.Add("2");
            this.domainUpDown3.Items.Add("3");
            this.domainUpDown3.Items.Add("4");
            this.domainUpDown3.Items.Add("5");
            this.domainUpDown3.Location = new System.Drawing.Point(131, 92);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown3.TabIndex = 7;
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Items.Add("1");
            this.domainUpDown4.Items.Add("2");
            this.domainUpDown4.Items.Add("3");
            this.domainUpDown4.Items.Add("4");
            this.domainUpDown4.Items.Add("5");
            this.domainUpDown4.Location = new System.Drawing.Point(131, 116);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown4.TabIndex = 7;
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Items.Add("1");
            this.domainUpDown5.Items.Add("2");
            this.domainUpDown5.Items.Add("3");
            this.domainUpDown5.Items.Add("4");
            this.domainUpDown5.Items.Add("5");
            this.domainUpDown5.Location = new System.Drawing.Point(131, 140);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown5.TabIndex = 7;
            // 
            // domainUpDown6
            // 
            this.domainUpDown6.Items.Add("1");
            this.domainUpDown6.Items.Add("2");
            this.domainUpDown6.Items.Add("3");
            this.domainUpDown6.Items.Add("4");
            this.domainUpDown6.Items.Add("5");
            this.domainUpDown6.Location = new System.Drawing.Point(131, 164);
            this.domainUpDown6.Name = "domainUpDown6";
            this.domainUpDown6.Size = new System.Drawing.Size(35, 20);
            this.domainUpDown6.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 371);
            this.Controls.Add(this.ch_sugar);
            this.Controls.Add(this.b_check);
            this.Controls.Add(this.l_check);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sauce);
            this.Controls.Add(this.l_sauce);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.l_drink);
            this.Controls.Add(this.Nuggets);
            this.Controls.Add(this.FirstCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FirstCourse.ResumeLayout(false);
            this.FirstCourse.PerformLayout();
            this.Nuggets.ResumeLayout(false);
            this.Nuggets.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FirstCourse;
        private System.Windows.Forms.CheckBox Pasta;
        private System.Windows.Forms.CheckBox Borsch;
        private System.Windows.Forms.CheckBox Plov;
        private System.Windows.Forms.CheckBox Cezar;
        private System.Windows.Forms.CheckBox HappyM;
        private System.Windows.Forms.CheckBox ChesBurger;
        private System.Windows.Forms.CheckBox Burger;
        private System.Windows.Forms.GroupBox Nuggets;
        private System.Windows.Forms.Label l_nugget;
        private System.Windows.Forms.RadioButton rb_9c;
        private System.Windows.Forms.RadioButton rb_6c;
        private System.Windows.Forms.RadioButton rb_3c;
        private System.Windows.Forms.Label l_drink;
        private System.Windows.Forms.ComboBox drinks;
        private System.Windows.Forms.Label l_sauce;
        private System.Windows.Forms.CheckedListBox sauce;
        private System.Windows.Forms.RadioButton rb_pacet;
        private System.Windows.Forms.RadioButton rb_hall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_milk;
        private System.Windows.Forms.RadioButton rb_laim;
        private System.Windows.Forms.Label l_check;
        private System.Windows.Forms.Button b_check;
        private System.Windows.Forms.CheckBox ch_sugar;
        private System.Windows.Forms.DomainUpDown domainUpDown6;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown up_burger;
    }
}

