using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Yahoo.Yui.Compressor;
using System.Windows.Forms;

namespace TintSoft
{
    public partial class Main : Form
    {
        private int jsCount;
        private int cssCount;
        private string strFilePath = "";
        private IList<FileInfo> fileList = new List<FileInfo>();

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtPath.Text))
            {
                MessageBox.Show("路径不存在，请重新选择！");
                this.btnSelect.PerformClick();
            }
            else
            {
                this.strFilePath = this.txtPath.Text;
                this.jsCount = 0;
                this.cssCount = 0;
                this.fileList.Clear();
                this.ListFile.Items.Clear();
                this.GetDirList(new DirectoryInfo(this.txtPath.Text));
                if (this.fileList.Count == 0)
                { 
                    this.btnCompressor.Enabled = false;
                    MessageBox.Show("未找到js或css文件！");
                }
                else
                {
                    this.txtInfo.Text = "共加载了" + this.jsCount.ToString() + "个JS文件、" + this.cssCount.ToString() + "个CSS文件！";
                    this.ListFile.BeginUpdate();
                    foreach (FileInfo info in this.fileList)
                    {
                        ListViewItem item = new ListViewItem(info.FullName.Replace(this.txtPath.Text, ""), 0);
                        item.SubItems.Add(this.FormatSize(info.Length));
                        item.SubItems.Add("");
                        item.SubItems.Add("就绪");
                        this.ListFile.Items.Add(item);
                    }
                    this.ListFile.EndUpdate();
                    this.btnCompressor.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompressor_Click(object sender, EventArgs e)
        {
            if (this.ListFile.Items.Count != 0)
            {
                Encoding encoding = this.GetEncoding();
                int num = 0;
                long num2 = 0L;
                long num3 = 0L;
                for (int i = 0; i < this.fileList.Count; i++)
                {
                    try
                    {
                        FileInfo finfo = this.fileList[i];
                        //读取文件内容
                        string javaScript = File.ReadAllText(finfo.FullName, encoding);
                        if (!finfo.Name.Contains(".min."))
                        {
                            //取消文件只读
                            File.SetAttributes(finfo.FullName, FileAttributes.Normal);
                            if (finfo.Extension.ToLower() == ".js")
                            {
                                //初始化JS压缩类
                                var js = new JavaScriptCompressor();
                                js.CompressionType = CompressionType.Standard;//压缩类型
                                js.Encoding = encoding;//编码
                                js.IgnoreEval = false;//大小写转换
                                js.ThreadCulture = System.Globalization.CultureInfo.CurrentCulture;
                                //压缩该js
                                javaScript = js.Compress(javaScript);
                            }
                            else if (finfo.Extension.ToLower() == ".css")
                            {
                                //进行CSS压缩
                                CssCompressor css = new CssCompressor();
                                javaScript = css.Compress(javaScript);
                            }

                            string filePath = finfo.FullName.Replace(finfo.Name, "");
                            // 没有扩展名的文件名 “Default”
                            string fimeName = filePath + Path.GetFileNameWithoutExtension(finfo.FullName) + ".min" + finfo.Extension.ToLower(); ;
                            //写入文件内容
                            File.WriteAllText(fimeName, javaScript);
                            this.ListFile.Items[i].ForeColor = Color.Blue;
                            this.ListFile.Items[i].SubItems[2].Text = this.FormatSize((long)javaScript.Length);
                            this.ListFile.Items[i].SubItems[3].Text = "完成";
                            num2 += finfo.Length;
                            num3 += javaScript.Length;
                        }
                        else //跳过
                        {
                            this.ListFile.Items[i].SubItems[2].Text = this.FormatSize((long)javaScript.Length);
                            this.ListFile.Items[i].SubItems[3].Text = "跳过";
                            num2 += finfo.Length;
                            num3 += javaScript.Length;
                        }
                    }
                    catch (Exception exception)
                    {
                        this.ListFile.Items[i].ForeColor = Color.Red;
                        this.ListFile.Items[i].SubItems[2].Text = "0";
                        this.ListFile.Items[i].SubItems[3].Text = "错误:" + exception.Message;
                        num++;
                    }
                    int num5 = i + 1;
                    this.txtInfo.Text = "共" + this.fileList.Count.ToString() + "个文件！正处理第" + num5.ToString() + "个文件！";
                    Application.DoEvents();
                }
                string text = "压缩完成！\r\n";
                if (num > 0)
                {
                    text = text + num.ToString() + "个文件压缩发生错误！\r\n";
                }
                text = text + "总体压缩：";
                text = text + ((((1.0 * num3) / ((double)num2)) * 100.0)).ToString() + "%";
                this.txtInfo.Text = text.Replace("\r\n", " ");
                if (num > 0)
                {
                    MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show(text, "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //Process.Start(fileinfo.FullName);
            }
            else 
            {
                MessageBox.Show("请选择要压缩的路径！");
            }
        }

        private string FormatSize(long size)
        {
            string str = "";
            double num = (size * 1.0) * ((size < 0L) ? ((double)(-1)) : ((double)1));
            if (num < 1024.0)
            {
                str = str + num.ToString() + "B";
            }
            else if (num < 1048576.0)
            {
                num /= 1024.0;
                str = str + num.ToString("0.##") + "K";
            }
            else if (num < 1073741824.0)
            {
                num = (num / 1024.0) / 1024.0;
                str = str + num.ToString("0.##") + "M";
            }
            else
            {
                str = str + ((((num / 1024.0) / 1024.0) / 1024.0)).ToString("0.##") + "G";
            }
            if (size < 0L)
            {
                str = "-" + str;
            }
            return str;
        }

        private void GetDirList(DirectoryInfo dir)
        {
            foreach (FileInfo info in dir.GetFiles("*.js"))
            {
                this.jsCount++;
                this.fileList.Add(info);
            }
            foreach (FileInfo info2 in dir.GetFiles("*.css"))
            {
                this.cssCount++;
                this.fileList.Add(info2);
            }
            DirectoryInfo[] directories = dir.GetDirectories();
            if (directories.Length > 0)
            {
                foreach (DirectoryInfo info3 in directories)
                {
                    this.GetDirList(info3);
                }
            }
        }

        private Encoding GetEncoding()
        {
            Encoding encoding = Encoding.Default;
            string str = this.cbEncoder.SelectedItem.ToString();
            if (str == null)
            {
                return encoding;
            }
            if (!(str == "UTF8"))
            {
                if (str != "ASCII")
                {
                    if (str == "Default")
                    {
                        return Encoding.Default;
                    }
                    if (str != "Unicode")
                    {
                        return encoding;
                    }
                    return Encoding.Unicode;
                }
            }
            else
            {
                return Encoding.UTF8;
            }
            return Encoding.ASCII;
        }

        private void linkadmin5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.tintsoft.com");
        }
    }
}
