using INaBit.ViewModel;
using INaBit.ViewModel.Posts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace INaBit
{ 
    /// <summary>
    /// StaticVarxaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public delegate void SetView(UserControl control);
        public delegate void Back();


        public static string NickName;

        public static SetView setView;
        public static Back back;

        public static PostsViewModel postsViewModel = new PostsViewModel();
        public static LoginControlViewModel loginViewModel = new LoginControlViewModel();
        public static MainViewModel mainViewModel = new MainViewModel();
        public static NormalPostViewModel AppListViewModel = new NormalPostViewModel();
        public static NormalPostViewModel WebListViewModel = new NormalPostViewModel();
        public static NormalPostViewModel IdeaListViewModel = new NormalPostViewModel();

        public static void SortAppList()
        {
            AppListViewModel.Items = new ObservableCollection<Controls.Posts.NormalPostItemControl>(
                AppListViewModel.Items.OrderByDescending(x => x.viewModel.Recommand));
            for(int i = 0; i < AppListViewModel.Items.Count; i++)
            {
                AppListViewModel.Items[i].viewModel = new NormalPostItemViewModel();
                AppListViewModel.Items[i].viewModel.Idx = (i + 1);
                MessageBox.Show("정렬");
            }
        }

        public static void SortWebList()
        {

        }

        public static void SortIdeaList()
        {

        }
    }
}
