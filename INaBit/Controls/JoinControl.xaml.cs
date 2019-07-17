using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INaBit.Controls
{
    /// <summary>
    /// UserControl2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class JoinControl : UserControl
    {
        public JoinControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StaticVar.ids.Where(x => x.Equals(tbId.Text)).FirstOrDefault() != null)
            {
                MessageBox.Show("중복된 아이디입니다.");
                return;
            }
            if (StaticVar.emails.Where(x => x.Equals(tbEmail.Text)).FirstOrDefault() != null)
            {
                MessageBox.Show("중복된 이메일입니다.");
                return;
            }
            StaticVar.users.Add(tbName.Text);
            StaticVar.pws.Add(tbPw.Password);
            StaticVar.ids.Add(tbId.Text);
            StaticVar.emails.Add(tbEmail.Text);
            MessageBox.Show("회원가입에 성공하였습니다.");
            StaticVar.joinDone();
            
        }
    }
}
