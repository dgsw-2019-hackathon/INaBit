using INaBit.Controls.Posts;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace INaBit.ViewModel.Posts
{
    public class NormalPostViewModel : BindableBase
    {
        private ObservableCollection<NormalPostItemControl> _items;
        public ObservableCollection<NormalPostItemControl> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
            
        }

        public NormalPostViewModel()
        {
            Items = new ObservableCollection<NormalPostItemControl>();
        }
    }
}
