using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2.Shared
{
    public class Genre
    {
        [Key]
        public int Genre_id { get; set; }
        public string Nama_Genre { get; set; } = string.Empty;
    }
}
