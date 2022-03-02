using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
   public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Category_Id { get; set; }
        [Required]
        public string Category_Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Category_Description { get; set; }
        public string Category_Image { get; set; }


    }
}
