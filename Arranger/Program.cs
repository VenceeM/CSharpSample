using System;
using System.IO;
using Arranger.Data;
using Arranger.Model;

namespace Arranger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Document arranger";

            PathCheck pc = new PathCheck();
            
           
            if(items.Valid == true)
            {
                if(items.Choice == "Documents")
                {
                    Console.Clear();
                    
                   
                    Coppier cp = new Coppier();
                    cp.Cop();
                    
                   
                }
                if(items.Choice == "Videos")
                {
                    
                    Coppier cp = new Coppier();
                    cp.Cop();
                }
                if(items.Choice == "Images")
                {
                    
                    Coppier cp = new Coppier();
                    cp.Cop();

                }
              
                
                
            }
           
            Console.ReadLine();
           
        }

     

       

    }
}
