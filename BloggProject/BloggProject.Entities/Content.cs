using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
    public class Content
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Content_Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Content_Title { get; set; }
        [Required]
        public string Content_Description { get; set; }
        [Required]
        public string Content_Image { get; set; }
        [Required]
        public int Category_Id { get; set; }

        public int Comment_Id { get; set; }
    }
}
