using BlazorApp2.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BlazorApp2.Server.Controllers
{
    [Route("api/buku")]
    [ApiController]
    public class BukuController : ControllerBase
    {

        public static List<Genre> Genre = new List<Genre>
        {
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
        };
        public static List<Buku> Buku = new List<Buku>
        {
            new Buku{ Id_buku = 11, Judul_buku = "Dear Nathan", 
                Penerbit = "Tere", Jumlah_halaman = 250, Genre = Genre[0], Genre_id = 1},
            new Buku{ Id_buku = 12, Judul_buku = "Dilan 1991",
                Penerbit = "Pidi Baiq", Jumlah_halaman = 250, Genre = Genre[1], Genre_id = 2},
            new Buku{ Id_buku = 16, Judul_buku = "Dibalik 98",
                Penerbit = "Ismail", Jumlah_halaman = 250, Genre = Genre[2], Genre_id = 3}
        };

        [HttpGet]
        public async Task<ActionResult<List<Buku>>> GetDataBuku()
        {
            return Ok(Buku);
        }
        [HttpGet("genre")]
        public async Task<ActionResult<List<Buku>>> GetGenre()
        {
            return Ok(Genre);
        }

            [HttpGet("{id}")]
        public async Task<ActionResult<Buku>> GetSingleDataBuku(int id)
        {
            var buku = Buku.FirstOrDefault(b => b.Id_buku == id);
            if (buku == null)
            {
                return NotFound("Data Buku Tidak Ada :/");
            }
            return Ok(buku);
        }
        [HttpGet("genre{id}")]
        public async Task<ActionResult<Buku>> GetSingleGenre(int id)
        {
            var genre = Genre.FirstOrDefault(b => b.Genre_id == id);
            if (genre == null)
            {
                return NotFound("Data Buku Tidak Ada :/");
            }
            return Ok(genre);
        }
    }
}
