using Microsoft.Office.Interop.Excel;
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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
            this.cbbManv.DataSource = NhanVienController.GetListNV();
            //this.cbbMada.DataSource = DAController.GetListDA();
            foreach (var da in DAController.GetListDA())
            {
                this.checkedListBox1.Items.Add(da);
            }
            ClearControls();
            ShowData();
        }
        private bool KiemTraErr(bool check)
        {
            //if(this.listBoxG.Items.Count==0)
            //{
            //    check = true;
            //    this.errorProvider1.SetError(this.listBoxG, "Hay chon ma cong viec");
            //}
            if(this.cbbManv.Text.Trim().Length<=0)
            {
                check = true;
                this.errorProvider2.SetError(this.cbbManv,"Hay chon ma nhan vien"); 
            }
            //if(this.cbbMada.Text.Trim().Length<=0)
            //{
            //    check = true;
            //    this.errorProvider3.SetError(this.cbbMada, "Hay chon ma du an");
            //}
            return check;
        }
        private void ClearControls()
        {
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.errorProvider3.Clear();
            this.errorProvider4.Clear();
            this.cbbManv.SelectedIndex = -1;
            this.listsearchG.DataSource = null;
            this.listsearchG.Items.Clear();
            this.listsearchX.DataSource = null;
            this.listsearchX.Items.Clear();

            this.listBoxG.DataSource = null;
            this.listBoxG.Items.Clear();
            this.listBoxX.DataSource = null;
            this.listBoxX.Items.Clear();

            this.progressBar1.Value = 0;
            //this.cbbMada.SelectedIndex = -1;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }
        private void ShowData()
        {
            this.listViewPhancong.Items.Clear();
            List<ClassNhanVien> lstnv = NhanVienController.GetListNvien();

            string displaycvGiao = "";
            string displaycvHoanThanh = "";
            foreach(var i in lstnv)
            {
                displaycvGiao = "";
                displaycvHoanThanh = "";
                foreach (var j in i.listCVLam)
                    displaycvGiao = displaycvGiao + j + " ";
                foreach (var j in i.listCVXong)
                    displaycvHoanThanh = displaycvHoanThanh + j + " ";

                ListViewItem nv = new ListViewItem(i.MaNV);
                
                nv.SubItems.Add(new ListViewItem.ListViewSubItem(nv, displaycvGiao));
                nv.SubItems.Add(new ListViewItem.ListViewSubItem(nv, displaycvHoanThanh));
                nv.SubItems.Add(new ListViewItem.ListViewSubItem(nv, i.TienDo));
                nv.SubItems.Add(new ListViewItem.ListViewSubItem(nv, i.MaDA));
                this.listViewPhancong.Items.Add(nv);
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (KiemTraErr(check) == true)
                return;

            ClassNhanVien nvien = NhanVienController.GetNV(this.cbbManv.Text.Trim());

            foreach (var cvg in nvien.listCVLam.ToList())
                nvien.listCVLam.Remove(cvg);
            foreach (var cvx in nvien.listCVXong.ToList())
                nvien.listCVXong.Remove(cvx);

            string displaycvGiao = "";
            string displaycvHoanThanh = "";

            for (int i = 0; i < listBoxG.Items.Count; i++)
            {
                displaycvGiao = displaycvGiao + this.listBoxG.Items + " ";
                ClassCongViec cv = CongViecController.GetCV(this.listBoxG.Items[i].ToString());
                nvien.listCVLam.Add(cv);

                //nvien.MaDA = cv.listDA.ToList()[0].ToString() + " " + nvien.MaDA;
            }

           

            for(int j=0;j<listBoxX.Items.Count;j++)
            {
                displaycvHoanThanh = displaycvHoanThanh + this.listBoxX.Items + " ";
                nvien.listCVXong.Add(CongViecController.GetCV(this.listBoxX.Items[j].ToString()));
            }

            string mada = "";
            foreach(var i in this.checkedListBox1.CheckedItems)
            {
                mada = mada + i.ToString() + " ";
            }
            nvien.MaDA = mada;
            if (NhanVienController.UpdateNvien(nvien)==false)
            {
                MessageBox.Show("Loi them cong viec", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowData();

            ClearControls();
        }

        

        private void listsearchG_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;
            //kiem tra cong viec dc chon trong listsearch da co trong danh sach cong viec duoc giao chua
            foreach(var x in listBoxG.Items)
            {
                if(x.ToString().Trim() == this.listsearchG.SelectedItem.ToString().Trim())
                {
                    count++;
                }
            }

            //them cong viec vao list cong viec duoc giao
            //them cong viec vao list cong viec co the duoc hoan thanh
            try
            {
                if (this.listsearchG.SelectedIndex >= 0 && count == 0)
                {
                    this.listBoxG.Items.Add(this.listsearchG.SelectedItem);
                    this.listsearchX.Items.Add(this.listsearchG.SelectedItem);
                }
            }
            catch { }
        }

        private void listsearchX_DoubleClick(object sender, EventArgs e)
        {
            //kiem tra cong viec dc chon trong listsearch da co trong danh sach cong viec da hoan thanh chua
            int count = 0;
            foreach (var x in listBoxX.Items)
            {
                if (x.ToString().Trim() == this.listsearchX.SelectedItem.ToString().Trim())
                {
                    count++;
                }
            }

            //them cong viec vao list cong viec hoan thanh
            if (this.listsearchX.SelectedIndex >= 0 && count == 0)
            {
                this.listBoxX.Items.Add(this.listsearchX.SelectedItem);
                
            }
        }

        private void listBoxG_DoubleClick(object sender, EventArgs e)
        {
            if(this.listBoxG.SelectedIndex>=0)
            {
                //xoa cong viec trong list cong viec duoc giao
                this.listBoxG.Items.RemoveAt(this.listBoxG.SelectedIndex);

            }

            //xoa cong viec trong listsearch cv hoan thanh
            this.listsearchX.DataSource = null;
            this.listsearchX.Items.Clear();
            this.listsearchX.DataSource = this.listBoxG.Items;


            //xoa cong viec trong list cv hoan thanh
            this.listBoxX.DataSource = null;
            this.listBoxX.Items.Clear();
            this.listBoxX.DataSource = this.listBoxG.Items;
        }

        private void listBoxX_DoubleClick(object sender, EventArgs e)
        {
            if(this.listBoxX.SelectedIndex>=0)
            {
                //xoa cong viec trong list cong viec da hoan thanh
                this.listBoxX.Items.RemoveAt(this.listBoxX.SelectedIndex);
            }
        }

        private void listViewPhancong_Click(object sender, EventArgs e)
        {
            try
            {
                this.listsearchX.DataSource = null;
                this.listsearchX.Items.Clear();
                this.listBoxX.DataSource = null;
                this.listBoxX.Items.Clear();
                this.listsearchG.DataSource = null;
                this.listsearchG.Items.Clear();
                this.listBoxG.DataSource = null;
                this.listBoxG.Items.Clear();


                this.cbbManv.Text = this.listViewPhancong.SelectedItems[0].SubItems[0].Text.Trim();
                //this.cbbMada.Text = this.listViewPhancong.SelectedItems[0].SubItems[1].Text.Trim();

                

                //chuyen du lieu dang text trong listview sang iteam va them vao listbox
                string[] arrCVgiao = this.listViewPhancong.SelectedItems[0].SubItems[1].Text.Split();
                foreach(var i in arrCVgiao)
                {
                    foreach(var j in CongViecController.GetListCV())
                    {
                        if(i==j.MaCV)
                        {
                            this.listBoxG.Items.Add(j);
                            this.listsearchX.Items.Add(j);
                        }
                    }
                }

                //chuyen du lieu dang text trong listview sang iteam va them vao listbox
                string[] arrCVxong = this.listViewPhancong.SelectedItems[0].SubItems[2].Text.Split();
                foreach (var i in arrCVxong)
                {
                    foreach (var j in CongViecController.GetListCV())
                    {
                        if (i == j.MaCV)
                        {
                            this.listBoxX.Items.Add(j);
                        }
                    }
                }

                string[] mada = this.listViewPhancong.SelectedItems[0].SubItems[4].Text.Split();
                for(int i=0;i<this.checkedListBox1.Items.Count;i++)
                {
                    for(int j=0;j<mada.Length;j++)
                    {
                        if (this.checkedListBox1.Items[i].ToString() == mada[j])
                            this.checkedListBox1.SetItemChecked(i, true);
                    }
                }

                string[] arr = this.listViewPhancong.SelectedItems[0].SubItems[3].Text.Trim().Split('/');
                //this.progTienDo.Value = 100;
                if(arr[1]=="0")
                {
                    this.progressBar1.Value = 0;
                    return;
                }
                double a = Convert.ToDouble(arr[0])/Convert.ToDouble(arr[1]) * 100;
                this.progressBar1.Value = Convert.ToInt32(a);
                //this.listsearchG.DataSource = null;
                //this.listsearchG.Items.Clear();
            }
            catch { }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            addbtn_Click(sender,e);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClassCongViec> lstcv = new List<ClassCongViec>();
                this.listsearchG.DataSource = null;
                this.listsearchG.Items.Clear();
                foreach (var item in this.checkedListBox1.CheckedItems)
                {
                    ClassDuAn da = DAController.GetDuAn(item.ToString());
                    
                    //lay danh sach cong viec cua du an vao listsearchG
                    foreach (var i in da.listCV)
                    {
                        lstcv.Add(i);
                    }
                    

                    //MessageBox.Show(item.ToString());
                }
                listsearchG.DataSource = lstcv;
            }
            catch
            { }
        }

        
    }
}
