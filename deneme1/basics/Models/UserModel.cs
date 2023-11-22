using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace basics.Models
{
    public class UserModel
    {

        public int id {get;set;}

        [Required(ErrorMessage = "Kullanıcı adı zorunlu bir alan.")]
        public string? username {get;set;}

        [Required(ErrorMessage = "Şifre zorunlu bir alan.")]
        public string? password {get;set;}
        

        
    }

    
}