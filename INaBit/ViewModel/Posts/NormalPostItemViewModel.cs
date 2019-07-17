using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace INaBit.ViewModel.Posts
{
    public class NormalPostItemViewModel : BindableBase
    {
        private string _webUri;
        public string WebUri
        {
            get => _webUri;
            set => SetProperty(ref _webUri, value);
        }

        private int _constIdx;
        public int ConstIdx
        {
            get => _constIdx;
            set => SetProperty(ref _constIdx, value);
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
        private int _idx;
        public int Idx
        {
            get => _idx;
            set => SetProperty(ref _idx, value);
        }

        private int _recommand = 0;
        public int Recommand
        {
            get => _recommand;
            set => SetProperty(ref _recommand, value);
        }

        private string _content;
        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public ICommand OnRecommandCommand { get; set; }
        public ICommand GotoSiteCommand { get; set; }

        public NormalPostItemViewModel()
        {
            OnRecommandCommand = new DelegateCommand(OnRecommand);
            GotoSiteCommand = new DelegateCommand(GotoSite);
        }

        private void GotoSite()
        {
            Process.Start(new ProcessStartInfo(WebUri));
        }

        private void OnRecommand()
        {
            MessageBox.Show("추천하셨습니다.");    
            Recommand++;
            StaticVar.RefreshAppList(ConstIdx, Recommand);
            StaticVar.SortAppList();
            StaticVar.SortWebList();
            StaticVar.SortIdeaList();
        }
    }
}
