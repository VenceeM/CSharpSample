using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LibArranger;
using LibArranger.Data;
using LibArranger.Model;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace WpfArranger.ViewModel
{
    public class DocumentsViewModel: BaseViewModel
    {
        
        public ICommand _commands { get; set; }
       
        public DocumentsViewModel()
        {




            //items.Path = string.Empty;

            _commands = new RelayCommand<string>((s) => Document(s));
            Title = "Home";
           
        }
      

        private void Desktop()
        {
            
            //items.Choice = "Desktop";
            var uname = Environment.UserName;
            items.Path = $@"C:\Users\{uname}\Desktop";
            Console.WriteLine("FFFF");
            
        }
        private void Document(string choice = "")
        {
            
            try
            {
                //items.Choice = "Documents";
                Coppier cp = new Coppier();

                var uname = Environment.UserName;
                switch(choice)
                {
                    case "Documents":
                        items.Path = $@"C:\Users\{uname}\Documents";
                        break;
                    case "Downloads":
                        items.Path = $@"C:\Users\{uname}\Downloads";
                        break;
                    case "Desktop":
                        items.Path = $@"C:\Users\{uname}\Desktop";
                        break;
                    case "Other":
                        //items.Path = ManualPath;
                        using(var fbd = new FolderBrowserDialog())
                        {
                            DialogResult result = fbd.ShowDialog();

                            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                            {
                                string folder = fbd.SelectedPath;
                                items.Path = folder;
                            }
                        }
                        break;

                }

                if(items.Path != string.Empty)
                {
                    System.Windows.Forms.MessageBox.Show($"Folder will open after you hit Ok", "Success");
                    System.Threading.Thread.Sleep(1000);
                    cp.Cop("Documents");
                }
             

             
                //Process.Start(items.Path);
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }





        
    }
}
