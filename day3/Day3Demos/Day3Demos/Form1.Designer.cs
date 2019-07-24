namespace Day3Demos
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileSaveContent = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtTcpReceived = new System.Windows.Forms.TextBox();
            this.btnStartTcpServer = new System.Windows.Forms.Button();
            this.tcpListenerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnBeginAcceptTcpServer = new System.Windows.Forms.Button();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(126, 79);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(55, 183);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(236, 127);
            this.txtFile.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(129, 316);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txtFileSaveContent
            // 
            this.txtFileSaveContent.Location = new System.Drawing.Point(396, 183);
            this.txtFileSaveContent.Multiline = true;
            this.txtFileSaveContent.Name = "txtFileSaveContent";
            this.txtFileSaveContent.Size = new System.Drawing.Size(236, 127);
            this.txtFileSaveContent.TabIndex = 3;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(481, 316);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // txtTcpReceived
            // 
            this.txtTcpReceived.Location = new System.Drawing.Point(55, 381);
            this.txtTcpReceived.Multiline = true;
            this.txtTcpReceived.Name = "txtTcpReceived";
            this.txtTcpReceived.Size = new System.Drawing.Size(236, 127);
            this.txtTcpReceived.TabIndex = 3;
            // 
            // btnStartTcpServer
            // 
            this.btnStartTcpServer.Location = new System.Drawing.Point(117, 515);
            this.btnStartTcpServer.Name = "btnStartTcpServer";
            this.btnStartTcpServer.Size = new System.Drawing.Size(125, 23);
            this.btnStartTcpServer.TabIndex = 5;
            this.btnStartTcpServer.Text = "Start TCP Server";
            this.btnStartTcpServer.UseVisualStyleBackColor = true;
            this.btnStartTcpServer.Click += new System.EventHandler(this.BtnStartTcpServer_Click);
            // 
            // tcpListenerBackgroundWorker
            // 
            this.tcpListenerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TcpListenerBackgroundWorker_DoWork);
            // 
            // btnBeginAcceptTcpServer
            // 
            this.btnBeginAcceptTcpServer.Location = new System.Drawing.Point(260, 515);
            this.btnBeginAcceptTcpServer.Name = "btnBeginAcceptTcpServer";
            this.btnBeginAcceptTcpServer.Size = new System.Drawing.Size(201, 23);
            this.btnBeginAcceptTcpServer.TabIndex = 5;
            this.btnBeginAcceptTcpServer.Text = "Start TCP Server Async";
            this.btnBeginAcceptTcpServer.UseVisualStyleBackColor = true;
            this.btnBeginAcceptTcpServer.Click += new System.EventHandler(this.BtnBeginAcceptTcpServer_Click);
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(396, 382);
            this.txtMessageToSend.Multiline = true;
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(236, 127);
            this.txtMessageToSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(494, 515);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 550);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBeginAcceptTcpServer);
            this.Controls.Add(this.btnStartTcpServer);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFileSaveContent);
            this.Controls.Add(this.txtMessageToSend);
            this.Controls.Add(this.txtTcpReceived);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileSaveContent;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtTcpReceived;
        private System.Windows.Forms.Button btnStartTcpServer;
        private System.ComponentModel.BackgroundWorker tcpListenerBackgroundWorker;
        private System.Windows.Forms.Button btnBeginAcceptTcpServer;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.Button btnSend;
    }
}

