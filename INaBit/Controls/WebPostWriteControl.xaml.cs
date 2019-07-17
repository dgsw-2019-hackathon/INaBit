using INaBit.Controls.Posts;
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
    /// WebPostWriteControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WebPostWriteControl : UserControl
    {
        public WebPostWriteControl()
        {
            InitializeComponent();
        }

        void OnPostingClicked()
        {
            NormalPostItemControl newItem = new NormalPostItemControl();
            newItem.viewModel.Title = Title.Text;
            newItem.viewModel.Writer = (StaticVar.NickName == null) ? "DGSW": StaticVar.NickName;
            newItem.viewModel.Content = PostContent.Text;
            newItem.control = new WebPostControl();
            newItem.control.DataContext = newItem.viewModel;
            StaticVar.WebListViewModel.Items.Add(newItem);
            StaticVar.back();
            StaticVar.webList.lstListView.Items.Add(newItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnPostingClicked();
        }
    }
}

