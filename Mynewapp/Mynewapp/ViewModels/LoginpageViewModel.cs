using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Mynewapp.ViewModels
{
	public class LoginpageViewModel : BindableBase
	{
        private INavigationService _navigationService;
        public DelegateCommand mevproduct { get;private set; }
         public LoginpageViewModel(INavigationService navigationService)
        {

            mevproduct = new DelegateCommand(show);

             _navigationService= navigationService;  
        }
        void show()
        {
            _navigationService.NavigateAsync("Productpage");
        }
	}
}
