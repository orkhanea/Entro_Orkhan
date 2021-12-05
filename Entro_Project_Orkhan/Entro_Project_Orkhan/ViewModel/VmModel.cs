using Entro_Project_Orkhan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro_Project_Orkhan.ViewModel
{
    public class VmModel
    {
        public List<Concert> concert { get; set; }
        public List<ConcertImage> concertImage { get; set; }
    }
}
