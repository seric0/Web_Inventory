using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Ibp
    {
        public int Id { get; set; }
        public string Ibp_inv { get; set; }
        [Required(ErrorMessage = "Введите Наименование!")]
        [Display(Name = "Наименование:")]
        public string Ibp_name { get; set; }
        [Required(ErrorMessage = "Введите мощность!")]
        [Display(Name = "Мощность:")]
        public string Ibp_power { get; set; }
        public string Cab { get; set; }
    }
}
