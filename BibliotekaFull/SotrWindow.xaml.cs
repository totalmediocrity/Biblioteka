using BibliotekaFull.context;
using BibliotekaFull.models;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для SotrWindow.xaml
    /// </summary>
    public partial class SotrWindow : Window
    {
        public SotrWindow()
        {
            InitializeComponent();

            ItemProd.ItemsSource = biblioteka.Products.ToList();

            if (Cart.Products.Count > 0)
            {
                ShowButton.IsEnabled = true;
            }
        }

        BibliotekaContext biblioteka = new BibliotekaContext();
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (ItemProd.SelectedItem != null)
            {
                ShowButton.IsEnabled = true;
                Product product = (Product)ItemProd.SelectedItem;

                OrderProduct orderProduct = new OrderProduct();
                orderProduct.Product = product;
                orderProduct.Count = 1;

                Cart.Products.Add(orderProduct);
                MessageBox.Show("Товар добавлен");
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.ShowDialog();
        }

        private void ItemProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemProd.SelectedItem != null)
            {
                Product product = (Product)ItemProd.SelectedItem;

                BitmapImage bitmapImage = new BitmapImage();
                MemoryStream mem = new MemoryStream(product.Image);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = mem;
                bitmapImage.EndInit();

                ImageProd.Source = bitmapImage as ImageSource;
            }
        }

        private void ShowAllOrderButton_Click(object sender, RoutedEventArgs e)
        {
            AllOrderShowWindow allOrderShowWindow = new AllOrderShowWindow();
            allOrderShowWindow.ShowDialog();
        }
    }
}
