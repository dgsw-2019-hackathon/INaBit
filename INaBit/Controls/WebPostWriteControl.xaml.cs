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
            newItem.viewModel.Title = "Title";
            newItem.viewModel.Writer = App.NickName;
            App.WebListViewModel.Items.Add(newItem);
        }
    }
}

