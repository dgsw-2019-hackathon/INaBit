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

        private string _id;
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

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
            var idx = StaticVar.ids.Where(x=>x.Equals(Id));
            if(idx == null || StaticVar.ids.Count <= 0)
            {
                MessageBox.Show("존재하지 않는 아이디입니다.");
                return;
            }

            var Idx = StaticVar.ids.IndexOf(Id);
            if (StaticVar.pws[Idx].Equals(Pwd))
            {
                StaticVar.NickName = Id;
                MessageBox.Show("로그인에 성공하였습니다.");
                loginDone?.Invoke();
                return;
            }
            MessageBox.Show("비밀번호를 다시 확인해주세요.");
        }
    }
}
