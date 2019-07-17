using INaBit.Controls;
using INaBit.ViewModel;
using INaBit.ViewModel.Posts;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace INaBit
{
    static class StaticVar
    {
        public delegate void SetView(UserControl control);
        public delegate void Back();


        public static string NickName;

        public static SetView setView;
        public static Back back;
        public static Back HideBackground;

        public static PostsViewModel postsViewModel = new PostsViewModel();
        public static LoginControlViewModel loginViewModel = new LoginControlViewModel();
        public static MainViewModel mainViewModel = new MainViewModel();
        public static NormalPostViewModel AppListViewModel = new NormalPostViewModel();
        public static NormalPostViewModel WebListViewModel = new NormalPostViewModel();
        public static NormalPostViewModel IdeaListViewModel = new NormalPostViewModel();

    
        public static WebListControl webList = new WebListControl();
        public static AppListControl appList = new AppListControl();
        public static IdeaListControl ideaList = new IdeaListControl();


        public static void RefreshAll()
        {
            AppListViewModel.Items = AppListViewModel.Items;
            WebListViewModel.Items = WebListViewModel.Items;
            IdeaListViewModel.Items = IdeaListViewModel.Items;
        }

        public static void RefreshAppList(int constidx,int Recommand)
        {
            var temp = AppListViewModel.Items.Where(x => x.viewModel.ConstIdx == constidx).FirstOrDefault();
            if(temp == null)
            {
                MessageBox.Show("오류");
                return;
            }
            temp.viewModel.Recommand = Recommand;
        }

        public static void SortAppList()
        {
            var Backup = new ObservableCollection<Controls.Posts.NormalPostItemControl>();

            for(int i = 0; i < AppListViewModel.Items.Count; i++)
            {
                Backup.Add(AppListViewModel.Items[i]);
            }

            var newItem = new ObservableCollection<Controls.Posts.NormalPostItemControl>(
                AppListViewModel.Items.OrderByDescending(x => x.viewModel.Recommand));

            for(int i = 0; i < AppListViewModel.Items.Count; i++)
            {
                newItem[i].viewModel = Backup[i].viewModel;
                newItem[i].viewModel.Idx = (i + 1);
            }

            AppListViewModel.Items = newItem;
            
        }
        public static void SortWebList()
        {

        }
        public static void SortIdeaList()
        {

        }
    }
}
