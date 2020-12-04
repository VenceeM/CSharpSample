using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfArranger.ViewModels
{
    public class HomeViewViewModel : BindableBase
    {

        public DelegateCommand<string> cmd { get; set; }
        public HomeViewViewModel()
        {
            cmd = new DelegateCommand<string>(Navigation);
        }

        private void Navigation(string navigationPath)
        {

        }
    }
}
