using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INaBit.ViewModel.Posts
{
    class PostItemViewModel : BindableBase
    {
        private string _category;
        public string Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }

    }
}
