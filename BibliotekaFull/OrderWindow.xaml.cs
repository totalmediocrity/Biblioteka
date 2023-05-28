using BibliotekaFull.context;
using BibliotekaFull.models;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotekaFull
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();

            AddressProd.ItemsSource = biblioteka.Addresses.ToList();
            AddressProd.DisplayMemberPath = "Address1";

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

                order.AddressId = address.Id;
                order.Date = DateTime.Now;
                order.UserId = Cart.CurrentUserID;

                foreach (var orderProduct in Cart.Products)
                {
                    orderProduct.ProductId = orderProduct.Product.Id;
                    orderProduct.Product = null;

                }

                order.OrderProducts = Cart.Products;
                biblioteka.Add(order);
                biblioteka.SaveChanges();
                MessageBox.Show("Заказ создан");
                GeneratePDF(order.Id);
                Close();
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ItemProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ItemProd.SelectedItem != null)
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

        private void GeneratePDF(int Id)
        {
            biblioteka = new BibliotekaContext();

            Order order = biblioteka.Orders.Include(o => o.Address).Include(o => o.OrderProducts).ThenInclude(o => o.Product).FirstOrDefault(o => o.Id == Id);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "palka|*.pdf";
            if (saveFileDialog.ShowDialog() == true)
            {
                PdfWriter pdf = new PdfWriter(saveFileDialog.FileName);
                PdfDocument pdfdoc = new PdfDocument(pdf);
                Document joke = new Document(pdfdoc);
                var font = PdfFontFactory.CreateFont(@"C:\Windows\Fonts\Arial.ttf");
                joke.SetFont(font);
                joke.Add(new Paragraph("Номер заказа № " + order.Id.ToString()));
                joke.Add(new Paragraph(order.Address.Address1));

                Random random = new Random();
                joke.Add(new Paragraph("Номер талончика " + random.Next(100,999).ToString()));
                foreach (OrderProduct op in order.OrderProducts)
                {
                    joke.Add(new Paragraph(op.Product.Name + " " + op.Count.ToString() + "шт. " + op.Product.Cost.ToString() + "руб."));
                }

                joke.Close();

            }
        }
    }
}
