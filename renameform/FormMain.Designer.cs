namespace renameForm
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileKeyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFileControl = new System.Windows.Forms.GroupBox();
            this.btAddFile = new System.Windows.Forms.Button();
            this.btDeleteFile = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbDescending = new System.Windows.Forms.CheckBox();
            this.btSort = new System.Windows.Forms.Button();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.tcOption = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbRenameString = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRenameString = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbInteger = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIntegerDigits = new System.Windows.Forms.ComboBox();
            this.nudIntegerStart = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbReplace = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplace1 = new System.Windows.Forms.TextBox();
            this.tbReplace0 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbAllSame = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAllSame = new System.Windows.Forms.TextBox();
            this.btOption = new System.Windows.Forms.Button();
            this.btPreview = new System.Windows.Forms.Button();
            this.gbClear = new System.Windows.Forms.GroupBox();
            this.btFileNameReset = new System.Windows.Forms.Button();
            this.btFileNameClear = new System.Windows.Forms.Button();
            this.gbSelectFolder = new System.Windows.Forms.GroupBox();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.cbOverWriteSave = new System.Windows.Forms.CheckBox();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.cbExcel = new System.Windows.Forms.CheckBox();
            this.btDecision = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbFileControl.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.tcOption.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbRenameString.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbInteger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegerStart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbReplace.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbAllSame.SuspendLayout();
            this.gbClear.SuspendLayout();
            this.gbSelectFolder.SuspendLayout();
            this.gbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRestart,
            this.menuExit});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // menuRestart
            // 
            this.menuRestart.Name = "menuRestart";
            this.menuRestart.Size = new System.Drawing.Size(128, 26);
            this.menuRestart.Text = "再起動";
            this.menuRestart.Click += new System.EventHandler(this.menuRestart_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(128, 26);
            this.menuExit.Text = "終了";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileDate,
            this.FileSize,
            this.FileKeyNumber});
            this.dgvMain.Location = new System.Drawing.Point(0, 32);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.Size = new System.Drawing.Size(697, 388);
            this.dgvMain.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "ファイル名";
            this.FileName.Name = "FileName";
            this.FileName.Width = 350;
            // 
            // FileDate
            // 
            this.FileDate.HeaderText = "作成日時";
            this.FileDate.Name = "FileDate";
            this.FileDate.ReadOnly = true;
            this.FileDate.Width = 150;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "サイズ";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 150;
            // 
            // FileKeyNumber
            // 
            this.FileKeyNumber.HeaderText = "識別番号";
            this.FileKeyNumber.Name = "FileKeyNumber";
            this.FileKeyNumber.ReadOnly = true;
            this.FileKeyNumber.Visible = false;
            // 
            // gbFileControl
            // 
            this.gbFileControl.Controls.Add(this.btAddFile);
            this.gbFileControl.Controls.Add(this.btDeleteFile);
            this.gbFileControl.Location = new System.Drawing.Point(0, 426);
            this.gbFileControl.Name = "gbFileControl";
            this.gbFileControl.Size = new System.Drawing.Size(313, 100);
            this.gbFileControl.TabIndex = 2;
            this.gbFileControl.TabStop = false;
            this.gbFileControl.Text = "ファイルの追加と削除";
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(12, 17);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(148, 76);
            this.btAddFile.TabIndex = 4;
            this.btAddFile.Text = "ファイルの追加";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Clicked);
            // 
            // btDeleteFile
            // 
            this.btDeleteFile.Location = new System.Drawing.Point(166, 18);
            this.btDeleteFile.Name = "btDeleteFile";
            this.btDeleteFile.Size = new System.Drawing.Size(132, 76);
            this.btDeleteFile.TabIndex = 3;
            this.btDeleteFile.Text = "選択したファイルを削除する";
            this.btDeleteFile.UseVisualStyleBackColor = true;
            this.btDeleteFile.Click += new System.EventHandler(this.btDeleteFile_Clicked);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.cbSort);
            this.gbSort.Controls.Add(this.cbDescending);
            this.gbSort.Controls.Add(this.btSort);
            this.gbSort.Location = new System.Drawing.Point(319, 426);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(375, 100);
            this.gbSort.TabIndex = 0;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "ファイルの並び替え";
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "昇順：ファイル名",
            "昇順：作成日時",
            "昇順：サイズ"});
            this.cbSort.Location = new System.Drawing.Point(6, 41);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(187, 32);
            this.cbSort.TabIndex = 1;
            // 
            // cbDescending
            // 
            this.cbDescending.AutoSize = true;
            this.cbDescending.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbDescending.Location = new System.Drawing.Point(199, 48);
            this.cbDescending.Name = "cbDescending";
            this.cbDescending.Size = new System.Drawing.Size(66, 23);
            this.cbDescending.TabIndex = 6;
            this.cbDescending.Text = "降順";
            this.cbDescending.UseVisualStyleBackColor = true;
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSort.Location = new System.Drawing.Point(271, 37);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(92, 42);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "並び替え";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Clicked);
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.tcOption);
            this.gbOption.Controls.Add(this.btOption);
            this.gbOption.Controls.Add(this.btPreview);
            this.gbOption.Location = new System.Drawing.Point(703, 32);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(549, 388);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "変更詳細";
            // 
            // tcOption
            // 
            this.tcOption.Controls.Add(this.tabPage1);
            this.tcOption.Controls.Add(this.tabPage2);
            this.tcOption.Controls.Add(this.tabPage3);
            this.tcOption.Controls.Add(this.tabPage4);
            this.tcOption.Location = new System.Drawing.Point(6, 18);
            this.tcOption.Name = "tcOption";
            this.tcOption.SelectedIndex = 0;
            this.tcOption.Size = new System.Drawing.Size(287, 267);
            this.tcOption.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbRenameString);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbRenameString
            // 
            this.gbRenameString.Controls.Add(this.label6);
            this.gbRenameString.Controls.Add(this.tbRenameString);
            this.gbRenameString.Location = new System.Drawing.Point(6, 6);
            this.gbRenameString.Name = "gbRenameString";
            this.gbRenameString.Size = new System.Drawing.Size(261, 229);
            this.gbRenameString.TabIndex = 1;
            this.gbRenameString.TabStop = false;
            this.gbRenameString.Text = "文字列を前後に追加する";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "追加する文字列";
            // 
            // tbRenameString
            // 
            this.tbRenameString.Location = new System.Drawing.Point(17, 47);
            this.tbRenameString.Name = "tbRenameString";
            this.tbRenameString.Size = new System.Drawing.Size(100, 19);
            this.tbRenameString.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbInteger);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbInteger
            // 
            this.gbInteger.Controls.Add(this.label4);
            this.gbInteger.Controls.Add(this.label5);
            this.gbInteger.Controls.Add(this.cbIntegerDigits);
            this.gbInteger.Controls.Add(this.nudIntegerStart);
            this.gbInteger.Location = new System.Drawing.Point(14, 6);
            this.gbInteger.Name = "gbInteger";
            this.gbInteger.Size = new System.Drawing.Size(259, 232);
            this.gbInteger.TabIndex = 2;
            this.gbInteger.TabStop = false;
            this.gbInteger.Text = "数値で変更する";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "開始の数値(max:99999)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "桁数\r\n(例:3桁なら001)";
            // 
            // cbIntegerDigits
            // 
            this.cbIntegerDigits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntegerDigits.FormattingEnabled = true;
            this.cbIntegerDigits.Items.AddRange(new object[] {
            "1桁",
            "2桁",
            "3桁",
            "4桁",
            "5桁"});
            this.cbIntegerDigits.Location = new System.Drawing.Point(19, 113);
            this.cbIntegerDigits.Name = "cbIntegerDigits";
            this.cbIntegerDigits.Size = new System.Drawing.Size(121, 20);
            this.cbIntegerDigits.TabIndex = 4;
            // 
            // nudIntegerStart
            // 
            this.nudIntegerStart.Location = new System.Drawing.Point(17, 48);
            this.nudIntegerStart.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudIntegerStart.Name = "nudIntegerStart";
            this.nudIntegerStart.Size = new System.Drawing.Size(120, 19);
            this.nudIntegerStart.TabIndex = 3;
            this.nudIntegerStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIntegerStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbReplace);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(279, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbReplace
            // 
            this.gbReplace.Controls.Add(this.label3);
            this.gbReplace.Controls.Add(this.label2);
            this.gbReplace.Controls.Add(this.tbReplace1);
            this.gbReplace.Controls.Add(this.tbReplace0);
            this.gbReplace.Location = new System.Drawing.Point(6, 6);
            this.gbReplace.Name = "gbReplace";
            this.gbReplace.Size = new System.Drawing.Size(267, 229);
            this.gbReplace.TabIndex = 5;
            this.gbReplace.TabStop = false;
            this.gbReplace.Text = "置換";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "置換後の文字列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "置換対象";
            // 
            // tbReplace1
            // 
            this.tbReplace1.Location = new System.Drawing.Point(18, 101);
            this.tbReplace1.Name = "tbReplace1";
            this.tbReplace1.Size = new System.Drawing.Size(100, 19);
            this.tbReplace1.TabIndex = 1;
            // 
            // tbReplace0
            // 
            this.tbReplace0.Location = new System.Drawing.Point(18, 45);
            this.tbReplace0.Name = "tbReplace0";
            this.tbReplace0.Size = new System.Drawing.Size(100, 19);
            this.tbReplace0.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbAllSame);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(279, 241);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbAllSame
            // 
            this.gbAllSame.Controls.Add(this.label1);
            this.gbAllSame.Controls.Add(this.tbAllSame);
            this.gbAllSame.Location = new System.Drawing.Point(3, 6);
            this.gbAllSame.Name = "gbAllSame";
            this.gbAllSame.Size = new System.Drawing.Size(270, 229);
            this.gbAllSame.TabIndex = 2;
            this.gbAllSame.TabStop = false;
            this.gbAllSame.Text = "全ての名前を同一にする";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文字列を入力してください";
            // 
            // tbAllSame
            // 
            this.tbAllSame.Location = new System.Drawing.Point(18, 59);
            this.tbAllSame.Name = "tbAllSame";
            this.tbAllSame.Size = new System.Drawing.Size(119, 19);
            this.tbAllSame.TabIndex = 0;
            // 
            // btOption
            // 
            this.btOption.Location = new System.Drawing.Point(6, 291);
            this.btOption.Name = "btOption";
            this.btOption.Size = new System.Drawing.Size(368, 42);
            this.btOption.TabIndex = 1;
            this.btOption.Text = "ファイル名変更オプション";
            this.btOption.UseVisualStyleBackColor = true;
            this.btOption.Click += new System.EventHandler(this.btOption_Click);
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(0, 339);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(543, 43);
            this.btPreview.TabIndex = 0;
            this.btPreview.Text = "変更内容を反映する";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // gbClear
            // 
            this.gbClear.Controls.Add(this.btFileNameReset);
            this.gbClear.Controls.Add(this.btFileNameClear);
            this.gbClear.Location = new System.Drawing.Point(12, 532);
            this.gbClear.Name = "gbClear";
            this.gbClear.Size = new System.Drawing.Size(410, 100);
            this.gbClear.TabIndex = 0;
            this.gbClear.TabStop = false;
            this.gbClear.Text = "ファイル名の復元と削除";
            // 
            // btFileNameReset
            // 
            this.btFileNameReset.Location = new System.Drawing.Point(6, 18);
            this.btFileNameReset.Name = "btFileNameReset";
            this.btFileNameReset.Size = new System.Drawing.Size(145, 66);
            this.btFileNameReset.TabIndex = 2;
            this.btFileNameReset.Text = "選択したファイルの名前を初期値に戻す";
            this.btFileNameReset.UseVisualStyleBackColor = true;
            this.btFileNameReset.Click += new System.EventHandler(this.btFileNameReset_Click);
            // 
            // btFileNameClear
            // 
            this.btFileNameClear.Location = new System.Drawing.Point(155, 18);
            this.btFileNameClear.Name = "btFileNameClear";
            this.btFileNameClear.Size = new System.Drawing.Size(148, 66);
            this.btFileNameClear.TabIndex = 1;
            this.btFileNameClear.Text = "全てのファイルの名前を削除する";
            this.btFileNameClear.UseVisualStyleBackColor = true;
            this.btFileNameClear.Click += new System.EventHandler(this.btFileNameClear_Click);
            // 
            // gbSelectFolder
            // 
            this.gbSelectFolder.Controls.Add(this.btSelectFolder);
            this.gbSelectFolder.Controls.Add(this.cbOverWriteSave);
            this.gbSelectFolder.Controls.Add(this.tbFolderName);
            this.gbSelectFolder.Location = new System.Drawing.Point(703, 426);
            this.gbSelectFolder.Name = "gbSelectFolder";
            this.gbSelectFolder.Size = new System.Drawing.Size(549, 94);
            this.gbSelectFolder.TabIndex = 0;
            this.gbSelectFolder.TabStop = false;
            this.gbSelectFolder.Text = "ファイルの保存先";
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Location = new System.Drawing.Point(415, 23);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(90, 39);
            this.btSelectFolder.TabIndex = 4;
            this.btSelectFolder.Text = "フォルダー選択";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Clicked);
            // 
            // cbOverWriteSave
            // 
            this.cbOverWriteSave.AutoSize = true;
            this.cbOverWriteSave.Location = new System.Drawing.Point(6, 72);
            this.cbOverWriteSave.Name = "cbOverWriteSave";
            this.cbOverWriteSave.Size = new System.Drawing.Size(204, 16);
            this.cbOverWriteSave.TabIndex = 3;
            this.cbOverWriteSave.Text = "それぞれのファイルを上書きで保存する";
            this.cbOverWriteSave.UseVisualStyleBackColor = true;
            this.cbOverWriteSave.CheckedChanged += new System.EventHandler(this.cbOverWriteSave_CheckedChanged);
            // 
            // tbFolderName
            // 
            this.tbFolderName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFolderName.Location = new System.Drawing.Point(6, 27);
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.ReadOnly = true;
            this.tbFolderName.Size = new System.Drawing.Size(403, 26);
            this.tbFolderName.TabIndex = 2;
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.cbExcel);
            this.gbConfirm.Controls.Add(this.btDecision);
            this.gbConfirm.Location = new System.Drawing.Point(703, 532);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(410, 100);
            this.gbConfirm.TabIndex = 0;
            this.gbConfirm.TabStop = false;
            this.gbConfirm.Text = "確認";
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Location = new System.Drawing.Point(107, 58);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(103, 16);
            this.cbExcel.TabIndex = 6;
            this.cbExcel.Text = "xlsxでログを取る";
            this.cbExcel.UseVisualStyleBackColor = true;
            // 
            // btDecision
            // 
            this.btDecision.Location = new System.Drawing.Point(223, 18);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(181, 67);
            this.btDecision.TabIndex = 5;
            this.btDecision.Text = "確定";
            this.btDecision.UseVisualStyleBackColor = true;
            this.btDecision.Click += new System.EventHandler(this.btDecision_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 680);
            this.Controls.Add(this.gbConfirm);
            this.Controls.Add(this.gbSelectFolder);
            this.Controls.Add(this.gbClear);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.gbFileControl);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbFileControl.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.tcOption.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbRenameString.ResumeLayout(false);
            this.gbRenameString.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbInteger.ResumeLayout(false);
            this.gbInteger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegerStart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbReplace.ResumeLayout(false);
            this.gbReplace.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbAllSame.ResumeLayout(false);
            this.gbAllSame.PerformLayout();
            this.gbClear.ResumeLayout(false);
            this.gbSelectFolder.ResumeLayout(false);
            this.gbSelectFolder.PerformLayout();
            this.gbConfirm.ResumeLayout(false);
            this.gbConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void SetDgvColumnName()
        {
            columnName = new string[]{
            "FileName", "FileDate", "FileSize", "FileKeyNumber"};
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRestart;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox gbFileControl;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Button btDeleteFile;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.CheckBox cbDescending;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.GroupBox gbClear;
        private System.Windows.Forms.Button btFileNameClear;
        private System.Windows.Forms.GroupBox gbSelectFolder;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.CheckBox cbOverWriteSave;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.GroupBox gbConfirm;
        private System.Windows.Forms.Button btDecision;
        private System.Windows.Forms.GroupBox gbInteger;
        private System.Windows.Forms.NumericUpDown nudIntegerStart;
        private System.Windows.Forms.GroupBox gbRenameString;
        private System.Windows.Forms.TextBox tbRenameString;
        private System.Windows.Forms.GroupBox gbReplace;
        private System.Windows.Forms.TextBox tbReplace1;
        private System.Windows.Forms.TextBox tbReplace0;
        private System.Windows.Forms.ComboBox cbIntegerDigits;
        private System.Windows.Forms.GroupBox gbAllSame;
        private System.Windows.Forms.TextBox tbAllSame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileKeyNumber;
        private System.Windows.Forms.Button btFileNameReset;
        private System.Windows.Forms.CheckBox cbExcel;
        private System.Windows.Forms.TabControl tcOption;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        public string[] columnName { get; private set; }
    }
}