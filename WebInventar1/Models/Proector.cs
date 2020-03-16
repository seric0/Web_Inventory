using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Proector
    {
        public int Id { get; set; }
        public string Proector_inv { get; set; }
        [Required(ErrorMessage = "Введите Наименование!")]
        [Display(Name = "Наименование:")]
        public string Cab { get; set; }
        public string Proector_name { get; set; }
        public string Proector_luminous_flux { get; set; }
        public string Proector_contrast { get; set; }
        public string Proector_texnology { get; set; }
        public string Proector_optimal { get; set; }
        public string Proector_connect { get; set; }
    }
}
