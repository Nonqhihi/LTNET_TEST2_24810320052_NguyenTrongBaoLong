using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bài1
{
    public partial class frmBookingManager : Form
    {
        private BindingList<BookingModel> bookingList;
        private BindingSource bindingSource;
        private int bookingCounter = 1;

        public frmBookingManager()
        {
            InitializeComponent();
        }


        private void frmBookingManager_Load(object sender, EventArgs e)
        {
            bookingList = new BindingList<BookingModel>();
            bindingSource = new BindingSource { DataSource = bookingList };
            dgvBookings.DataSource = bindingSource;

            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BookingId", HeaderText = "Mã Đặt", Width = 80 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Tên Khách", Width = 150 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdentityCard", HeaderText = "CCCD", Width = 120 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RoomType", HeaderText = "Loại Phòng", Width = 100 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CheckInDate", HeaderText = "Ngày Nhận", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Days", HeaderText = "Số Đêm", Width = 70 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PricePerNight", HeaderText = "Giá/Đêm", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });

            if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            GenerateNewId();
        }
        private void GenerateNewId()
        {
            txtBookingId.Text = $"BK{bookingCounter:D3}";
        }
        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtIdentityCard.Text, @"^(?:\d{9}|\d{12})$"))
            {
                errorProvider1.SetError(txtIdentityCard, "CCCD/CMND phải bao gồm đúng 9 hoặc 12 chữ số.");
                isValid = false;
            }

            if (!decimal.TryParse(txtPricePerNight.Text, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtPricePerNight, "Giá phòng phải là một số lớn hơn 0.");
                isValid = false;
            }

            return isValid;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            var newBooking = new BookingModel
            {
                BookingId = txtBookingId.Text,
                CustomerName = txtCustomerName.Text,
                IdentityCard = txtIdentityCard.Text,
                RoomType = cboRoomType.Text,
                CheckInDate = dtpCheckIn.Value,
                Days = (int)numDays.Value,
                PricePerNight = decimal.Parse(txtPricePerNight.Text)
            };

            bookingList.Add(newBooking);
            bookingCounter++;
            btnClear_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null || !ValidateData()) return;


            var current = (BookingModel)bindingSource.Current;
            current.CustomerName = txtCustomerName.Text;
            current.IdentityCard = txtIdentityCard.Text;
            current.RoomType = cboRoomType.Text;
            current.CheckInDate = dtpCheckIn.Value;
            current.Days = (int)numDays.Value;
            current.PricePerNight = decimal.Parse(txtPricePerNight.Text);


            bindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa đặt phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GenerateNewId();
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            txtPricePerNight.Clear();
            if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Now;
            numDays.Value = 1;
            errorProvider1.Clear();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSource.Current != null)
            {
                var current = (BookingModel)bindingSource.Current;
                txtBookingId.Text = current.BookingId;
                txtCustomerName.Text = current.CustomerName;
                txtIdentityCard.Text = current.IdentityCard;
                cboRoomType.Text = current.RoomType;
                dtpCheckIn.Value = current.CheckInDate;
                numDays.Value = current.Days;
                txtPricePerNight.Text = current.PricePerNight.ToString("G0");
            }
        }
        public class BookingModel
        {
            public string BookingId { get; set; }
            public string CustomerName { get; set; }
            public string IdentityCard { get; set; }
            public string RoomType { get; set; }
            public DateTime CheckInDate { get; set; }
            public int Days { get; set; }
            public decimal PricePerNight { get; set; }
        }
    }
}
