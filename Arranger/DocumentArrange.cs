using Arranger.Data;
using Arranger.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Arranger
{
    public class DocumentArrange
    {
       // public List<string> docList { get; set; }
       
        

        public void listDoc()
        {

            Coppier cp = new Coppier();
            cp.Cop();

            #region Old
            //try
            //{
            //    //Return the documents list and create a Folder named 'Arranger'
            //    //Move all the documents to arranger folder 
            //    Console.WriteLine("Please wait...");
            //    Console.WriteLine();
            //    Scan sc = new Scan();
            //    docList = await sc.DocList();
            //    string fullPath = items.Path + "\\ArrangerDocuments\\";
            //    string filename = "";

            //    string ext = "";

            //    foreach (var i in docList)
            //    {


            //        Directory.CreateDirectory(fullPath + Path.GetExtension(i).Substring(1).ToUpper());

            //        filename = Path.GetFileName(i);

            //        ext = Path.GetExtension(i);

            //        string[] ps = { "txt", "docx", "doc", "xls", "xlsx", "ppt", "pptx,", "pdf" };
            //        switch (ext)
            //        {
            //            case ".txt":
            //                File.Copy(i, Path.Combine(fullPath + ps[0].ToString(), filename), true);
            //                break;
            //            case ".docx":
            //                File.Copy(i, Path.Combine(fullPath + ps[1].ToString(), filename), true);
            //                break;
            //            case ".doc":
            //                File.Copy(i, Path.Combine(fullPath + ps[2].ToString(), filename), true);
            //                break;
            //            case ".xls":
            //                File.Copy(i, Path.Combine(fullPath + ps[3].ToString(), filename), true);
            //                break;
            //            case ".xlsx":
            //                File.Copy(i, Path.Combine(fullPath + ps[4].ToString(), filename), true);
            //                break;
            //            case ".ppt":
            //                File.Copy(i, Path.Combine(fullPath + ps[5].ToString(), filename), true);
            //                break;
            //            case ".pptx":
            //                File.Copy(i, Path.Combine(fullPath + ps[6].ToString(), filename), true);
            //                break;
            //            case ".pdf":
            //                File.Copy(i, Path.Combine(fullPath + ps[7].ToString(), filename), true);
            //                break;
            //        }


                   


            //        System.Threading.Thread.Sleep(300);
            //        Console.WriteLine(Path.GetFileName(i));


            //    }


            //    Console.Clear();
            //    Console.WriteLine("Success...Please check the folder named ArrangerDocuments");
            //    Console.WriteLine();
            //    Console.WriteLine("Press enter to exit.");

            //}catch(Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write(ex.Message.ToString());
            //}

            #endregion




        }


    }
}
