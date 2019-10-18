using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
/// <summary>
/// Created by:   
/// </summary>
namespace CashRegister
{
    public partial class form1 : Form
    {
        const double BURGER_PRICE = 5.00;
        const double FRY_PRICE = 3.00;
        const double DRINK_PRICE = 2.00;

        double tax = 0.13;

        int numOfBurgers = 0;
        int numOfFries = 0;
        int numOfDrink = 0;

        double subTotal = 0;
        double totalTax;
        double totalPrice;

        public form1()
        {
            InitializeComponent();
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            numOfBurgers = Convert.ToInt16(textBox1.Text);
            numOfFries = Convert.ToInt16(textBox2.Text);
            numOfDrink = Convert.ToInt16(textBox3.Text);

            subTotal = BURGER_PRICE * numOfBurgers + FRY_PRICE * numOfFries + DRINK_PRICE * numOfDrink;
            totalTax = subTotal * tax;
            totalPrice = subTotal + totalTax;

            subTotalOutput.Text = subTotal.ToString("C");
            taxOutput.Text = totalTax.ToString("C");
            totalOutput.Text = totalPrice.ToString("C");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Graphics Settings
                Graphics g = this.CreateGraphics();
                Font reciptFont = new Font("consolas", 10);
                SolidBrush ReciptBrush = new SolidBrush(Color.Black);

                g.DrawString("Bartmans Burgers", reciptFont, ReciptBrush, 490, 70);

                Thread.Sleep(500);

                g.DrawString("Burgers x " + numOfBurgers + "    " + BURGER_PRICE.ToString("C"), reciptFont, ReciptBrush, 490, 95);

                Thread.Sleep(500);

                g.DrawString("Fries x " + numOfFries + "    " + FRY_PRICE.ToString("C"), reciptFont, ReciptBrush, 490, 110);

                Thread.Sleep(500);

                g.DrawString("Drinks x " + numOfDrink + "    " + DRINK_PRICE.ToString("C"), reciptFont, ReciptBrush, 490, 130);

                Thread.Sleep(500);

                g.DrawString("Subtotal " + subTotal.ToString("C"), reciptFont, ReciptBrush, 490, 150);

                Thread.Sleep(500);

                g.DrawString("Tax " + totalTax.ToString("C"), reciptFont, ReciptBrush, 490, 170);

                Thread.Sleep(500);

                g.DrawString("Total " + totalPrice.ToString("C"), reciptFont, ReciptBrush, 490, 190);


            }
            catch { }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Chocolate);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            numOfBurgers = 0;
            numOfFries = 0;
            numOfDrink = 0;

            subTotalOutput.Text = "";
        }
    }
}
