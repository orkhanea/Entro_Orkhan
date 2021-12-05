using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public String Title { get; set; }
        [MaxLength(200)]
        public String Link1 { get; set; }
        [MaxLength(200)]
        public String Link2 { get; set; }
        [MaxLength(250)]
        public String Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
