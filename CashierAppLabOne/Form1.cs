﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierAppLabOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        DiscountedItem discItem;
        private void button1_Click(object sender, EventArgs e)
        {
            discItem = new DiscountedItem(itemName.Text, Convert.ToDouble(price.Text), Convert.ToInt32(quant.Text), Convert.ToDouble(disc.Text));
            

            double totalprice = discItem.getTotalPrice();
            
            totalAmount.Text = totalprice.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double paymentAmount = Convert.ToDouble(payment.Text);
            
            discItem.setPayment(paymentAmount);
            double change = discItem.getChange();
            changeAmount.Text = change.ToString();

        }
    }
}
