using BibliotekaFull.context;
using BibliotekaFull.models;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotekaFull
{
    /// <summary>
    /// Логика взаимодействия для OrderSotrWindow.xaml
    /// </summary>
    public partial class OrderSotrWindow : Window
    {
        public OrderSotrWindow()
        {
            InitializeComponent();
            AddressProd.ItemsSource = biblioteka.Addresses.ToList();
            AddressProd.DisplayMemberPath = "Address1";

            UserProd.ItemsSource = biblioteka.Users.Where(o => o.RoleId == 3).ToList();
            UserProd.DisplayMemberPath = "Login";

            Refresh();

        }

        BibliotekaContext biblioteka = new BibliotekaContext();
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            if (Cart.Products.Count > 0)
            {
                Order order = new Order();
                Address address = (Address)AddressProd.SelectedItem;
                User user = (User)UserProd.SelectedItem;

                order.AddressId = address.Id;
                order.Date = DateTime.Now;
                order.UserId = user.Id;

                foreach (var orderProduct in Cart.Products)
                {
                    orderProduct.ProductId = orderProduct.Product.Id;
                    orderProduct.Product = null;

                }

                order.OrderProducts = Cart.Products;
                biblioteka.Add(order);
                biblioteka.SaveChanges();
                MessageBox.Show("Заказ создан");
                Close();
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ItemProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemProd.SelectedItem != null)
            {
                OrderProduct product = (OrderProduct)ItemProd.SelectedItem;
                CountProd.Text = product.Count.ToString();
            }
        }

        private void EditCountButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemProd.SelectedItem != null)
            {
                OrderProduct product = (OrderProduct)ItemProd.SelectedItem;
                product.Count = Convert.ToInt32(CountProd.Text);

                Refresh();

            }
        }

        private void Refresh()
        {
            ItemProd.ItemsSource = null;
            ItemProd.ItemsSource = Cart.Products.ToList();
            decimal price = 0;

            foreach (OrderProduct product in Cart.Products)
            {
                price += Convert.ToDecimal(product.Count) + product.Product.Cost;

            }

            CountAllProd.Text = "Стоимость заказа: " + price.ToString();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemProd.SelectedItem != null)
            {
                OrderProduct product = (OrderProduct)ItemProd.SelectedItem;

                Cart.Products.Remove(product);
                Refresh();
            }
        }
    }
}
