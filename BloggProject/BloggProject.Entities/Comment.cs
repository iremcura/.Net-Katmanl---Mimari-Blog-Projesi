using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
   public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Comment_Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Comment_Message { get; set; }
        public DateTime Comment_Date { get; set; }
        public int Content_Id { get; set; }

        public int User_Id { get; set; }
       
    }
}
