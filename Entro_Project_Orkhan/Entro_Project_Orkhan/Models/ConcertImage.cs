using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class ConcertImage
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("Concert")]

        public int ConcertId { get; set; }

        public Concert Concert { get; set; }




    }
}
