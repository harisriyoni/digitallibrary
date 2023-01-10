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
        private readonly DataContext _context;
        public BukuController(DataContext context) 
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Buku>>> GetDataBuku()
        {
            var Buku = await _context.Buku.ToListAsync();
            return Ok(Buku);
        }
        [HttpGet("genre")]
        public async Task<ActionResult<List<Buku>>> GetGenre()
        {
            var Genre = await _context.Genre.ToListAsync();
            return Ok(Genre);
        }

        //    [HttpGet("{id}")]
        //public async Task<ActionResult<Buku>> GetSingleDataBuku(int id)
       // {
          //  var buku = await _context.Buku
            //    .Include(b => b.Genre)
              //  .FirstOrDefault(b => b.Id_buku == id);
            //if (buku == null)
            //{
              //  return NotFound("Data Buku Tidak Ada :/");
            //}
            //return Ok(buku);
       // }
       // [HttpGet("genre{id}")]
        //public async Task<ActionResult<Buku>> GetSingleGenre(int id)
        //{
          //  var genre =await  Genre.FirstOrDefault(b => b.Genre_id == id);
            //if (genre == null)
            //{
             //   return NotFound("Data Buku Tidak Ada :/");
            //}
            //return Ok(genre);
        //}
    }
}
