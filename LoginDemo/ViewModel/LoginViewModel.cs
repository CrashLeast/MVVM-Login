
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using LoginDemo.Model.Entity;
using LoginDemo.Model.Implement;

namespace LoginDemo.ViewModel
{
    public class LoginViewModel : ViewModelBase

    {
        private LoginService _loginService;
        private LoginService LoginService
        {
            get
            {
                if (_loginService == null)
                {
                    _loginService = new LoginService();
                }
                return _loginService;
            }
        }

        private User _user;
        public User User
        {
            get
            {
                if (_user == null)
                {
                    _user = new User();
                }
                return _user;
            }
        }

        public RelayCommand LoginCommand
        {
            get
            {
                return new RelayCommand(()=>Login());
            }
        }

        private void Login()
        {
            if (LoginService.Login(this.User))
            {
                var nav = ServiceLocator.Current.GetInstance<INavigationService>();
                nav.NavigateTo("Main");
            }
            else
            {
                var dialog = ServiceLocator.Current.GetInstance<IDialogService>();
                dialog.ShowMessage(
                    "check your name and password",
                    "infomation",
                    "OK",
                    null);
            }
        }
    }
}