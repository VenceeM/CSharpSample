using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Arranger.Model;
using System.Linq;
using System.Collections;

namespace Arranger.Data
{
    public class Scan : IScan
    {

        public List<string> list;
        public List<string> vidList;
        public List<string> imgList;
        public async Task<bool> Check_Path(string check_path)
        {
            if (!Directory.Exists(check_path))
            {
                return await Task.FromResult(false);
            }
            else
            {
                return await Task.FromResult(true);
            }
        }

       
        public async Task<List<string>> DocList()
        {
           
            string[] ps = { ".txt", ".docx", ".doc", ".xls", ".xlsx", ".ppt", ".pptx,",".pdf" };
            
            var files = Directory.EnumerateFiles(items.Path, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(ps[0], StringComparison.OrdinalIgnoreCase) || s.EndsWith(ps[1], StringComparison.OrdinalIgnoreCase)
                || s.EndsWith(ps[2], StringComparison.OrdinalIgnoreCase) || s.EndsWith(ps[3], StringComparison.OrdinalIgnoreCase)
                || s.EndsWith(ps[4], StringComparison.OrdinalIgnoreCase) || s.EndsWith(ps[5], StringComparison.OrdinalIgnoreCase)
                || s.EndsWith(ps[6], StringComparison.OrdinalIgnoreCase) || s.EndsWith(ps[7], StringComparison.OrdinalIgnoreCase));
            
            list = new List<string>();

            foreach(var i in files)
            {
                list.Add(i);
            }
            return await Task.FromResult(list);
           
        }
        public async Task<List<string>> VidList()
        {
            string[] list = { ".mp4", ".flv", ".avi", ".mkv", ".vob", ".wmv" };
            var files = Directory.EnumerateFiles(items.Path, "*.*", SearchOption.TopDirectoryOnly)
                .Where(x => x.EndsWith(list[0], StringComparison.OrdinalIgnoreCase) || x.EndsWith(list[1], StringComparison.OrdinalIgnoreCase)
                || x.EndsWith(list[2], StringComparison.OrdinalIgnoreCase) || x.EndsWith(list[3], StringComparison.OrdinalIgnoreCase)
                || x.EndsWith(list[4], StringComparison.OrdinalIgnoreCase) || x.EndsWith(list[5], StringComparison.OrdinalIgnoreCase));
            vidList = new List<string>();
            foreach(var i in files)
            {
                vidList.Add(i);
            }

            return await Task.FromResult(vidList);
        }

        public async Task<List<string>> ImgList()
        {
            string[] list = { ".bimp", ".jpg", ".jpeg", ".gif", ".png"};
            var files = Directory.EnumerateFiles(items.Path, "*.*", SearchOption.TopDirectoryOnly)
                .Where(x => x.EndsWith(list[0], StringComparison.OrdinalIgnoreCase) || x.EndsWith(list[1], StringComparison.OrdinalIgnoreCase)
                || x.EndsWith(list[2], StringComparison.OrdinalIgnoreCase) || x.EndsWith(list[3], StringComparison.OrdinalIgnoreCase)
                || x.EndsWith(list[4], StringComparison.OrdinalIgnoreCase));
            imgList = new List<string>();
            foreach (var i in files)
            {
                imgList.Add(i);
            }

            return await Task.FromResult(imgList);


        }



    }
}
