namespace ApkTool
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDecode = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tabSign = new System.Windows.Forms.TabPage();
            this.btnSaveStore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKeyPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKeyAlias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStorePwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenSignFile = new System.Windows.Forms.Button();
            this.tbStoreFile = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDecode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础配置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "输出路径";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(138, 106);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(0, 24);
            this.lbOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apk文件";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1008, 45);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(161, 45);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "选择";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(129, 50);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(866, 35);
            this.tbFile.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDecode);
            this.tabControl1.Controls.Add(this.tabSign);
            this.tabControl1.Location = new System.Drawing.Point(21, 202);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 829);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDecode
            // 
            this.tabDecode.Controls.Add(this.groupBox3);
            this.tabDecode.Controls.Add(this.groupBox2);
            this.tabDecode.Location = new System.Drawing.Point(8, 39);
            this.tabDecode.Name = "tabDecode";
            this.tabDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecode.Size = new System.Drawing.Size(1172, 782);
            this.tabDecode.TabIndex = 0;
            this.tabDecode.Text = "反编译";
            this.tabDecode.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMessage);
            this.groupBox3.Location = new System.Drawing.Point(278, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(857, 730);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // tbMessage
            // 
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Location = new System.Drawing.Point(3, 31);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(851, 696);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Controls.Add(this.btnInstall);
            this.groupBox2.Controls.Add(this.btnSign);
            this.groupBox2.Controls.Add(this.btnBuild);
            this.groupBox2.Controls.Add(this.btnDecode);
            this.groupBox2.Location = new System.Drawing.Point(18, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 730);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(23, 394);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(171, 89);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "安装到手机";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(23, 279);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(171, 89);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "重新签名";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(23, 166);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(171, 89);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "重新打包";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(23, 51);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(171, 89);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "解包";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // tabSign
            // 
            this.tabSign.Controls.Add(this.btnSaveStore);
            this.tabSign.Controls.Add(this.label5);
            this.tabSign.Controls.Add(this.tbKeyPwd);
            this.tabSign.Controls.Add(this.label4);
            this.tabSign.Controls.Add(this.tbKeyAlias);
            this.tabSign.Controls.Add(this.label3);
            this.tabSign.Controls.Add(this.tbStorePwd);
            this.tabSign.Controls.Add(this.label2);
            this.tabSign.Controls.Add(this.btnOpenSignFile);
            this.tabSign.Controls.Add(this.tbStoreFile);
            this.tabSign.Location = new System.Drawing.Point(8, 39);
            this.tabSign.Name = "tabSign";
            this.tabSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabSign.Size = new System.Drawing.Size(1172, 782);
            this.tabSign.TabIndex = 1;
            this.tabSign.Text = "签名配置";
            this.tabSign.UseVisualStyleBackColor = true;
            // 
            // btnSaveStore
            // 
            this.btnSaveStore.Location = new System.Drawing.Point(127, 316);
            this.btnSaveStore.Name = "btnSaveStore";
            this.btnSaveStore.Size = new System.Drawing.Size(161, 45);
            this.btnSaveStore.TabIndex = 12;
            this.btnSaveStore.Text = "保存";
            this.btnSaveStore.UseVisualStyleBackColor = true;
            this.btnSaveStore.Click += new System.EventHandler(this.btnSaveStore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key密码";
            // 
            // tbKeyPwd
            // 
            this.tbKeyPwd.Location = new System.Drawing.Point(127, 237);
            this.tbKeyPwd.Name = "tbKeyPwd";
            this.tbKeyPwd.Size = new System.Drawing.Size(866, 35);
            this.tbKeyPwd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "KeyAlias";
            // 
            // tbKeyAlias
            // 
            this.tbKeyAlias.Location = new System.Drawing.Point(127, 169);
            this.tbKeyAlias.Name = "tbKeyAlias";
            this.tbKeyAlias.Size = new System.Drawing.Size(866, 35);
            this.tbKeyAlias.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "签名密码";
            // 
            // tbStorePwd
            // 
            this.tbStorePwd.Location = new System.Drawing.Point(127, 104);
            this.tbStorePwd.Name = "tbStorePwd";
            this.tbStorePwd.Size = new System.Drawing.Size(866, 35);
            this.tbStorePwd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "签名文件";
            // 
            // btnOpenSignFile
            // 
            this.btnOpenSignFile.Location = new System.Drawing.Point(1000, 30);
            this.btnOpenSignFile.Name = "btnOpenSignFile";
            this.btnOpenSignFile.Size = new System.Drawing.Size(161, 45);
            this.btnOpenSignFile.TabIndex = 4;
            this.btnOpenSignFile.Text = "选择";
            this.btnOpenSignFile.UseVisualStyleBackColor = true;
            this.btnOpenSignFile.Click += new System.EventHandler(this.btnOpenSignFile_Click);
            // 
            // tbStoreFile
            // 
            this.tbStoreFile.Location = new System.Drawing.Point(127, 35);
            this.tbStoreFile.Name = "tbStoreFile";
            this.tbStoreFile.Size = new System.Drawing.Size(866, 35);
            this.tbStoreFile.TabIndex = 3;
            // 
            // ofd
            // 
            this.ofd.Filter = "Apk文件|*.apk";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(23, 505);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(171, 89);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "清空输出";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 1043);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApkTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDecode.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabSign.ResumeLayout(false);
            this.tabSign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSign;
        private System.Windows.Forms.Button btnSaveStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKeyPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKeyAlias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStorePwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenSignFile;
        private System.Windows.Forms.TextBox tbStoreFile;
        private System.Windows.Forms.TabPage tabDecode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnClean;
    }
}

