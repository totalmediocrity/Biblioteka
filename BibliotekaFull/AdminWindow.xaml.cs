using BibliotekaFull.context;
using BibliotekaFull.models;
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
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotekaFull
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

            ItemProd.ItemsSource = biblioteka.Products.ToList();

        }

        BibliotekaContext biblioteka = new BibliotekaContext();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            Product product = new Product();

            try
            {
                product.Name = NameProd.Text;
                product.Cost = Convert.ToDecimal(CostProd.Text);
                product.Descrip = DescripProd.Text;

                MemoryStream mem = new MemoryStream();
                JpegBitmapEncoder jpeg = new JpegBitmapEncoder();
                jpeg.Frames.Add(BitmapFrame.Create((ImageProd.Source as BitmapImage)));
                jpeg.Save(mem);

                product.Image = mem.ToArray();

                biblioteka.Add(product);
                biblioteka.SaveChanges();
                ItemProd.ItemsSource = biblioteka.Products.ToList();
            }
            catch
            {
                MessageBox.Show("Какое-то поле пустое, сомневаюсь, что дальше это будет работать. Но как знать");
            };
        }

        private void EditProdButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            if (ItemProd.SelectedItem != null)
            {
                try
                {
                    Product product = (Product)ItemProd.SelectedItem;

                    product.Name = NameProd.Text;
                    product.Cost = Convert.ToDecimal(CostProd.Text);
                    product.Descrip = DescripProd.Text;

                    MemoryStream mem = new MemoryStream();
                    JpegBitmapEncoder jpeg = new JpegBitmapEncoder();
                    jpeg.Frames.Add(BitmapFrame.Create((ImageProd.Source as BitmapImage)));
                    jpeg.Save(mem);

                    product.Image = mem.ToArray();

                    biblioteka.Products.Update(product);
                    biblioteka.SaveChanges();
                    ItemProd.ItemsSource = biblioteka.Products.ToList();
                }
                catch
                {
                    MessageBox.Show("Какое-то поле пустое, сомневаюсь, что дальше это будет работать. Но как знать");
                };
            }
            else
            {
                MessageBox.Show("Вначале выберите поле с товаром для редактирования");
            }
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            if (ItemProd.SelectedItem != null)
            {

                Product product = (Product)ItemProd.SelectedItem;
                biblioteka.Products.Remove(product);
                biblioteka.SaveChanges();
                ItemProd.ItemsSource = biblioteka.Products.ToList();
            }
            else
            {
                MessageBox.Show("Вначале выберите поле с товаром для удаления");
            }

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Black Tea|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                ImageProd.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void ShowOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.ShowDialog();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemProd.SelectedItem != null)
            {
                Product product = (Product)ItemProd.SelectedItem;

                NameProd.Text = product.Name;
                CostProd.Text = product.Cost.ToString();
                DescripProd.Text = product.Descrip;

                BitmapImage bitmapImage = new BitmapImage();
                MemoryStream mem = new MemoryStream(product.Image);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = mem;
                bitmapImage.EndInit();

                ImageProd.Source = bitmapImage as ImageSource;
            }
        }
    }
}
