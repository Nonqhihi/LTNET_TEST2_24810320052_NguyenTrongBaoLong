namespace bài1
{
    partial class frmBookingManager
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBookingId = new TextBox();
            txtCustomerName = new TextBox();
            txtIdentityCard = new TextBox();
            txtPricePerNight = new TextBox();
            dtpCheckIn = new DateTimePicker();
            numDays = new NumericUpDown();
            cboRoomType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            bindingSource1 = new BindingSource(components);
            dgvBookings = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Đặt Phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Số CCCD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 149);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Loại Phòng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 26);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày Nhận:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 66);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Số Đêm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 108);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Giá/Đêm:";
            // 
            // txtBookingId
            // 
            txtBookingId.Location = new Point(123, 21);
            txtBookingId.Name = "txtBookingId";
            txtBookingId.ReadOnly = true;
            txtBookingId.Size = new Size(152, 23);
            txtBookingId.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(123, 66);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(152, 23);
            txtCustomerName.TabIndex = 8;
            // 
            // txtIdentityCard
            // 
            txtIdentityCard.Location = new Point(123, 105);
            txtIdentityCard.Name = "txtIdentityCard";
            txtIdentityCard.Size = new Size(152, 23);
            txtIdentityCard.TabIndex = 9;
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Location = new Point(507, 100);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(180, 23);
            txtPricePerNight.TabIndex = 10;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Location = new Point(507, 20);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(177, 23);
            dtpCheckIn.TabIndex = 11;
            // 
            // numDays
            // 
            numDays.Location = new Point(507, 58);
            numDays.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(177, 23);
            numDays.TabIndex = 12;
            numDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboRoomType
            // 
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Items.AddRange(new object[] { "VIP", "Deluxe", "Standard" });
            cboRoomType.Location = new Point(123, 146);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(152, 23);
            cboRoomType.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm đặt phòng";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(217, 196);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(416, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(609, 196);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvBookings.Location = new Point(12, 260);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(719, 150);
            dgvBookings.TabIndex = 18;
            dgvBookings.CellContentClick += dgvBookings_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BookingId";
            Column1.HeaderText = "Mã";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CustomerName";
            Column2.HeaderText = "Tên khách";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "IdentityCard";
            Column3.HeaderText = "CCCD";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "RoomType";
            Column4.HeaderText = "Loại phòng";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "CheckInDate";
            Column5.HeaderText = "Check in";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Days";
            Column6.HeaderText = "Số đêm";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "PricePerNight";
            dataGridViewCellStyle1.Format = "N0";
            Column7.DefaultCellStyle = dataGridViewCellStyle1;
            Column7.HeaderText = "Giá/Đêm";
            Column7.Name = "Column7";
            // 
            // frmBookingManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBookings);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboRoomType);
            Controls.Add(numDays);
            Controls.Add(dtpCheckIn);
            Controls.Add(txtPricePerNight);
            Controls.Add(txtIdentityCard);
            Controls.Add(txtCustomerName);
            Controls.Add(txtBookingId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBookingManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Đặt phòng Khách sạn";
            Load += frmBookingManager_Load;
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBookingId;
        private TextBox txtCustomerName;
        private TextBox txtIdentityCard;
        private TextBox txtPricePerNight;
        private DateTimePicker dtpCheckIn;
        private NumericUpDown numDays;
        private ComboBox cboRoomType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private ErrorProvider errorProvider1;
        private BindingSource bindingSource1;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}