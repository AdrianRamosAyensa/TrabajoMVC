using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoMVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Column(TypeName = "double(18, 2)")]
        public int precio { get; set; }
    }
}
