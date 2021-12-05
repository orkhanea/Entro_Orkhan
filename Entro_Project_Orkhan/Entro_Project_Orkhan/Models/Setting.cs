using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Entro_Project_Orkhan.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public String Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(100)]
        public String Address { get; set; }
        [MaxLength(25)]
        public String Phone { get; set; }
        [MaxLength(50)]
        public String Email { get; set; }
        [MaxLength(50)]
        public String Copyright { get; set; }
        [MaxLength(100)]
        public String CopyrightLink { get; set; }
        [Column(TypeName = "ntext")]
        public String GalleryText { get; set; }

    }
}
