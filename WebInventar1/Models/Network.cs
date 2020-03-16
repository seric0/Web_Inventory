using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Network
    {
        [Key]
        public int SetiId { get; set; }        
        [Display(Name = "Структурное подразделение:")]
        public int Str_pod { get; set; }        
        [Display(Name = "ФИО:")]
        public int Fio { get; set; }        
        [Display(Name = "Должность:")]
        public string Dolg { get; set; }
        [Required(ErrorMessage = "Кабинет:")]
        [Display(Name = "Кабинет:")]
        public int Cabinet { get; set; }
        [Display(Name = "Телефон:")]
        public string Phone { get; set; }        
        [Display(Name = "Дата:")]
        public DateTime Data { get; set; }
        [Display(Name = "Сетевое оборудование (Серийный номер):")]
        public string Activ_sn { get; set; }
        [Required(ErrorMessage = "Сетевое оборудование (Инвентарный номер):")]
        [Display(Name = "Сетевое оборудование (Инвентарный номер):")]
        public string Activ_inv { get; set; }
        [Required(ErrorMessage = "Описание:")]
        [Display(Name = "Описание:")]
        public string Notice { get; set; }
        [Required(ErrorMessage = "Ip адрес:")]
        [Display(Name = "Ip адрес:")]
        public string Ip { get; set; }        
        [Display(Name = "Площадка размещения:")]
        public int Platform { get; set; }
        [Display(Name = "Руководитель подразделения:")]
        public int Rukov_podr { get; set; }
        [Display(Name = "Руководитель ХС:")]
        public int Rukov_xc { get; set; }
        [Display(Name = "Паспорт заполнил:")]
        public int Pasport { get; set; }
        [Required(ErrorMessage = "Дата заполнения:")]
        [Display(Name = "Дата заполнения:")]
        public DateTime Data2 { get; set; }
        public int Net_nId { get; set; }
        public int Net_tId { get; set; }
        public int Net_pId { get; set; }
    }

    public class Platform
    {
        public int Id { get; set; }
        [Display(Name = "Платформа размещения:")]
        public string Name { get; set; }
    }

    public class Nets
    {

        public Nets()
        {

        }
        public Nets(Network p, Otdel c, Worker w, Cabinet o, Platform pl)
        {
            //TO DO: Complete Member Initialization  
            this.Network = p;
            this.Otdel = c;
            this.Cabinet = o;
            this.Worker = w;
            this.Platform = pl;
        }
        public Network Network { get; set; }
        public Otdel Otdel { get; set; }
        public Worker Worker { get; set; }
        public Cabinet Cabinet { get; set; }
        public Platform Platform { get; set; }
    }
}
