namespace UDPServer
{
    partial class frmUDPServer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtDataToSend = new System.Windows.Forms.TextBox();
            this.btnSendToClient = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(462, 18);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(100, 40);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Chạy Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtDataToSend
            // 
            this.txtDataToSend.Location = new System.Drawing.Point(47, 72);
            this.txtDataToSend.Name = "txtDataToSend";
            this.txtDataToSend.Size = new System.Drawing.Size(371, 22);
            this.txtDataToSend.TabIndex = 1;
            // 
            // btnSendToClient
            // 
            this.btnSendToClient.Location = new System.Drawing.Point(462, 64);
            this.btnSendToClient.Name = "btnSendToClient";
            this.btnSendToClient.Size = new System.Drawing.Size(100, 40);
            this.btnSendToClient.TabIndex = 2;
            this.btnSendToClient.Text = "Gửi Client";
            this.btnSendToClient.UseVisualStyleBackColor = true;
            this.btnSendToClient.Click += new System.EventHandler(this.btnSendToClient_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 16;
            this.lstData.Location = new System.Drawing.Point(12, 150);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(604, 180);
            this.lstData.TabIndex = 3;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(44, 42);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(85, 16);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Nhập dữ liệu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInput);
            this.groupBox1.Controls.Add(this.txtDataToSend);
            this.groupBox1.Controls.Add(this.btnSendToClient);
            this.groupBox1.Controls.Add(this.btnStartServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác gửi data sang client";
            // 
            // frmUDPServer
            // 
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstData);
            this.Name = "frmUDPServer";
            this.Text = "UDP Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtDataToSend;
        private System.Windows.Forms.Button btnSendToClient;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}