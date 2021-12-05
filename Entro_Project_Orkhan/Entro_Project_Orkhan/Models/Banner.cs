using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public String Title { get; set; }
        
    }
}
