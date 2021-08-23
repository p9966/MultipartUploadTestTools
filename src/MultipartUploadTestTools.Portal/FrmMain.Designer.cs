
namespace MultipartUploadTestTools.Portal
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFileLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbFileMD5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTotalPart = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnMultipartFiles = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMutipartFiles = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tbOperate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnResetMutipart = new System.Windows.Forms.Button();
            this.btnSlice = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ntxtCustomSize = new System.Windows.Forms.NumericUpDown();
            this.rbtnCustome = new System.Windows.Forms.RadioButton();
            this.rbtn10M = new System.Windows.Forms.RadioButton();
            this.rbtn5M = new System.Windows.Forms.RadioButton();
            this.rbtn3M = new System.Windows.Forms.RadioButton();
            this.rbtn2M = new System.Windows.Forms.RadioButton();
            this.rbtn1M = new System.Windows.Forms.RadioButton();
            this.rbtn512K = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGetUploadSignature = new System.Windows.Forms.Button();
            this.btnGetUploadConfig = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnMultipartFiles.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbOperate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtCustomSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFileName
            // 
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(74, 17);
            this.lbFileName.Text = "FileName：";
            this.lbFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFileLength
            // 
            this.lbFileLength.Name = "lbFileLength";
            this.lbFileLength.Size = new System.Drawing.Size(78, 17);
            this.lbFileLength.Text = "FileLength：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbFileName,
            this.lbFileLength,
            this.lbFileMD5,
            this.lbTotalPart});
            this.statusStrip1.Location = new System.Drawing.Point(0, 839);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbFileMD5
            // 
            this.lbFileMD5.Name = "lbFileMD5";
            this.lbFileMD5.Size = new System.Drawing.Size(67, 17);
            this.lbFileMD5.Text = "FileMD5：";
            // 
            // lbTotalPart
            // 
            this.lbTotalPart.Name = "lbTotalPart";
            this.lbTotalPart.Size = new System.Drawing.Size(63, 17);
            this.lbTotalPart.Text = "TotalPart:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 75);
            this.panel1.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.Location = new System.Drawing.Point(778, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset(&R)";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenFile.Location = new System.Drawing.Point(697, 24);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 26);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open(&O)";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(89, 26);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(590, 23);
            this.txtFilePath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "FilePath";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 709);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.Color.White;
            this.rtxtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtLog.Location = new System.Drawing.Point(3, 19);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(878, 108);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 706);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(884, 3);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // pnMultipartFiles
            // 
            this.pnMultipartFiles.Controls.Add(this.groupBox2);
            this.pnMultipartFiles.Controls.Add(this.splitter2);
            this.pnMultipartFiles.Controls.Add(this.tbOperate);
            this.pnMultipartFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMultipartFiles.Location = new System.Drawing.Point(0, 75);
            this.pnMultipartFiles.Name = "pnMultipartFiles";
            this.pnMultipartFiles.Size = new System.Drawing.Size(884, 631);
            this.pnMultipartFiles.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMutipartFiles);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 468);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multipart Files";
            // 
            // lvMutipartFiles
            // 
            this.lvMutipartFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMutipartFiles.CheckBoxes = true;
            this.lvMutipartFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvMutipartFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMutipartFiles.FullRowSelect = true;
            this.lvMutipartFiles.HideSelection = false;
            this.lvMutipartFiles.Location = new System.Drawing.Point(3, 19);
            this.lvMutipartFiles.Name = "lvMutipartFiles";
            this.lvMutipartFiles.Size = new System.Drawing.Size(878, 446);
            this.lvMutipartFiles.TabIndex = 0;
            this.lvMutipartFiles.UseCompatibleStateImageBehavior = false;
            this.lvMutipartFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileName";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Offset";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Upload";
            this.columnHeader5.Width = 100;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 160);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(884, 3);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // tbOperate
            // 
            this.tbOperate.Controls.Add(this.tabPage1);
            this.tbOperate.Controls.Add(this.tabPage2);
            this.tbOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOperate.Location = new System.Drawing.Point(0, 0);
            this.tbOperate.Name = "tbOperate";
            this.tbOperate.SelectedIndex = 0;
            this.tbOperate.Size = new System.Drawing.Size(884, 160);
            this.tbOperate.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectPath);
            this.tabPage1.Controls.Add(this.btnResetMutipart);
            this.tabPage1.Controls.Add(this.btnSlice);
            this.tabPage1.Controls.Add(this.txtSavePath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ntxtCustomSize);
            this.tabPage1.Controls.Add(this.rbtnCustome);
            this.tabPage1.Controls.Add(this.rbtn10M);
            this.tabPage1.Controls.Add(this.rbtn5M);
            this.tabPage1.Controls.Add(this.rbtn3M);
            this.tabPage1.Controls.Add(this.rbtn2M);
            this.tabPage1.Controls.Add(this.rbtn1M);
            this.tabPage1.Controls.Add(this.rbtn512K);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Multipart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectPath.Location = new System.Drawing.Point(600, 71);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 26);
            this.btnSelectPath.TabIndex = 18;
            this.btnSelectPath.Text = "Select(&C)";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnResetMutipart
            // 
            this.btnResetMutipart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResetMutipart.Location = new System.Drawing.Point(774, 71);
            this.btnResetMutipart.Name = "btnResetMutipart";
            this.btnResetMutipart.Size = new System.Drawing.Size(75, 26);
            this.btnResetMutipart.TabIndex = 17;
            this.btnResetMutipart.Text = "Reset(&R)";
            this.btnResetMutipart.UseVisualStyleBackColor = true;
            // 
            // btnSlice
            // 
            this.btnSlice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSlice.Location = new System.Drawing.Point(693, 71);
            this.btnSlice.Name = "btnSlice";
            this.btnSlice.Size = new System.Drawing.Size(75, 26);
            this.btnSlice.TabIndex = 16;
            this.btnSlice.Text = "Slice(&S)";
            this.btnSlice.UseVisualStyleBackColor = true;
            this.btnSlice.Click += new System.EventHandler(this.btnSlice_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(85, 73);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(509, 23);
            this.txtSavePath.TabIndex = 15;
            this.txtSavePath.TextChanged += new System.EventHandler(this.txtSavePath_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "SavePath";
            // 
            // ntxtCustomSize
            // 
            this.ntxtCustomSize.Enabled = false;
            this.ntxtCustomSize.Location = new System.Drawing.Point(571, 34);
            this.ntxtCustomSize.Maximum = new decimal(new int[] {
            52428800,
            0,
            0,
            0});
            this.ntxtCustomSize.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ntxtCustomSize.Name = "ntxtCustomSize";
            this.ntxtCustomSize.Size = new System.Drawing.Size(104, 23);
            this.ntxtCustomSize.TabIndex = 13;
            this.ntxtCustomSize.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ntxtCustomSize.ValueChanged += new System.EventHandler(this.ntxtCustomSize_ValueChanged);
            // 
            // rbtnCustome
            // 
            this.rbtnCustome.AutoSize = true;
            this.rbtnCustome.Location = new System.Drawing.Point(480, 34);
            this.rbtnCustome.Name = "rbtnCustome";
            this.rbtnCustome.Size = new System.Drawing.Size(94, 21);
            this.rbtnCustome.TabIndex = 12;
            this.rbtnCustome.Tag = "0";
            this.rbtnCustome.Text = "Custom(KB)";
            this.rbtnCustome.UseVisualStyleBackColor = true;
            this.rbtnCustome.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn10M
            // 
            this.rbtn10M.AutoSize = true;
            this.rbtn10M.Location = new System.Drawing.Point(410, 34);
            this.rbtn10M.Name = "rbtn10M";
            this.rbtn10M.Size = new System.Drawing.Size(52, 21);
            this.rbtn10M.TabIndex = 11;
            this.rbtn10M.Tag = "10485760";
            this.rbtn10M.Text = "10M";
            this.rbtn10M.UseVisualStyleBackColor = true;
            this.rbtn10M.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn5M
            // 
            this.rbtn5M.AutoSize = true;
            this.rbtn5M.Location = new System.Drawing.Point(347, 34);
            this.rbtn5M.Name = "rbtn5M";
            this.rbtn5M.Size = new System.Drawing.Size(45, 21);
            this.rbtn5M.TabIndex = 10;
            this.rbtn5M.Tag = "5242880";
            this.rbtn5M.Text = "5M";
            this.rbtn5M.UseVisualStyleBackColor = true;
            this.rbtn5M.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn3M
            // 
            this.rbtn3M.AutoSize = true;
            this.rbtn3M.Location = new System.Drawing.Point(284, 34);
            this.rbtn3M.Name = "rbtn3M";
            this.rbtn3M.Size = new System.Drawing.Size(45, 21);
            this.rbtn3M.TabIndex = 9;
            this.rbtn3M.Tag = "3145728";
            this.rbtn3M.Text = "3M";
            this.rbtn3M.UseVisualStyleBackColor = true;
            this.rbtn3M.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn2M
            // 
            this.rbtn2M.AutoSize = true;
            this.rbtn2M.Location = new System.Drawing.Point(221, 34);
            this.rbtn2M.Name = "rbtn2M";
            this.rbtn2M.Size = new System.Drawing.Size(45, 21);
            this.rbtn2M.TabIndex = 8;
            this.rbtn2M.Tag = "2097152";
            this.rbtn2M.Text = "2M";
            this.rbtn2M.UseVisualStyleBackColor = true;
            this.rbtn2M.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn1M
            // 
            this.rbtn1M.AutoSize = true;
            this.rbtn1M.Checked = true;
            this.rbtn1M.Location = new System.Drawing.Point(158, 34);
            this.rbtn1M.Name = "rbtn1M";
            this.rbtn1M.Size = new System.Drawing.Size(45, 21);
            this.rbtn1M.TabIndex = 7;
            this.rbtn1M.TabStop = true;
            this.rbtn1M.Tag = "1048576";
            this.rbtn1M.Text = "1M";
            this.rbtn1M.UseVisualStyleBackColor = true;
            this.rbtn1M.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // rbtn512K
            // 
            this.rbtn512K.AutoSize = true;
            this.rbtn512K.Location = new System.Drawing.Point(85, 34);
            this.rbtn512K.Name = "rbtn512K";
            this.rbtn512K.Size = new System.Drawing.Size(55, 21);
            this.rbtn512K.TabIndex = 6;
            this.rbtn512K.Tag = "524288";
            this.rbtn512K.Text = "512K";
            this.rbtn512K.UseVisualStyleBackColor = true;
            this.rbtn512K.CheckedChanged += new System.EventHandler(this.rbtnBlockSize_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "BlockSize";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btnGetUploadSignature);
            this.tabPage2.Controls.Add(this.btnGetUploadConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "Step5. SubmitUploadFile";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Step4. MergeUploadFiles";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Step3. UploadSelectFiles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGetUploadSignature
            // 
            this.btnGetUploadSignature.Location = new System.Drawing.Point(235, 36);
            this.btnGetUploadSignature.Name = "btnGetUploadSignature";
            this.btnGetUploadSignature.Size = new System.Drawing.Size(198, 26);
            this.btnGetUploadSignature.TabIndex = 4;
            this.btnGetUploadSignature.Text = "Step2. GetUploadSignature";
            this.btnGetUploadSignature.UseVisualStyleBackColor = true;
            this.btnGetUploadSignature.Click += new System.EventHandler(this.btnGetUploadSignature_Click);
            // 
            // btnGetUploadConfig
            // 
            this.btnGetUploadConfig.Location = new System.Drawing.Point(27, 36);
            this.btnGetUploadConfig.Name = "btnGetUploadConfig";
            this.btnGetUploadConfig.Size = new System.Drawing.Size(198, 26);
            this.btnGetUploadConfig.TabIndex = 3;
            this.btnGetUploadConfig.Text = "Step1. GetUploadConfig";
            this.btnGetUploadConfig.UseVisualStyleBackColor = true;
            this.btnGetUploadConfig.Click += new System.EventHandler(this.btnGetUploadConfig_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.pnMultipartFiles);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultipartUpload-TestTools";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnMultipartFiles.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tbOperate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtCustomSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel lbFileName;
        private System.Windows.Forms.ToolStripStatusLabel lbFileLength;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbFileMD5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnMultipartFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabControl tbOperate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ntxtCustomSize;
        private System.Windows.Forms.RadioButton rbtnCustome;
        private System.Windows.Forms.RadioButton rbtn10M;
        private System.Windows.Forms.RadioButton rbtn5M;
        private System.Windows.Forms.RadioButton rbtn3M;
        private System.Windows.Forms.RadioButton rbtn2M;
        private System.Windows.Forms.RadioButton rbtn1M;
        private System.Windows.Forms.RadioButton rbtn512K;
        private System.Windows.Forms.Button btnResetMutipart;
        private System.Windows.Forms.Button btnSlice;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.ToolStripStatusLabel lbTotalPart;
        private System.Windows.Forms.ListView lvMutipartFiles;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGetUploadSignature;
        private System.Windows.Forms.Button btnGetUploadConfig;
    }
}

