using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class Form1 : Form
    {
        static string rbtext = "";
        string drink=string.Empty,limMIlk=string.Empty,sugar=string.Empty;
        double drinkPrice;
        string resChesk=string.Empty;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void b_save_Click()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, resChesk);
            MessageBox.Show("Файл сохранен");
        }
        private void b_check_Click(object sender, EventArgs e)
        {
            double ticket=0;
            foreach (var item in l_check.Items)
            {
                resChesk += item+"\n";
            }
            Regex regex = new Regex(@"\d+((.\d)\$|\$)");
            MatchCollection match = regex.Matches(resChesk);
            foreach (var item in match)
            {
                string myitem = item.ToString().TrimEnd('$');
                ticket += Convert.ToDouble(myitem);
            }
            var dialog = MessageBox.Show($"Итого {ticket}","Счет за заказ",MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK) {
                b_save_Click();
            }

        }
        private void upDownCheck(object sender, decimal updown_value, string name, double price)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true && updown_value != 0)
            {
                l_check.Items.Add($"\n {updown_value} {name} =" +
                $" {int.Parse(updown_value.ToString()) * price}$");
            }
            else if (checkBox.Checked == false)
            {
                string res = $"\n {updown_value} {name} =" +
                $" {int.Parse(updown_value.ToString()) * price}$";
                l_check.Items.Remove(res);
            }
        }
        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_burger.Value, "бургер", 1);
        }

        private void ChesBurger_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_chburger.Value, "Чизбургер", 1.1);
        }

        private void HappyM_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_happy.Value, "Хаппи милл", 1.5);
        }


        private void Cezar_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_cezar.Value, "Салат Цезарь", 1);
        }

        private void Plov_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_plov.Value, "Плов", 2);
        }

        private void Borsch_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_borch.Value, "Борщ", 2);
        }

        private void Pasta_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, up_pasta.Value, "Паста", 1.2);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rb_3c.Checked)
            {
                l_check.Items.Remove(rbtext);
                rbtext = "Nuggets " + rb_3c.Text;                
            }
            else
            if (rb_6c.Checked)
            {
                l_check.Items.Remove(rbtext);
                rbtext = "Nuggets " + rb_6c.Text;
            }
            else
            if (rb_9c.Checked)
            {
                l_check.Items.Remove(rbtext);
                rbtext = "Nuggets " + rb_9c.Text;
            }
            l_check.Items.Add(rbtext);
        }

        private void cb_couce_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, 1, "Кетчуп", 0.2);
        }

        private void cb_moiz_CheckedChanged(object sender, EventArgs e)
        {
            upDownCheck(sender, 1, "Майонез", 0.2);
        }

        private void drinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drinks.SelectedIndex == 0)
            {
                drink = "Чай";
                drinkPrice = 0.3;
            }
            else
                if (drinks.SelectedIndex == 1)
            {
                drink = "Кофе";
                drinkPrice = 0.4;
            }
        }

        private void b_addDrink_Click(object sender, EventArgs e)
        {
            l_check.Items.Add(drink+" "+limMIlk+" "+sugar+" = "+drinkPrice.ToString()+"$");
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            l_check.Items.Remove(l_check.SelectedItem);
            
        }

        private void ch_sugar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked == true)
            {
                sugar = check.Text;
            }
            else
                sugar = string.Empty;
        }
        private void radioButtonDrinks_CheckedChanged(object sender, EventArgs e) {
            if (rb_laim.Checked) {
                limMIlk = "лимон";
            }
            if (rb_milk.Checked) {
                limMIlk = "молоко";
            }
        }
    }
}
