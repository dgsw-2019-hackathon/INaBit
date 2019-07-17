using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace INaBit.ViewModel.Posts
{
    public class PostItemViewModel : BindableBase
    {
        private string _category;
        public string Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }

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

        private int _recommand;
        public int Recommand
        {
            get => _recommand;
            set => SetProperty(ref _recommand, value);
        }
        
        public ICommand RecommandCommand { get; set; }
        public PostItemViewModel()
        {
            RecommandCommand = new DelegateCommand(OnRecommand);
        }

        void OnRecommand()
        {
            MessageBox.Show("추천 하셨습니다.");
            Recommand++;
        }
    }
}
