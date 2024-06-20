using exam.controllers;
using exam.models;
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

namespace exam.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAutorizate.xaml
    /// </summary>
    public partial class PageAutorizate : Page
    {
        private AutorizateController _autorizateController;
        public PageAutorizate()
        {
            InitializeComponent();
            _autorizateController = new AutorizateController();

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            string login = TxbLogin.Text;
            string password = TxbPassword.Text;
            FrameNavigate.user = _autorizateController.FindUserByLoginAndPassword(login, password);
            switch (FrameNavigate.user.UserRoleId)
                {
                case 1:
                    FrameNavigate.frame.Navigate(new PageClient());
                    break;
                case 2:
                    FrameNavigate.frame.Navigate(new PageMaster());
                    break;
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
