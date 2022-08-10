using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "ИИН не может быть менее 12 симоволов")]
        [Display(Name = "ИИН")]
        public string IIN { get; set; }
        [Display(Name = "Пол")]
        public Sex Sex { get; set; }
        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime DoB { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Фото")]
        public string Photo { get; set; }

    }
}