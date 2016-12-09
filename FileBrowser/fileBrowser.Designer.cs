namespace FileBrowser
{
    partial class fileBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileBrowser));
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.displaySPanel = new System.Windows.Forms.SplitContainer();
            this.directoryListview = new BrightIdeasSoftware.TreeListView();
            this.dirColum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.detailOLV = new BrightIdeasSoftware.ObjectListView();
            this.fileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileCTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.displaySPanel)).BeginInit();
            this.displaySPanel.Panel1.SuspendLayout();
            this.displaySPanel.Panel2.SuspendLayout();
            this.displaySPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directoryListview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(1208, 34);
            this.toolBarPanel.TabIndex = 0;
            // 
            // displaySPanel
            // 
            this.displaySPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaySPanel.Location = new System.Drawing.Point(0, 34);
            this.displaySPanel.Name = "displaySPanel";
            // 
            // displaySPanel.Panel1
            // 
            this.displaySPanel.Panel1.Controls.Add(this.directoryListview);
            // 
            // displaySPanel.Panel2
            // 
            this.displaySPanel.Panel2.Controls.Add(this.detailOLV);
            this.displaySPanel.Size = new System.Drawing.Size(1208, 754);
            this.displaySPanel.SplitterDistance = 333;
            this.displaySPanel.TabIndex = 1;
            // 
            // directoryListview
            // 
            this.directoryListview.AllColumns.Add(this.dirColum);
            this.directoryListview.CellEditUseWholeCell = false;
            this.directoryListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dirColum});
            this.directoryListview.Cursor = System.Windows.Forms.Cursors.Default;
            this.directoryListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryListview.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryListview.Location = new System.Drawing.Point(0, 0);
            this.directoryListview.Name = "directoryListview";
            this.directoryListview.ShowGroups = false;
            this.directoryListview.Size = new System.Drawing.Size(333, 754);
            this.directoryListview.SmallImageList = this.imageList1;
            this.directoryListview.TabIndex = 0;
            this.directoryListview.UseCompatibleStateImageBehavior = false;
            this.directoryListview.View = System.Windows.Forms.View.Details;
            this.directoryListview.VirtualMode = true;
            this.directoryListview.SelectedIndexChanged += new System.EventHandler(this.directoryListview_SelectedIndexChanged);
            // 
            // dirColum
            // 
            this.dirColum.AspectName = "fileName";
            this.dirColum.FillsFreeSpace = true;
            this.dirColum.HeaderFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirColum.Text = "Dir";
            this.dirColum.Width = 424;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dir");
            this.imageList1.Images.SetKeyName(1, "file");
            // 
            // detailOLV
            // 
            this.detailOLV.AllColumns.Add(this.fileName);
            this.detailOLV.AllColumns.Add(this.fileSize);
            this.detailOLV.AllColumns.Add(this.fileCTime);
            this.detailOLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailOLV.CellEditUseWholeCell = false;
            this.detailOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileSize,
            this.fileCTime});
            this.detailOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.detailOLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailOLV.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailOLV.FullRowSelect = true;
            this.detailOLV.GridLines = true;
            this.detailOLV.Location = new System.Drawing.Point(0, 0);
            this.detailOLV.Name = "detailOLV";
            this.detailOLV.ShowGroups = false;
            this.detailOLV.Size = new System.Drawing.Size(871, 754);
            this.detailOLV.SmallImageList = this.imageList1;
            this.detailOLV.TabIndex = 0;
            this.detailOLV.UseCompatibleStateImageBehavior = false;
            this.detailOLV.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.AspectName = "fileName";
            this.fileName.AspectToStringFormat = "";
            this.fileName.Groupable = false;
            this.fileName.Text = "name";
            this.fileName.Width = 403;
            // 
            // fileSize
            // 
            this.fileSize.AspectName = "size";
            this.fileSize.AspectToStringFormat = "";
            this.fileSize.Groupable = false;
            this.fileSize.Text = "size";
            this.fileSize.Width = 174;
            // 
            // fileCTime
            // 
            this.fileCTime.AspectName = "creatTime";
            this.fileCTime.AspectToStringFormat = "{0:d}";
            this.fileCTime.FillsFreeSpace = true;
            this.fileCTime.Groupable = false;
            this.fileCTime.Text = "creat time";
            // 
            // fileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 788);
            this.Controls.Add(this.displaySPanel);
            this.Controls.Add(this.toolBarPanel);
            this.Name = "fileBrowser";
            this.Text = "Form1";
            this.displaySPanel.Panel1.ResumeLayout(false);
            this.displaySPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displaySPanel)).EndInit();
            this.displaySPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directoryListview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailOLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.SplitContainer displaySPanel;
        private BrightIdeasSoftware.TreeListView directoryListview;
        private BrightIdeasSoftware.ObjectListView detailOLV;
        private BrightIdeasSoftware.OLVColumn dirColum;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn fileName;
        private BrightIdeasSoftware.OLVColumn fileSize;
        private BrightIdeasSoftware.OLVColumn fileCTime;
    }
}

