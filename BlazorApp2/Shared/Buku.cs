using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2.Shared
{
    public class Buku
    {
        [Key]
        public int Id_buku { get; set; }
        public string Judul_buku { get; set; } = string.Empty;
        public string Penerbit { get; set; } = string.Empty;
        public int Jumlah_halaman { get; set; }
        public Genre? Genre { get; set; }
        public int Genre_id { get; set; }

    }
}
