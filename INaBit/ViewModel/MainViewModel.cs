using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace INaBit.ViewModel
{
    public class MainViewModel : BindableBase
    {
        public ICommand IdeaPageCommand { get; set; }
        public ICommand WebPageCommand { get; set; }
        public ICommand AppPageCommand { get; set; }

        public MainViewModel()
        {
            IdeaPageCommand = new DelegateCommand(IdeaPage);
            WebPageCommand = new DelegateCommand(WebPage);
            AppPageCommand = new DelegateCommand(AppPage);
        }

        private void AppPage()
        {
            
        }

        private void WebPage()
        {
            
        }

        private void IdeaPage()
        {
            
        }
    }
}
