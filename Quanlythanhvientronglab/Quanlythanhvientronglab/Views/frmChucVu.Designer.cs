namespace Quanlythanhvientronglab.Views
{
    partial class frmChucVu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataChucVu = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.editbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTencv);
            this.groupBox1.Controls.Add(this.txtmacv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(992, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chức Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.delbtn);
            this.groupBox2.Controls.Add(this.addbtn);
            this.groupBox2.Location = new System.Drawing.Point(528, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(413, 146);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lưu";
            // 
            // txtTencv
            // 
            this.txtTencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencv.Location = new System.Drawing.Point(189, 136);
            this.txtTencv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(264, 32);
            this.txtTencv.TabIndex = 78;
            // 
            // txtmacv
            // 
            this.txtmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Location = new System.Drawing.Point(189, 48);
            this.txtmacv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(264, 32);
            this.txtmacv.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // dataChucVu
            // 
            this.dataChucVu.AllowUserToAddRows = false;
            this.dataChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dataChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataChucVu.Location = new System.Drawing.Point(0, 234);
            this.dataChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataChucVu.Name = "dataChucVu";
            this.dataChucVu.RowHeadersWidth = 51;
            this.dataChucVu.RowTemplate.Height = 24;
            this.dataChucVu.Size = new System.Drawing.Size(992, 310);
            this.dataChucVu.TabIndex = 3;
            this.dataChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChucVu_CellClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaChucVu";
            dataGridViewCellStyle1.Format = "Microsoft Sans Serif, 10.8pt";
            this.MaCV.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle2.Format = "Microsoft Sans Serif, 10.8pt";
            this.TenCV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // editbtn
            // 
            this.editbtn.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.edit;
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbtn.Location = new System.Drawing.Point(291, 34);
            this.editbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(70, 69);
            this.editbtn.TabIndex = 0;
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.xoa;
            this.delbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delbtn.Location = new System.Drawing.Point(179, 34);
            this.delbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(70, 69);
            this.delbtn.TabIndex = 0;
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.save;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbtn.Location = new System.Drawing.Point(72, 34);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(70, 69);
            this.addbtn.TabIndex = 0;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.dataChucVu);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChucVu";
            this.Text = "Chức vụ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataChucVu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
    }
}