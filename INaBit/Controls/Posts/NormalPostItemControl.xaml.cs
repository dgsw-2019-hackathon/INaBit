using INaBit.ViewModel.Posts;
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

namespace INaBit.Controls.Posts
{
    /// <summary>
    /// NormalPostItemControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NormalPostItemControl : UserControl
    {
        public NormalPostItemViewModel viewModel;
        public UserControl userControl;
        public NormalPostItemControl()
        {
            InitializeComponent();
            viewModel = new NormalPostItemViewModel();
            this.DataContext = viewModel;
        }
    }
}
