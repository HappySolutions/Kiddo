using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Kiddo1.Infrastructure;

namespace Kiddo1.ViewModels
{
    public class NotificationsPageViewModel : AppMapViewModelBase
    {


        public NotificationsPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
