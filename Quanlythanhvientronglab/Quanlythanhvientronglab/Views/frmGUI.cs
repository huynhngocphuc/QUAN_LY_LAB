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
    public partial class frmGUI : Form
    {
        #region NewForm
        frmHoSoNV fnv;
        frmDuAn fda;
        frmBangLuong fluong;
        frmChucVu fcvu;
        frmPhanCong fpc;
        frmCongViec fcv;
        frmTimKiem ftk;
        #endregion
        public frmGUI()
        {
            InitializeComponent();
        }
        #region ControlForm
        private void btn_hosonv_Click(object sender, EventArgs e)
        {
            if (this.fnv is null || this.fnv.IsDisposed)
            {
                this.fnv = new frmHoSoNV();
                this.fnv.MdiParent = this;
                this.fnv.Show();
            }
            else
            {
                this.fnv.Select();
            }


        }

        private void btn_duan_Click(object sender, EventArgs e)
        {
            if (this.fda is null || this.fda.IsDisposed)
            {
                this.fda = new frmDuAn();
                this.fda.MdiParent = this;
                this.fda.Show();
            }
            else
            {
                this.fda.Select();
            }

        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            if (this.fluong is null || this.fluong.IsDisposed)
            {
                this.fluong = new frmBangLuong();
                this.fluong.MdiParent = this;
                this.fluong.Show();
            }
            else
            {
                this.fluong.Select();
            }


        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            if (this.fcvu is null || this.fnv.IsDisposed)
            {
                this.fcvu = new frmChucVu();
                this.fcvu.MdiParent = this;
                this.fcvu.Show();
            }
            else
            {
                this.fcvu.Select();
            }
        }

        private void btn_phancong_Click(object sender, EventArgs e)
        {
            if (this.fpc is null || this.fnv.IsDisposed)
            {
                this.fpc = new frmPhanCong();
                this.fpc.MdiParent = this;
                this.fpc.Show();
            }
            else
            {
                this.fpc.Select();
            }

        }



        private void btn_thannhan_Click(object sender, EventArgs e)
        {
            if (this.fcv is null || this.fnv.IsDisposed)
            {
                this.fcv = new frmCongViec();
                this.fcv.MdiParent = this;
                this.fcv.Show();
            }
            else
            {
                this.fcv.Select();
            }

        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fnv is null || this.fnv.IsDisposed)
            {
                this.fnv = new frmHoSoNV();
                this.fnv.MdiParent = this;
                this.fnv.Show();
            }
            else
            {
                this.fcv.Select();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.ftk is null || this.ftk.IsDisposed)
            {
                this.ftk = new frmTimKiem();
                this.ftk.MdiParent = this;
                this.ftk.Show();
            }
            else
            {
                this.ftk.Select();
            }

        }
        #endregion

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var _context=new DBManageContext())
            {
                ClassChucVu cv = new ClassChucVu { MaChucVu = "GD", TenChucVu = "Giam doc" };
                _context.tbChucVu.Add(cv);
                _context.SaveChanges();
            }
            MessageBox.Show("Finish");
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoNV fnv = new frmHoSoNV();
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";

            //tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = "QUẢN LÝ THÀNH VIÊN TRONG LAB";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = worksheet.get_Range("A3", "A3");
            cl1.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl2 = worksheet.get_Range("B3", "B3");
            cl2.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl3 = worksheet.get_Range("C3", "C3");
            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl5 = worksheet.get_Range("E3", "E3");
            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = worksheet.get_Range("F3", "F3");
            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl7 = worksheet.get_Range("G3", "G3");
            cl3.ColumnWidth = 20;

            int a = fnv.dataNV.Rows.Count + 2;
            Microsoft.Office.Interop.Excel.Range rowHead = worksheet.get_Range("A2", "I"+a.ToString());
            rowHead.Font.Bold = true;
            //kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // storing header part in Excel  
            for (int i=1;i<fnv.dataNV.Columns.Count+1-4;i++)
            {
                worksheet.Cells[2, i] = fnv.dataNV.Columns[i - 1].HeaderText;
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < fnv.dataNV.Rows.Count ; i++)
            {
                for (int j = 0; j < fnv.dataNV.Columns.Count-4; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = fnv.dataNV.Rows[i].Cells[j].Value.ToString();
                }
            }
            List<ClassNhanVien> nv = NhanVienController.GetLuongNV();
            for (int i = 0; i < fnv.dataNV.Rows.Count ; i++)
                worksheet.Cells[i + 3, 9] = nv[i].Luong.ToString();
            // save the application  
            //workbook.SaveAs("c:\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //app.Quit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinBảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Đồ án môn Lập trình windows\nGiáo viên hướng dẫn: Huỳnh Xuân Phụng \nTác giả:\n\tLê Trần Đức Huy\n\tHuỳnh Ngọc Phúc";
            MessageBox.Show(info, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/duchuy.letran.3/");
        }

        private void frmGUI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabControl1;
                this.tabControl1.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed; ;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                (this.tabControl1.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
