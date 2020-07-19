namespace Quanlythanhvientronglab.Views
{
    partial class frmDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuAn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtChitiet = new System.Windows.Forms.RichTextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listViewda = new System.Windows.Forms.ListView();
            this.MaDA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenDA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChiTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fromDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editbt = new System.Windows.Forms.Button();
            this.delbt = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.txtChitiet);
            this.groupBox1.Controls.Add(this.txtTenDA);
            this.groupBox1.Controls.Add(this.txtMaDA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1037, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Công Việc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editbt);
            this.groupBox2.Controls.Add(this.delbt);
            this.groupBox2.Controls.Add(this.addbt);
            this.groupBox2.Location = new System.Drawing.Point(538, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 155);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lưu";
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(642, 134);
            this.toDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(285, 32);
            this.toDatePicker.TabIndex = 87;
            this.toDatePicker.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(642, 48);
            this.fromDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(285, 32);
            this.fromDatePicker.TabIndex = 87;
            this.fromDatePicker.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // txtChitiet
            // 
            this.txtChitiet.Location = new System.Drawing.Point(189, 215);
            this.txtChitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChitiet.Name = "txtChitiet";
            this.txtChitiet.Size = new System.Drawing.Size(264, 80);
            this.txtChitiet.TabIndex = 86;
            this.txtChitiet.Text = "";
            // 
            // txtTenDA
            // 
            this.txtTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDA.Location = new System.Drawing.Point(189, 136);
            this.txtTenDA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(264, 32);
            this.txtTenDA.TabIndex = 78;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDA.Location = new System.Drawing.Point(189, 48);
            this.txtMaDA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(264, 32);
            this.txtMaDA.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 77;
            this.label4.Text = "Chi Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên Dự Án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Bắt Đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã Dự Án";
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // listViewda
            // 
            this.listViewda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDA,
            this.TenDA,
            this.ChiTiet,
            this.fromDate,
            this.toDate});
            this.listViewda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.listViewda.GridLines = true;
            this.listViewda.HideSelection = false;
            this.listViewda.Location = new System.Drawing.Point(0, 425);
            this.listViewda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewda.Name = "listViewda";
            this.listViewda.Size = new System.Drawing.Size(1037, 390);
            this.listViewda.TabIndex = 5;
            this.listViewda.UseCompatibleStateImageBehavior = false;
            this.listViewda.View = System.Windows.Forms.View.Details;
            this.listViewda.Click += new System.EventHandler(this.listViewda_Click);
            // 
            // MaDA
            // 
            this.MaDA.Text = "Mã Dự Án";
            this.MaDA.Width = 130;
            // 
            // TenDA
            // 
            this.TenDA.Text = "Tên Dự Án";
            this.TenDA.Width = 130;
            // 
            // ChiTiet
            // 
            this.ChiTiet.Text = "Chi Tiết";
            this.ChiTiet.Width = 130;
            // 
            // fromDate
            // 
            this.fromDate.Text = "Bắt Đầu";
            this.fromDate.Width = 130;
            // 
            // toDate
            // 
            this.toDate.Text = "Kết Thúc";
            this.toDate.Width = 130;
            // 
            // editbt
            // 
            this.editbt.BackgroundImage = global::Quanlythanhvientronglab.Properties.Resources.edit;
            this.editbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbt.Location = new System.Drawing.Point(264, 46);
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
            this.delbt.Location = new System.Drawing.Point(152, 46);
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
            this.addbt.Location = new System.Drawing.Point(45, 46);
            this.addbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(70, 69);
            this.addbt.TabIndex = 0;
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // frmDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 816);
            this.Controls.Add(this.listViewda);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDuAn";
            this.Text = "Dự án";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtChitiet;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Button delbt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ListView listViewda;
        private System.Windows.Forms.ColumnHeader MaDA;
        private System.Windows.Forms.ColumnHeader TenDA;
        private System.Windows.Forms.ColumnHeader ChiTiet;
        private System.Windows.Forms.ColumnHeader fromDate;
        private System.Windows.Forms.ColumnHeader toDate;
    }
}