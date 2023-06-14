namespace WinFormsQLSV.API
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbDiemToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDiemVan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiemAnh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHocLuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(1221, 628);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(1097, 628);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimKiem.Location = new System.Drawing.Point(918, 115);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(316, 27);
            this.tbTimKiem.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(507, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "QUAN LY SINH VIEN";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(965, 628);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbDiemToan
            // 
            this.tbDiemToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiemToan.Location = new System.Drawing.Point(1041, 382);
            this.tbDiemToan.Name = "tbDiemToan";
            this.tbDiemToan.Size = new System.Drawing.Size(316, 27);
            this.tbDiemToan.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Điểm Toán";
            // 
            // tbTuoi
            // 
            this.tbTuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTuoi.Location = new System.Drawing.Point(1041, 334);
            this.tbTuoi.Name = "tbTuoi";
            this.tbTuoi.Size = new System.Drawing.Size(316, 27);
            this.tbTuoi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tuổi";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGioiTinh.Location = new System.Drawing.Point(1041, 287);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(316, 27);
            this.tbGioiTinh.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 294);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giới Tính";
            // 
            // tbTenSV
            // 
            this.tbTenSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTenSV.Location = new System.Drawing.Point(1041, 244);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(316, 27);
            this.tbTenSV.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.Location = new System.Drawing.Point(1041, 198);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(316, 27);
            this.tbId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ten,
            this.GioiTinh,
            this.Tuoi,
            this.DiemToan,
            this.DiemVan,
            this.DiemAnh,
            this.DiemTB,
            this.HocLuc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(905, 450);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TEN";
            this.Ten.HeaderText = "Tên SV";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GIOITINH";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "TUOI";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.ReadOnly = true;
            // 
            // DiemToan
            // 
            this.DiemToan.DataPropertyName = "DIEMTOAN";
            this.DiemToan.HeaderText = "Điểm Toán";
            this.DiemToan.MinimumWidth = 6;
            this.DiemToan.Name = "DiemToan";
            this.DiemToan.ReadOnly = true;
            // 
            // DiemVan
            // 
            this.DiemVan.DataPropertyName = "DIEMVAN";
            this.DiemVan.HeaderText = "Điểm Văn";
            this.DiemVan.MinimumWidth = 6;
            this.DiemVan.Name = "DiemVan";
            this.DiemVan.ReadOnly = true;
            // 
            // DiemAnh
            // 
            this.DiemAnh.DataPropertyName = "DIEMANH";
            this.DiemAnh.HeaderText = "Điểm Anh";
            this.DiemAnh.MinimumWidth = 6;
            this.DiemAnh.Name = "DiemAnh";
            this.DiemAnh.ReadOnly = true;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DIEMTRUNGBINH";
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.ReadOnly = true;
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HOCLUC";
            this.HocLuc.HeaderText = "Học Lực";
            this.HocLuc.MinimumWidth = 6;
            this.HocLuc.Name = "HocLuc";
            this.HocLuc.ReadOnly = true;
            // 
            // tbDiemVan
            // 
            this.tbDiemVan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiemVan.Location = new System.Drawing.Point(1041, 431);
            this.tbDiemVan.Name = "tbDiemVan";
            this.tbDiemVan.Size = new System.Drawing.Size(316, 27);
            this.tbDiemVan.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(923, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Điểm Văn";
            // 
            // tbDiemAnh
            // 
            this.tbDiemAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiemAnh.Location = new System.Drawing.Point(1041, 480);
            this.tbDiemAnh.Name = "tbDiemAnh";
            this.tbDiemAnh.Size = new System.Drawing.Size(316, 27);
            this.tbDiemAnh.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(923, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Điểm Anh";
            // 
            // tbDiemTB
            // 
            this.tbDiemTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiemTB.Location = new System.Drawing.Point(1041, 524);
            this.tbDiemTB.Name = "tbDiemTB";
            this.tbDiemTB.Size = new System.Drawing.Size(316, 27);
            this.tbDiemTB.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(923, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Điểm TB";
            // 
            // tbHocLuc
            // 
            this.tbHocLuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHocLuc.Location = new System.Drawing.Point(1041, 566);
            this.tbHocLuc.Name = "tbHocLuc";
            this.tbHocLuc.Size = new System.Drawing.Size(316, 27);
            this.tbHocLuc.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(923, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Điểm Học Lực";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Location = new System.Drawing.Point(1263, 115);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 714);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbHocLuc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDiemTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDiemAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDiemVan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDiemToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTenSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnXoa;
        private Button btnSua;
        private TextBox tbTimKiem;
        private Label label6;
        private Button btnThem;
        private TextBox tbDiemToan;
        private Label label5;
        private TextBox tbTuoi;
        private Label label4;
        private TextBox tbGioiTinh;
        private Label label3;
        private TextBox tbTenSV;
        private Label label2;
        private TextBox tbId;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox tbDiemVan;
        private Label label8;
        private TextBox tbDiemAnh;
        private Label label9;
        private TextBox tbDiemTB;
        private Label label10;
        private TextBox tbHocLuc;
        private Label label11;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn DiemToan;
        private DataGridViewTextBoxColumn DiemVan;
        private DataGridViewTextBoxColumn DiemAnh;
        private DataGridViewTextBoxColumn DiemTB;
        private DataGridViewTextBoxColumn HocLuc;
        private Button btnTimKiem;
    }
}