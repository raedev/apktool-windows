using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApkTool.Model;

namespace ApkTool
{
    internal class ApkToolShell
    {
        public static void Decode(string filePath, string outputDir)
        {
            string[] args = {
                outputDir,
                $"d {filePath} -f -o source",
                "解包"
            };
            new Thread(RunBat)
            {
                Name = "ApkToolThread",
                IsBackground = true

            }.Start(args);
        }

        public static void Build(string outputDir)
        {
            string[] args = {
                outputDir,
                $"b {outputDir}{Path.DirectorySeparatorChar}source -f -o release-unsigned.apk",
                "重新打包"
            };
            new Thread(RunBat)
            {
                Name = "ApkToolBuildThread",
                IsBackground = true

            }.Start(args);
        }

        static void RunBat(object obj)
        {
            var args = (string[])obj;
            var outputDir = args[0];
            var cmd = args[1];
            var cmdName = args[2];
            var proc = new Process();
            var batFile = new DirectoryInfo(".").FullName + Path.DirectorySeparatorChar + "tool" + Path.DirectorySeparatorChar + "apktool.bat";
            proc.StartInfo.WorkingDirectory = outputDir;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.FileName = batFile;
            proc.StartInfo.Arguments = cmd;
            proc.Start();
            while (!proc.HasExited)
            {
                Log.D(proc.StandardOutput.ReadLine());
            }

            var error = proc.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(error))
            {
                Log.E(error);
            }

            proc.WaitForExit();
            Log.D($"{cmdName}完成");
            Log.D($"{outputDir}");
        }

        public static void Sign(ProjectConfig config)
        {
            new Thread(RunSign)
            {
                Name = "ApkToolSignThread",
                IsBackground = true

            }.Start(config);
        }

        static void RunSign(object obj)
        {
            var config = (ProjectConfig)obj;
            var proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.WorkingDirectory = config.ProjectDir;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;

            var exec = new StringBuilder();
            exec.Append("java -jar ");
            exec.Append(new DirectoryInfo(".").FullName).Append(Path.DirectorySeparatorChar).Append("tool").Append(Path.DirectorySeparatorChar).Append("apksigner.jar");
            exec.Append(" sign --ks ");
            exec.Append(config.StoreFile);
            exec.Append(" --pass-encoding utf-8 --ks-pass pass:");
            exec.Append(config.StorePassword);
            exec.Append(" --ks-key-alias ");
            exec.Append(config.KeyAlias);
            exec.Append(" --v1-signing-enabled true --v2-signing-enabled true --out ");
            exec.Append(config.ProjectDir).Append(Path.DirectorySeparatorChar).Append("release.apk");
            exec.Append(" ").Append(config.ProjectDir).Append(Path.DirectorySeparatorChar).Append("release-unsigned.apk");

            proc.StartInfo.Arguments = "/c " + exec;

            Log.D(exec.ToString());

            proc.Start();
            while (!proc.HasExited)
            {
                Log.D(proc.StandardOutput.ReadLine());
            }

            var error = proc.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(error))
            {
                Log.E(error);
            }

            proc.WaitForExit();
            Log.D($"签名完成");
        }


        public static void Install(string file)
        {
            void InstallThread()
            {
                var adb = new DirectoryInfo(".").FullName + Path.DirectorySeparatorChar + "tool" + Path.DirectorySeparatorChar + "adb.exe";
                var proc = new Process();
                proc.StartInfo.FileName = adb;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.Arguments = "install " + file;
                proc.Start();
                while (!proc.HasExited)
                {
                    Log.D(proc.StandardOutput.ReadLine());
                }

                var error = proc.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(error))
                {
                    Log.E(error);
                }

                proc.WaitForExit();
                Log.D($"安装完成：{file}");
            }

            new Thread(InstallThread)
            {
                Name = "ApkToolInstallThread",
                IsBackground = true
            }.Start();

        }
    }
}
