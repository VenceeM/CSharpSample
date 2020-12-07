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
        public ICommand fileType { get; set; }
       
        public DocumentsViewModel()
        {


            

            //items.Path = string.Empty;
            fileType = new RelayCommand<string>((s) => FileType(s));
            _commands = new RelayCommand<string>((s) =>  Document(s));
            Title = "Home";
           
        }

      
        private bool valid = false;

        public bool Valid
        {
            get => valid;
            set => SetProperty(ref valid, value);
        }
        private string extension = "";

        public string Extension
        {
            get => extension;
            set => SetProperty(ref extension, value);
        }


        private void FileType(string _fileType = "")
        {
            switch (_fileType)
            {
                case "Documents":
                    Extension = "Documents";
                    Valid = true;
                    break;
                case "Videos":
                    Extension = "Videos";
                    Valid = true;
                    break;
                case "Images":
                    Extension = "Images";
                    Valid = true;
                    break;


                    
            }

        }



        private async void Document(string choice = "")
        {
            await DocumentAsync(choice);
            
        }

        private int count = 0;

        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }
        private string vis = "Hidden";

        public string Vis
        {
            get => vis;
            set => SetProperty(ref vis, value);
        }


        private async Task DocumentAsync(string choice)
        {
            Count = 0;
          
            try
            {
                //items.Choice = "Documents";
                Coppier cp = new Coppier();

                var uname = Environment.UserName;
                switch (choice)
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
                        using (var fbd = new FolderBrowserDialog())
                        {
                            DialogResult result = fbd.ShowDialog();

                            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                            {
                                string folder = fbd.SelectedPath;
                                items.Path = folder;
                            }
                        }
                        break;

                }

                if (items.Path != string.Empty)
                {


                    System.Windows.Forms.MessageBox.Show($"Hit Ok to start copying your files.", "Wait");

                    System.Threading.Thread.Sleep(1000);
                
                    Task t;

                    t =  Task.Run(() => cp.Cop(Extension));
                    Vis = "Visible";
                    while (!t.IsCompleted)
                    {
                        Count++;
                        
                        await Task.Run(() =>
                        {

                            System.Threading.Thread.Sleep(1000);

                            if (t.IsCompleted)
                            {
                                Count = 100;
                            }
                            
                            Console.WriteLine(Count);
                        });
                    
                    }

                    await t.ContinueWith(s =>
                    {
                        System.Windows.Forms.MessageBox.Show($"Folder will open after you hit Ok", "Success");
                        Process.Start(items.FullPath);
                        Vis = "Hidden";
                    });
                    //await t.ContinueWith( s => 
                    //{
                    //    while (!s.IsCompleted)
                    //    {
                    //        Console.WriteLine("SDFSDF");
                    //    }
                    //    System.Windows.Forms.MessageBox.Show($"Folder will open after you hit Ok", "Success");
                    //    Process.Start(items.FullPath);
                    //});
                    
                   

                   





                    //cp.Cop(Extension);

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
