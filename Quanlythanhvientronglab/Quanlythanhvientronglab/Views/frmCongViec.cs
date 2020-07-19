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
    public partial class frmCongViec : Form
    {
        public frmCongViec()
        {
            InitializeComponent();
            this.cbbMaDA.DataSource = DAController.GetListDA();
            ShowData();
        }
        private bool KiemTraError(bool check)
        {
            if(this.txtMacv.Text.Trim().Length<=0)
            {
                this.errorProvider1.SetError(this.txtMacv, "Hay nhap ma cong viec");
                check = true;
            }
            if (this.txtTencv.Text.Trim().Length <= 0)
            {
                this.errorProvider2.SetError(this.txtMacv, "Hay nhap ten cong viec");
                check = true;
            }
            if(this.cbbMaDA.Text.Trim().Length<=0)
            {
                this.errorProvider3.SetError(this.cbbMaDA, "Hay chon ma du an");
                check = true;
            }
            return check;
        }
        private void ShowData()
        {
            this.listViewCV.Items.Clear();
            string displayDA = "";
            List<ClassCongViec> lstcv = CongViecController.GetListCV();
            foreach(var cv in lstcv)
            {
                displayDA = "";
                foreach(var da in cv.listDA)
                {
                    displayDA = displayDA + da + " ";
                }

                ListViewItem view = new ListViewItem(cv.MaCV);
                view.SubItems.Add(new ListViewItem.ListViewSubItem(view, cv.TenCV));
                view.SubItems.Add(new ListViewItem.ListViewSubItem(view, cv.ChiTiet));
                view.SubItems.Add(new ListViewItem.ListViewSubItem(view, displayDA));

                listViewCV.Items.Add(view);
            }
            
        }
        private void addbt_Click(object sender, EventArgs e)
        {
            bool check = false;
            //Kiem tra MaCV da ton tai
            if (CongViecController.GetCV(this.txtMacv.Text.Trim()) != null)
            {
                MessageBox.Show("Cong viec nay da ton tai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kiem tra hop le 
            if (KiemTraError(check) == true) 
                return;

            ClassCongViec congviec = new ClassCongViec ();

            congviec.MaCV = this.txtMacv.Text.Trim();
            congviec.TenCV = this.txtTencv.Text.Trim();
            congviec.ChiTiet = this.txtChitiet.Text.Trim();
            congviec.listDA.Add(DAController.GetDuAn(this.cbbMaDA.Text.Trim()));

            if (CongViecController.AddCV(congviec) == false)
            {
                MessageBox.Show("Loi khi them cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            //Xoa control
            this.txtChitiet.Clear();
            this.txtMacv.Clear();
            this.txtTencv.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
        }

        

        private void delbt_Click(object sender, EventArgs e)
        {
            //Kiem tra user co chon hang de xoa khong ?
            //if (dataCongViec.SelectedRows.Count <= 0) 
            //    return;

            ClassCongViec cv = CongViecController.GetCV(this.txtMacv.Text.Trim());
            //Xoa cong viec
            if(CongViecController.DeleteCV(cv)==false)
            {
                MessageBox.Show("Loi khi xoa cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowData();
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTraError(check) == true)
                return;

            ClassCongViec congviec = new ClassCongViec 
            { MaCV = this.txtMacv.Text.Trim(), 
                TenCV = this.txtTencv.Text.Trim(), 
                ChiTiet = this.txtChitiet.Text.Trim() };
            congviec.listDA.Add(DAController.GetDuAn(this.cbbMaDA.Text.Trim()));


            if (CongViecController.UpdateCV(congviec)==false)
            {
                MessageBox.Show("Loi khi sua cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowData();

            this.txtChitiet.Clear();
            this.txtMacv.Clear();
            this.txtTencv.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
        }

        private void listViewCV_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtMacv.Text = this.listViewCV.SelectedItems[0].SubItems[0].Text.Trim();
                this.txtTencv.Text = this.listViewCV.SelectedItems[0].SubItems[1].Text.Trim();
                this.txtChitiet.Text = this.listViewCV.SelectedItems[0].SubItems[2].Text.Trim();
                this.cbbMaDA.Text = this.listViewCV.SelectedItems[0].SubItems[3].Text.Trim();
            }
            catch { }
        }
    }
}
