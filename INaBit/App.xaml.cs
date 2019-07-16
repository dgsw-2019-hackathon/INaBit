using INaBit.ViewModel;
using INaBit.ViewModel.Posts;
using System;
using System.Collections.Generic;
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
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public delegate void SetView(UserControl control);
        public static SetView setView;

        public static PostsViewModel postsViewModel = new PostsViewModel();
        public static LoginControlViewModel loginViewModel = new LoginControlViewModel();
        public static MainViewModel mainViewModel = new MainViewModel();
        public static NormalPostViewModel normalPost = new NormalPostViewModel();
    }
}
