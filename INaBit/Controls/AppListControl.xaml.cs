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

namespace INaBit.Controls
{
    /// <summary>
    /// AppListControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AppListControl : UserControl
    {
        public AppListControl()
        {
            InitializeComponent();
            if(App.normalPost == null)
            {
                App.normalPost = new ViewModel.Posts.NormalPostViewModel();
                if (App.normalPost == null)
                {
                    MessageBox.Show("널");
                }
                else
                {
                    App.normalPost.Items.Add(new Posts.NormalPostItemControl());
                    App.normalPost.Items.Add(new Posts.NormalPostItemControl());
                    App.normalPost.Items.Add(new Posts.NormalPostItemControl());
                    App.normalPost.Items.Add(new Posts.NormalPostItemControl());
                    App.normalPost.Items[0].viewModel.Idx = 1;
                    App.normalPost.Items[0].viewModel.Title = "MFC 정말 훌륭한 라이브러리에요^^";
                    App.normalPost.Items[1].viewModel.Idx = 2;
                    App.normalPost.Items[2].viewModel.Idx = 3;
                }
            }
            this.DataContext = App.normalPost;
        }
    }
}
