using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApkTool.Model;

namespace ApkTool
{
    internal class ApkTool
    {
        public ProjectConfig Config { get; set; }

        public event ErrorEventHandler OnError;

        private void WriteError(string message)
        {
            OnError?.Invoke(this, new ErrorEventArgs(new NullReferenceException(message)));
        }


        public void Decode()
        {
            if (Config == null || !Config.CheckFileExists())
            {
                WriteError("请先选择文件");
                return;
            }

            Log.D($"正在解包：{Config.ApKFilePath}");
            ApkToolShell.Decode(Config.ApKFilePath, Config.ProjectDir);

        }


        public void Build()
        {

            if (Config == null || !Config.CheckFileExists())
            {
                WriteError("请先选择文件");
                return;
            }
            if (!File.Exists(Config.ProjectDir + Path.DirectorySeparatorChar + "source" + Path.DirectorySeparatorChar + "apktool.yml"))
            {
                WriteError("请先解包");
                return;
            }

            Log.D($"正在重新打包：{Config.ApKFilePath}");
            ApkToolShell.Build(Config.ProjectDir);

        }

        public void Sign()
        {

            if (Config == null || !Config.CheckFileExists())
            {
                WriteError("请先选择文件");
                return;
            }
            if (!File.Exists(Config.UnSignedFile))
            {
                WriteError("请先重新打包");
                return;
            }

            if (!File.Exists(Config.StoreFile))
            {
                WriteError("签名文件不存在：" + Config.StoreFile);
                return;
            }
            if (string.IsNullOrEmpty(Config.StorePassword))
            {
                WriteError("签名密码不能为空");
                return;
            }
            if (string.IsNullOrEmpty(Config.KeyAlias) || string.IsNullOrEmpty(Config.KeyAliasPassword))
            {
                WriteError("请填写签名KeyAlias信息");
                return;
            }
            Log.D("正在签名...");
            ApkToolShell.Sign(Config);
        }
    }
}
