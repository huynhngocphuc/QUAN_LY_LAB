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
    public partial class frmTimKiem : Form
    {
        List<find> FindList;
        private string tmp;

        public string Tmp { get => tmp; set => tmp = value; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            cbbChonTheo.Text = "";
            cbbTimKiem.Text = "";
            FindList = new List<find>();
            FindList.Add(new find("MaNV"));
            FindList.Add(new find("MaDA"));
            cbbChonTheo.DataSource = FindList;
            cbbChonTheo.DisplayMember = "Name";
        }

        int kiemtra()
        {

            if (cbbChonTheo.Text == "MaNV")
            {
                this.cbbTimKiem.DataSource = NhanVienController.GetListNV();
                return 0;
            }

            if (cbbChonTheo.Text == "MaDA")
            {
                this.cbbTimKiem.DataSource = DAController.GetListDA();
                return 1;
            }
            return 0;


        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            kiemtra();
        }
        public class find
        {
            private string name;

            public string Name { get => name; set => name = value; }

            public find(string name)
            {
                this.Name = name;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Tmp = cbbTimKiem.Text;
            if (kiemtra() == 0)
            {
                DBManageContext db = new DBManageContext();
                var result = from c in db.tbNhanVien
                             where c.MaNV == Tmp
                             select c;
                dataGridView1.DataSource = result.ToList();
                cbbTimKiem.Text = Tmp;
                cbbTimKiem.Show();

            }
            else
            {
                DBManageContext db = new DBManageContext();
                var result = from c in db.tbDuAn
                             where c.MaDA == Tmp
                             select c;
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[5].Visible = false;
                cbbTimKiem.Text = Tmp;
                cbbTimKiem.Show();
            }

        }
    }
}
