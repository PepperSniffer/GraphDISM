namespace GraphDISM
{
    partial class GraphDismMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphDismMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Information = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPathInfo = new System.Windows.Forms.TextBox();
            this.btnOpenFileInfo = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.mount = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMount = new System.Windows.Forms.Button();
            this.chkCheckIntegrityMount = new System.Windows.Forms.CheckBox();
            this.chkOptimizeMount = new System.Windows.Forms.CheckBox();
            this.chkReadOnlyMout = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAppendUnmount = new System.Windows.Forms.CheckBox();
            this.chkCheckIntegrityUnmount = new System.Windows.Forms.CheckBox();
            this.chkCommitUnmount = new System.Windows.Forms.CheckBox();
            this.btnUnmout = new System.Windows.Forms.Button();
            this.btnCleanupMount = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMountTo = new System.Windows.Forms.TextBox();
            this.btnMountTo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbMoutIndex = new System.Windows.Forms.NumericUpDown();
            this.txtMountFrom = new System.Windows.Forms.TextBox();
            this.btnOpenWimMount = new System.Windows.Forms.Button();
            this.Exporter = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoot = new System.Windows.Forms.CheckBox();
            this.chkVerifyExport = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCompress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.txtExportTo = new System.Windows.Forms.TextBox();
            this.btnExportTo = new System.Windows.Forms.Button();
            this.txtExportFrom = new System.Windows.Forms.TextBox();
            this.btnOpenWimExp = new System.Windows.Forms.Button();
            this.Splitter = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkVerifySplit = new System.Windows.Forms.CheckBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSizeSplit = new System.Windows.Forms.TextBox();
            this.txtSplitTo = new System.Windows.Forms.TextBox();
            this.txtOpenSplit = new System.Windows.Forms.TextBox();
            this.btnSplitTo = new System.Windows.Forms.Button();
            this.btnOpenSplit = new System.Windows.Forms.Button();
            this.addPackage = new System.Windows.Forms.TabPage();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnChoosePackages = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFolderPathPackage = new System.Windows.Forms.TextBox();
            this.btnPackagesTo = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.btnChooseDismPath = new System.Windows.Forms.Button();
            this.txtDISMPath = new System.Windows.Forms.TextBox();
            this.chkUseDism = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnResetOutput = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOpenNewWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Information.SuspendLayout();
            this.mount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMoutIndex)).BeginInit();
            this.Exporter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.Splitter.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.addPackage.SuspendLayout();
            this.options.SuspendLayout();
            this.about.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.Information);
            this.tabControl1.Controls.Add(this.mount);
            this.tabControl1.Controls.Add(this.Exporter);
            this.tabControl1.Controls.Add(this.Splitter);
            this.tabControl1.Controls.Add(this.addPackage);
            this.tabControl1.Controls.Add(this.options);
            this.tabControl1.Controls.Add(this.about);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Information
            // 
            resources.ApplyResources(this.Information, "Information");
            this.Information.BackColor = System.Drawing.Color.White;
            this.Information.Controls.Add(this.label19);
            this.Information.Controls.Add(this.txtPathInfo);
            this.Information.Controls.Add(this.btnOpenFileInfo);
            this.Information.Controls.Add(this.btnGetInfo);
            this.Information.Name = "Information";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // txtPathInfo
            // 
            resources.ApplyResources(this.txtPathInfo, "txtPathInfo");
            this.txtPathInfo.Name = "txtPathInfo";
            // 
            // btnOpenFileInfo
            // 
            resources.ApplyResources(this.btnOpenFileInfo, "btnOpenFileInfo");
            this.btnOpenFileInfo.Name = "btnOpenFileInfo";
            this.btnOpenFileInfo.UseVisualStyleBackColor = true;
            this.btnOpenFileInfo.Click += new System.EventHandler(this.btnOpenFileInfo_Click);
            // 
            // btnGetInfo
            // 
            resources.ApplyResources(this.btnGetInfo, "btnGetInfo");
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // mount
            // 
            resources.ApplyResources(this.mount, "mount");
            this.mount.Controls.Add(this.groupBox2);
            this.mount.Controls.Add(this.groupBox1);
            this.mount.Controls.Add(this.btnCleanupMount);
            this.mount.Controls.Add(this.label18);
            this.mount.Controls.Add(this.txtMountTo);
            this.mount.Controls.Add(this.btnMountTo);
            this.mount.Controls.Add(this.label7);
            this.mount.Controls.Add(this.label17);
            this.mount.Controls.Add(this.cbbMoutIndex);
            this.mount.Controls.Add(this.txtMountFrom);
            this.mount.Controls.Add(this.btnOpenWimMount);
            this.mount.Name = "mount";
            this.mount.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnMount);
            this.groupBox2.Controls.Add(this.chkCheckIntegrityMount);
            this.groupBox2.Controls.Add(this.chkOptimizeMount);
            this.groupBox2.Controls.Add(this.chkReadOnlyMout);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnMount
            // 
            resources.ApplyResources(this.btnMount, "btnMount");
            this.btnMount.Name = "btnMount";
            this.btnMount.UseVisualStyleBackColor = true;
            this.btnMount.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkCheckIntegrityMount
            // 
            resources.ApplyResources(this.chkCheckIntegrityMount, "chkCheckIntegrityMount");
            this.chkCheckIntegrityMount.Name = "chkCheckIntegrityMount";
            this.chkCheckIntegrityMount.UseVisualStyleBackColor = true;
            // 
            // chkOptimizeMount
            // 
            resources.ApplyResources(this.chkOptimizeMount, "chkOptimizeMount");
            this.chkOptimizeMount.Name = "chkOptimizeMount";
            this.chkOptimizeMount.UseVisualStyleBackColor = true;
            // 
            // chkReadOnlyMout
            // 
            resources.ApplyResources(this.chkReadOnlyMout, "chkReadOnlyMout");
            this.chkReadOnlyMout.Name = "chkReadOnlyMout";
            this.chkReadOnlyMout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkAppendUnmount);
            this.groupBox1.Controls.Add(this.chkCheckIntegrityUnmount);
            this.groupBox1.Controls.Add(this.chkCommitUnmount);
            this.groupBox1.Controls.Add(this.btnUnmout);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkAppendUnmount
            // 
            resources.ApplyResources(this.chkAppendUnmount, "chkAppendUnmount");
            this.chkAppendUnmount.Name = "chkAppendUnmount";
            this.chkAppendUnmount.UseVisualStyleBackColor = true;
            // 
            // chkCheckIntegrityUnmount
            // 
            resources.ApplyResources(this.chkCheckIntegrityUnmount, "chkCheckIntegrityUnmount");
            this.chkCheckIntegrityUnmount.Name = "chkCheckIntegrityUnmount";
            this.chkCheckIntegrityUnmount.UseVisualStyleBackColor = true;
            // 
            // chkCommitUnmount
            // 
            resources.ApplyResources(this.chkCommitUnmount, "chkCommitUnmount");
            this.chkCommitUnmount.Name = "chkCommitUnmount";
            this.chkCommitUnmount.UseVisualStyleBackColor = true;
            // 
            // btnUnmout
            // 
            resources.ApplyResources(this.btnUnmout, "btnUnmout");
            this.btnUnmout.Name = "btnUnmout";
            this.btnUnmout.UseVisualStyleBackColor = true;
            this.btnUnmout.Click += new System.EventHandler(this.btnUnmout_Click);
            // 
            // btnCleanupMount
            // 
            resources.ApplyResources(this.btnCleanupMount, "btnCleanupMount");
            this.btnCleanupMount.Name = "btnCleanupMount";
            this.btnCleanupMount.UseVisualStyleBackColor = true;
            this.btnCleanupMount.Click += new System.EventHandler(this.btnCleanupMount_Click);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // txtMountTo
            // 
            resources.ApplyResources(this.txtMountTo, "txtMountTo");
            this.txtMountTo.Name = "txtMountTo";
            // 
            // btnMountTo
            // 
            resources.ApplyResources(this.btnMountTo, "btnMountTo");
            this.btnMountTo.Name = "btnMountTo";
            this.btnMountTo.UseVisualStyleBackColor = true;
            this.btnMountTo.Click += new System.EventHandler(this.btnMountTo_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // cbbMoutIndex
            // 
            resources.ApplyResources(this.cbbMoutIndex, "cbbMoutIndex");
            this.cbbMoutIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbMoutIndex.Name = "cbbMoutIndex";
            this.cbbMoutIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMountFrom
            // 
            resources.ApplyResources(this.txtMountFrom, "txtMountFrom");
            this.txtMountFrom.Name = "txtMountFrom";
            // 
            // btnOpenWimMount
            // 
            resources.ApplyResources(this.btnOpenWimMount, "btnOpenWimMount");
            this.btnOpenWimMount.Name = "btnOpenWimMount";
            this.btnOpenWimMount.UseVisualStyleBackColor = true;
            this.btnOpenWimMount.Click += new System.EventHandler(this.btnOpenWimMount_Click);
            // 
            // Exporter
            // 
            resources.ApplyResources(this.Exporter, "Exporter");
            this.Exporter.BackColor = System.Drawing.Color.White;
            this.Exporter.Controls.Add(this.groupBox3);
            this.Exporter.Controls.Add(this.label11);
            this.Exporter.Controls.Add(this.label10);
            this.Exporter.Controls.Add(this.label9);
            this.Exporter.Controls.Add(this.cmbCompress);
            this.Exporter.Controls.Add(this.label1);
            this.Exporter.Controls.Add(this.numIndex);
            this.Exporter.Controls.Add(this.txtExportTo);
            this.Exporter.Controls.Add(this.btnExportTo);
            this.Exporter.Controls.Add(this.txtExportFrom);
            this.Exporter.Controls.Add(this.btnOpenWimExp);
            this.Exporter.Name = "Exporter";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chkBoot);
            this.groupBox3.Controls.Add(this.chkVerifyExport);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chkBoot
            // 
            resources.ApplyResources(this.chkBoot, "chkBoot");
            this.chkBoot.Name = "chkBoot";
            this.chkBoot.UseVisualStyleBackColor = true;
            // 
            // chkVerifyExport
            // 
            resources.ApplyResources(this.chkVerifyExport, "chkVerifyExport");
            this.chkVerifyExport.Name = "chkVerifyExport";
            this.chkVerifyExport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cmbCompress
            // 
            resources.ApplyResources(this.cmbCompress, "cmbCompress");
            this.cmbCompress.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cmbCompress.AutoCompleteCustomSource"),
            resources.GetString("cmbCompress.AutoCompleteCustomSource1"),
            resources.GetString("cmbCompress.AutoCompleteCustomSource2")});
            this.cmbCompress.FormattingEnabled = true;
            this.cmbCompress.Items.AddRange(new object[] {
            resources.GetString("cmbCompress.Items"),
            resources.GetString("cmbCompress.Items1"),
            resources.GetString("cmbCompress.Items2"),
            resources.GetString("cmbCompress.Items3")});
            this.cmbCompress.Name = "cmbCompress";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numIndex
            // 
            resources.ApplyResources(this.numIndex, "numIndex");
            this.numIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndex.Name = "numIndex";
            this.numIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtExportTo
            // 
            resources.ApplyResources(this.txtExportTo, "txtExportTo");
            this.txtExportTo.Name = "txtExportTo";
            // 
            // btnExportTo
            // 
            resources.ApplyResources(this.btnExportTo, "btnExportTo");
            this.btnExportTo.Name = "btnExportTo";
            this.btnExportTo.UseVisualStyleBackColor = true;
            this.btnExportTo.Click += new System.EventHandler(this.btnExportTo_Click);
            // 
            // txtExportFrom
            // 
            resources.ApplyResources(this.txtExportFrom, "txtExportFrom");
            this.txtExportFrom.Name = "txtExportFrom";
            // 
            // btnOpenWimExp
            // 
            resources.ApplyResources(this.btnOpenWimExp, "btnOpenWimExp");
            this.btnOpenWimExp.Name = "btnOpenWimExp";
            this.btnOpenWimExp.UseVisualStyleBackColor = true;
            this.btnOpenWimExp.Click += new System.EventHandler(this.btnOpenWimExp_Click);
            // 
            // Splitter
            // 
            resources.ApplyResources(this.Splitter, "Splitter");
            this.Splitter.BackColor = System.Drawing.Color.White;
            this.Splitter.Controls.Add(this.groupBox4);
            this.Splitter.Controls.Add(this.label16);
            this.Splitter.Controls.Add(this.label15);
            this.Splitter.Controls.Add(this.label14);
            this.Splitter.Controls.Add(this.label13);
            this.Splitter.Controls.Add(this.label12);
            this.Splitter.Controls.Add(this.txtSizeSplit);
            this.Splitter.Controls.Add(this.txtSplitTo);
            this.Splitter.Controls.Add(this.txtOpenSplit);
            this.Splitter.Controls.Add(this.btnSplitTo);
            this.Splitter.Controls.Add(this.btnOpenSplit);
            this.Splitter.Name = "Splitter";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.chkVerifySplit);
            this.groupBox4.Controls.Add(this.btnSplit);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // chkVerifySplit
            // 
            resources.ApplyResources(this.chkVerifySplit, "chkVerifySplit");
            this.chkVerifySplit.Name = "chkVerifySplit";
            this.chkVerifySplit.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            resources.ApplyResources(this.btnSplit, "btnSplit");
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtSizeSplit
            // 
            resources.ApplyResources(this.txtSizeSplit, "txtSizeSplit");
            this.txtSizeSplit.Name = "txtSizeSplit";
            // 
            // txtSplitTo
            // 
            resources.ApplyResources(this.txtSplitTo, "txtSplitTo");
            this.txtSplitTo.Name = "txtSplitTo";
            // 
            // txtOpenSplit
            // 
            resources.ApplyResources(this.txtOpenSplit, "txtOpenSplit");
            this.txtOpenSplit.Name = "txtOpenSplit";
            // 
            // btnSplitTo
            // 
            resources.ApplyResources(this.btnSplitTo, "btnSplitTo");
            this.btnSplitTo.Name = "btnSplitTo";
            this.btnSplitTo.UseVisualStyleBackColor = true;
            this.btnSplitTo.Click += new System.EventHandler(this.btnSplitTo_Click);
            // 
            // btnOpenSplit
            // 
            resources.ApplyResources(this.btnOpenSplit, "btnOpenSplit");
            this.btnOpenSplit.Name = "btnOpenSplit";
            this.btnOpenSplit.UseVisualStyleBackColor = true;
            this.btnOpenSplit.Click += new System.EventHandler(this.btnOpenSplit_Click);
            // 
            // addPackage
            // 
            resources.ApplyResources(this.addPackage, "addPackage");
            this.addPackage.Controls.Add(this.btnAddPackage);
            this.addPackage.Controls.Add(this.btnChoosePackages);
            this.addPackage.Controls.Add(this.label20);
            this.addPackage.Controls.Add(this.txtFolderPathPackage);
            this.addPackage.Controls.Add(this.btnPackagesTo);
            this.addPackage.Name = "addPackage";
            this.addPackage.UseVisualStyleBackColor = true;
            // 
            // btnAddPackage
            // 
            resources.ApplyResources(this.btnAddPackage, "btnAddPackage");
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnChoosePackages
            // 
            resources.ApplyResources(this.btnChoosePackages, "btnChoosePackages");
            this.btnChoosePackages.Name = "btnChoosePackages";
            this.btnChoosePackages.UseVisualStyleBackColor = true;
            this.btnChoosePackages.Click += new System.EventHandler(this.btnChoosePackages_Click);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // txtFolderPathPackage
            // 
            resources.ApplyResources(this.txtFolderPathPackage, "txtFolderPathPackage");
            this.txtFolderPathPackage.Name = "txtFolderPathPackage";
            // 
            // btnPackagesTo
            // 
            resources.ApplyResources(this.btnPackagesTo, "btnPackagesTo");
            this.btnPackagesTo.Name = "btnPackagesTo";
            this.btnPackagesTo.UseVisualStyleBackColor = true;
            this.btnPackagesTo.Click += new System.EventHandler(this.btnPackagesTo_Click);
            // 
            // options
            // 
            resources.ApplyResources(this.options, "options");
            this.options.Controls.Add(this.label21);
            this.options.Controls.Add(this.btnChooseDismPath);
            this.options.Controls.Add(this.txtDISMPath);
            this.options.Controls.Add(this.chkUseDism);
            this.options.Name = "options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // btnChooseDismPath
            // 
            resources.ApplyResources(this.btnChooseDismPath, "btnChooseDismPath");
            this.btnChooseDismPath.Name = "btnChooseDismPath";
            this.btnChooseDismPath.UseVisualStyleBackColor = true;
            this.btnChooseDismPath.Click += new System.EventHandler(this.btnChooseDismPath_Click);
            // 
            // txtDISMPath
            // 
            resources.ApplyResources(this.txtDISMPath, "txtDISMPath");
            this.txtDISMPath.Name = "txtDISMPath";
            this.txtDISMPath.ReadOnly = true;
            // 
            // chkUseDism
            // 
            resources.ApplyResources(this.chkUseDism, "chkUseDism");
            this.chkUseDism.Name = "chkUseDism";
            this.chkUseDism.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            resources.ApplyResources(this.about, "about");
            this.about.BackColor = System.Drawing.Color.DarkGray;
            this.about.Controls.Add(this.label22);
            this.about.Controls.Add(this.label8);
            this.about.Controls.Add(this.label6);
            this.about.Controls.Add(this.label5);
            this.about.Controls.Add(this.label4);
            this.about.Controls.Add(this.label3);
            this.about.Controls.Add(this.label2);
            this.about.Name = "about";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtOutput
            // 
            resources.ApplyResources(this.txtOutput, "txtOutput");
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            // 
            // btnResetOutput
            // 
            resources.ApplyResources(this.btnResetOutput, "btnResetOutput");
            this.btnResetOutput.Name = "btnResetOutput";
            this.btnResetOutput.UseVisualStyleBackColor = true;
            this.btnResetOutput.Click += new System.EventHandler(this.btnResetOutput_Click);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // btnOpenNewWindow
            // 
            resources.ApplyResources(this.btnOpenNewWindow, "btnOpenNewWindow");
            this.btnOpenNewWindow.Name = "btnOpenNewWindow";
            this.btnOpenNewWindow.UseVisualStyleBackColor = true;
            this.btnOpenNewWindow.Click += new System.EventHandler(this.btnOpenNewWindow_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.btnOpenNewWindow);
            this.panel1.Controls.Add(this.btnResetOutput);
            this.panel1.Name = "panel1";
            // 
            // GraphDismMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "GraphDismMain";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.mount.ResumeLayout(false);
            this.mount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMoutIndex)).EndInit();
            this.Exporter.ResumeLayout(false);
            this.Exporter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.Splitter.ResumeLayout(false);
            this.Splitter.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.addPackage.ResumeLayout(false);
            this.addPackage.PerformLayout();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Information;
        private System.Windows.Forms.TabPage Exporter;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOpenFileInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtPathInfo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtExportFrom;
        private System.Windows.Forms.Button btnOpenWimExp;
        private System.Windows.Forms.TextBox txtExportTo;
        private System.Windows.Forms.Button btnExportTo;
        private System.Windows.Forms.CheckBox chkVerifyExport;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.CheckBox chkBoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompress;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Splitter;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSizeSplit;
        private System.Windows.Forms.TextBox txtSplitTo;
        private System.Windows.Forms.TextBox txtOpenSplit;
        private System.Windows.Forms.Button btnSplitTo;
        private System.Windows.Forms.Button btnOpenSplit;
        private System.Windows.Forms.CheckBox chkVerifySplit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage mount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown cbbMoutIndex;
        private System.Windows.Forms.TextBox txtMountFrom;
        private System.Windows.Forms.Button btnOpenWimMount;
        private System.Windows.Forms.TextBox txtMountTo;
        private System.Windows.Forms.Button btnMountTo;
        private System.Windows.Forms.CheckBox chkCheckIntegrityMount;
        private System.Windows.Forms.CheckBox chkOptimizeMount;
        private System.Windows.Forms.CheckBox chkReadOnlyMout;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.CheckBox chkAppendUnmount;
        private System.Windows.Forms.CheckBox chkCheckIntegrityUnmount;
        private System.Windows.Forms.CheckBox chkCommitUnmount;
        private System.Windows.Forms.Button btnUnmout;
        private System.Windows.Forms.TabPage addPackage;
        private System.Windows.Forms.Button btnChoosePackages;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFolderPathPackage;
        private System.Windows.Forms.Button btnPackagesTo;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnCleanupMount;
        private System.Windows.Forms.TabPage options;
        public System.Windows.Forms.CheckBox chkUseDism;
        private System.Windows.Forms.TextBox txtDISMPath;
        private System.Windows.Forms.Button btnChooseDismPath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnOpenNewWindow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnResetOutput;
        private System.Windows.Forms.Panel panel1;
    }
}

