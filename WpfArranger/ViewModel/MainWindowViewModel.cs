using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfArranger.ViewModel
{
    public class MainWindowViewModel: BaseViewModel
    {

        private DocumentsViewModel doc;
        public ICommand docs { get; set; }
        public MainWindowViewModel()
        {
            doc = new DocumentsViewModel();
            docs = new RelayCommand<string>((s) => OnNavigate(s));
           
        }

        private void OnNavigate(string navPath)
        {
            switch (navPath)
            {
                case "Docs":
                    CurrentView = doc;
                    break;
            }
        }
        

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }



    }
}
