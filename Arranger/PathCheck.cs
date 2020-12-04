using Arranger.Data;
using Arranger.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Arranger
{
   public class PathCheck
    {
        public PathCheck()
        {
            items.Path = "";
            items.Valid = false;
            
            welcome();
            
        }
        public void welcome()
        {
           

            Console.WriteLine("This Application will help you to arrange your files");
         
            Console.WriteLine();
            
            Console.WriteLine("1.Documents");
            Console.WriteLine("2.Videos");
            Console.WriteLine("3.Images");
            Console.WriteLine();
            Console.Write("Pick -> ");
            var o = Console.ReadLine();
            switch (o)
            {
                case "1":
                    items.Choice = "Documents";
                    Document();
                    break;
                case "2":
                    items.Choice = "Videos";
                    Document();
                    break;
                case "3":
                    items.Choice = "Images";
                    Document();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    welcome();
                    break;

            }
            

        }

        public void Document()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pick the location you want to arrange or input the path");
            Console.WriteLine();
            Console.WriteLine("1.Documents");
            Console.WriteLine("2.Downloads");
            Console.WriteLine("3.Desktop");
            Console.WriteLine("4.Other");
            Console.WriteLine("5.Back");
            Console.WriteLine();
            Console.Write("Pick -> ");
            var doc = Console.ReadLine();
            
            switch (doc)
            {
                case "1":
                    Documents();

                    break;
                case "2":
                    Downloads();
                    break;
                case "3":
                    Desktop();
                    break;
                case "4":
                    ManualPath();
                    break;
                case "5":
                    Back();
                    break;

            }
        }
        public void Back()
        {
            Console.Clear();
            welcome();
        }
        public void Documents()
        {
            
            string uname = Environment.UserName;
            items.Path = @$"C:\Users\{uname}\Documents";
            items.Valid = true;
        }
        public void Downloads()
        {
            string uname = Environment.UserName;
            items.Path = @$"C:\Users\{uname}\Downloads";
            items.Valid = true;
        }
        public void Desktop()
        {
            string uname = Environment.UserName;
            items.Path = @$"C:\Users\{uname}\Desktop";
            items.Valid = true;
        }
        public async void ManualPath()
        {
            

            Console.ForegroundColor = ConsoleColor.White;
            Scan sc = new Scan();
            Console.Write("Enter the path: ");
            var path = Console.ReadLine();
            
            var res = await sc.Check_Path(path);
            if(path == "q")
            {
                Environment.Exit(0);
            }
            items.Path = path;

            while (res == false)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(path + " Error path not found");
                
                ManualPath();
                break;
            }
            items.Valid = true;
            




        }
       

        
       

       
    }
}
