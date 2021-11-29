using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Jeniis Kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
