using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        public String Text { get; set; }
        [MaxLength(250)]
        public String BackgroundImage { get; set; }
        [NotMapped]
        public IFormFile BackgroundImageFile { get; set; }
        [MaxLength(250)]
        public String Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
