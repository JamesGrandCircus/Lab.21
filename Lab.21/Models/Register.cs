using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab._21.Models
{
    public class Register
    {

		// I'm enjoying your use of attributes here

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.] +)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a - zA - Z0 - 9\-]+\.)+))([a - zA - Z]{2,4}|[0-9]{1,3})(\]?)$")]
        public string Email { get; set; }

        [Required]
        //[RegularExpression(@"^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

    }
}