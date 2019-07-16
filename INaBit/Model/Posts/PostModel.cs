using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INaBit.Model.Posts
{
    class PostitemControl : BindableBase
    {
        private string _category = "asd";
        public string Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }
    }
}
