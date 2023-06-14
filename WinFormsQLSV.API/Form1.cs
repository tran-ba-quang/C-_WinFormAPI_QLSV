using System.Data;
using Newtonsoft.Json;
using System.Text.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace WinFormsQLSV.API
{
    public partial class Form1 : Form
    {

        SinhVien svChon = new SinhVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public async void LoadData()
        {
            try
            {
                string path = "http://localhost:5080/SinhVien";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                string kq = await qlsv.GetProductAsync(path);
                DataTable dt = new DataTable();
                dt = JsonConvert.DeserializeObject<DataTable>(kq);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }



        public SinhVien getForm()
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.ID = tbId.Text;
            sinhVien.TEN = tbTenSV.Text;
            sinhVien.GIOITINH = tbGioiTinh.Text;
            sinhVien.TUOI = Convert.ToInt32(tbTuoi.Text);
            sinhVien.DIEMTOAN = Convert.ToDouble(tbDiemToan.Text);
            sinhVien.DIEMVAN = Convert.ToDouble(tbDiemVan.Text);
            sinhVien.DIEMANH = Convert.ToDouble(tbDiemAnh.Text);
            sinhVien.DIEMTRUNGBINH = Convert.ToDouble(tbDiemTB.Text);
            sinhVien.HOCLUC = tbHocLuc.Text;
            return sinhVien;
        }

        public void SetForm(SinhVien sv)
        {
            if (sv == null)
            {
                tbId.Text = "";
                tbTenSV.Text = "";
                tbGioiTinh.Text = "";
                tbTuoi.Text = "";
                tbDiemToan.Text = "";
                tbDiemVan.Text = "";
                tbDiemAnh.Text = "";
                tbDiemTB.Text = "";
                tbHocLuc.Text = "";

            }
            else
            {

                tbId.Text = sv.ID;
                tbTenSV.Text = sv.TEN;
                tbGioiTinh.Text = sv.GIOITINH;
                tbTuoi.Text = Convert.ToString(sv.TUOI);
                tbDiemToan.Text = Convert.ToString(sv.DIEMTOAN);
                tbDiemVan.Text = Convert.ToString(sv.DIEMVAN);
                tbDiemAnh.Text = Convert.ToString(sv.DIEMANH);
                tbDiemTB.Text = Convert.ToString(sv.DIEMTRUNGBINH);
                tbHocLuc.Text = sv.HOCLUC;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                svChon.ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                svChon.TEN = dataGridView1.Rows[index].Cells[1].Value.ToString();
                svChon.GIOITINH = dataGridView1.Rows[index].Cells[2].Value.ToString();
                svChon.TUOI = Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value.ToString());
                svChon.DIEMTOAN = Convert.ToDouble(dataGridView1.Rows[index].Cells[4].Value.ToString());
                svChon.DIEMVAN = Convert.ToDouble(dataGridView1.Rows[index].Cells[5].Value.ToString());
                svChon.DIEMANH = Convert.ToDouble(dataGridView1.Rows[index].Cells[6].Value.ToString());
                svChon.DIEMTRUNGBINH = Convert.ToDouble(dataGridView1.Rows[index].Cells[7].Value.ToString());
                svChon.HOCLUC = dataGridView1.Rows[index].Cells[8].Value.ToString();
                SetForm(svChon);
            }
        }
        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                string path = "http://localhost:5080";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                int nRow = await qlsv.CreateProductAsync(path, sv);
                if (nRow > 0)
                {
                    MessageBox.Show("Thêm thành công !!!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !!!");
            }
        }
        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = getForm();
                string path = "http://localhost:5080";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                int nRow = await qlsv.UpdateProductAsync(path, sv);
                if (nRow > 0)
                {
                    MessageBox.Show("Sua thành công !!!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua thất bại !!!");
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (svChon != null)
            {
                SinhVien sv = getForm();
                string path = "http://localhost:5080";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                int nRow = await qlsv.DeleteProductAsync(path, sv);
                if (nRow > 0)
                {
                    MessageBox.Show("Xoa thành công !!!");
                    LoadData();
                }
            }
        }
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
               
                string path = "http://localhost:5080";
                QuanLySinhVien qlsv = new QuanLySinhVien();
                SinhVien sv = new SinhVien { TEN = tbTimKiem.Text };
                string kq = await qlsv.SearchProductByNameAsync(path, sv);
                List<SinhVien> sinhViens = JsonConvert.DeserializeObject<List<SinhVien>>(kq);
              
                dataGridView1.DataSource = sinhViens;
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}