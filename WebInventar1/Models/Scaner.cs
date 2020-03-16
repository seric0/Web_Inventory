using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Scaner
    {
        public Scaner()
        {
            Scan_type = "Планшетный";
            Scan_optical = "4800х4800";
            Scan_interface = "USB";
            Document_size = "A4";
            Scan_power = "USB";
        }
        public int Id { get; set; }
        public string Scan_inv { get; set; }
        [Required(ErrorMessage = "Введите Наименование!")]
        [Display(Name = "Наименование:")]
        public string Scan_name { get; set; }
        [Required(ErrorMessage = "Тип сканера!")]
        [Display(Name = "Тип:")]
        public string Scan_type { get; set; }
        [Required(ErrorMessage = "Оптическое разрешение!")]
        [Display(Name = "Оптическое разрешение:")]
        public string Scan_optical { get; set; }
        [Required(ErrorMessage = "Интерфейс!")]
        [Display(Name = "Интерфейс:")]
        public string Scan_interface { get; set; }
        [Required(ErrorMessage = "Формат документов!")]
        [Display(Name = "Формат документов:")]
        public string Document_size { get; set; }
        [Required(ErrorMessage = "Питание!")]
        [Display(Name = "Питание:")]
        public string Scan_power { get; set; }
        public string Cab { get; set; }
    }
}
