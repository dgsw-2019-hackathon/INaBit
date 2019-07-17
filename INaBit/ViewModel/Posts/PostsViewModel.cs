using INaBit.Controls;
using INaBit.Controls.Posts;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace INaBit.ViewModel.Posts
{
    public class PostsViewModel : BindableBase
    {
        private ObservableCollection<PostItemControl> _items;
        public ObservableCollection<PostItemControl> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public PostsViewModel()
        {
            Items = new ObservableCollection<PostItemControl>();
            Items.Add(new PostItemControl());
            Items.Add(new PostItemControl());
            Items.Add(new PostItemControl());
            Items[0].viewModel.Category = "아이디어";
            Items[1].viewModel.Category = "유용한 앱";
            Items[2].viewModel.Category = "유용한 웹";
            Items[0].viewModel.Title = "좋은 아이디어 공유합니다.";
            Items[1].viewModel.Title = "이 앱 유용하네요. 추천합니다.";
            Items[2].viewModel.Title = "웹 추천합니다.";
            Items[0].control = new WebPostControl();
            Items[1].control = new WebPostControl();
            Items[2].control = new WebPostControl();
            (Items[0].control as WebPostControl).imgImage.Source = new BitmapImage(new Uri("/디자인/BasePicture.jpeg", UriKind.Relative));
            (Items[1].control as WebPostControl).imgImage.Source = new BitmapImage(new Uri("/디자인/screen_close.png", UriKind.Relative));
            (Items[2].control as WebPostControl).imgImage.Source = new BitmapImage(new Uri("/디자인/screen2.png", UriKind.Relative));
            Items[0].control.DataContext = new PostItemViewModel() { Recommand = 3827,Content = "반짝이는 아이디어입니다." ,Title = Items[0].viewModel.Title};
            Items[1].control.DataContext = new PostItemViewModel() { Recommand = 7271 , Content = "앙 기모찌", Title = Items[1].viewModel.Title };
            Items[2].control.DataContext = new PostItemViewModel() { Recommand = 5261 , Content = "데헷", Title = Items[2].viewModel.Title };
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].viewModel.Writer = "DGSW" + (i+1).ToString();
            }

        }

    }
}
