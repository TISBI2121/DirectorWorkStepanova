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
using System.Windows.Navigation;
using System.Windows.Shapes;
using NaitiKino.Models;

namespace N.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            //public static NaitiKinoEntities DB = new NaitiKinoEntities();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.NaitiKino.FirstOrDefault(x => x.Login == UserName.Text && x.Password == Password.Text);
            if (loggedUser == null)
            {
                MessageBox.Show("Логин или пароль неверный");
                return;
            }
            App LoggedUser = loggedUser;
            NavigationService.Navigate(new MainPage());
                
        }

        private void OnRegButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
