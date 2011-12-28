﻿namespace _3DSExplorer
{
    partial class frmExplorer
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
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorer));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.chOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHexValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.lblTreeViewTitle = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblFileListTitle = new System.Windows.Forms.Label();
            this.imlFS = new System.Windows.Forms.ImageList(this.components);
            this.cxtFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bwCheckForUpdates = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsXORTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsHashTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools3DVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsQuickCRC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpCheckNow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpVisitGoogleCode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVisit3DBrew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVisitNDev = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lvFileTree = new TreeListView.TreeListViewControl();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInfo
            // 
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOffset,
            this.chSize,
            this.chDescription,
            this.chValue,
            this.chHexValue});
            this.lstInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInfo.FullRowSelect = true;
            listViewGroup8.Header = "";
            listViewGroup8.Name = "lvg0";
            listViewGroup9.Header = "";
            listViewGroup9.Name = "lvg1";
            listViewGroup10.Header = "";
            listViewGroup10.Name = "lvg2";
            listViewGroup11.Header = "";
            listViewGroup11.Name = "lvg3";
            listViewGroup12.Header = "";
            listViewGroup12.Name = "lvg4";
            listViewGroup13.Header = "";
            listViewGroup13.Name = "lvg5";
            listViewGroup14.Header = "";
            listViewGroup14.Name = "lvg6";
            this.lstInfo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14});
            this.lstInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstInfo.HideSelection = false;
            this.lstInfo.Location = new System.Drawing.Point(0, 0);
            this.lstInfo.MultiSelect = false;
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(809, 423);
            this.lstInfo.TabIndex = 1;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            this.lstInfo.DoubleClick += new System.EventHandler(this.lstInfo_DoubleClick);
            // 
            // chOffset
            // 
            this.chOffset.Text = "Offset";
            this.chOffset.Width = 48;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 254;
            // 
            // chValue
            // 
            this.chValue.Text = "Decimal Value";
            this.chValue.Width = 139;
            // 
            // chHexValue
            // 
            this.chHexValue.Text = "Hex / String Value";
            this.chHexValue.Width = 278;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lstInfo);
            this.splitContainer.Size = new System.Drawing.Size(1076, 425);
            this.splitContainer.SplitterDistance = 263;
            this.splitContainer.SplitterWidth = 2;
            this.splitContainer.TabIndex = 2;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackgroundImage = global::_3DSExplorer.Properties.Resources.menuBack;
            this.splitContainerLeft.Panel1.Controls.Add(this.lblTreeViewTitle);
            this.splitContainerLeft.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackgroundImage = global::_3DSExplorer.Properties.Resources.menuBack;
            this.splitContainerLeft.Panel2.Controls.Add(this.lblFileListTitle);
            this.splitContainerLeft.Panel2.Controls.Add(this.lvFileTree);
            this.splitContainerLeft.Size = new System.Drawing.Size(263, 425);
            this.splitContainerLeft.SplitterDistance = 200;
            this.splitContainerLeft.TabIndex = 2;
            // 
            // lblTreeViewTitle
            // 
            this.lblTreeViewTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTreeViewTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTreeViewTitle.Location = new System.Drawing.Point(6, 0);
            this.lblTreeViewTitle.Name = "lblTreeViewTitle";
            this.lblTreeViewTitle.Size = new System.Drawing.Size(255, 23);
            this.lblTreeViewTitle.TabIndex = 3;
            this.lblTreeViewTitle.Text = "(Open a file from the \'File\' Menu)";
            this.lblTreeViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 23);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(261, 175);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bullet_black.png");
            // 
            // lblFileListTitle
            // 
            this.lblFileListTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFileListTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblFileListTitle.Location = new System.Drawing.Point(6, 0);
            this.lblFileListTitle.Name = "lblFileListTitle";
            this.lblFileListTitle.Size = new System.Drawing.Size(255, 23);
            this.lblFileListTitle.TabIndex = 2;
            this.lblFileListTitle.Text = "File List";
            this.lblFileListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imlFS
            // 
            this.imlFS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFS.ImageStream")));
            this.imlFS.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFS.Images.SetKeyName(0, "page_white_text.png");
            this.imlFS.Images.SetKeyName(1, "folder.png");
            // 
            // cxtFile
            // 
            this.cxtFile.Name = "contextMenuStrip1";
            this.cxtFile.Size = new System.Drawing.Size(61, 4);
            // 
            // bwCheckForUpdates
            // 
            this.bwCheckForUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckForUpdates_DoWork);
            this.bwCheckForUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCheckForUpdates_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::_3DSExplorer.Properties.Resources.menuBack;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTools,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "Main Menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSep0,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(36, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = global::_3DSExplorer.Properties.Resources.folder;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(127, 22);
            this.menuFileOpen.Text = "&Open...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Enabled = false;
            this.menuFileSave.Image = global::_3DSExplorer.Properties.Resources.disk;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(127, 22);
            this.menuFileSave.Text = "&Save as...";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSep0
            // 
            this.menuFileSep0.Name = "menuFileSep0";
            this.menuFileSep0.Size = new System.Drawing.Size(124, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Image = global::_3DSExplorer.Properties.Resources.door_in;
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(127, 22);
            this.menuFileExit.Text = "&Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsXORTool,
            this.menuToolsHashTool,
            this.menuTools3DVideo,
            this.menuToolsQuickCRC});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(48, 20);
            this.menuTools.Text = "&Tools";
            // 
            // menuToolsXORTool
            // 
            this.menuToolsXORTool.Image = global::_3DSExplorer.Properties.Resources.select_by_intersection;
            this.menuToolsXORTool.Name = "menuToolsXORTool";
            this.menuToolsXORTool.Size = new System.Drawing.Size(168, 22);
            this.menuToolsXORTool.Text = "&XOR Tool";
            this.menuToolsXORTool.Click += new System.EventHandler(this.menuToolsXORTool_Click);
            // 
            // menuToolsHashTool
            // 
            this.menuToolsHashTool.Image = global::_3DSExplorer.Properties.Resources.magnifier;
            this.menuToolsHashTool.Name = "menuToolsHashTool";
            this.menuToolsHashTool.Size = new System.Drawing.Size(168, 22);
            this.menuToolsHashTool.Text = "&Hash Tool";
            this.menuToolsHashTool.Click += new System.EventHandler(this.menuToolsHashTool_Click);
            // 
            // menuTools3DVideo
            // 
            this.menuTools3DVideo.Image = global::_3DSExplorer.Properties.Resources.ico_3d_glasses_32;
            this.menuTools3DVideo.Name = "menuTools3DVideo";
            this.menuTools3DVideo.Size = new System.Drawing.Size(168, 22);
            this.menuTools3DVideo.Text = "3D &Video Creator";
            this.menuTools3DVideo.Click += new System.EventHandler(this.menuTools3DVideo_Click);
            // 
            // menuToolsQuickCRC
            // 
            this.menuToolsQuickCRC.Enabled = false;
            this.menuToolsQuickCRC.Image = global::_3DSExplorer.Properties.Resources.code;
            this.menuToolsQuickCRC.Name = "menuToolsQuickCRC";
            this.menuToolsQuickCRC.Size = new System.Drawing.Size(168, 22);
            this.menuToolsQuickCRC.Text = "&Quick CRC32";
            this.menuToolsQuickCRC.Click += new System.EventHandler(this.menuToolsQuickCRC_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpCheckNow,
            this.menuHelpCheckUpdates,
            this.menuHelpSep1,
            this.menuHelpVisitGoogleCode,
            this.menuHelpVisit3DBrew,
            this.menuHelpVisitNDev,
            this.menuHelpSep0,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(43, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpCheckNow
            // 
            this.menuHelpCheckNow.Name = "menuHelpCheckNow";
            this.menuHelpCheckNow.Size = new System.Drawing.Size(235, 22);
            this.menuHelpCheckNow.Text = "Check for &updates...";
            this.menuHelpCheckNow.Click += new System.EventHandler(this.menuHelpCheckNow_Click);
            // 
            // menuHelpCheckUpdates
            // 
            this.menuHelpCheckUpdates.Checked = true;
            this.menuHelpCheckUpdates.CheckOnClick = true;
            this.menuHelpCheckUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuHelpCheckUpdates.Name = "menuHelpCheckUpdates";
            this.menuHelpCheckUpdates.Size = new System.Drawing.Size(235, 22);
            this.menuHelpCheckUpdates.Text = "&Check for updates on startup";
            this.menuHelpCheckUpdates.Click += new System.EventHandler(this.menuHelpCheckUpdates_Click);
            // 
            // menuHelpSep1
            // 
            this.menuHelpSep1.Name = "menuHelpSep1";
            this.menuHelpSep1.Size = new System.Drawing.Size(232, 6);
            // 
            // menuHelpVisitGoogleCode
            // 
            this.menuHelpVisitGoogleCode.Name = "menuHelpVisitGoogleCode";
            this.menuHelpVisitGoogleCode.Size = new System.Drawing.Size(235, 22);
            this.menuHelpVisitGoogleCode.Text = "Visit &Google code site";
            this.menuHelpVisitGoogleCode.Click += new System.EventHandler(this.menuHelpVisitGoogleCode_Click);
            // 
            // menuHelpVisit3DBrew
            // 
            this.menuHelpVisit3DBrew.Name = "menuHelpVisit3DBrew";
            this.menuHelpVisit3DBrew.Size = new System.Drawing.Size(235, 22);
            this.menuHelpVisit3DBrew.Text = "&Visit 3DBrew.org";
            this.menuHelpVisit3DBrew.Click += new System.EventHandler(this.menuHelpVisit3DBrew_Click);
            // 
            // menuHelpVisitNDev
            // 
            this.menuHelpVisitNDev.Name = "menuHelpVisitNDev";
            this.menuHelpVisitNDev.Size = new System.Drawing.Size(235, 22);
            this.menuHelpVisitNDev.Text = "Visit &n-dev.net";
            this.menuHelpVisitNDev.Click += new System.EventHandler(this.menuHelpVisitNDev_Click);
            // 
            // menuHelpSep0
            // 
            this.menuHelpSep0.Name = "menuHelpSep0";
            this.menuHelpSep0.Size = new System.Drawing.Size(232, 6);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Image = global::_3DSExplorer.Properties.Resources.information;
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(235, 22);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // lvFileTree
            // 
            this.lvFileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileTree.AutoScroll = true;
            this.lvFileTree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cSize,
            this.cOffset});
            this.lvFileTree.ImageList = this.imlFS;
            this.lvFileTree.Location = new System.Drawing.Point(0, 23);
            this.lvFileTree.Name = "lvFileTree";
            this.lvFileTree.SelectedNode = null;
            this.lvFileTree.Size = new System.Drawing.Size(261, 197);
            this.lvFileTree.TabIndex = 1;
            this.lvFileTree.TreeDoubleClicked += new System.Windows.Forms.MouseEventHandler(this.lvFileTree_TreeDoubleClicked);
            this.lvFileTree.TreeMouseClicked += new System.Windows.Forms.MouseEventHandler(this.lvFileTree_TreeMouseClicked);
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 150;
            // 
            // cSize
            // 
            this.cSize.Text = "Size";
            this.cSize.Width = 50;
            // 
            // cOffset
            // 
            this.cOffset.Text = "Offset";
            // 
            // frmExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 449);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExplorer";
            this.Text = "3DS Explorer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmExplorer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmExplorer_DragEnter);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.ColumnHeader chOffset;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.ImageList imlFS;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuToolsXORTool;
        private System.Windows.Forms.ToolStripMenuItem menuToolsHashTool;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripSeparator menuFileSep0;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVisit3DBrew;
        private System.Windows.Forms.ToolStripSeparator menuHelpSep0;
        private System.Windows.Forms.ContextMenuStrip cxtFile;
        private System.Windows.Forms.ColumnHeader chHexValue;
        private TreeListView.TreeListViewControl lvFileTree;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSize;
        private System.Windows.Forms.ColumnHeader cOffset;
        private System.Windows.Forms.Label lblFileListTitle;
        private System.Windows.Forms.Label lblTreeViewTitle;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVisitNDev;
        private System.ComponentModel.BackgroundWorker bwCheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem menuHelpCheckUpdates;
        private System.Windows.Forms.ToolStripSeparator menuHelpSep1;
        private System.Windows.Forms.ToolStripMenuItem menuHelpCheckNow;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVisitGoogleCode;
        private System.Windows.Forms.ToolStripMenuItem menuTools3DVideo;
        private System.Windows.Forms.ToolStripMenuItem menuToolsQuickCRC;
    }
}

