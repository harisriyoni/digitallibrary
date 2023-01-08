using System.Net.Http.Json;

namespace BlazorApp2.Client.Services.BukuServices
{
    public class Bukuservice : iBukuservice
    {
        private HttpClient _http;

        public Bukuservice(HttpClient http)
        {
            _http = http;
        }
        public List<Buku> buku { get ; set; } = new List<Buku>();
        public List<Genre> genres { get; set; } = new List<Genre>();

        public async Task GetDataBuku()
        {
            var result = await _http.GetFromJsonAsync<List<Buku>>("api/buku");
            if (result != null) 
                buku = result;
           
        }

        public async Task GetGenre()
        {
            var result = await _http.GetFromJsonAsync<List<Genre>>($"api/buku/genre");
            if (result != null)
                genres = result;
        }

        public async Task<Buku> GetSingleBuku(int id)
        {
            var result = await _http.GetFromJsonAsync<Buku>($"api/buku/{id}");
            if (result != null)
                return result;
            throw new Exception("Buku Gaketemu!");
        }
    }
}
