using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace EmiCalculatorWebApi.Models
{
    [Table("EmiDbTable")]
    public class UserModel
    {
        
        [Key]
        public  string Username { get; set; }
        public  password { get; set; }
         public string email { get; set; }
         public int phonenumber { get; set; }
         public string image{ get; set; }

    }
}
int