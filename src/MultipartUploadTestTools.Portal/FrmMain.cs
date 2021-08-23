using MultipartUploadTestTools_Core.Common;
using MultipartUploadTestTools_Core.Model;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipartUploadTestTools.Portal
{
    public partial class FrmMain : Form
    {
        private readonly string lbFileNameText = "FileName:";
        private readonly string lbFileLengthText = "FileLength:";
        private readonly string lbFileMD5Text = "FileMD5:";
        private readonly string lbTotalPartTitle = "TotalPart:";
        private readonly string frmMainTitle = "MultipartUploadTestTools";

        private MultipartUploadTestTools_Core.Model.FileInfo currentFileInfo = null;
        private long blockSize = 1024 * 1024;
        private string currentSavePath = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            WriteLog(LogType.Info, "Welcome to use the file MutipartUpload test tool, please select a file to start your test.");
        }

        private void ntxtCustomSize_ValueChanged(object sender, EventArgs e)
        {
            blockSize = (long)(ntxtCustomSize.Value * 1024);
            WriteLog(LogType.Log, $"Choose file slice size as {blockSize / 1024}(K).");
        }

        private void rbtnBlockSize_CheckedChanged(object sender, EventArgs e)
        {
            var rbtnControl = sender as RadioButton;

            if (rbtnControl == null || !rbtnControl.Checked)
                return;

            if (int.TryParse(rbtnControl.Tag.ToString(), out var size))
            {
                if (size > 0)
                {
                    ntxtCustomSize.Enabled = false;
                    blockSize = size;
                }
                else
                {
                    blockSize = (long)(ntxtCustomSize.Value * 1024);
                    ntxtCustomSize.Enabled = true;
                }
                WriteLog(LogType.Log, $"Choose file slice size as {blockSize / 1024}(K).");
            }
        }

        private async void btnOpenFile_Click(object sender, EventArgs e)
        {
            WriteLog(LogType.Log, "Select file...");

            using (var openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    WriteLog(LogType.Log, "Loading file information, please wait...");
                    Text = frmMainTitle + " (waiting...)";

                    var selectedFileInfo = await FileHelper.GetFileInfoAsync(openFile.FileName);
                    if (selectedFileInfo.Exception != null)
                    {
                        WriteLog(LogType.Error, $"Failed to select file,because:\r\b{selectedFileInfo.Exception.Message}.");
                        return;
                    }

                    currentFileInfo = selectedFileInfo;
                    txtFilePath.Text = currentFileInfo.Path;
                    lbFileName.Text = lbFileNameText + currentFileInfo.Name;
                    lbFileLength.Text = $"{ lbFileLengthText + currentFileInfo.LengthKB}K,{currentFileInfo.LengthMB}M";
                    lbFileMD5.Text = $"{lbFileMD5Text + currentFileInfo.MD5}({currentFileInfo.MD5ComputingTime}ms)";
                    if (string.IsNullOrEmpty(currentSavePath))
                    {
                        txtSavePath.Text = currentSavePath = Environment.CurrentDirectory + "\\" + Path.GetFileNameWithoutExtension(currentFileInfo.Name);
                    }

                    Text = frmMainTitle;


                    WriteLog(LogType.Info, $"The file is loaded, the file name is {currentFileInfo.Name}, the size is {currentFileInfo.Length}b, the MD5 is {currentFileInfo.MD5}, and the total time is {currentFileInfo.MD5ComputingTime}ms.");
                }
                else
                {
                    WriteLog(LogType.Log, "The file is cancel selected.");
                }
            }
        }

        private void btnSlice_Click(object sender, EventArgs e)
        {
            if (currentFileInfo == null)
            {
                WriteLog(LogType.Error, "Slicing file failed because no file was selected.");
                MessageBox.Show("Please select file first", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(currentSavePath))
            {
                WriteLog(LogType.Error, "Slicing file failed because the save path was not selected.");
                MessageBox.Show("Please select the save path first", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lvMutipartFiles.Items.Clear();
            Task.Run(async () =>
            {
                try
                {
                    using (var stream = new FileStream(currentFileInfo.Path, FileMode.Open))
                    {
                        var totalPart = (int)Math.Ceiling(stream.Length / (blockSize * 1.0));
                        var streamIndex = 0;
                        var startTime = DateTime.Now;

                        for (int i = 0; i < totalPart; i++)
                        {
                            var writeBuffer = new byte[blockSize];
                            var realLength = await stream.ReadAsync(writeBuffer, 0, writeBuffer.Length);
                            var saveFileName = $"{Path.GetFileNameWithoutExtension(stream.Name)}_{DateTime.Now.ToString("yyyyyMMddHHmmssffff")}_part_{(i + 1)}";

                            if (!Directory.Exists(currentSavePath))
                                Directory.CreateDirectory(currentSavePath);

                            using (var saveStream = new FileStream(currentSavePath + "\\" + saveFileName, FileMode.OpenOrCreate))
                            {
                                await saveStream.WriteAsync(writeBuffer, 0, realLength);
                                saveStream.Close();
                            }

                            ListViewItem item = new ListViewItem
                            {
                                Text = (i + 1).ToString(),
                            };
                            item.SubItems.Add(new ListViewItem.ListViewSubItem { Text = saveFileName });
                            item.SubItems.Add(new ListViewItem.ListViewSubItem { Text = (i * realLength).ToString() });
                            item.SubItems.Add(new ListViewItem.ListViewSubItem { Text = realLength.ToString() });
                            item.SubItems.Add(new ListViewItem.ListViewSubItem { Text = "Ready" });

                            if (lvMutipartFiles.InvokeRequired)
                            {
                                lvMutipartFiles.Invoke(new Action<ListViewItem>(newItem =>
                                {
                                    lvMutipartFiles.Items.Add(newItem);
                                    newItem.EnsureVisible();
                                }), item);
                            }

                            streamIndex += realLength;
                            stream.Seek(streamIndex, SeekOrigin.Begin);
                        }

                        if (lvMutipartFiles.InvokeRequired)
                        {
                            lvMutipartFiles.Invoke(new Action(() =>
                            {
                                WriteLog(LogType.Info, $"The file {currentFileInfo.Name} is cut successfully, a total of {totalPart} pieces, and the total time is {(DateTime.Now - startTime).TotalMilliseconds}(ms).");
                                lbTotalPart.Text = lbTotalPartTitle + totalPart.ToString();
                            }));
                        }
                    }

                }
                catch (Exception ex)
                {
                    WriteLog(LogType.Error, "Failed to cut the file because:\r\n" + ex.Message);
                }
            });
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            WriteLog(LogType.Log, "Select save path...");

            using (var savePathDialog = new FolderBrowserDialog())
            {
                savePathDialog.RootFolder = Environment.SpecialFolder.ApplicationData;
                if (savePathDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSavePath.Text = currentSavePath = savePathDialog.SelectedPath;
                    WriteLog(LogType.Log, $"Select the save path as {currentSavePath}.");
                }
                else
                {
                    WriteLog(LogType.Log, "The path is cancel selected.");
                }
            }
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            currentSavePath = txtSavePath.Text;
        }

        private void WriteLog(LogType logType, string log)
        {
            var currentTime = DateTime.Now;

            rtxtLog.SelectionStart = rtxtLog.TextLength;

            rtxtLog.SelectionColor = Color.Black;
            rtxtLog.SelectedText = $"【{currentTime}】 ";
            rtxtLog.SelectionColor = GetColorFromLogType(logType);
            rtxtLog.SelectedText = log + "\r\n";
            rtxtLog.ScrollToCaret();
        }

        private Color GetColorFromLogType(LogType logType)
        {
            var logColor = Color.Black;

            if (logType == LogType.Error)
                logColor = Color.Red;
            if (logType == LogType.Info)
                logColor = Color.Green;

            return logColor;
        }

        private async void btnGetUploadConfig_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://translate.google.com/?sl=zh-CN&tl=en&text=%E6%8F%90%E4%BA%A4%E4%B8%8A%E4%BC%A0%E6%96%87%E4%BB%B6&op=translate");
                var responseBody = await response.Content.ReadAsStringAsync();
                WriteLog(LogType.Log, $"Get upload config {responseBody}.");
            }
        }

        private void btnGetUploadSignature_Click(object sender, EventArgs e)
        {
            var item = lvMutipartFiles.Items[2];
            item.ForeColor = Color.Red;
        }
    }
}
