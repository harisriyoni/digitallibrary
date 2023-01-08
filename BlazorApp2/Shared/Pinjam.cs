using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2.Shared
{
    public class Pinjam
    {
        public int Id_pinjam { get; set; }
        public string Nama_peminjam { get; set; } = string.Empty;
        public int Genre_id { get; set; }
        public int Id_buku { get; set; }

    }
}
