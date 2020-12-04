using Arranger.Data;
using Arranger.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Arranger
{
    public class Coppier
    {

        public List<string> list { get; set; }


        public async void Cop()
        {
            try
            {

                //Return the documents list and create a Folder named 'Arranger'
                //Move all the documents to arranger folder 
                Console.Clear();
                Console.WriteLine("Please wait...");
                Console.WriteLine();
                Scan sc = new Scan();
                string pathname = "";
                
                switch (items.Choice)
                {
                    case "Documents":

                        list = await sc.DocList();
                        pathname = "Documents";

                        break;
                    case "Videos":
                        list = await sc.VidList();
                        pathname = "Videos";
                        break;
                    case "Images":
                        list = await sc.ImgList();
                        pathname = "Images";
                        break;

                }
             
                string fullPath = items.Path + $"\\Arranger{pathname}\\";
                string filename = "";

                string ext = "";

                foreach (var i in list)
                {


                    Directory.CreateDirectory(fullPath + Path.GetExtension(i).Substring(1).ToUpper());

                    filename = Path.GetFileName(i);

                    ext = Path.GetExtension(i);

                    

                    if(items.Choice == "Documents")
                    {
                        string[] ps = { "txt", "docx", "doc", "xls", "xlsx", "ppt", "pptx,", "pdf" };
                        switch (ext)
                        {
                            case ".txt":
                                File.Copy(i, Path.Combine(fullPath + ps[0].ToString(), filename), true);
                                break;
                            case ".docx":
                                File.Copy(i, Path.Combine(fullPath + ps[1].ToString(), filename), true);
                                break;
                            case ".doc":
                                File.Copy(i, Path.Combine(fullPath + ps[2].ToString(), filename), true);
                                break;
                            case ".xls":
                                File.Copy(i, Path.Combine(fullPath + ps[3].ToString(), filename), true);
                                break;
                            case ".xlsx":
                                File.Copy(i, Path.Combine(fullPath + ps[4].ToString(), filename), true);
                                break;
                            case ".ppt":
                                File.Copy(i, Path.Combine(fullPath + ps[5].ToString(), filename), true);
                                break;
                            case ".pptx":
                                File.Copy(i, Path.Combine(fullPath + ps[6].ToString(), filename), true);
                                break;
                            case ".pdf":
                                File.Copy(i, Path.Combine(fullPath + ps[7].ToString(), filename), true);
                                break;
                        }
                    }
                    if(items.Choice == "Videos")
                    {
                        string[] ps = { "mp4", "flv", "avi", "mkv", "vob", "wmv" };
                        switch (ext)
                        {
                            case ".mp4":
                                File.Copy(i, Path.Combine(fullPath + ps[0].ToString(), filename), true);
                                break;
                            case ".flv":
                                File.Copy(i, Path.Combine(fullPath + ps[1].ToString(), filename), true);
                                break;
                            case ".avi":
                                File.Copy(i, Path.Combine(fullPath + ps[2].ToString(), filename), true);
                                break;
                            case ".mkv":
                                File.Copy(i, Path.Combine(fullPath + ps[3].ToString(), filename), true);
                                break;
                            case ".vob":
                                File.Copy(i, Path.Combine(fullPath + ps[4].ToString(), filename), true);
                                break;
                            case ".wmv":
                                File.Copy(i, Path.Combine(fullPath + ps[5].ToString(), filename), true);
                                break;

                        }
                    }
                    if(items.Choice == "Images")
                    {
                        string[] ps = { "bimp", "jpg", "jpeg", "gif", "png" };
                        switch (ext)
                        {
                            case ".bimp":
                                File.Copy(i, Path.Combine(fullPath + ps[0].ToString(), filename), true);
                                break;
                            case ".jpg":
                                File.Copy(i, Path.Combine(fullPath + ps[1].ToString(), filename), true);
                                break;
                            case ".jpeg":
                                File.Copy(i, Path.Combine(fullPath + ps[2].ToString(), filename), true);
                                break;
                            case ".gif":
                                File.Copy(i, Path.Combine(fullPath + ps[3].ToString(), filename), true);
                                break;
                            case ".png":
                                File.Copy(i, Path.Combine(fullPath + ps[4].ToString(), filename), true);
                                break;
                            

                        }
                    }
                    





                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine(Path.GetFileName(i));


                }


                Console.Clear();

                Console.WriteLine($"Success...Please check the folder named Arranger{pathname}");

                Console.WriteLine();
                Console.WriteLine("Press enter to exit.");

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());
            }
        }

    }
}
