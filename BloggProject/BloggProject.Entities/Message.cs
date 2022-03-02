using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BloggProject.Entities
{
  public  class Message
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Message_Id { get; set; }
        [Required]
        public string Message_Title { get; set; }
        public string Message_Description { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Email { get; set; }
        [StringLength(20)]
        [Required]
        public DateTime Date { get; set; }

    }
}
