namespace UDPClient
{
    partial class frmUDPClient
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDataSending = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(462, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 40);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Kết nối Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDataSending
            // 
            this.txtDataSending.Location = new System.Drawing.Point(47, 72);
            this.txtDataSending.Name = "txtDataSending";
            this.txtDataSending.Size = new System.Drawing.Size(371, 22);
            this.txtDataSending.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(462, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 40);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.groupBox1.Controls.Add(this.txtDataSending);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác gửi data sang server";
            // 
            // frmUDPClient
            // 
            this.ClientSize = new System.Drawing.Size(661, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstData);
            this.Name = "frmUDPClient";
            this.Text = "UDP Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDataSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}