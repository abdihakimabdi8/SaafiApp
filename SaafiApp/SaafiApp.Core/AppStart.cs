﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using SaafiApp.Core.Contracts.Services;
using SaafiApp.Core.ViewModels;

namespace SaafiApp.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public async void Start(object hint = null)
        {
            //hardcoded login for this demo
            var userService = Mvx.Resolve<IUserDataService>();
            await userService.Login("gillcleeren", "123456");

            ShowViewModel<MainViewModel>();
        }
    }
}
