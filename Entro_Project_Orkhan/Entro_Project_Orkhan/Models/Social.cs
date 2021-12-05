using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public String Name { get; set; }
        [MaxLength(100)]
        public String Icon { get; set; }
        [MaxLength(200)]
        public String Link { get; set; }
        
    }
}
