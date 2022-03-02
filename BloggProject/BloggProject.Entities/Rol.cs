using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
   public class Rol
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rol_Id { get; set; }
        [Required]
        public string Name { get; set; }

        public User User { get; set; }
    }
}
