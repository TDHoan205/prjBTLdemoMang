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
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 16;
            this.lstData.Location = new System.Drawing.Point(12, 63);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(560, 260);
            this.lstData.TabIndex = 0;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(472, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(100, 40);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Chạy Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // frmUDPServer
            // 
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.lstData);
            this.Name = "frmUDPServer";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnStartServer;
    }
}