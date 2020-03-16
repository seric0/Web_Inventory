using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebInventar1.Models
{
    public class Inventarcontext : DbContext
    {        
        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Programm> Programms { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<Otdel> Otdels { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Repattr1> Rep1s { get; set; }
        public DbSet<Hdd_ob> Hdd_ob { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Monitor_size> Monitor_size { get; set; }
        public DbSet<Monitor_resolution> Monitor_resolution { get; set; }
        public DbSet<Monitor_name> Monitor_name { get; set; }
        public DbSet<Monitor_matrix> Monitor_matrix { get; set; }
        public DbSet<Monitor_connection> Monitor_connection { get; set; }
        public DbSet<Proc> Procs { get; set; }
        public DbSet<Proc_ch> Proc_ch { get; set; }
        public DbSet<Ram_ob> Ram_ob { get; set; }
        public DbSet<Typec> Typecs { get; set; }
        public DbSet<Ups> Ups { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Diagnostic_c> Diagnostic_c { get; set; }
        public DbSet<Backup_g> Backup_g { get; set; }      
        public DbSet<Sklad> Sklads { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Workstation> Workstations { get; set; }
        public DbSet<Os> Os { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Antivirus> Antivirus { get; set; }
        public DbSet<Grafic> Grafics { get; set; }
        public DbSet<Arhivator> Arhivators { get; set; }
        public DbSet<Buxgalter> Buxgalters { get; set; }
        public DbSet<Browser> Browsers { get; set; }
        public DbSet<Component_type> Component_type { get; set; }
        public DbSet<Network_hard_name> Network_hard_name { get; set; }
        public DbSet<Network_hard_type> Network_hard_type { get; set; }
        public DbSet<Printer_name> Printer_name { get; set; }
        public DbSet<Printer_type> Printer_type { get; set; }
        public DbSet<Printer_cart> Printer_cart { get; set; }
        public DbSet<Printer_format> Printer_format { get; set; }
        public DbSet<Printer_texnology> Printer_texnology { get; set; }
        public DbSet<Network_hard_port> Network_hard_port { get; set; }
        public DbSet<Hard_type_name> Hard_type_names { get; set; }
        public DbSet<Server_cpu> Server_cpu { get; set; }
        public DbSet<Server_dvd_sp> Server_dvd_sp { get; set; }
        public DbSet<Server_dvd_type> Server_dvd_type { get; set; }
        public DbSet<Server_dvd> Server_dvd { get; set; }
        public DbSet<Server_hdd_type> Server_hdd_type { get; set; }
        public DbSet<Server_model> Server_model { get; set; }
        public DbSet<Server_sound> Server_sound { get; set; }
        public DbSet<Server_video_type> Server_video_type { get; set; }
        public DbSet<Input_type> Input_type { get; set; }
        public DbSet<Scaner> Scaners { get; set; }
        public DbSet<Risograph> Risographs { get; set; }
        public DbSet<Ibp> Ibps { get; set; }
        public DbSet<Proector> Proectors { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<Name_d_spr> Name_d_spr { get; set; }        
        public DbSet<Reason_p_spr> Reason_p_spr { get; set; }
        public DbSet<Reason_r_spr> Reason_r_spr { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Server_type> Server_type { get; set; }
        public DbSet<Server_strimer> Server_strimer { get; set; }
        public DbSet<Server_ethernet> Server_ethernet { get; set; }
        public DbSet<Server_video> Server_video { get; set; }
        public DbSet<Ethernet> Ethernets { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<Devices> Devices { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Server_room> Server_room { get; set; }
        public DbSet<Type_g> Type_g { get; set; }
        public DbSet<Vid_g> Vid_g { get; set; }
        public DbSet<Vid_copy> Vid_copy { get; set; }
        public DbSet<Name_g> Name_g { get; set; }
        public DbSet<Result_g> Result_g { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Ground> Ground { get; set; }
    }
}
