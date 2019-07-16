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
        }

        private void InitViewControl()
        {
            App.loginViewModel.loginDone += LoginDone;
        }

        public void LoginDone()
        {
            LoginCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
        }
    }
}
