namespace psu_generic_parser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllObjparamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllMonsterLayoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateAnimationNameHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableScriptParsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllWeaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAllWeaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNMLLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptNMLBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptNMLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueEnemyparamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentFileInHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.arbitraryFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractSelectedTreeContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceFileTreeContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsNblFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nblChunkContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.compressChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.actionProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressStatusLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.arbitraryFileContextMenuStrip.SuspendLayout();
            this.nblChunkContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.standardToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.standardToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSelectedFileToolStripMenuItem,
            this.exportAllToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportSelectedFileToolStripMenuItem
            // 
            this.exportSelectedFileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exportSelectedFileToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.exportSelectedFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exportSelectedFileToolStripMenuItem.Name = "exportSelectedFileToolStripMenuItem";
            this.exportSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportSelectedFileToolStripMenuItem.Text = "Export Selected";
            this.exportSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedToolStripMenuItem_Click);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exportAllToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.exportAllToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportAllToolStripMenuItem.Text = "Export All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.exportAllToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAllInFolderToolStripMenuItem,
            this.listAllObjparamsToolStripMenuItem,
            this.listAllMonsterLayoutsToolStripMenuItem});
            this.batchToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.batchToolStripMenuItem.Text = "Batch";
            // 
            // extractAllInFolderToolStripMenuItem
            // 
            this.extractAllInFolderToolStripMenuItem.Name = "extractAllInFolderToolStripMenuItem";
            this.extractAllInFolderToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.extractAllInFolderToolStripMenuItem.Text = "Extract All In Folder";
            this.extractAllInFolderToolStripMenuItem.Click += new System.EventHandler(this.extractAllInFolderToolStripMenuItem_Click);
            // 
            // listAllObjparamsToolStripMenuItem
            // 
            this.listAllObjparamsToolStripMenuItem.Name = "listAllObjparamsToolStripMenuItem";
            this.listAllObjparamsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listAllObjparamsToolStripMenuItem.Text = "List all objparams";
            this.listAllObjparamsToolStripMenuItem.Click += new System.EventHandler(this.listAllObjparamsToolStripMenuItem_Click);
            // 
            // listAllMonsterLayoutsToolStripMenuItem
            // 
            this.listAllMonsterLayoutsToolStripMenuItem.Name = "listAllMonsterLayoutsToolStripMenuItem";
            this.listAllMonsterLayoutsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listAllMonsterLayoutsToolStripMenuItem.Text = "List all monster layouts";
            this.listAllMonsterLayoutsToolStripMenuItem.Click += new System.EventHandler(this.listAllMonsterLayoutsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateAnimationNameHashToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculateAnimationNameHashToolStripMenuItem
            // 
            this.calculateAnimationNameHashToolStripMenuItem.Name = "calculateAnimationNameHashToolStripMenuItem";
            this.calculateAnimationNameHashToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.calculateAnimationNameHashToolStripMenuItem.Text = "Calculate Animation Name Hash";
            this.calculateAnimationNameHashToolStripMenuItem.Click += new System.EventHandler(this.calculateAnimationNameHashToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportBlobToolStripMenuItem,
            this.createAFSToolStripMenuItem,
            this.disableScriptParsingToolStripMenuItem,
            this.exportAllWeaponsToolStripMenuItem,
            this.importAllWeaponsToolStripMenuItem,
            this.insertNMLLFileToolStripMenuItem,
            this.decryptNMLBToolStripMenuItem,
            this.decryptNMLLToolStripMenuItem,
            this.textureCatalogueToolStripMenuItem,
            this.catalogueEnemyparamToolStripMenuItem,
            this.viewCurrentFileInHexToolStripMenuItem});
            this.debugToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // exportBlobToolStripMenuItem
            // 
            this.exportBlobToolStripMenuItem.Name = "exportBlobToolStripMenuItem";
            this.exportBlobToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportBlobToolStripMenuItem.Text = "Export blob";
            this.exportBlobToolStripMenuItem.Click += new System.EventHandler(this.exportBlob_Click);
            // 
            // createAFSToolStripMenuItem
            // 
            this.createAFSToolStripMenuItem.Name = "createAFSToolStripMenuItem";
            this.createAFSToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createAFSToolStripMenuItem.Text = "Create AFS";
            this.createAFSToolStripMenuItem.Click += new System.EventHandler(this.createAFSToolStripMenuItem_Click);
            // 
            // disableScriptParsingToolStripMenuItem
            // 
            this.disableScriptParsingToolStripMenuItem.Name = "disableScriptParsingToolStripMenuItem";
            this.disableScriptParsingToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.disableScriptParsingToolStripMenuItem.Text = "Disable Script Parsing";
            this.disableScriptParsingToolStripMenuItem.Click += new System.EventHandler(this.disableScriptParsingToolStripMenuItem_Click);
            // 
            // exportAllWeaponsToolStripMenuItem
            // 
            this.exportAllWeaponsToolStripMenuItem.Name = "exportAllWeaponsToolStripMenuItem";
            this.exportAllWeaponsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportAllWeaponsToolStripMenuItem.Text = "Export all weapons";
            this.exportAllWeaponsToolStripMenuItem.Click += new System.EventHandler(this.exportAllWeaponsToolStripMenuItem_Click);
            // 
            // importAllWeaponsToolStripMenuItem
            // 
            this.importAllWeaponsToolStripMenuItem.Name = "importAllWeaponsToolStripMenuItem";
            this.importAllWeaponsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.importAllWeaponsToolStripMenuItem.Text = "Import all weapons";
            this.importAllWeaponsToolStripMenuItem.Click += new System.EventHandler(this.importAllWeaponsToolStripMenuItem_Click);
            // 
            // insertNMLLFileToolStripMenuItem
            // 
            this.insertNMLLFileToolStripMenuItem.Name = "insertNMLLFileToolStripMenuItem";
            this.insertNMLLFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.insertNMLLFileToolStripMenuItem.Text = "Insert NMLL file";
            this.insertNMLLFileToolStripMenuItem.Click += new System.EventHandler(this.insertNMLLFileToolStripMenuItem_Click);
            // 
            // decryptNMLBToolStripMenuItem
            // 
            this.decryptNMLBToolStripMenuItem.Name = "decryptNMLBToolStripMenuItem";
            this.decryptNMLBToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.decryptNMLBToolStripMenuItem.Text = "Decrypt NMLB";
            this.decryptNMLBToolStripMenuItem.Click += new System.EventHandler(this.decryptNMLBToolStripMenuItem_Click);
            // 
            // decryptNMLLToolStripMenuItem
            // 
            this.decryptNMLLToolStripMenuItem.Name = "decryptNMLLToolStripMenuItem";
            this.decryptNMLLToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.decryptNMLLToolStripMenuItem.Text = "Decrypt NMLL";
            this.decryptNMLLToolStripMenuItem.Click += new System.EventHandler(this.decryptNMLLToolStripMenuItem_Click);
            // 
            // textureCatalogueToolStripMenuItem
            // 
            this.textureCatalogueToolStripMenuItem.Name = "textureCatalogueToolStripMenuItem";
            this.textureCatalogueToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.textureCatalogueToolStripMenuItem.Text = "Texture catalogue";
            this.textureCatalogueToolStripMenuItem.Click += new System.EventHandler(this.textureCatalogueToolStripMenuItem_Click);
            // 
            // catalogueEnemyparamToolStripMenuItem
            // 
            this.catalogueEnemyparamToolStripMenuItem.Name = "catalogueEnemyparamToolStripMenuItem";
            this.catalogueEnemyparamToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.catalogueEnemyparamToolStripMenuItem.Text = "Catalogue enemyparam";
            this.catalogueEnemyparamToolStripMenuItem.Click += new System.EventHandler(this.catalogueEnemyparamToolStripMenuItem_Click);
            // 
            // viewCurrentFileInHexToolStripMenuItem
            // 
            this.viewCurrentFileInHexToolStripMenuItem.Name = "viewCurrentFileInHexToolStripMenuItem";
            this.viewCurrentFileInHexToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.viewCurrentFileInHexToolStripMenuItem.Text = "View Current File in Hex";
            this.viewCurrentFileInHexToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentFileInHexToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.githubToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.githubToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.githubToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.githubToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.versionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.versionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.versionToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.versionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(102, 19);
            this.versionToolStripMenuItem.Text = "Custom Version";
            // 
            // importDialog
            // 
            this.importDialog.FileName = "openFileDialog2";
            // 
            // arbitraryFileContextMenuStrip
            // 
            this.arbitraryFileContextMenuStrip.BackColor = System.Drawing.Color.Gray;
            this.arbitraryFileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractSelectedTreeContextItem,
            this.replaceFileTreeContextItem,
            this.renameFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem});
            this.arbitraryFileContextMenuStrip.Name = "treeViewContextMenu";
            this.arbitraryFileContextMenuStrip.ShowImageMargin = false;
            this.arbitraryFileContextMenuStrip.Size = new System.Drawing.Size(114, 92);
            // 
            // extractSelectedTreeContextItem
            // 
            this.extractSelectedTreeContextItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.extractSelectedTreeContextItem.Name = "extractSelectedTreeContextItem";
            this.extractSelectedTreeContextItem.Size = new System.Drawing.Size(113, 22);
            this.extractSelectedTreeContextItem.Text = "Extract File";
            this.extractSelectedTreeContextItem.Click += new System.EventHandler(this.extractFileTreeContextItem_Click);
            // 
            // replaceFileTreeContextItem
            // 
            this.replaceFileTreeContextItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.replaceFileTreeContextItem.Name = "replaceFileTreeContextItem";
            this.replaceFileTreeContextItem.Size = new System.Drawing.Size(113, 22);
            this.replaceFileTreeContextItem.Text = "Replace File";
            this.replaceFileTreeContextItem.Click += new System.EventHandler(this.replaceFileTreeContextItem_Click);
            // 
            // renameFileToolStripMenuItem
            // 
            this.renameFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.renameFileToolStripMenuItem.Name = "renameFileToolStripMenuItem";
            this.renameFileToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.renameFileToolStripMenuItem.Text = "Rename File";
            this.renameFileToolStripMenuItem.Click += new System.EventHandler(this.renameFileToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete File";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // afsNblFileContextMenuStrip
            // 
            this.afsNblFileContextMenuStrip.Name = "afsNblFileContextMenuStrip";
            this.afsNblFileContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // nblChunkContextMenuStrip
            // 
            this.nblChunkContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressChunkToolStripMenuItem,
            this.addFileToolStripMenuItem});
            this.nblChunkContextMenuStrip.Name = "nblChunkContextMenuStrip";
            this.nblChunkContextMenuStrip.Size = new System.Drawing.Size(166, 48);
            this.nblChunkContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.nblChunkContextMenuStrip_Opening);
            // 
            // compressChunkToolStripMenuItem
            // 
            this.compressChunkToolStripMenuItem.CheckOnClick = true;
            this.compressChunkToolStripMenuItem.Name = "compressChunkToolStripMenuItem";
            this.compressChunkToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.compressChunkToolStripMenuItem.Text = "Compress Chunk";
            this.compressChunkToolStripMenuItem.CheckedChanged += new System.EventHandler(this.compressChunkToolStripMenuItem_CheckedChanged);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.ForeColor = System.Drawing.Color.Coral;
            this.treeView1.HideSelection = false;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(3, 29);
            this.treeView1.MaximumSize = new System.Drawing.Size(383, 800);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(383, 436);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_BeforeLabelEdit);
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // actionProgressBar
            // 
            this.actionProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionProgressBar.Location = new System.Drawing.Point(63, 1263);
            this.actionProgressBar.Name = "actionProgressBar";
            this.actionProgressBar.Size = new System.Drawing.Size(255, 13);
            this.actionProgressBar.TabIndex = 22;
            // 
            // progressStatusLabel
            // 
            this.progressStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressStatusLabel.AutoSize = true;
            this.progressStatusLabel.Location = new System.Drawing.Point(3, 1263);
            this.progressStatusLabel.Name = "progressStatusLabel";
            this.progressStatusLabel.Size = new System.Drawing.Size(54, 13);
            this.progressStatusLabel.TabIndex = 23;
            this.progressStatusLabel.Text = "Progress: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.progressStatusLabel);
            this.splitContainer1.Panel1.Controls.Add(this.actionProgressBar);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Coral;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Coral;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(2088, 1064);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 14;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(392, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tenora Works Custom";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.arbitraryFileContextMenuStrip.ResumeLayout(false);
            this.nblChunkContextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportBlobToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem createAFSToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip arbitraryFileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem replaceFileTreeContextItem;
        private System.Windows.Forms.ToolStripMenuItem extractSelectedTreeContextItem;
        private System.Windows.Forms.ToolStripMenuItem disableScriptParsingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllWeaponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAllWeaponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNMLLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptNMLBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptNMLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureCatalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAllInFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip afsNblFileContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip nblChunkContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem compressChunkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllObjparamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllMonsterLayoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueEnemyparamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateAnimationNameHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentFileInHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ProgressBar actionProgressBar;
        private System.Windows.Forms.Label progressStatusLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
    }
}

