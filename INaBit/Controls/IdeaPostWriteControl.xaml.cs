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
    /// IdeaPostWriteControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IdeaPostWriteControl : UserControl
    {
        public string filename = null;
        public IdeaPostWriteControl()
        {
            InitializeComponent();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                this.filename = dlg.FileName;
                text1.Text = filename;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NormalPostItemControl newItem = new NormalPostItemControl();
            newItem.viewModel.Title = "";
            newItem.viewModel.Writer = "";
            newItem.viewModel.Recommand = 0;
            newItem.control = this;
            App.IdeaListViewModel.Items.Add(newItem);
        }
    }
}
