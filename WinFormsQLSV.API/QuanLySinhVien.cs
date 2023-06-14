using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WinFormsQLSV.API
{
    internal class QuanLySinhVien
    {
        private HttpClient client;

        public QuanLySinhVien()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5080");

            client.MaxResponseContentBufferSize = 1048576; // 1 MB
        }
        public async Task<string> GetProductAsync(string path)
        {
            string product = "";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
            }
            return product;
        }

        public async Task<int> CreateProductAsync(string path, SinhVien sv)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
               path + "/SinhVien", sv);
            if (response.IsSuccessStatusCode)
                return 1;
            return 0;
        }

        public async Task<int> UpdateProductAsync(string path, SinhVien sv)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(path + $"/id?id={sv.ID}", sv);
            if (response.IsSuccessStatusCode)
                return 1;
            return 0;
        }
        public async Task<int> DeleteProductAsync(string path, SinhVien sv)
        {
            HttpResponseMessage response = await client.DeleteAsync(path + $"/id?id={sv.ID}");
            if (response.IsSuccessStatusCode)
                return 1;
            return 0;
        }
        public async Task<string> SearchProductByNameAsync(string path, SinhVien sv)
        {
            string product = "";
            HttpResponseMessage response = await client.GetAsync(path +$"/ten?ten={sv.TEN}");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
                
            }
            return product;
        }
    }
}
