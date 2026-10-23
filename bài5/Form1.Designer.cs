namespace bài5
{
    partial class frmIoTMonitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lblTemperature = new Label();
            dgvLogs = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblTickCount = new ToolStripStatusLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(22, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(189, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Bắt đầu Giám sát";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(382, 30);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(210, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dừng Giám sát";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Microsoft Sans Serif", 20F);
            lblTemperature.Location = new Point(290, 114);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(70, 31);
            lblTemperature.TabIndex = 3;
            lblTemperature.Text = "-- °C";
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(60, 170);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.Size = new Size(549, 106);
            dgvLogs.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblTickCount });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.Text = "Sẵn sàng";
            // 
            // lblTickCount
            // 
            lblTickCount.Name = "lblTickCount";
            lblTickCount.Size = new Size(56, 17);
            lblTickCount.Text = "Chu kỳ: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 6;
            label1.Text = "Nhiệt độ hiện tại:";
            // 
            // frmIoTMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(dgvLogs);
            Controls.Add(lblTemperature);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "frmIoTMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Giám sát IoT";
            Load += frmIoTMonitor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblTemperature;
        private DataGridView dgvLogs;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblTickCount;
        private Label label1;
    }
}
