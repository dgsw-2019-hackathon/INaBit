using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace INaBit.ViewModel
{
    public class LoginControlViewModel : BindableBase
    {
        public delegate void LoginDoneCommand();
        public LoginDoneCommand loginDone;



        public ICommand LoginCommand { get; set; }


        private string _pwd;
        public string Pwd
        {
            get => _pwd;
            set => SetProperty(ref _pwd, value);
        }


        public LoginControlViewModel()
        {
            LoginCommand = new DelegateCommand(OnLogin);
        }

        private void OnLogin()
        {
            
            MessageBox.Show("로그인에 성공하였습니다.");
            loginDone?.Invoke();
        }
    }
}
