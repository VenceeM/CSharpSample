using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibArranger.Model
{
   public class items
    {
        public static bool Valid { get; set; }
        public static string Path { get; set; }
        public static List<string> FileList { get; set; }
        public static long fileSize { get; set; }
        public static string FullPath { get; set; }
        public static string Choice { get; set; }
    }
}
