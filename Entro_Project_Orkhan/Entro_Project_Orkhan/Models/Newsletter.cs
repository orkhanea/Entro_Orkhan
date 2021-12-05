using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public String Email { get; set; }
        public DateTime CreatedDate { get; set; }
        
        
        
    }
}
