using INaBit.Controls.Posts;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INaBit.ViewModel
{
    public class SearchViewModel : BindableBase
    {
        private ObservableCollection<NormalPostItemControl> _items;
        public ObservableCollection<NormalPostItemControl> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public SearchViewModel()
        {
            Items = new ObservableCollection<NormalPostItemControl>();
        }
    }
}
