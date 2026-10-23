namespace bài5
{
    public partial class frmIoTMonitor : Form
    {
        private bool isMonitoring = false;
        private int tickCount = 0;
        private Random random = new Random();
        public frmIoTMonitor()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isMonitoring = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "Đang giám sát...";
            Task.Run(() => MonitorIoTData());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isMonitoring = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Đã dừng";
        }

        private void frmIoTMonitor_Load(object sender, EventArgs e)
        {
            dgvLogs.Columns.Add("Time", "Thời gian");
            dgvLogs.Columns.Add("Temp", "Nhiệt độ (°C)");
            dgvLogs.Columns[0].Width = 150;
            dgvLogs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private async Task MonitorIoTData()
        {
            while (isMonitoring)
            {
                int currentTemp = random.Next(30, 43);
                tickCount++;

                if (this.IsHandleCreated) 
                {
                    this.Invoke(new Action(() =>
                    {

                        lblTemperature.Text = $"{currentTemp} °C";
                        lblTemperature.ForeColor = currentTemp > 37 ? Color.Red : Color.Green;

                        dgvLogs.Rows.Insert(0, DateTime.Now.ToString("HH:mm:ss"), $"{currentTemp} °C");

                        lblTickCount.Text = $"Chu kỳ: {tickCount}";
                    }));
                }

                await Task.Delay(2000);
            }
        }
    }
}
