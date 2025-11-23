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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for PagePics.xaml
    /// </summary>
    public partial class PagePics : Page
    {
        public PagePics()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PListView(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new PageListView());
        }

        private void PCalander(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new PageCalender());
        }

        private void PText(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new PageText());
        }
    }
}
