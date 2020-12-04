using Arranger.Data;
using Arranger.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Arranger
{
    public class VideoArrange
    {

       // public List<string> vidList;
       

        public void VideoList()
        {
            Coppier cp = new Coppier();
            cp.Cop();

            #region Old
            //try
            //{
                
            //    //Return the documents list and create a Folder named 'Arranger'
            //    //Move all the documents to arranger folder 
            //    Console.Clear();
            //    Console.WriteLine("Please wait...");
            //    Console.WriteLine();
            //    Scan sc = new Scan();
            //    vidList = await sc.VidList();
            //    string fullPath = items.Path + "\\ArrangerVideos\\";
            //    string filename = "";

            //    string ext = "";

            //    foreach (var i in vidList)
            //    {


            //        Directory.CreateDirectory(fullPath + Path.GetExtension(i).Substring(1).ToUpper());

            //        filename = Path.GetFileName(i);

            //        ext = Path.GetExtension(i);

            //        string[] ps = { "mp4", "flv", "avi", "mkv", "vob", "wmv" };
            //        switch (ext)
            //        {
            //            case ".mp4":
            //                File.Copy(i, Path.Combine(fullPath + ps[0].ToString(), filename), true);
            //                break;
            //            case ".flv":
            //                File.Copy(i, Path.Combine(fullPath + ps[1].ToString(), filename), true);
            //                break;
            //            case ".avi":
            //                File.Copy(i, Path.Combine(fullPath + ps[2].ToString(), filename), true);
            //                break;
            //            case ".mkv":
            //                File.Copy(i, Path.Combine(fullPath + ps[3].ToString(), filename), true);
            //                break;
            //            case ".vob":
            //                File.Copy(i, Path.Combine(fullPath + ps[4].ToString(), filename), true);
            //                break;
            //            case ".wmv":
            //                File.Copy(i, Path.Combine(fullPath + ps[5].ToString(), filename), true);
            //                break;
                        
            //        }





            //        System.Threading.Thread.Sleep(300);
            //        Console.WriteLine(Path.GetFileName(i));


            //    }

                
            //    Console.Clear();
              
            //    Console.WriteLine("Success...Please check the folder named ArrangerVideos");
                
            //    Console.WriteLine();
            //    Console.WriteLine("Press enter to exit.");

            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.Message.ToString());
            //}

            #endregion
        }

    }
}
