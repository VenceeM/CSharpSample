using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Arranger.Data
{
    public interface IScan
    {


        Task<List<string>> DocList();
        Task<List<string>> VidList();
        Task<List<string>> ImgList();
        Task<bool> Check_Path(string check_path);
   

    }
}
