using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{    
    public class Computer
    {
        public Computer()
        {
            Ip = "Присвоен DHCP";
        }
        [Key]
        public int CompID { get; set; }
        [Required(ErrorMessage = "Введите ФИО!")]
        [Display(Name = "ФИО:")]
        public int Name { get; set; }
        [Required(ErrorMessage = "Введите должность!")]
        [Display(Name = "Должность:")]
        public int Dolgnost { get; set; }
        [Required(ErrorMessage = "Введите кабинет!")]
        [Display(Name = "Кабинет:")]
        public int Cab { get; set; }
        [Display(Name = "Год выпуска:")]
        public int Data { get; set; }
        [Display(Name = "Серийный номер (системник):")]
        public string Sys_sn_c { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Длина строки должна быть от 5 до 20 символов")]
        [Display(Name = "Инвентарный номер (системник):")]
        public string Sys_inv_c { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [Display(Name = "Серийный номер (монитор):")]
        public string Sys_sn_m { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [Display(Name = "Инвентарный номер (монитор):")]
        public string Sys_inv_m { get; set; }
        [Display(Name = "Серийный номер (принтер):")]
        public string Sys_sn_p { get; set; }
        [Display(Name = "Инвентарный номер (принтер):")]
        public string Sys_inv_p { get; set; }
        [Display(Name = "Серийный номер (ноутбук):")]
        public string Sys_sn_n { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [Display(Name = "Инвентарный номер (ноутбук):")]
        public string Sys_inv_n { get; set; }
        [Required(ErrorMessage = "Выберите название монитора!")]
        [Display(Name = "Название монитора:")]
        public string M_name { get; set; }
        [Display(Name = "Инвен.номер UPS:")]
        public string Ups_sys_inv { get; set; }
        [Required(ErrorMessage = "Выберите Ethernet Card!")]
        [Display(Name = "Сетевая карта:")]
        public int Ethernet { get; set; }
        [Required(ErrorMessage = "Введите имя в сети!")]
        [Display(Name = "Имя в сети:")]
        public string Network { get; set; }
        [Required(ErrorMessage = "Введите IP-адрес сети!")]
        [Display(Name = "IP-адрес сети:")]
        public string Ip { get; set; }
        [Required(ErrorMessage = "Введите группу или домен сети!")]
        [Display(Name = "Рабочая группа/домен:")]
        public int Workgroup { get; set; }
        [Display(Name = "Email-адрес:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Выберите Да или Нет!")]
        [Display(Name = "Интернет:")]
        public int Internet { get; set; }
        [Required(ErrorMessage = "Выберите Да или Нет!")]
        [Display(Name = "ЕСЭДО:")]
        public int Ecedo { get; set; }
        [Required(ErrorMessage = "Введите ФИО руководителя!")]
        [Display(Name = "Руководитель подразделения:")]
        public int Rukov_podr { get; set; }
        [Required(ErrorMessage = "Введите ФИО руководителя!")]
        [Display(Name = "Руководитель хозчасти:")]
        public int Rukov_xoz { get; set; }
        [Required(ErrorMessage = "Введите ФИО!")]
        [Display(Name = "Паспорт заполнил:")]
        public int Passport { get; set; }
        [Display(Name = "Дата заполнения:")]
        public DateTime Data2 { get; set; }
        public int Otdel_id { get; set; }
        public int Type_id { get; set; }
        public int Cpu_id { get; set; }
        public int Cpu_ch_id { get; set; }
        public int Ram_id { get; set; }
        public int Hdd_id { get; set; }
        public int M_type_id { get; set; }
        public int Ups_id { get; set; }

        //public IEnumerable<Computer> Comps { get; set; }
        //public List<Programm> Programms { get; set; }        
    }

    public class Programm
    {
        [Key]
        public int ProgID { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Портал Egov:")]
        public int CompId { get; set; }
        public int Egov { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Амбулаторно-поликлиническая помощь:")]
        public int App { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Информационная система Лекарственного обеспечения:")]
        public int Islo { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "АИС Поликлиника:")]
        public int Aic { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Регистр прикрепленного населения:")]
        public int Rpn { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Электронный регистр стационарных больных:")]
        public int Ersb { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Бюро госпитализации:")]
        public int Bg { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "ИС ДКПН:")]
        public int Dkpn { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Система управления ресурсами:")]
        public int Sur { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "ИС СУМТ:")]
        public int Sumt { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Регистр беременных и Женщин фертильного возраста:")]
        public int Rb { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "ИС Диабет:")]
        public int Diabet { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "ИС Почка:")]
        public int Pochka { get; set; }
        [Required(ErrorMessage = "Выберите !")]
        [Display(Name = "Комплексная медицинская информационная система:")]
        public int Kmis { get; set; }
        public int Os_id { get; set; }
        public int Office_id { get; set; }
        public int Antivir_id { get; set; }
        public int Grapfic_id { get; set; }
        public int Browser_id { get; set; }
        public int Arhivator_id { get; set; }
        public int Buxgalter_id { get; set; }
        //public Computer Computer { get; set; }
    }

    public class OsWithProgramm
    {

        public OsWithProgramm()
        {

        }
        public OsWithProgramm(Programm p, Os c, Office o, Antivirus a, Browser b)
        {
            //TO DO: Complete Member Initialization  
            this.Programm = p;
            this.Os = c;
            this.Office = o;
            this.Antivirus = a;
            this.Browser = b;
        }
        public Programm Programm { get; set; }
        public Os Os { get; set; }
        public Office Office { get; set; }
        public Antivirus Antivirus { get; set; }
        public Browser Browser { get; set; }
    }

    public class Organization
    {
        public int Id { get; set; }
        public string Name_org { get; set; }
        public string Adres_org { get; set; }
        public string Fio_rukov { get; set; }
        public string Dolg_rukov { get; set; }
        public string Fio_zam { get; set; }
        public string Dolg_zam { get; set; }
        public string Fio_admin { get; set; }
        public string Dolg_admin { get; set; }
        public string Email { get; set; }
    }

    public class Change
    {
        public int Id { get; set; }
        [Display(Name = "Используется/Не используется:")]
        public string Name { get; set; }
    }

    public class Otdel
    {
        public int Id { get; set; }
        [Display(Name = "Наименование отдела:")]
        public string Name { get; set; }
    }

    public class Cabinet
    {
        public int Id { get; set; }
        [Display(Name = "Наименование кабинета:")]
        public string Name { get; set; }
    }

    public class Position
    {
        public int Id { get; set; }
        [Display(Name = "Наименование должности:")]
        public string Name { get; set; }
    }

    public class Worker
    {
        public int Id { get; set; }
        [Display(Name = "ФИО сотрудника:")]
        public string Name { get; set; }
        public bool Programmist { get; set; }
    }

    public class Repattr1
    {
        [Key]
        public int Repid { get; set; }
        [Display(Name = "Наименование:")]
        public string Name { get; set; }
    }

    public class Hdd_ob
    {
        public int Id { get; set; }
        [Display(Name = "Объем жесткого диска:")]
        public string Name { get; set; }
    }

    public class Monitor
    {
        public int Id { get; set; }
        [Display(Name = "Наименование монитора:")]
        public string Name { get; set; }
    }

    public class Monitor_size
    {
        public int Id { get; set; }
        [Display(Name = "Размер монитора:")]
        public string Name { get; set; }
    }

    public class Monitor_name
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Monitor_resolution
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Monitor_matrix
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Monitor_connection
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Proc
    {
        public int Id { get; set; }
        [Display(Name = "Наименование процессора:")]
        public string Name { get; set; }
    }

    public class Proc_ch
    {
        public int Id { get; set; }
        [Display(Name = "Частота процессора:")]
        public string Name { get; set; }
    }

    public class Ram_ob
    {
        public int Id { get; set; }
        [Display(Name = "Объем памяти:")]
        public string Name { get; set; }
    }

    public class Typec
    {
        public int Id { get; set; }
        [Display(Name = "Тип компьютера:")]
        public string Name { get; set; }
    }

    public class Workstation
    {
        public int Id { get; set; }
        [Display(Name = "Наименование рабочей группы/домена:")]
        public string Name { get; set; }
    }

    public class Ups
    {
        public int Id { get; set; }
        [Display(Name = "Наименование ИБП:")]
        public string Name { get; set; }
    }

    public class Os
    {
        public int Id { get; set; }
        [Display(Name = "Наименование ОС:")]
        public string Name { get; set; }
    }

    public class Office
    {
        public int Id { get; set; }
        [Display(Name = "Наименование офисной программы:")]
        public string Name { get; set; }
    }

    public class Antivirus
    {
        public int Id { get; set; }
        [Display(Name = "Наименование антивируса:")]
        public string Name { get; set; }
    }

    public class Browser
    {
        public int Id { get; set; }
        [Display(Name = "Наименование браузера:")]
        public string Name { get; set; }
    }

    public class Grafic
    {
        public int Id { get; set; }
        [Display(Name = "Наименование графической программы:")]
        public string Name { get; set; }
    }

    public class Arhivator
    {
        public int Id { get; set; }
        [Display(Name = "Наименование архиватора:")]
        public string Name { get; set; }
    }

    public class Buxgalter
    {
        public int Id { get; set; }
        [Display(Name = "Наименование бухгалтерской программы:")]
        public string Name { get; set; }
    }

    public class Component_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип комплектующего оборудования:")]
        public string Name { get; set; }
    }

    public class Network_hard_name
    {
        public int Id { get; set; }
        [Display(Name = "Наименование сетевого оборудования:")]
        public string Name { get; set; }
    }

    public class Network_hard_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип сетевого оборудования:")]
        public string Name { get; set; }
    }

    public class Network_hard_port
    {
        public int Id { get; set; }
        [Display(Name = "Кол-во портов сетевого оборудования:")]
        public string Name { get; set; }
    }

    public class Printer_name
    {
        public int Id { get; set; }
        [Display(Name = "Наименование принтера:")]
        public string Name { get; set; }
    }

    public class Printer_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип принтера:")]
        public string Name { get; set; }
    }

    public class Printer_texnology
    {
        public int Id { get; set; }
        [Display(Name = "Тип принтера:")]
        public string Name { get; set; }
    }

    public class Printer_format
    {
        public int Id { get; set; }
        [Display(Name = "Тип принтера:")]
        public string Name { get; set; }
    }

    public class Printer_cart
    {
        public int Id { get; set; }
        [Display(Name = "Тип принтера:")]
        public string Name { get; set; }
    }
    
    public class Hard_type_name
    {
        public int Id { get; set; }
        [Display(Name = "Наименование:")]
        public string Name { get; set; }
    }

    public class Reason_p_spr
    {
        public int Id { get; set; }
        [Display(Name = "Наименование поломки:")]
        public string Name { get; set; }
    }

    public class Reason_r_spr
    {
        public int Id { get; set; }
        [Display(Name = "Наименование диагностики:")]
        public string Name { get; set; }
    }
    
    public class Name_d_spr
    {
        public int Id { get; set; }
        [Display(Name = "Наименование диагностики:")]
        public string Name { get; set; }
    }

    public class Ethernet
    {
        public int Id { get; set; }
        [Display(Name = "Сетевая карта:")]
        public string Name { get; set; }
    }

    public class Devices
    {
        public int Id { get; set; }
        [Display(Name = "Устройство:")]
        public string Name { get; set; }
    }

    public class Result
    {
        public int Id { get; set; }
        [Display(Name = "Результат ремонта:")]
        public string Name { get; set; }
    }

    public class Type_g
    {
        public int Id { get; set; }        
        public string Name { get; set; }
    }

    public class Vid_g
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Name_g
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Vid_copy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Result_g
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Ground
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Monitorwithelement
    {

        public Monitorwithelement()
        {

        }
        public Monitorwithelement(Monitor mon, Monitor_name mon_name, Monitor_size mon_size, Monitor_resolution mon_res, Monitor_matrix mon_matrix, Monitor_connection mon_conn)
        {
            //TO DO: Complete Member Initialization  
            this.Monitors = mon;
            this.Monitor_name = mon_name;
            this.Monitor_size = mon_size;
            this.Monitor_resolution = mon_res;
            this.Monitor_matrix = mon_matrix;
            this.Monitor_connection = mon_conn;
        }
        public Monitor Monitors { get; set; }
        public Monitor_name Monitor_name { get; set; }
        public Monitor_size Monitor_size { get; set; }
        public Monitor_resolution Monitor_resolution { get; set; }
        public Monitor_matrix Monitor_matrix { get; set; }
        public Monitor_connection Monitor_connection { get; set; }
    }

    public class Component
    {
        [Key]
        public int ComponentiId { get; set; }
        [Required(ErrorMessage = "Введите Наименование!")]
        [Display(Name = "Наименование:")]
        public string Hard_name { get; set; }
        [Required(ErrorMessage = "Введите Количество!")]
        [Display(Name = "Количество:")]
        public int Col { get; set; }
        [Required(ErrorMessage = "Введите Кабинет!")]
        [Display(Name = "Кабинет:")]
        public int Cab { get; set; }
        [Required(ErrorMessage = "Введите Расход!")]
        [Display(Name = "Расход:")]
        public int Expense { get; set; }
        [Required(ErrorMessage = "Введите Остаток!")]
        [Display(Name = "Остаток:")]
        public int Residue { get; set; }
        [Display(Name = "Дата заполнения:")]
        public DateTime Data { get; set; }
        public int Hard_id { get; set; }
    }

    public class Componentwithelement
    {

        public Componentwithelement()
        {

        }
        public Componentwithelement(Component com, Cabinet cab)
        {
            //TO DO: Complete Member Initialization  
            this.Component = com;
            this.Cabinet = cab;            
        }
        public Component Component { get; set; }
        public Cabinet Cabinet { get; set; }        
    }

    public class Printer
    {
        [Key]
        public int PrinteriId { get; set; }
        [Required(ErrorMessage = "Введите Инвентарный номер!")]
        [Display(Name = "Инвентарный номер (принтер):")]
        public string Sys_inv_p { get; set; }
        [Display(Name = "Серийный номер (принтер):")]
        public string Sys_sn_p { get; set; }
        [Required(ErrorMessage = "Введите № кабинета!")]
        [Display(Name = "Кабинет:")]
        public string Cab_p { get; set; }
        public int Name_id { get; set; }
        public int Type_id { get; set; }
        public int Tex_id { get; set; }
        public int Format_id { get; set; }
        public int Cart_id { get; set; }
    }

    public class Printerwithcart
    {

        public Printerwithcart()
        {

        }
        public Printerwithcart(Printer p, Printer_name pn, Printer_type pt, Printer_texnology px, Printer_format pc, Printer_cart pk)
        {
            //TO DO: Complete Member Initialization  
            this.Printer = p;
            this.Printer_name = pn;
            this.Printer_type = pt;
            this.Printer_texnology = px;
            this.Printer_format = pc;
            this.Printer_cart = pk;
        }
        public Printer Printer { get; set; }
        public Printer_name Printer_name { get; set; }
        public Printer_type Printer_type { get; set; }
        public Printer_texnology Printer_texnology { get; set; }
        public Printer_format Printer_format { get; set; }
        public Printer_cart Printer_cart { get; set; }
    }

    public class Diagnostic_c
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Название организации!")]
        [Display(Name = "Название организации:")]
        public int Name_org { get; set; }
        [Display(Name = "Наименование диагностики/ремнота:")]
        public int Name_d { get; set; }
        [Display(Name = "Наименование устройства:")]
        public int Type_d { get; set; }
        [Required(ErrorMessage = "Введите Кабинет!")]
        [Display(Name = "Кабинет:")]
        public int Cab_d { get; set; }
        [Required(ErrorMessage = "Введите Описание поломки!")]
        [Display(Name = "Описание поломки:")]
        public int Reason_p { get; set; }
        [Required(ErrorMessage = "Введите Диагностические мероприятия!")]
        [Display(Name = "Диагностические мероприятия:")]        
        public int Reason_r { get; set; }
        [Required(ErrorMessage = "Введите Заключение!")]
        [Display(Name = "Заключение:")]
        public string Conclusion_r { get; set; }
        [Required(ErrorMessage = "Введите Техника!")]
        [Display(Name = "Техник:")]
        public int Engineer_r { get; set; }
        [Required(ErrorMessage = "Введите Руководителя!")]
        [Display(Name = "Руководитель:")]
        public int Director_r { get; set; }
        [Display(Name = "Дата ремонта:")]
        public DateTime Data_r { get; set; }
    }

    public class Diagnostic
    {

        public Diagnostic()
        {

        }
        public Diagnostic(Diagnostic_c dc, Organization o, Name_d_spr nd, Devices td, Cabinet cab, Reason_p_spr rp, Reason_r_spr rc, Worker wk, Worker wc)
        {
            //TO DO: Complete Member Initialization  
            this.Diagnostic_c = dc;
            this.Organization = o;
            this.Name_d_spr = nd;
            this.Devices = td;
            this.Cabinet = cab;
            this.Reason_p_spr = rp;
            this.Reason_r_spr = rc;
            this.Worker = wk;
            this.Worker2 = wc;
        }
        public Diagnostic_c Diagnostic_c { get; set; }
        public Organization Organization { get; set; }
        public Name_d_spr Name_d_spr { get; set; }
        public Devices Devices { get; set; }
        public Cabinet Cabinet { get; set; }
        public Reason_p_spr Reason_p_spr { get; set; }
        public Reason_r_spr Reason_r_spr { get; set; }
        public Worker Worker { get; set; }
        public Worker Worker2 { get; set; }
    }

    public class Backup_g
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Кабинет:")]
        public int Cab_g { get; set; }
        [Display(Name = "Тип (Копирование/Восстановление):")]
        public int Type_g { get; set; }
        [Display(Name = "Вид копирования/восстановления:")]
        public int Vid_g { get; set; }
        [Display(Name = "Объект копирования/восстановления:")]
        public int Vid_copy { get; set; }
        [Display(Name = "Область копирования/восстановления:")]
        public int Name_g { get; set; }
        [Display(Name = "Размещение копии:")]
        public int Location_g { get; set; }
        [Display(Name = "Количество копий:")]
        public int Col_copy { get; set; }
        [Display(Name = "Результат копирования/восстановления:")]
        public int Result_g { get; set; }
        [Display(Name = "Сотрудник выполнявший копирование/восстановление:")]
        public int Personal_g { get; set; }
        [Display(Name = "Дата копирования/восстановления:")]
        public DateTime Data_g { get; set; }
    }

    public class Backups
    {

        public Backups()
        {

        }
        public Backups(Backup_g back, Cabinet cab, Type_g tg, Vid_g vg, Vid_copy vc, Name_g ng, Name_g ngg, Result_g rg, Worker wc)
        {
            //TO DO: Complete Member Initialization  
            this.Backup_g = back;
            this.Cabinet = cab;
            this.Type_g = tg;
            this.Vid_g = vg;
            this.Cabinet = cab;
            this.Vid_copy = vc;
            this.Name_g = ng;
            this.Name_gr = ngg;
            this.Result_g = rg;
            this.Worker = wc;
        }
        public Backup_g Backup_g { get; set; }
        public Cabinet Cabinet { get; set; }
        public Type_g Type_g { get; set; }
        public Vid_g Vid_g { get; set; }        
        public Vid_copy Vid_copy { get; set; }
        public Name_g Name_g { get; set; }
        public Name_g Name_gr { get; set; }
        public Result_g Result_g { get; set; }
        public Worker Worker { get; set; }
    }

    public class CompWithelement
    {

        public CompWithelement()
        {

        }
        public CompWithelement(Computer c, Worker work, Position pos, Cabinet cab, Otdel o, Typec t, Proc p, Proc_ch pc, Ram_ob r, Hdd_ob h, Monitor_size ms, Ups u, Ethernet setkarta, Workstation workgr, Change inet, Change ecedo, Worker rukov_p, Worker rukov_x, Worker passport)
        {
            //TO DO: Complete Member Initialization  
            this.Computer = c;
            this.Worker = work;
            this.Position = pos;
            this.Cabinet = cab;
            this.Otdel = o;
            this.Typec = t;
            this.Proc = p;
            this.Proc_ch = pc;
            this.Ram_ob = r;
            this.Hdd_ob = h;
            this.Monitor_size = ms;
            this.Ups = u;
            this.Ethernet = setkarta;
            this.Workstation = workgr;
            this.Internet = inet;
            this.Ecedo = ecedo;
            this.Worker = rukov_p;
            this.Worker = rukov_x;
            this.Worker = passport;
        }
        public Computer Computer { get; set; }
        public Worker Worker { get; set; }
        public Position Position { get; set; }
        public Cabinet Cabinet { get; set; }
        public Otdel Otdel { get; set; }
        public Typec Typec { get; set; }
        public Proc Proc { get; set; }
        public Proc_ch Proc_ch { get; set; }
        public Ram_ob Ram_ob { get; set; }
        public Hdd_ob Hdd_ob { get; set; }
        public Monitor_size Monitor_size { get; set; }
        public Ups Ups { get; set; }
        public Ethernet Ethernet { get; set; }
        public Workstation Workstation { get; set; }
        public Change Internet { get; set; }
        public Change Ecedo { get; set; }
        public Worker Rurov_p { get; set; }
        public Worker Rurov_x { get; set; }
        public Worker Passport { get; set; }
    }

    public class Repair
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Кабинет:")]
        public int Cab { get; set; }
        [Display(Name = "Тип устройства")]
        public int Device { get; set; }
        [Display(Name = "Наименование устройства:")]
        [Required(ErrorMessage = "Описание поломки!")]
        public string Name_repair { get; set; }
        [Display(Name = "Описание поломки:")]
        [Required(ErrorMessage = "Описание ремонта!")]
        public string Damage { get; set; }
        [Display(Name = "Описание ремонта:")]
        [Required(ErrorMessage = "Описание дефекта устройства!")]
        public string Repair_def { get; set; }
        public int Result { get; set; }
        [Display(Name = "Описание дефекта устройства:")]
        public string Ground { get; set; }
        [Display(Name = "ФИО программиста:")]
        public int FIO { get; set; }
        [Display(Name = "Дата поломки:")]
        public DateTime Data_detect { get; set; }
        [Display(Name = "Дата ремонта:")]
        public DateTime Data_repair { get; set; }
    }

    public class Repairs
    {

        public Repairs()
        {

        }
        public Repairs(Repair rep, Cabinet cab, Devices dev, Result res, Worker work)
        {            
            this.Repair = rep;
            this.Cabinet = cab;
            this.Devices = dev;
            this.Result = res;
            this.Workers = work;
        }
        public Repair Repair { get; set; }
        public Cabinet Cabinet { get; set; }
        public Devices Devices { get; set; }
        public Result Result { get; set; }
        public Worker Workers { get; set; }
    }

    public class Sklad
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите Инвентарный номер!")]
        [Display(Name = "Инвентарный номер:")]
        public string Sys_inv { get; set; }
        [Required(ErrorMessage = "Введите № кабинета!")]
        [Display(Name = "№ кабинета:")]
        public int Cab { get; set; }
        [Required(ErrorMessage = "Введите наименование!")]
        [Display(Name = "Наименование:")]
        public string Name { get; set; }
        [Display(Name = "Тип оборудования:")]
        public int Type { get; set; }
        [Display(Name = "Состояние оборудования:")]
        public int Condition { get; set; }
        [Display(Name = "Причина поломки:")]
        public int Ground { get; set; }
        public int Fio_admin { get; set; }
        [Display(Name = "Дата размещения в склад:")]
        public DateTime Data_r { get; set; }
        [Display(Name = "Дата заполнения:")]
        public DateTime Data_z { get; set; }
    }

    public class SkladwithElements
    {

        public SkladwithElements()
        {

        }
        public SkladwithElements(Sklad sklad, Cabinet cab, Devices dev, Condition con, Ground ground, Worker work)
        {
            this.Sklad = sklad;
            this.Cabinet = cab;            
            this.Devices = dev;
            this.Condition = con;
            this.Ground = ground;
            this.Workers = work;
        }
        public Sklad Sklad { get; set; }
        public Cabinet Cabinet { get; set; }        
        public Devices Devices { get; set; }
        public Condition Condition { get; set; }
        public Ground Ground { get; set; }
        public Worker Workers { get; set; }
    }
}
