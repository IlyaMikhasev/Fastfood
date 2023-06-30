using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double resault = 0;
        private void sum_chek() {
        
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void b_check_Click(object sender, EventArgs e)
        {

        }

        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                l_check.Text += $"\n {up_burger.SelectedItem.ToString()} бургер =" +
                $" {int.Parse(up_burger.SelectedItem.ToString()) * 1}";
            }
        }

        private void ChesBurger_CheckedChanged(object sender, EventArgs e)
        {
            sum = 1.1;
        }

        private void HappyM_CheckedChanged(object sender, EventArgs e)
        {
            sum  = 1.5;
        }
    }
}
