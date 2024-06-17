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
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        public PageClient()
        {
            InitializeComponent();
            this.GridList.ItemsSource = DbConnection.Examentities.Requests.Where(r => r.ClientId == FrameNavigate.user.id).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.frame.GoBack();
        }
    }
}
