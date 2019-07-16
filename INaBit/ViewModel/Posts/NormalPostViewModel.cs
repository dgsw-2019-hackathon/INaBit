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
    public class NormalPostViewModel : BindableBase
    {
        private ObservableCollection<NormalPostItemControl> _items = new ObservableCollection<NormalPostItemControl>();
        public ObservableCollection<NormalPostItemControl> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

    }
}
