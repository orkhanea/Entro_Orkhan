using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public String Name { get; set; }
        [MaxLength(100)]
        public String Address { get; set; }
        [MaxLength(25)]
        public String Phone { get; set; }
        [MaxLength(50)]
        public String Email { get; set; }
        public String MessageContent { get; set; }
        [MaxLength(100)]
        public DateTime CreatedDate { get; set; }
        
    }
}
