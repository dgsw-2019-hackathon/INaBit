using INaBit.Controls.Posts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.DataContext = StaticVar.mainViewModel;
        }

        private void InitViewControl()
        {
            StaticVar.loginViewModel.loginDone += LoginDone;
            StaticVar.setView += PageView;
            StaticVar.back += Back;
            StaticVar.HideBackground += HideBack;
            StaticVar.joinDone += JoinDone;
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
            SearchCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
            PageGrid.Children.Clear();
        }

        private void HideBack()
        {
            PageGrid.Children[0].Visibility = Visibility.Collapsed;
        }

        private void JoinDone()
        {
            RegisterCtrl.Visibility = Visibility.Collapsed;
            MainCtrl.Visibility = Visibility.Visible;
        }

        private void Back()
        {
            var parent = PageGrid.Children[0];
            PageGrid.Children.Clear();
            PageGrid.Children.Add(parent);
            MessageBox.Show(StaticVar.WebListViewModel.Items.Count.ToString());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            
            OnSearch();
        }
        
        void OnSearch()
        {
            if(tbSearch.Text.Length < 0)
            {
                return;
            }
            string Keyword = tbSearch.Text;
            List<NormalPostItemControl> temp = new List<NormalPostItemControl>();
            var a = StaticVar.AppListViewModel.Items.Where(x => x.viewModel.Title.Contains(Keyword)).ToList();
            foreach(var b in a)
            {
                temp.Add(b);
            }
            var s = StaticVar.IdeaListViewModel.Items.Where(x => x.viewModel.Title.Contains(Keyword)).ToList();
            foreach (var b in s)
            {
                temp.Add(b);
            }
            var d = StaticVar.WebListViewModel.Items.Where(x => x.viewModel.Title.Contains(Keyword)).ToList();
            foreach (var b in d)
            {
                temp.Add(b);
            }
            MainCtrl.Visibility = Visibility.Collapsed;
            SearchCtrl.Visibility = Visibility.Visible;
            if(temp.Count == 0)
            {
                MessageBox.Show("ㅁㄴㅇ");
            }
            foreach (var w in temp)
            {
                SearchControl.lstSearch.Items.Add(w);
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainCtrl.Visibility = Visibility.Collapsed;
            RegisterCtrl.Visibility = Visibility.Visible;
        }
    }
}
