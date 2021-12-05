using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Entro_Project_Orkhan.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public String Title { get; set; }
        [Column(TypeName ="ntext")]
        public String Text { get; set; }
        public DateTime CreateDate { get; set; }

        public List<ConcertImage> ConcertImage { get; set; }

    }
}
