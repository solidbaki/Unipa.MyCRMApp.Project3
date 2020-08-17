using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemoApp.Models
{
    //Database table name will be users
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required]
        public int Authentication { get; set; }
       
    }
}
