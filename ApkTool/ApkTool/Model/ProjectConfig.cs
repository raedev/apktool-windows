using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApkTool.Model
{
    /// <summary>
    /// 项目配置信息
    /// </summary>
    internal class ProjectConfig
    {
        public string ProjectId { get; }

        /// <summary>
        /// 项目目录
        /// </summary>
        public string ProjectDir
        {
            get
            {
                var path = ApkFile.DirectoryName + Path.DirectorySeparatorChar +
                           "ApkTool-" + ApkFile.Name.Replace(".apk", "");
                // 创建文件夹
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }

        /// <summary>
        /// 项目文件
        /// </summary>
        public string ProjectFile => ProjectId + ".json";

        /// <summary>
        /// Apk文件
        /// </summary>
        public string ApKFilePath { get; set; }

        /// <summary>
        /// 文件信息
        /// </summary>
        private FileInfo ApkFile => new FileInfo(ApKFilePath);

        /// <summary>
        /// 输出文件
        /// </summary>
        public string OutputFile => ProjectDir + Path.DirectorySeparatorChar + "release.apk";

        /// <summary>
        /// 未签名的文件
        /// </summary>
        public string UnSignedFile => ProjectDir + Path.DirectorySeparatorChar + "release-unsigned.apk";

        public string StoreFile { get; set; }
        public string StorePassword { get; set; }
        public string KeyAlias { get; set; }
        public string KeyAliasPassword { get; set; }

        public ProjectConfig()
        {

        }

        public ProjectConfig(string filePath)
        {
            ApKFilePath = filePath;
            ProjectId = GetProjectId(filePath);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static string GetProjectId(string path)
        {
            return Md5(path);
        }

        public ProjectConfig Load()
        {
            if (!File.Exists(ProjectFile))
            {
                return this;
            }

            var json = File.ReadAllText(ProjectFile);
            if (string.IsNullOrEmpty(json))
            {
                return this;
            }
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<ProjectConfig>(json);
            if (obj == null)
            {
                return this;
            }
            this.StoreFile = obj.StoreFile;
            this.StorePassword = obj.StorePassword;
            this.KeyAlias = obj.KeyAlias;
            this.KeyAliasPassword = obj.KeyAliasPassword;
            return this;
        }

        /// <summary>
        /// 检查APK文件是否存在
        /// </summary>
        /// <returns></returns>
        public bool CheckFileExists()
        {
            return !string.IsNullOrEmpty(ApKFilePath) && File.Exists(this.ApKFilePath);
        }


        private static string Md5(string value)
        {
            var b = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
            var sb = new StringBuilder("prj");
            foreach (var item in b)
            {
                sb.Append(item.ToString("X2"));
            }
            return sb.ToString();
        }

        public void Save()
        {
            string json = ToString();
            File.WriteAllText(ProjectFile, json);
        }
    }
}
