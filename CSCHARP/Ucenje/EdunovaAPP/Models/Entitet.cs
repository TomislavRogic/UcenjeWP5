using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public abstract class Entitet
    {
        // sada treba reci ORM da je ovo primarni kljuc
        // to napravimo na na nacin
        [Key] // System.ComponentModel.DataAnnotations, dio EntityFrameworkCore paketa, dodajemo ga u Entitet.cs,
              // će reći ORM-u da je to primarni ključ
        public int? Sifra { get; set; }
    }
}
