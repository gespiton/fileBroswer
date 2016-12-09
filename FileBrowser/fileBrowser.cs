using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileBrowser.classes;
using System.IO;
using System.Collections;

namespace FileBrowser
{
    public partial class fileBrowser : Form
    {
        public fileBrowser()
        {
            InitializeComponent();
            installDelegate();
            createRootObject();
        }

        void installDelegate()
        {
            //<summary>
            //    this function will insatll necessary for two listview
            //<summary>
            
            directoryListview.CanExpandGetter = delegate (object o)
            {
                var dir = o as DirFile;
                return (dir == null ? false : true);
            };

            directoryListview.ChildrenGetter = delegate (object o)
            {
                DirFile.getChildren((IFile)o);
                foreach (var item in ((DirFile)o).children)
                {
                    DirFile.getChildren(item);
                }
                return ((DirFile)o).children;
            };


            dirColum.ImageGetter = delegate (object o)
            {
                var curFile = o as IFile;
                if (curFile.type == fileType.directory)
                {
                    return "dir";
                }
                else
                {
                    return "file";
                }
            };

            fileName.ImageGetter = delegate (object o)
            {
                var curFile = o as IFile;
                if (curFile.type == fileType.directory)
                {
                    return "dir";
                }
                else
                {
                    return "file";
                }
            };

            fileSize.AspectGetter = delegate (Object o)
            {
                return string.Format("{0:F1}", ((IFile)o).size);
            };


            //detailOLV.CustomSorter = delegate (BrightIdeasSoftware.OLVColumn column, SortOrder order)
            //{
            //    if (column == fileSize)
            //    {
            //        //detailOLV.ListViewItemSorter = new sizeComparer(order);
            //    }
            //};
            //MessageBox.Show(fileSize.DataType.ToString());
            this.fileSize.DataType = typeof(double);
            MessageBox.Show(fileSize.DataType.ToString());

            //directoryListview.getter
        }


        #region sorter

        //    MyOlv.CustomSorter = delegate(OLVColumn column, SortOrder order) {
        //// check which column is about to be sorted and set your custom comparer
        //if (column == ArticleNumber) {
        //    MyOlv.ListViewItemSorter = new ArticleNumberComparer(order);
        //}


        #endregion





        void createRootObject()
        {
            directoryListview.Roots = DirFile.getRoots();
            //detailOLV.SetObjects(DirFile.getRoots()[1].children);
        }


        DirFile curSelect = null;
        private void directoryListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directoryListview.SelectedItem!=null)
            {
                var selected = directoryListview.SelectedItem.RowObject as DirFile;
                if (selected!=null&&curSelect!=selected)
                {
                    updateDetailOLV(selected);
                }
            }
        }

        private void updateDetailOLV(DirFile dir)
        {
            //detailOLV.Clear();
            detailOLV.SetObjects(dir.children);
            //detailOLV.Refresh();
        }
    }
}

class sizeComparer : IComparer
{
    SortOrder _Order;

    public sizeComparer(SortOrder order)
    {
        _Order = order;
    }

    public int Compare(object x, object y)
    {
        //MessageBox.Show("ha");
        return 1;
        //var lhs = x as BrightIdeasSoftware.OLVListItem;
        //if (lhs == null)
        //{
        //    return -1;
        //}
        //var l = lhs.RowObject as IFile;

        //var rhs = y as BrightIdeasSoftware.OLVListItem;
        //if (rhs == null)
        //{
        //    return 1;
        //}
        //var r = lhs.RowObject as IFile;
        //if (l.size == null)
        //{
        //    return -1;
        //}
        //if(r.size == null)
        //{
        //    return 1;
        //}
        //return Compare(l.size, r.size);
        // perform you desired comparison depending on the _Order
    }
}
