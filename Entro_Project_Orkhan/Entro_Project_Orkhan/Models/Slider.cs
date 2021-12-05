using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public String SupTitle { get; set; }
        [MaxLength(50)]
        public String SubTitle { get; set; }
        [MaxLength(2000)]
        public String Text { get; set; }
        [MaxLength(250)]
        public String Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
