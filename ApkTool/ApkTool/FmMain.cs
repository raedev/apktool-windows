using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApkTool.Model;

namespace ApkTool
{
    public partial class FmMain : Form
    {
        private readonly ApkTool _tool = new ApkTool();


        public FmMain()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _tool.OnError += _tool_OnError;
            Log.OnLogEvent += Logger_OnLogEvent;
            // 测试使用
            //_tool.Config = new ProjectConfig(@"C:\Users\rae\Downloads\test.apk").Load();
            //RefreshConfig();
        }

        private void Logger_OnLogEvent(string message)
        {
            tbMessage.AppendText(message);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Apk文件|*.apk";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName)) return;
            _tool.Config = new ProjectConfig(ofd.FileName).Load();
            RefreshConfig();
        }

        private void _tool_OnError(object sender, ErrorEventArgs e)
        {
            Log.E(e.GetException().Message);
        }

        private void RefreshConfig()
        {
            var config = _tool.Config;
            tbFile.Text = config.ApKFilePath;
            lbOutput.Text = config.OutputFile;
            tbStoreFile.Text = config.StoreFile;
            tbStorePwd.Text = config.StorePassword;
            tbKeyAlias.Text = config.KeyAlias;
            tbKeyPwd.Text = config.KeyAliasPassword;
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            var config = _tool.Config;
            config.StoreFile = tbStoreFile.Text;
            config.StorePassword = tbStorePwd.Text;
            config.KeyAlias = tbKeyAlias.Text;
            config.KeyAliasPassword = tbKeyPwd.Text;
            config.Save();
            RefreshConfig();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            Log.D("开始解包..");
            _tool.Decode();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Log.D("开始重新打包..");
            _tool.Build();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Log.D("开始重新签名..");
            _tool.Sign();
        }

        private void btnOpenSignFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Keystore文件|*.jks";
            ofd.ShowDialog();
            _tool.Config.StoreFile = ofd.FileName;
            RefreshConfig();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (_tool.Config == null)
            {
                Log.E("请先选择文件");
                return;
            }

            var file = _tool.Config.OutputFile;
            if (File.Exists(file))
            {
                Log.D("安装文件：" + file);
                ApkToolShell.Install(file);
            }
            else
            {
                Log.E("文件不存在：" + file);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbMessage.Clear();
        }
    }
}