using Quanlythanhvientronglab.Controllers;
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
    public partial class frmBangLuong : Form
    {
        public frmBangLuong()
        {
            InitializeComponent();
            ShowData();
        }
        private void ShowData()
        {
            BindingSource src = new BindingSource();
            src.DataSource = NhanVienController.GetLuongNV();
            dataLuong.DataSource = src;
      
            dataLuong.Columns[2].Visible = false;
            dataLuong.Columns[3].Visible = false;
            dataLuong.Columns[4].Visible = false;
            dataLuong.Columns[5].Visible = false;
            dataLuong.Columns[6].Visible = false;
            dataLuong.Columns[7].Visible = false;
            dataLuong.Columns[10].Visible = false;
            dataLuong.Columns[11].Visible = false;
            dataLuong.Columns[12].Visible = false;
        }

        private void dataLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtmanv.Text= this.dataLuong.CurrentRow.Cells[0].Value.ToString();
            this.txtTennv.Text = this.dataLuong.CurrentRow.Cells[1].Value.ToString();
            if(this.dataLuong.CurrentRow.Cells[9].Value is null)
            {
                this.txtTiendo.Text = "0";
            }
            else
            {
                this.txtTiendo.Text = this.dataLuong.CurrentRow.Cells[9].Value.ToString();
            }
            this.txtLuong.Text = this.dataLuong.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
