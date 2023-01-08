namespace BlazorApp2.Client.Services.BukuServices
{
    public interface iBukuservice
    {
        List<Buku> buku { get; set; }
        List<Genre> genres { get; set; }
        Task GetGenre();
        Task GetDataBuku();
        Task<Buku> GetSingleBuku(int id);

    }
}
