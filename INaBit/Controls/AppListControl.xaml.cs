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
            if(StaticVar.AppListViewModel == null)
            {
                StaticVar.AppListViewModel = new ViewModel.Posts.NormalPostViewModel();
            }
            this.DataContext = StaticVar.AppListViewModel;
            initList();
        }

        private void initList()
        {
            if (StaticVar.AppListViewModel == null)
            {
                MessageBox.Show("널");
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    StaticVar.AppListViewModel.Items.Add(new Posts.NormalPostItemControl());
                    StaticVar.AppListViewModel.Items[i].viewModel.ConstIdx = i;
                }
                StaticVar.AppListViewModel.Items[0].viewModel.Recommand = 2;
                StaticVar.AppListViewModel.Items[0].viewModel.Title = "MFC 정말 훌륭한 라이브러리에요^^";
                StaticVar.AppListViewModel.Items[0].viewModel.Writer = "hbmin3789";
                StaticVar.AppListViewModel.Items[1].viewModel.Title = "MFC 와는 차원이 다른 라이브러리입니다.";
                StaticVar.AppListViewModel.Items[1].viewModel.Writer = "hbmin3789";
                StaticVar.AppListViewModel.Items[1].viewModel.Recommand = 3;
                StaticVar.AppListViewModel.Items[2].viewModel.Recommand = 4;
                StaticVar.AppListViewModel.Items[2].viewModel.Title = "공유 api입니다.";
                StaticVar.AppListViewModel.Items[2].viewModel.Writer = "aquayo";
                StaticVar.AppListViewModel.Items[2].viewModel.Recommand = 1;
                StaticVar.AppListViewModel.Items[3].viewModel.Title = "나니 라이브러리입니다^^";
                StaticVar.AppListViewModel.Items[3].viewModel.Writer = "goarosa";
                StaticVar.AppListViewModel.Items =
                    new System.Collections.ObjectModel.ObservableCollection<Posts.NormalPostItemControl>(
                        StaticVar.AppListViewModel.Items.OrderByDescending(x => x.viewModel.Recommand));
                for (int i = 0; i < StaticVar.AppListViewModel.Items.Count; i++)
                {
                    StaticVar.AppListViewModel.Items[i].viewModel.Idx = (i + 1);
                }
                for (int i = 0; i < 4; i++)
                {
                    StaticVar.AppListViewModel.Items[i].control = new WebPostControl();
                    StaticVar.AppListViewModel.Items[i].control.DataContext = StaticVar.AppListViewModel.Items[i].viewModel;
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticVar.setView(new WebPostWriteControl());
        }
    }
}
