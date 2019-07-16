using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INaBit.ViewModel.Posts
{
    public class NormalPostItemViewModel : BindableBase
    {
        private string _writer;
        public string Writer
        {
            get => _writer;
            set => SetProperty(ref _writer, value);
        }
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        private int _idx;
        public int Idx
        {
            get => _idx;
            set => SetProperty(ref _idx, value);
        }

        private int _recommand;
        public int Recommand
        {
            get => _recommand;
            set => SetProperty(ref _recommand, value);
        }
    }
}
