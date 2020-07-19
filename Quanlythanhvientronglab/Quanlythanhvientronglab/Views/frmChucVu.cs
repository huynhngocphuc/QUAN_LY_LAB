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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            
            InitializeComponent();
            ShowData();
        }
        private bool KiemTraError(bool check)
        {
            if(this.txtmacv.Text.Trim().Length<=0)
            {
                check = true;
                this.errorProvider1.SetError(this.txtmacv,"Hay nhap ma chuc vu");
            }
            if(this.txtTencv.Text.Trim().Length<=0)
            {
                check = true;
                this.errorProvider2.SetError(this.txtTencv, "Hay nhap ten chuc vu");
            }
            return check;
        }
        private void ClearControls()
        {
            this.txtTencv.Clear();
            this.txtmacv.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
        }
        private void ShowData()
        {
            BindingSource src = new BindingSource();
            src.DataSource = ChucVuController.GetListCVu();
            this.dataChucVu.DataSource = src;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            //kiem machucvu da ton tai trong sql ko
            if (ChucVuController.GetCVu(this.txtmacv.Text.Trim()) != null)
                return;

            bool check = false;
            if(KiemTraError(check)==true)
            {
                return;
            }

            ClassChucVu cvu = new ClassChucVu();
            cvu.MaChucVu = txtmacv.Text.Trim();
            cvu.TenChucVu = txtTencv.Text.Trim();

            //add xuong csdl
            if(ChucVuController.AddCVu(cvu)==false)
            {
                MessageBox.Show("Loi khi them chuc vu", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            ClearControls();
        }

        private void dataChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu tu datagridview hien thi len textbox
            this.txtmacv.Text = this.dataChucVu.CurrentRow.Cells[0].Value.ToString();
            this.txtTencv.Text = this.dataChucVu.CurrentRow.Cells[1].Value.ToString();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            //Kiem tra user co chon hang de xoa khong ?
            if (dataChucVu.SelectedRows.Count <= 0)
                return;


            //xoa chuc vu
            if (ChucVuController.DeleteCVu(this.txtmacv.Text.Trim())==false)
            {
                MessageBox.Show("Loi khi xoa chuc vu", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTraError(check) == true)
                return;

            ClassChucVu cvu = new ClassChucVu();
            cvu.MaChucVu = txtmacv.Text.Trim();
            cvu.TenChucVu = txtTencv.Text.Trim();

            if(ChucVuController.UpdateChucVu(cvu)==false)
            {
                MessageBox.Show("Loi khi update chuc vu", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();
            ClearControls();
        }
    }
}
