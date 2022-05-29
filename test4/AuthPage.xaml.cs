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

namespace test4
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }


        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            Пользователи users = new Пользователи();

            using(TestEntities usersdb = new TestEntities())
            {
                users = usersdb.Пользователи.Where(p => p.Логин == LoginBox.Text && p.Пароль == PassBox.Text).FirstOrDefault();
            }

            if(users != null)
            {
                MessageBox.Show("Авторизация успешно!");
                Manager.MainFrame.Navigate(new MenuPage());
            }
        }

        private void RegBtnClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RegPage(null));
        }
    }
}
