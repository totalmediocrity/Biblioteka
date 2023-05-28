using BibliotekaFull.context;
using BibliotekaFull.models;
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
    /// Логика взаимодействия для AllOrderShowWindow.xaml
    /// </summary>
    public partial class AllOrderShowWindow : Window
    {
        public AllOrderShowWindow()
        {
            InitializeComponent();

            AddressProd.ItemsSource = biblioteka.Addresses.ToList();
            AddressProd.DisplayMemberPath = "Address1";

            Refresh();
        }

        BibliotekaContext biblioteka = new BibliotekaContext();

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            if (ItemProd.SelectedItem != null)
            {
                Order order = (Order)ItemProd.SelectedItem;

                order.AddressId = ((Address)AddressProd.SelectedItem).Id;

                biblioteka.Update(order);
                biblioteka.SaveChanges();
                Refresh();
            }
            else
            {
                MessageBox.Show("Вначале выбор товара, потом реадакирование.Повторите по инструкции");
            }
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            if (ItemProd.SelectedItem != null)
            {
                Order order = (Order)ItemProd.SelectedItem;

               biblioteka.Remove(order);
               biblioteka.SaveChanges();
               Refresh();
            }
            else
            {
                MessageBox.Show("Вначале выбор товара, потом удаление.Повторите по инструкции");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Refresh()
        {
            ItemProd.ItemsSource = null;
            ItemProd.ItemsSource = biblioteka.Orders.ToList();
    
        }

    }
}
