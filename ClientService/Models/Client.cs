using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClientService.Models
{
    public class Client : IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Client otherTemperature = obj as Client;
            if (otherTemperature != null)
                return this.Surname.CompareTo(otherTemperature.Surname);
            else
                throw new ArgumentException("Object is not a Client");
        }
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [RegularExpression(@"^[\S]{1,60}$", ErrorMessage = "Длина поля до 60 симв.")]
        public string Surname { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [RegularExpression(@"^[\S]{1,60}$", ErrorMessage = "Длина поля до 60 симв.")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        [RegularExpression(@"^[\S]{1,60}$", ErrorMessage = "Длина поля до 60 симв.")]
        public string MiddleName { get; set; }

        [DisplayName("Номер телефона")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [RegularExpression(@"^[\d\+\(\)\-]{6,16}$", ErrorMessage = "Номер телефона может содержать цифры, а также знаки: ( ) + -")]
        public string Phone { get; set; }
    }
}