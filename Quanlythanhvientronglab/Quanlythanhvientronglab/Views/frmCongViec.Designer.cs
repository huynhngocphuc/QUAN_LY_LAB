namespace Quanlythanhvientronglab.Views
{
    partial class frmCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongViec));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaDA = new System.Windows.Forms.ComboBox();
            this.txtChitiet = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.txtMacv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewCV = new System.Windows.Forms.ListView();
            this.MaCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChiTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaDA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editbt = new System.Windows.Forms.Button();
            this.delbt = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaDA);
            this.groupBox1.Controls.Add(this.txtChitiet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTencv);
            this.groupBox1.Controls.Add(this.txtMacv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(992, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Công Việc";
            // 
            // cbbMaDA
            // 
            this.cbbMaDA.FormattingEnabled = true;
            this.cbbMaDA.Location = new System.Drawing.Point(186, 139);
            this.cbbMaDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaDA.Name = "cbbMaDA";
            this.cbbMaDA.Size = new System.Drawing.Size(264, 34);
            this.cbbMaDA.TabIndex = 87;
            // 
            // txtChitiet
            // 
            this.txtChitiet.Location = new System.Drawing.Point(649, 48);
            this.txtChitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChitiet.Name = "txtChitiet";
            this.txtChitiet.Size = new System.Drawing.Size(282, 80);
            this.txtChitiet.TabIndex = 86;
            this.txtChitiet.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editbt);
            this.groupBox2.Controls.Add(this.delbt);
            this.groupBox2.Controls.Add(this.addbt);
            this.groupBox2.Location = new System.Drawing.Point(525, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(413, 155);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lưu";
            // 
            // txtTencv
            // 
            this.txtTencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencv.Location = new System.Drawing.Point(186, 215);
            this.txtTencv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(264, 32);
            this.txtTencv.TabIndex = 78;
            // 
            // txtMacv
            // 
            this.txtMacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacv.Location = new System.Drawing.Point(186, 51);
            this.txtMacv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMacv.Name = "txtMacv";
            this.txtMacv.Size = new System.Drawing.Size(264, 32);
            this.txtMacv.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 77;
            this.label4.Text = "Chi Tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mã Dự Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên Công Việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã Công Việc";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listViewCV);
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 259);
            this.panel1.TabIndex = 4;
            // 
            // listViewCV
            // 
            this.listViewCV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCV,
            this.TenCV,
            this.ChiTiet,
            this.MaDA});
            this.listViewCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCV.GridLines = true;
            this.listViewCV.HideSelection = false;
            this.listViewCV.Location = new System.Drawing.Point(0, 0);
            this.listViewCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewCV.Name = "listViewCV";
            this.listViewCV.Size = new System.Drawing.Size(992, 255);
            this.listViewCV.TabIndex = 0;
            this.listViewCV.UseCompatibleStateImageBehavior = false;
            this.listViewCV.View = System.Windows.Forms.View.Details;
            this.listViewCV.Click += new System.EventHandler(this.listViewCV_Click);
            // 
            // MaCV
            // 
            this.MaCV.Text = "Mã Công Việc";
            this.MaCV.Width = 100;
            // 
            // TenCV
            // 
            this.TenCV.Text = "Tên Công Việc";
            this.TenCV.Width = 150;
            // 
            // ChiTiet
            // 
            this.ChiTiet.Text = "Chi Tiết";
            this.ChiTiet.Width = 200;
            // 
            // MaDA
            // 
            this.MaDA.Text = "Mã Dự Án";
            this.MaDA.Width = 150;
            // 
            // editbt
            // 
            this.editbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.edit;
            this.editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbt.Location = new System.Drawing.Point(308, 45);
            this.editbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(70, 69);
            this.editbt.TabIndex = 0;
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // delbt
            // 
            this.delbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.xoa;
            this.delbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delbt.Location = new System.Drawing.Point(196, 45);
            this.delbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delbt.Name = "delbt";
            this.delbt.Size = new System.Drawing.Size(70, 69);
            this.delbt.TabIndex = 0;
            this.delbt.UseVisualStyleBackColor = true;
            this.delbt.Click += new System.EventHandler(this.delbt_Click);
            // 
            // addbt
            // 
            this.addbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.save;
            this.addbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbt.Location = new System.Drawing.Point(89, 45);
            this.addbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(70, 69);
            this.addbt.TabIndex = 0;
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // frmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCongViec";
            this.Text = "Công việc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Button delbt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.TextBox txtMacv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtChitiet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ComboBox cbbMaDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewCV;
        private System.Windows.Forms.ColumnHeader MaCV;
        private System.Windows.Forms.ColumnHeader MaDA;
        private System.Windows.Forms.ColumnHeader TenCV;
        private System.Windows.Forms.ColumnHeader ChiTiet;
    }
}