using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama Jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }
        
        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
