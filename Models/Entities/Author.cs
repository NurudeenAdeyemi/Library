using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Entities
{
    public class Author : BaseEntity
    {
        [Required(ErrorMessage = "Firstname is required")]
        [DisplayName("Firstname")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        [DisplayName("Firstname")]
        [StringLength(160)]
        public string LasttName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
          ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(72)]
        public string Password { get; set; }

        //public IList<Book> Books = new List<Book>();
    }
}
