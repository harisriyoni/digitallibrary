namespace BlazorApp2.Server.Helper
{
   
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) :base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Genre_id = 1,
                    Nama_Genre = "Horor"
                },
            new Genre
            {
                Genre_id = 2,
                Nama_Genre = "Comedi"
            },
            new Genre
            {
                Genre_id = 3,
                Nama_Genre = "Romance"
            },
            new Genre
            {
                Genre_id = 4,
                Nama_Genre = "Fantasi"
            },
            new Genre
            {
                Genre_id = 5,
                Nama_Genre = "Edukasi"
            }
                );
            modelBuilder.Entity<Buku>().HasData(
                new Buku
                {
                    Id_buku = 11,
                    Judul_buku = "Dear Nathan",
                    Penerbit = "Tere",
                    Jumlah_halaman = 250,
                    Genre_id = 1
                },
            new Buku
            {
                Id_buku = 12,
                Judul_buku = "Dilan 1991",
                Penerbit = "Pidi Baiq",
                Jumlah_halaman = 250,
                Genre_id = 2
            },
            new Buku
            {
                Id_buku = 16,
                Judul_buku = "Dibalik 98",
                Penerbit = "Ismail",
                Jumlah_halaman = 250,
                Genre_id = 3
            }
                ) ;
        }

        public DbSet<Buku> Buku { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}

