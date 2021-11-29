using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [MinLength(5, ErrorMessage = "No Polisi minimal 5 angka")]
        [MaxLength(8, ErrorMessage = "No Polisi maksimal 8 angka")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh disi oleh angka")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }

        public virtual JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
