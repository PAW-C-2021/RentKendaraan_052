using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Kondisi kendaraan tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public virtual ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
