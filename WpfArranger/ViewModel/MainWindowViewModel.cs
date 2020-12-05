using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfArranger.ViewModel
{
    public class MainWindowViewModel: BaseViewModel
    {

        private HomeViewModel home;
        public MainWindowViewModel()
        {
            home = new HomeViewModel();
            CurrentView = home;
           
        }


        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }



    }
}
