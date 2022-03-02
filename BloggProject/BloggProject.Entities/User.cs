using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
   public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int User_Id { get; set; }
        [Required]
        public string User_Name { get; set; }       
        [Required]
        public string User_Email { get; set; }       
        [Required]
        public string User_Password { get; set; } 
    }
}
