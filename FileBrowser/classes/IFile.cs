using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBrowser.classes
{
    public enum fileType
    {
        directory,
        file
    }

    public interface IFile
    {
        fileType type { get; set; }
        string fileName { get; set; }
        string path { get; set; }
        DirFile parent { get; set; }
        DateTime creatTime { get; set; }
        double? size { get; set; }
    }
}
