using System;
using Android.App;
using Android.OS;
using Android.Widget;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using LoginDemo.ViewModel;

namespace LoginDemo
{
    [Activity(Label = "LoginDemo", MainLauncher = true)]
    class LoginActivity:ActivityBase
    {
        private EditText mEtName;
        private EditText mEtPassword;
        private Button mBtnLogin;

        public LoginViewModel VM
        {
            get { return App.Locator.Login; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            init();

        }

        private void init()
        {
            initViews();
            initEvent();
        }

        private void initViews()
        {
            mEtName = FindViewById<EditText>(Resource.Id.et_name);
            mEtPassword = FindViewById<EditText>(Resource.Id.et_password);
            mBtnLogin = FindViewById<Button>(Resource.Id.btn_login);
        }

        private void initEvent()
        {
            this.SetBinding(() => VM.User.Name, mEtName, () => mEtName.Text, BindingMode.TwoWay);
            this.SetBinding(() => VM.User.Password, mEtPassword, () => mEtPassword.Text, BindingMode.TwoWay);

            //button click
            mBtnLogin.SetCommand("Click", VM.LoginCommand);
        }

    }
}