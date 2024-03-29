﻿using INaBit.Controls.Posts;
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
    /// WebListControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WebListControl : UserControl
    {
        public WebListControl()
        {
            InitializeComponent();
            if(StaticVar.WebListViewModel == null)
            {
                StaticVar.WebListViewModel = new ViewModel.Posts.NormalPostViewModel();
            }
            this.DataContext = StaticVar.WebListViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticVar.setView(new WebPostWriteControl());
        }
    }
}
