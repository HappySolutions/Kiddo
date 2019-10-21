using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Kiddo1.Infrastructure;

namespace Kiddo1.ViewModels
{
    public class ProfilePageViewModel : AppMapViewModelBase
    {


        public ProfilePageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
