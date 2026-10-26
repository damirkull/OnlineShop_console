using OnlineShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOnlineShop_2026
{
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent();
        }

        public UserCart(Cart cart)
        {
            InitializeComponent();

            decimal price = 0;

            foreach (CartItem cartItem in cart.getAll())
                listBoxUserCart.Items.Add(cartItem.Product);

            
            foreach (CartItem cartItem in cart.getAll())
                price += cartItem.Product.Price;

            labelPrice.Text = $"Цена: {price.ToString()}";
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxUserCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
