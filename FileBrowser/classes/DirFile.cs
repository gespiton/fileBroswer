using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileBrowser.classes
{
    public class DirFile : IFile
    {
        DirFile(){ }
        DirFile(string name, string p,DirFile par, fileType t)
        {
            fileName = name;
            path = p;
            parent = par;
            type = t;
        }

        DirFile(string name, string p, DirFile par, fileType t,DateTime cT):this(name,p,par,t)
        {
            creatTime = cT;
        }

        #region property
        public string fileName{ get;set;}

        public string path { get; set; }

        public fileType type { get; set; }

        public List<IFile> children { get; set; } = new List<IFile>();

        public DirFile parent { get; set; }
        public DateTime creatTime { get; set; }
        public double? size { get; set; } = null;

        static public List<DirFile> roots { get; set; } = null;
        #endregion


        static public List<DirFile> getRoots()
        {
            if(roots == null)
            {
                roots = new List<DirFile>();
                var r = Directory.GetLogicalDrives();
                foreach (var item in r)
                {
                    Console.WriteLine(item);
                    DirFile buf = new DirFile(item,item,null,fileType.directory);
                    getChildren(buf);
                    roots.Add(buf);
                }
            }
            return roots;
        }
        static public void getChildren(IFile dir)
        {
            var d = dir as DirFile;
            if (d!= null)
            {
                if (d.children.Count!=0)
                {
                    return;
                }
                List<string> files = new List<string>();
                // get files in current directory
                try
                {
                    files = Directory.GetFiles(d.path).ToList();
                }
                catch (Exception)
                {
                }
                foreach (var item in files)
                {
                    var name = item.Substring(item.LastIndexOf("\\")+1);
                    var cTime = File.GetCreationTime(item);
                    var size =(double) new FileInfo(item).Length/1024;


                    d.children.Add(new DFile(name, item,d,fileType.file, cTime, size));
                    //Console.WriteLine(name);
                    //var attr = File.GetAttributes(item);
                    //if ((attr&FileAttributes.Directory)!=0)
                    //{
                    //    Console.WriteLine("--directory");
                    //}
                }
                // get directory in current directory

                List<string> dirs = new List<string>();
                try
                {
                    dirs = Directory.GetDirectories(d.path).ToList();
                }
                catch (Exception)
                {
                }

                foreach (var item in dirs)
                {
                    var name = item.Substring(item.LastIndexOf("\\") + 1);
                    var cTime = Directory.GetCreationTime(item);
                    var size = 0.0;
                    try
                    {
                        size = (double)new FileInfo(item).Length / 1024;
                    }
                    catch (Exception)
                    {}

                    d.children.Add(new DirFile(name, item, d, fileType.directory, Directory.GetCreationTime(item)));

                }
            }
        }
    }
}
