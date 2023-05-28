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
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        BibliotekaContext biblioteka = new BibliotekaContext();

        private void RegistButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            User user = new User();

            user.Login = LogText.Text;
            user.Password = Convert.ToInt32(PassText.Password);
            user.RoleId = 3;

            biblioteka.Users.Add(user);
            biblioteka.SaveChanges();
            MessageBox.Show("Пользователь успешно зарегистрован");
            Close();

        }
    }
}
