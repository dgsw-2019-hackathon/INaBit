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

namespace INaBit
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();
            InitViewControl();
            this.DataContext = App.mainViewModel;
        }

        private void InitViewControl()
        {
            App.loginViewModel.loginDone += LoginDone;
            App.setView += PageView;
            App.back += Back;
        }

        public void LoginDone()
        {
            LoginCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
        }

        public void SetViewMain()
        {
            PageCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
        }

        public void PageView(UserControl control)
        {
            PageGrid.Children.Add(control);
            PageCtrl.Visibility = Visibility.Visible;
            MainCtrl.Visibility = Visibility.Collapsed;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
            PageGrid.Children.Clear();
        }

        private void Back()
        {
            var parent = PageGrid.Children[0];
            PageGrid.Children.Clear();
            PageGrid.Children.Add(parent);
            MessageBox.Show(App.WebListViewModel.Items.Count.ToString());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
