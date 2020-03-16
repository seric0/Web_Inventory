using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebInventar1.Models
{
    public class Server
    {
        [Key]
        public int ServerID { get; set; }
        [Required(ErrorMessage = "Введите наименование сервера!")]
        [Display(Name = "Наименование сервера:")]
        public int Name_server { get; set; }
        [Required(ErrorMessage = "Введите отделение!")]
        [Display(Name = "Отделение:")]
        public int Departament { get; set; }
        [Required(ErrorMessage = "Введите ФИО!")]
        [Display(Name = "ФИО администратора:")]
        public int FIO_admin { get; set; }
        [Required(ErrorMessage = "Введите номер телефона!")]
        [Display(Name = "Телефон:")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Введите ФИО!")]
        [Display(Name = "ФИО ответств.лица:")]
        public int FIO_otvet { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [Display(Name = "Серийный номер:")]
        public string Server_sn { get; set; }
        [Required(ErrorMessage = "Введите номер!")]
        [Display(Name = "Инвентарный номер:")]
        public string Server_inv { get; set; }
        [Required(ErrorMessage = "Введите кол-во!")]
        [Display(Name = "ЦПУ кол-во:")]
        public int Cpu_col { get; set; }
        [Required(ErrorMessage = "Введите кол-во ЖД!")]
        [Display(Name = "Жесткий диск (кол-во):")]
        public int Hdd_col { get; set; }
        [Display(Name = "Стример (тип):")]
        public int Strimer { get; set; }
        [Display(Name = "Видеокарта (объем):")]
        public int Video { get; set; }
        [Required(ErrorMessage = "Введите кол-во сетевых карт!")]
        [Display(Name = "Сетевая карта:")]
        public int Ethernet { get; set; }
        [Required(ErrorMessage = "Введите скорость сетевого адаптера!")]
        [Display(Name = "Сетевая карта (скорость):")]
        public string Ethernet_sp { get; set; }
        [Display(Name = "Серийный номер (монитор)::")]
        public string Mon_bl_sn { get; set; }
        [Display(Name = "Инвентарный номер (монитор):")]
        public string Mon_bl_inv { get; set; }
        [Display(Name = "Серийный номер (принтер):")]
        public string Printer_sn { get; set; }
        [Display(Name = "Инвентарный номер (принтер):")]
        public string Printer_inv { get; set; }
        [Display(Name = "Серийный номер (ИБП):")]
        public string Ibp_sn { get; set; }
        [Display(Name = "Инвентарный номер (ИБП):")]
        public string Ibp_inv { get; set; }
        [Required(ErrorMessage = "Введите мат.лицо!")]
        [Display(Name = "ФИО мат.лицо:")]
        public int Fio_mat { get; set; }
        [Required(ErrorMessage = "Введите руководителя!")]
        [Display(Name = "Руководитель департамента:")]
        public int Rukov_dep { get; set; }
        [Required(ErrorMessage = "Введите дату!")]
        [Display(Name = "Дата заполнения:")]
        public DateTime Data { get; set; }
        public int Model_id { get; set; }
        public int Cpu_type_id { get; set; }
        public int Cpu_ch_id { get; set; }
        public int Hdd_type_id { get; set; }
        public int Hdd_ob_id { get; set; }
        public int Dvd_id { get; set; }
        public int Dvd_type_id { get; set; }
        public int Dvd_sp_id { get; set; }
        public int Ram_id { get; set; }
        public int Sound_id { get; set; }
        public int Video_type_id { get; set; }
        public int Monitor_model_id { get; set; }
        public int Mtype_id { get; set; }
        public int Printer_model_id { get; set; }
        public int Ibp_model_id { get; set; }
        public int Keyboard_id { get; set; }
        public int Mouse_id { get; set; }
        public int Room_id { get; set; }
    }

    public class Server_cpu
    {
        public int Id { get; set; }
        [Display(Name = "Наименование процессора:")]
        public string Name { get; set; }
    }

    public class Server_dvd_sp
    {
        public int Id { get; set; }
        [Display(Name = "Скорость работы DVD:")]
        public string Name { get; set; }
    }

    public class Server_dvd_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип DVD:")]
        public string Name { get; set; }
    }

    public class Server_dvd
    {
        public int Id { get; set; }
        [Display(Name = "CD/DVD:")]
        public string Name { get; set; }
    }

    public class Server_hdd_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип HDD:")]
        public string Name { get; set; }
    }

    public class Server_model
    {
        public int Id { get; set; }
        [Display(Name = "Модель сервера:")]
        public string Name { get; set; }
    }

    public class Server_sound
    {
        public int Id { get; set; }
        [Display(Name = "Звуковая карта:")]
        public string Name { get; set; }
    }

    public class Server_video_type
    {
        public int Id { get; set; }
        [Display(Name = "Видеокарта:")]
        public string Name { get; set; }
    }

    public class Input_type
    {
        public int Id { get; set; }
        [Display(Name = "Видеокарта:")]
        public string Name { get; set; }
    }

    public class Server_type
    {
        public int Id { get; set; }
        [Display(Name = "Тип сервера:")]
        public string Name { get; set; }
    }

    public class Server_strimer
    {
        public int Id { get; set; }
        [Display(Name = "Стример (тип):")]
        public string Name { get; set; }
    }

    public class Server_video
    {
        public int Id { get; set; }
        [Display(Name = "Видеокарта (объем):")]
        public string Name { get; set; }
    }

    public class Server_ethernet
    {
        public int Id { get; set; }
        [Display(Name = "Сетевая карта (количество):")]
        public string Name { get; set; }
    }    

    public class Server_room
    {
        public int Id { get; set; }
        [Display(Name = "Наименование кабинета:")]
        public string Name_cab { get; set; }
        [Display(Name = "Номер кабинета:")]
        public string Cab_server { get; set; }
        [Display(Name = "Этаж:")]
        public string Floor_server { get; set; }
        [Display(Name = "Количество этажей:")]
        public string Level_server { get; set; }
        [Display(Name = "Ширина комнаты (м):")]
        public string Width_server { get; set; }
        [Display(Name = "Длина комнаты (м):")]
        public string Length_server { get; set; }
        [Display(Name = "Высота комнаты (м):")]
        public string Height_server { get; set; }
        [Display(Name = "Тип двери:")]
        public string Door_type { get; set; }
        [Display(Name = "Тип замка:")]
        public string Lock_type { get; set; }
        [Display(Name = "Освещение:")]
        public string Lighting { get; set; }
        [Display(Name = "Электропитание:")]
        public string Power_supply { get; set; }
        [Display(Name = "ФИО Администратора:")]
        public string Fio_admin { get; set; }
        [Display(Name = "ФИО Администратора:")]        
        public DateTime Data { get; set; }
    }
    
    public class ServerWithDetail
    {

        public ServerWithDetail()
        {

        }
        public ServerWithDetail(Server sp, Server_type st, Server_model sm, Server_cpu sc, Proc_ch pc, Server_hdd_type ht, Hdd_ob hb, Ram_ob r, Otdel otd, Worker wk, Worker otv, Worker mat, Worker rukov, Server_dvd sd, Server_dvd_sp sdp, Server_dvd_type sdt, Server_ethernet se, Server_sound ss, Server_strimer str, Server_video sv, Server_video_type svt, Monitor_name m, Monitor_size ms, Printer_name pn, Ibp i, Input_type it, Input_type itm, Server_room srm)
        {
            //TO DO: Complete Member Initialization  
            this.Server = sp;
            this.Server_type = st;
            this.Server_model = sm;
            this.Server_cpu = sc;
            this.Proc_ch = pc;
            this.Server_hdd_type = ht;
            this.Hdd_ob = hb;
            this.Ram_ob = r;
            this.Otdel = otd;
            this.Worker = wk;
            this.Worker2 = otv;
            this.Worker3 = mat;
            this.Worker4 = rukov;
            this.Server_dvd = sd;
            this.Server_dvd_sp = sdp;
            this.Server_dvd_type = sdt;
            this.Server_ethernet = se;
            this.Server_sound = ss;
            this.Server_strimer = str;
            this.Server_video = sv;
            this.Server_video_type = svt;
            this.Monitor_name = m;
            this.Monitor_size = ms;
            this.Printer_name = pn;
            this.Ibp = i;
            this.Input_type = it;
            this.Input_type2 = itm;
            this.Server_room = srm;
        }
        public Server Server { get; set; }
        public Server_type Server_type { get; set; }
        public Server_model Server_model { get; set; }
        public Server_cpu Server_cpu { get; set; }
        public Proc_ch Proc_ch { get; set; }
        public Server_hdd_type Server_hdd_type { get; set; }
        public Hdd_ob Hdd_ob { get; set; }
        public Ram_ob Ram_ob { get; set; }
        public Otdel Otdel { get; set; }
        public Worker Worker { get; set; }
        public Worker Worker2 { get; set; }
        public Worker Worker3 { get; set; }
        public Worker Worker4 { get; set; }
        public Server_dvd Server_dvd { get; set; }
        public Server_dvd_sp Server_dvd_sp { get; set; }
        public Server_dvd_type Server_dvd_type { get; set; }
        public Server_ethernet Server_ethernet { get; set; }
        public Server_sound Server_sound { get; set; }
        public Server_strimer Server_strimer { get; set; }
        public Server_video Server_video { get; set; }
        public Server_video_type Server_video_type { get; set; }
        public Monitor_name Monitor_name { get; set; }
        public Monitor_size Monitor_size { get; set; }
        public Printer_name Printer_name { get; set; }
        public Ibp Ibp { get; set; }
        public Input_type Input_type { get; set; }
        public Input_type Input_type2 { get; set; }
        public Server_room Server_room { get; set; }
    }
}
