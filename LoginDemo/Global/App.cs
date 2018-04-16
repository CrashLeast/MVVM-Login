using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using LoginDemo.ViewModel;

namespace LoginDemo
{
    public static class App
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    _locator = new ViewModelLocator();
                }
                return _locator;
            }
        }
    }
}