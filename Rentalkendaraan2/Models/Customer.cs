using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh disi oleh angka")]
        public string Nik { get; set; }
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No MP minimal 13 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
