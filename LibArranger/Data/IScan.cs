using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibArranger.Data
{
    public interface IScan
    {
        Task<List<string>> DocList();
        Task<List<string>> VidList();
        Task<List<string>> ImgList();
        Task<bool> Check_Path(string check_path);
    }
}
