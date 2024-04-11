namespace renameForm
{
    partial class RenameForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileKeyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFileControl = new System.Windows.Forms.GroupBox();
            this.btDeleteFile = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.btSort = new System.Windows.Forms.Button();
            this.cbDescending = new System.Windows.Forms.CheckBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.gbAddString = new System.Windows.Forms.GroupBox();
            this.lbRenameString = new System.Windows.Forms.Label();
            this.tbRenameString = new System.Windows.Forms.TextBox();
            this.cbInteger = new System.Windows.Forms.CheckBox();
            this.nudIntegerStart = new System.Windows.Forms.NumericUpDown();
            this.lbIntegerStart = new System.Windows.Forms.Label();
            this.cbIntegerDigits = new System.Windows.Forms.ComboBox();
            this.lbIntegerDigits = new System.Windows.Forms.Label();
            this.gbReplace = new System.Windows.Forms.GroupBox();
            this.lbReplace1 = new System.Windows.Forms.Label();
            this.lbReplace0 = new System.Windows.Forms.Label();
            this.tbReplace1 = new System.Windows.Forms.TextBox();
            this.tbReplace0 = new System.Windows.Forms.TextBox();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSame = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbFront = new System.Windows.Forms.RadioButton();
            this.btPreview = new System.Windows.Forms.Button();
            this.gbClear = new System.Windows.Forms.GroupBox();
            this.btFileNameClear = new System.Windows.Forms.Button();
            this.gbSelectFolder = new System.Windows.Forms.GroupBox();
            this.cbOverWriteSave = new System.Windows.Forms.CheckBox();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.tbFolderName = new System.Windows.Forms.TextBox();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.btDecision = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbFileControl.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.gbAddString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegerStart)).BeginInit();
            this.gbReplace.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.gbClear.SuspendLayout();
            this.gbSelectFolder.SuspendLayout();
            this.gbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileDate,
            this.FileSize,
            this.FileKeyNumber});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.Location = new System.Drawing.Point(12, 32);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.Size = new System.Drawing.Size(671, 383);
            this.dgvMain.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "ファイル名";
            this.FileName.Name = "FileName";
            this.FileName.Width = 320;
            // 
            // FileDate
            // 
            this.FileDate.HeaderText = "作成日時";
            this.FileDate.Name = "FileDate";
            this.FileDate.ReadOnly = true;
            this.FileDate.Width = 200;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "サイズ";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            // 
            // FileKeyNumber
            // 
            this.FileKeyNumber.HeaderText = "識別番号";
            this.FileKeyNumber.Name = "FileKeyNumber";
            this.FileKeyNumber.ReadOnly = true;
            this.FileKeyNumber.Visible = false;
            this.FileKeyNumber.Width = 78;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolMenu
            // 
            this.toolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRestart,
            this.menuExit});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(65, 25);
            this.toolMenu.Text = "メニュー";
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
            // gbFileControl
            // 
            this.gbFileControl.Controls.Add(this.btDeleteFile);
            this.gbFileControl.Controls.Add(this.btAddFile);
            this.gbFileControl.Location = new System.Drawing.Point(12, 421);
            this.gbFileControl.Name = "gbFileControl";
            this.gbFileControl.Size = new System.Drawing.Size(671, 79);
            this.gbFileControl.TabIndex = 2;
            this.gbFileControl.TabStop = false;
            this.gbFileControl.Text = "ファイルの追加と削除";
            // 
            // btDeleteFile
            // 
            this.btDeleteFile.Location = new System.Drawing.Point(187, 21);
            this.btDeleteFile.Name = "btDeleteFile";
            this.btDeleteFile.Size = new System.Drawing.Size(129, 58);
            this.btDeleteFile.TabIndex = 1;
            this.btDeleteFile.Text = "選択したファイルを削除する";
            this.btDeleteFile.UseVisualStyleBackColor = true;
            this.btDeleteFile.Click += new System.EventHandler(this.btDeleteFile_Clicked);
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(52, 21);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(129, 58);
            this.btAddFile.TabIndex = 0;
            this.btAddFile.Text = "ファイルの追加";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Clicked);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.btSort);
            this.gbSort.Controls.Add(this.cbDescending);
            this.gbSort.Controls.Add(this.cbSort);
            this.gbSort.Location = new System.Drawing.Point(12, 506);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(671, 85);
            this.gbSort.TabIndex = 2;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "ファイルの並び替え";
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(350, 18);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(103, 57);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "並び替え";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Clicked);
            // 
            // cbDescending
            // 
            this.cbDescending.AutoSize = true;
            this.cbDescending.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbDescending.Location = new System.Drawing.Point(273, 33);
            this.cbDescending.Name = "cbDescending";
            this.cbDescending.Size = new System.Drawing.Size(71, 25);
            this.cbDescending.TabIndex = 1;
            this.cbDescending.Text = "降順";
            this.cbDescending.UseVisualStyleBackColor = true;
            // 
            // cbSort
            // 
            this.cbSort.DisplayMember = "0";
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "昇順：ファイル名",
            "昇順：作成日時",
            "昇順：サイズ"});
            this.cbSort.Location = new System.Drawing.Point(6, 33);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(261, 29);
            this.cbSort.TabIndex = 0;
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.gbAddString);
            this.gbOption.Controls.Add(this.gbReplace);
            this.gbOption.Controls.Add(this.gbSelect);
            this.gbOption.Controls.Add(this.btPreview);
            this.gbOption.Location = new System.Drawing.Point(689, 32);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(563, 225);
            this.gbOption.TabIndex = 3;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "groupBox1";
            // 
            // gbAddString
            // 
            this.gbAddString.Controls.Add(this.button1);
            this.gbAddString.Controls.Add(this.lbRenameString);
            this.gbAddString.Controls.Add(this.tbRenameString);
            this.gbAddString.Controls.Add(this.cbInteger);
            this.gbAddString.Controls.Add(this.nudIntegerStart);
            this.gbAddString.Controls.Add(this.lbIntegerStart);
            this.gbAddString.Controls.Add(this.cbIntegerDigits);
            this.gbAddString.Controls.Add(this.lbIntegerDigits);
            this.gbAddString.Location = new System.Drawing.Point(156, 18);
            this.gbAddString.Name = "gbAddString";
            this.gbAddString.Size = new System.Drawing.Size(401, 146);
            this.gbAddString.TabIndex = 2;
            this.gbAddString.TabStop = false;
            this.gbAddString.Text = "先頭末尾に文字列を加える";
            // 
            // lbRenameString
            // 
            this.lbRenameString.AutoSize = true;
            this.lbRenameString.Location = new System.Drawing.Point(6, 41);
            this.lbRenameString.Name = "lbRenameString";
            this.lbRenameString.Size = new System.Drawing.Size(84, 12);
            this.lbRenameString.TabIndex = 5;
            this.lbRenameString.Text = "追加する文字列";
            // 
            // tbRenameString
            // 
            this.tbRenameString.Location = new System.Drawing.Point(8, 62);
            this.tbRenameString.Name = "tbRenameString";
            this.tbRenameString.Size = new System.Drawing.Size(100, 19);
            this.tbRenameString.TabIndex = 4;
            // 
            // cbInteger
            // 
            this.cbInteger.AutoSize = true;
            this.cbInteger.Location = new System.Drawing.Point(8, 93);
            this.cbInteger.Name = "cbInteger";
            this.cbInteger.Size = new System.Drawing.Size(100, 28);
            this.cbInteger.TabIndex = 4;
            this.cbInteger.Text = "数値を追加する\r\nON/OFF";
            this.cbInteger.UseVisualStyleBackColor = true;
            // 
            // nudIntegerStart
            // 
            this.nudIntegerStart.Location = new System.Drawing.Point(165, 115);
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
            // lbIntegerStart
            // 
            this.lbIntegerStart.AutoSize = true;
            this.lbIntegerStart.Location = new System.Drawing.Point(163, 100);
            this.lbIntegerStart.Name = "lbIntegerStart";
            this.lbIntegerStart.Size = new System.Drawing.Size(124, 12);
            this.lbIntegerStart.TabIndex = 2;
            this.lbIntegerStart.Text = "開始の数値(max:99999)";
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
            this.cbIntegerDigits.Location = new System.Drawing.Point(165, 73);
            this.cbIntegerDigits.Name = "cbIntegerDigits";
            this.cbIntegerDigits.Size = new System.Drawing.Size(121, 20);
            this.cbIntegerDigits.TabIndex = 1;
            // 
            // lbIntegerDigits
            // 
            this.lbIntegerDigits.AutoSize = true;
            this.lbIntegerDigits.Location = new System.Drawing.Point(163, 46);
            this.lbIntegerDigits.Name = "lbIntegerDigits";
            this.lbIntegerDigits.Size = new System.Drawing.Size(81, 24);
            this.lbIntegerDigits.TabIndex = 0;
            this.lbIntegerDigits.Text = "桁数\r\n(例:3桁なら001)";
            // 
            // gbReplace
            // 
            this.gbReplace.Controls.Add(this.lbReplace1);
            this.gbReplace.Controls.Add(this.lbReplace0);
            this.gbReplace.Controls.Add(this.tbReplace1);
            this.gbReplace.Controls.Add(this.tbReplace0);
            this.gbReplace.Location = new System.Drawing.Point(156, 18);
            this.gbReplace.Name = "gbReplace";
            this.gbReplace.Size = new System.Drawing.Size(401, 146);
            this.gbReplace.TabIndex = 0;
            this.gbReplace.TabStop = false;
            this.gbReplace.Text = "置換";
            this.gbReplace.Visible = false;
            // 
            // lbReplace1
            // 
            this.lbReplace1.AutoSize = true;
            this.lbReplace1.Location = new System.Drawing.Point(6, 63);
            this.lbReplace1.Name = "lbReplace1";
            this.lbReplace1.Size = new System.Drawing.Size(77, 12);
            this.lbReplace1.TabIndex = 3;
            this.lbReplace1.Text = "置換後テキスト";
            // 
            // lbReplace0
            // 
            this.lbReplace0.AutoSize = true;
            this.lbReplace0.Location = new System.Drawing.Point(6, 19);
            this.lbReplace0.Name = "lbReplace0";
            this.lbReplace0.Size = new System.Drawing.Size(89, 12);
            this.lbReplace0.TabIndex = 2;
            this.lbReplace0.Text = "置換対象テキスト";
            // 
            // tbReplace1
            // 
            this.tbReplace1.Location = new System.Drawing.Point(6, 80);
            this.tbReplace1.Name = "tbReplace1";
            this.tbReplace1.Size = new System.Drawing.Size(100, 19);
            this.tbReplace1.TabIndex = 1;
            // 
            // tbReplace0
            // 
            this.tbReplace0.Location = new System.Drawing.Point(6, 37);
            this.tbReplace0.Name = "tbReplace0";
            this.tbReplace0.Size = new System.Drawing.Size(100, 19);
            this.tbReplace0.TabIndex = 0;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.rbSame);
            this.gbSelect.Controls.Add(this.rbReplace);
            this.gbSelect.Controls.Add(this.rbEnd);
            this.gbSelect.Controls.Add(this.rbFront);
            this.gbSelect.Location = new System.Drawing.Point(0, 18);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(150, 146);
            this.gbSelect.TabIndex = 1;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "編集項目";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSame
            // 
            this.rbSame.AutoSize = true;
            this.rbSame.Checked = true;
            this.rbSame.Location = new System.Drawing.Point(3, 81);
            this.rbSame.Name = "rbSame";
            this.rbSame.Size = new System.Drawing.Size(126, 16);
            this.rbSame.TabIndex = 3;
            this.rbSame.TabStop = true;
            this.rbSame.Text = "全てを同じ名前にする";
            this.rbSame.UseVisualStyleBackColor = true;
            this.rbSame.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(3, 59);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(66, 16);
            this.rbReplace.TabIndex = 2;
            this.rbReplace.Text = "置換する";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(3, 37);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(86, 16);
            this.rbEnd.TabIndex = 1;
            this.rbEnd.Text = "末尾に加える";
            this.rbEnd.UseVisualStyleBackColor = true;
            this.rbEnd.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // rbFront
            // 
            this.rbFront.AutoSize = true;
            this.rbFront.Location = new System.Drawing.Point(3, 15);
            this.rbFront.Name = "rbFront";
            this.rbFront.Size = new System.Drawing.Size(86, 16);
            this.rbFront.TabIndex = 0;
            this.rbFront.Text = "先頭に加える";
            this.rbFront.UseVisualStyleBackColor = true;
            this.rbFront.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(6, 170);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(551, 49);
            this.btPreview.TabIndex = 0;
            this.btPreview.Text = "変更内容を反映する";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // gbClear
            // 
            this.gbClear.Controls.Add(this.btFileNameClear);
            this.gbClear.Location = new System.Drawing.Point(689, 263);
            this.gbClear.Name = "gbClear";
            this.gbClear.Size = new System.Drawing.Size(563, 68);
            this.gbClear.TabIndex = 0;
            this.gbClear.TabStop = false;
            this.gbClear.Text = "変更";
            // 
            // btFileNameClear
            // 
            this.btFileNameClear.Location = new System.Drawing.Point(3, 15);
            this.btFileNameClear.Name = "btFileNameClear";
            this.btFileNameClear.Size = new System.Drawing.Size(103, 47);
            this.btFileNameClear.TabIndex = 0;
            this.btFileNameClear.Text = "全てのファイルの名前を削除する";
            this.btFileNameClear.UseVisualStyleBackColor = true;
            this.btFileNameClear.Click += new System.EventHandler(this.btFileNameClear_Click);
            // 
            // gbSelectFolder
            // 
            this.gbSelectFolder.Controls.Add(this.cbOverWriteSave);
            this.gbSelectFolder.Controls.Add(this.btSelectFolder);
            this.gbSelectFolder.Controls.Add(this.tbFolderName);
            this.gbSelectFolder.Location = new System.Drawing.Point(689, 337);
            this.gbSelectFolder.Name = "gbSelectFolder";
            this.gbSelectFolder.Size = new System.Drawing.Size(563, 86);
            this.gbSelectFolder.TabIndex = 0;
            this.gbSelectFolder.TabStop = false;
            this.gbSelectFolder.Text = "ファイルの保存先";
            // 
            // cbOverWriteSave
            // 
            this.cbOverWriteSave.AutoSize = true;
            this.cbOverWriteSave.Location = new System.Drawing.Point(6, 55);
            this.cbOverWriteSave.Name = "cbOverWriteSave";
            this.cbOverWriteSave.Size = new System.Drawing.Size(204, 16);
            this.cbOverWriteSave.TabIndex = 2;
            this.cbOverWriteSave.Text = "それぞれのファイルを上書きで保存する";
            this.cbOverWriteSave.UseVisualStyleBackColor = true;
            this.cbOverWriteSave.CheckedChanged += new System.EventHandler(this.cbOverWriteSave_CheckedChanged);
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Location = new System.Drawing.Point(449, 18);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(108, 31);
            this.btSelectFolder.TabIndex = 1;
            this.btSelectFolder.Text = "フォルダー選択";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Clicked);
            // 
            // tbFolderName
            // 
            this.tbFolderName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFolderName.Location = new System.Drawing.Point(6, 18);
            this.tbFolderName.Name = "tbFolderName";
            this.tbFolderName.ReadOnly = true;
            this.tbFolderName.Size = new System.Drawing.Size(437, 31);
            this.tbFolderName.TabIndex = 0;
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.btDecision);
            this.gbConfirm.Location = new System.Drawing.Point(689, 429);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(563, 100);
            this.gbConfirm.TabIndex = 3;
            this.gbConfirm.TabStop = false;
            this.gbConfirm.Text = "確認";
            // 
            // btDecision
            // 
            this.btDecision.Location = new System.Drawing.Point(137, 18);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(258, 76);
            this.btDecision.TabIndex = 0;
            this.btDecision.Text = "確定";
            this.btDecision.UseVisualStyleBackColor = true;
            this.btDecision.Click += new System.EventHandler(this.btDecision_Click);
            // 
            // RenameForm
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
            this.Name = "RenameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFileControl.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbAddString.ResumeLayout(false);
            this.gbAddString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegerStart)).EndInit();
            this.gbReplace.ResumeLayout(false);
            this.gbReplace.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbClear.ResumeLayout(false);
            this.gbSelectFolder.ResumeLayout(false);
            this.gbSelectFolder.PerformLayout();
            this.gbConfirm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void SetDgvColumnName()
        {
            columnName = new string[]{
            "FileName", "FileDate", "FileSize", "FileKeyNumber"};
        }

        public string[] columnName { get; private set; }

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRestart;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.GroupBox gbFileControl;
        private System.Windows.Forms.Button btDeleteFile;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.CheckBox cbDescending;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.GroupBox gbReplace;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.GroupBox gbClear;
        private System.Windows.Forms.GroupBox gbSelectFolder;
        private System.Windows.Forms.GroupBox gbAddString;
        private System.Windows.Forms.TextBox tbRenameString;
        private System.Windows.Forms.RadioButton rbSame;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.RadioButton rbFront;
        private System.Windows.Forms.Label lbReplace1;
        private System.Windows.Forms.Label lbReplace0;
        private System.Windows.Forms.TextBox tbReplace1;
        private System.Windows.Forms.TextBox tbReplace0;
        private System.Windows.Forms.ComboBox cbIntegerDigits;
        private System.Windows.Forms.Label lbIntegerDigits;
        private System.Windows.Forms.CheckBox cbInteger;
        private System.Windows.Forms.NumericUpDown nudIntegerStart;
        private System.Windows.Forms.Label lbIntegerStart;
        private System.Windows.Forms.Button btFileNameClear;
        private System.Windows.Forms.CheckBox cbOverWriteSave;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.TextBox tbFolderName;
        private System.Windows.Forms.GroupBox gbConfirm;
        private System.Windows.Forms.Button btDecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileKeyNumber;
        private System.Windows.Forms.Label lbRenameString;
        private System.Windows.Forms.Button button1;
    }
}

