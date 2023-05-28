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
    /// Логика взаимодействия для LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        BibliotekaContext biblioteka = new BibliotekaContext();
        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            biblioteka = new BibliotekaContext();

            User user = biblioteka.Users.FirstOrDefault(o => o.Password == Convert.ToInt32(PassText.Password) && o.Login == LogText.Text);

           if(user != null)
            {
                Cart.CurrentUserID = user.Id;

                if(user.RoleId == 1) {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.ShowDialog();
                }

                if(user.RoleId == 2)
                {
                    SotrWindow sotrWindow = new SotrWindow();
                    sotrWindow.ShowDialog();
                }

                if (user.RoleId == 3)
                {
                    UserWindow userWindow = new UserWindow();
                    userWindow.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Что-то пошло не так. Повторите позднее");
            }
        }

        private void JustLogButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow();
            userWindow.ShowDialog();

        }

        private void RegistButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow();
            registrWindow.ShowDialog();
        }
    }
}
