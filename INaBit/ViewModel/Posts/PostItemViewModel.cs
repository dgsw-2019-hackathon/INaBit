using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace INaBit.ViewModel.Posts
{
    class PostListItem : ListViewItem , INotifyPropertyChanged
    {
        private string _category;
        public string Category
        {
            get => _category;
            set
            {
                _category = value;
                NotifyProeprtyChanged(nameof(Category));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void NotifyProeprtyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
