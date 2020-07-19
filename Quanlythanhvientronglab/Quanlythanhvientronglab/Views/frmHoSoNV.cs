using Quanlythanhvientronglab.Controllers;
using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythanhvientronglab.Views
{
    public partial class frmHoSoNV : Form
    {
        public frmHoSoNV()
        {
            InitializeComponent();
            ShowData();
            this.cbbChucVu.DataSource = ChucVuController.GetListCVu();
        }
        private bool KiemTraErr(bool check)
        {
            if(this.txtmanv.Text.Trim().Length<=0)
            {
                check = true;
                this.errorProvider1.SetError(this.txtmanv, "Hay nhap ma nhan vien");
            }
            if (this.txtTenNv.Text.Trim().Length <= 0)
            {
                check = true;
                this.errorProvider2.SetError(this.txtTenNv, "Hay nhap ten nhan vien");
            }
            if (this.txtDiachi.Text.Trim().Length <= 0)
            {
                check = true;
                this.errorProvider3.SetError(this.txtDiachi, "Hay nhap dia chi");
            }
            if (this.txtsdt.Text.Trim().Length <= 0)
            {
                check = true;
                this.errorProvider4.SetError(this.txtsdt, "Hay nhap dia chi");
            }
            if (this.txtemail.Text.Trim().Length <= 0)
            {
                check = true;
                this.errorProvider5.SetError(this.txtemail, "Hay nhap email");
            }
            if(this.cbbChucVu.Text.Trim().Length<=0)
            {
                check = true;
                this.errorProvider6.SetError(this.cbbChucVu, "Hay chon chuc vu");
            }
            if((this.checkFemale.Checked==false && this.checkMale.Checked==false) ||(this.checkFemale.Checked == true && this.checkMale.Checked == true))
            {
                check = true;
                this.errorProvider7.SetError(this.checkFemale, "Hay chon gioi tinh");
                this.errorProvider8.SetError(this.checkMale, "Hay chon gioi tinh");
            }
            if(this.Ngaysinhpicker.Value.Year<2000)
            {
                check = true;
                this.errorProvider9.SetError(this.Ngaysinhpicker, "Hay nhap lai ngay sinh");
            }
            return check;
        }
        private void ClearControls()
        {
            this.txtmanv.Clear();
            this.txtTenNv.Clear();
            this.txtsdt.Clear();
            this.txtDiachi.Clear();
            this.txtemail.Text = "@gmail.com";
            this.Ngaysinhpicker.Value = DateTime.Now;
            this.checkMale.Checked = false;
            this.checkFemale.Checked = false;
        }
        private void ShowData()
        {
            BindingSource src = new BindingSource();
            src.DataSource = NhanVienController.GetListNV();
            dataNV.DataSource = src;
            this.dataNV.Columns[9].Visible = false;
            this.dataNV.Columns[8].Visible = false;
            this.dataNV.Columns[10].Visible = false;
            this.dataNV.Columns[11].Visible = false;
            this.dataNV.Columns[12].Visible = false;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            //kiem man nhan vien da ton tai chua
            if (NhanVienController.GetNV(this.txtmanv.Text.Trim()) != null)
                return;

            bool check = false;
            if (KiemTraErr(check) == true)
            {
                return;
            }

            ClassNhanVien nv = new ClassNhanVien();
            nv.MaNV = this.txtmanv.Text.Trim();
            nv.TenNV = this.txtTenNv.Text.Trim();
            if (this.checkFemale.Checked == true)
                nv.GioiTinh = "Nu";
            else
                nv.GioiTinh = "Nam";
            nv.SDT = this.txtsdt.Text.Trim();
            nv.NgaySinh = this.Ngaysinhpicker.Value;
            nv.MaChucVu = this.cbbChucVu.Text.Trim();
            nv.Email = this.txtemail.Text.Trim();
            nv.DiaChi = this.txtDiachi.Text.Trim();

            //add xuong csdl
            if(NhanVienController.AddNV(nv)==false)
            {
                MessageBox.Show("Loi khi them nhan vien", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearControls();

            ShowData();
        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtmanv.Text = this.dataNV.CurrentRow.Cells[0].Value.ToString();
            this.txtTenNv.Text = this.dataNV.CurrentRow.Cells[1].Value.ToString();
            this.Ngaysinhpicker.Value = DateTime.Parse(this.dataNV.CurrentRow.Cells[2].Value.ToString());
            if (this.dataNV.CurrentRow.Cells[3].Value.ToString() == "Nam")
                checkMale.Checked = true;
            else
                checkFemale.Checked = true;
            this.txtsdt.Text = this.dataNV.CurrentRow.Cells[4].Value.ToString();
            this.txtemail.Text = this.dataNV.CurrentRow.Cells[5].Value.ToString();
            this.txtDiachi.Text= this.dataNV.CurrentRow.Cells[6].Value.ToString();
            this.cbbChucVu.Text= this.dataNV.CurrentRow.Cells[7].Value.ToString();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            //kiem tra user co chon hang de xoa hay ko
            if (this.dataNV.SelectedRows.Count <= 0)
                return;

            if(NhanVienController.DeleteNV(this.txtmanv.Text.Trim())==false)
            {
                MessageBox.Show("Loi khi xoa nhan vien", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTraErr(check) == true)
            {
                return;
            }

            ClassNhanVien nv = new ClassNhanVien();
            nv.MaNV = this.txtmanv.Text.Trim();
            nv.TenNV = this.txtTenNv.Text.Trim();
            if (this.checkFemale.Checked == true)
                nv.GioiTinh = "Nu";
            else
                nv.GioiTinh = "Nam";
            nv.SDT = this.txtsdt.Text.Trim();
            nv.NgaySinh = this.Ngaysinhpicker.Value;
            nv.MaChucVu = this.cbbChucVu.Text.Trim();
            nv.Email = this.txtemail.Text.Trim();
            nv.DiaChi = this.txtDiachi.Text.Trim();

            if(NhanVienController.UpdateNV(nv)==false)
            {
                MessageBox.Show("Loi khi sua nhan vien", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            ClearControls();
        }
    }
}
