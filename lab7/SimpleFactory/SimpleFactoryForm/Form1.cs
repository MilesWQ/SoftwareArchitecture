﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleFactoryLibrary;

namespace SimpleFactoryForm
{
    public partial class Form1 : Form
    {
        private List<string> _pizzaList;
        private PizzaStore _store;
        private HomeDelivery newForm;
        public Form1()
        {
            _store = PizzaStore.GetInstance(new SimplePizzaFactory());
            
            InitializeComponent();
        }

        private void ShowPizzaList()
        {
            _pizzaList = new List<string>
            {
                "ham",
                "cheese",
                "funghi"
            };
            for (int i = 0; i < 3; ++i)
            {
                listPizza.Items.Insert(i, _pizzaList[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            ShowPizzaList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Pizza myPizza = _store.OrderPizza(listPizza.GetItemText(listPizza.SelectedItem));
            lblOrder.Text = myPizza.ShowDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newForm = new HomeDelivery();
            newForm.Show();
            newForm = null;
            this.Show();
        }
    }
}
