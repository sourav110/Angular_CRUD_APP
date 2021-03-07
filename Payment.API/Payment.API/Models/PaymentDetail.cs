using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string ExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string SecurityCode { get; set; }
    }
}
