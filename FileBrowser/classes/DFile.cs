using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBrowser.classes
{
    public class DFile:IFile
    {
        public DFile(string name, string p,DirFile par, fileType t, DateTime date, double s)
        {
            fileName = name;
            path = p;
            parent = par;
            type = t;
            creatTime = date;
            size = s;
        }

        public string fileName { get; set; }
        public string path { get; set; }
        public fileType type { get; set; }
        public DateTime creatTime { get; set; }
        public DirFile parent { get; set; }
        //public double size { get; set; }

        public double? size { get; set; }


        //public dic MyProperty { get; set; }  // artribute

    }
}
