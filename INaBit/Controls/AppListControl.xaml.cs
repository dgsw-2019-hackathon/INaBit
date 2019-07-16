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
            if(App.AppListViewModel == null)
            {
                App.AppListViewModel = new ViewModel.Posts.NormalPostViewModel();
            }
            this.DataContext = App.AppListViewModel;
            ASD();
        }

        private void ASD()
        {
            if (App.AppListViewModel == null)
            {
                MessageBox.Show("널");
            }
            else
            {
                App.AppListViewModel.Items.Add(new Posts.NormalPostItemControl());
                App.AppListViewModel.Items.Add(new Posts.NormalPostItemControl());
                App.AppListViewModel.Items.Add(new Posts.NormalPostItemControl());
                App.AppListViewModel.Items.Add(new Posts.NormalPostItemControl());
                App.AppListViewModel.Items[0].viewModel.Recommand = 200;
                App.AppListViewModel.Items[0].viewModel.Title = "MFC 정말 훌륭한 라이브러리에요^^";
                App.AppListViewModel.Items[0].viewModel.Writer = "hbmin3789";
                App.AppListViewModel.Items[1].viewModel.Title = "MFC 와는 차원이 다른 라이브러리입니다.";
                App.AppListViewModel.Items[1].viewModel.Writer = "hbmin3789";
                App.AppListViewModel.Items[1].viewModel.Recommand = 500;
                App.AppListViewModel.Items[2].viewModel.Recommand = 700;
                App.AppListViewModel.Items[2].viewModel.Title = "공유 api입니다.";
                App.AppListViewModel.Items[2].viewModel.Writer = "aquayo";
                App.AppListViewModel.Items[2].viewModel.Recommand = 700;
                App.AppListViewModel.Items[3].viewModel.Title = "나니 라이브러리입니다^^";
                App.AppListViewModel.Items[3].viewModel.Writer = "goarosa";
                App.AppListViewModel.Items =
                    new System.Collections.ObjectModel.ObservableCollection<Posts.NormalPostItemControl>(
                        App.AppListViewModel.Items.OrderByDescending(x => x.viewModel.Recommand));
                for (int i = 0; i < App.AppListViewModel.Items.Count; i++)
                {
                    App.AppListViewModel.Items[i].viewModel.Idx = (i + 1);
                }
                App.AppListViewModel.Items[0].control = new WebPostControl();
                App.AppListViewModel.Items[0].control.DataContext = App.AppListViewModel.Items[0].viewModel;
                App.AppListViewModel.Items[1].control = new WebPostControl();
                App.AppListViewModel.Items[2].control = new WebPostControl();
            }
        }
    }
}
