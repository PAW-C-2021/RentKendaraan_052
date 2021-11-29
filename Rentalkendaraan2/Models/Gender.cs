using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rentalkendaraan2.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        [Required(ErrorMessage = "Nama Gender tidak boleh kosong")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
