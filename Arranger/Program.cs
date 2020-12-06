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
                    
                    DocumentArrange sd = new DocumentArrange();
                    
                    sd.listDoc();
                   
                }
                if(items.Choice == "Videos")
                {
                    VideoArrange vd = new VideoArrange();
                    vd.VideoList();
                }
                if(items.Choice == "Images")
                {
                    ImgArrange img = new ImgArrange();
                    img.listImg();

                }
              
                
                
            }
           
            Console.ReadLine();
           
        }

     

       

    }
}
