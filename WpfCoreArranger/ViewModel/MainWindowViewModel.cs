using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCoreArranger.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        private DocumentsViewModel doc;



        public MainWindowViewModel()
        {

            doc = new DocumentsViewModel();

            CurrentView = doc;

        }




        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }



    }
}
