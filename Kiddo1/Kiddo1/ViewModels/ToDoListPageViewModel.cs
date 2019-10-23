using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Kiddo1.Infrastructure;
using Kiddo1.Views;

namespace Kiddo1.ViewModels
{
    public class ToDoListPageViewModel : AppMapViewModelBase
    {
        
        public ToDoListPageViewModel(INavigationService navigationService) : base (navigationService)
        {
            
        }
        

    }
}
