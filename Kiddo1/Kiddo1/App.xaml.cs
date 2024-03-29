﻿using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Kiddo1.Views;
using Kiddo1.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Kiddo1
{
    public partial class App
    {

        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) 
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer) {
                    }

        protected override async void OnInitialized()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTYwNDIxQDMxMzcyZTMzMmUzMERsRlcwVGpBMG55a0szZkIzaHNWclJ5SE00SFhGTEltWmtRbFcxci8wRUU9");

            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/ToDoListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ToDoListPage, ToDoListPageViewModel>();
            containerRegistry.RegisterForNavigation<NewTaskPage, NewTaskPageViewModel>();
            containerRegistry.RegisterForNavigation<EditProfilePage, EditProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<ScorePage, ScorePageViewModel>();
            containerRegistry.RegisterForNavigation<BlockPage, BlockPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
        }
    }
}
