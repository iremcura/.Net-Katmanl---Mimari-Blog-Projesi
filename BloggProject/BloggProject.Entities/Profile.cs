using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
    public class Profile
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int User_Id { get; set; }
        [StringLength(50)]
        [Required]
        public string About { get; set; }
        public int Phone { get; set; }
        [StringLength(30)]
        [Required]
        public string City { get; set; }

    }
}
