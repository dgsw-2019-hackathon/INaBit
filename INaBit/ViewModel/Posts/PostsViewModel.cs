using INaBit.Controls.Posts;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INaBit.ViewModel.Posts
{
    class PostsViewModel : BindableBase
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
        }

    }
}
