using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Interaction logic for PageListView.xaml
    /// </summary>
    public partial class PageListView : Page
    {
        public PageListView()
        {
            InitializeComponent();
            List<int> list1 = new List<int> { 100, 90, 140 };
            List<DateTime> list2 = new List<DateTime> { new DateTime(2025, 11, 23), new DateTime(2025, 11, 24), new DateTime(2025, 11, 25) };
            Lv1.ItemsSource = list1;
            Lv2.ItemsSource = list2;
        }

        private void PPics(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new PagePics());
        }

        private void PCalender(object sender, RoutedEventArgs e)
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
