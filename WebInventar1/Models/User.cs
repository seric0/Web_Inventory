using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "Введите ФИО!")]
        [Display(Name = "ФИО:")]
        public string Fio { get; set; }
        [Required(ErrorMessage = "Введите должность!")]
        [Display(Name = "Должность:")]
        public string Dolgnost { get; set; }
        [Required(ErrorMessage = "Введите логин!")]
        [Display(Name = "Логин:")]
        public string LoginUser { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите пароль! Пароль должен быть не меньше 6 символов, содержать буквы нижнего и верхнего регистров и один спецсимвол.")]
        [Display(Name = "Пароль:")]
        public string Passwd { get; set; }
        public DateTime Data { get; set; }
    }

    public class Login
    {
        [Required(ErrorMessage = "Введите логин!")]
        [Display(Name = "Логин:")]
        public string LoginUser { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите пароль! Пароль должен быть не меньше 6 символов, содержать буквы нижнего и верхнего регистров и один спецсимвол.")]
        [Display(Name = "Пароль:")]
        public string Passwd { get; set; }
    }

    public class RestorePass
    {
        [Required(ErrorMessage = "Введите логин!")]
        [Display(Name = "Логин:")]
        public string LoginUser { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите текущий пароль! Пароль должен быть не меньше 6 символов, содержать буквы нижнего и верхнего регистров и один спецсимвол.")]
        [Display(Name = "Текущий Пароль:")]
        public string OldPasswd { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите новый пароль! Пароль должен быть не меньше 6 символов, содержать буквы нижнего и верхнего регистров и один спецсимвол.")]
        [Display(Name = "Новый Пароль:")]
        public string Passwd { get; set; }
        [DataType(DataType.Password)]
        [Compare("Passwd", ErrorMessage = "Пароли не совпадают")]
        [Display(Name = "Новый Пароль:")]
        public string ConfirmPasswd { get; set; }
    }
}
