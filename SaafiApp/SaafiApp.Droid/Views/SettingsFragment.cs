﻿using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using SaafiApp.Core.ViewModel;
using SaafiApp.Droid.Activities;
using SaafiApp.Droid.Extensions;

namespace SaafiApp.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("saafiapp.views.SettingsFragment")]
    public class SettingsFragment : MvxFragment<SettingsViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.SettingsView, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            (Activity as MainActivity).SetCustomTitle("Settings");
        }
    }
}