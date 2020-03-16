using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Risograph
    {
        public int Id { get; set; }
        public string Riso_inv { get; set; }
        [Required(ErrorMessage = "Введите Наименование!")]
        [Display(Name = "Наименование:")]
        public string Riso_name { get; set; }
        [Required(ErrorMessage = "Формат печати!")]
        [Display(Name = "Формат печати:")]
        public string Riso_type { get; set; }
        [Required(ErrorMessage = "Формат бумаги!")]
        [Display(Name = "Формат бумаги для печати (мм):")]
        public string Riso_format { get; set; }
        [Required(ErrorMessage = "Разрешение сканирования!")]
        [Display(Name = "Разрешение сканирования, dpi:")]
        public string Riso_optical { get; set; }
        [Required(ErrorMessage = "Скорость печати!")]
        [Display(Name = "Скорость печати, листов/минута:")]
        public string Riso_speed { get; set; }
        [Required(ErrorMessage = "Интерфейс пользователя!")]
        [Display(Name = "Интерфейс пользователя:")]
        public string Riso_interface { get; set; }
        [Display(Name = "Краска (количество):")]
        public string Riso_ink_col { get; set; }
        [Display(Name = "Краска (тип):")]
        public string Riso_ink_type { get; set; }
        [Display(Name = "Мастер-пленка (тип):")]
        public string Riso_master_type { get; set; }
        [Display(Name = "Электропитание:")]
        public string Power_supply { get; set; }
        [Display(Name = "Габариты (ШхГхВ), мм:")]
        public string Riso_size { get; set; }
        [Display(Name = "Масса, кг:")]
        public string Riso_weight { get; set; }
        [Display(Name = "Кабинет:")]
        public string Cab { get; set; }
        [Display(Name = "ФИО ответственного лица:")]
        public string Fio_admin { get; set; }
        [Display(Name = "Дата заполнения:")]
        public DateTime Data { get; set; }
    }
}
