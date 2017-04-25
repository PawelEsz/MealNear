using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MealNear.Models
{
    public class Person
    {
        [DisplayName("Imię: ")]
        public string Name { get; set; }
        [DisplayName("Nazwisko: ")]
        public string Surname { get; set; }
        [DisplayName("Email: ")]
        public string Email { get; set; }
        [DisplayName("Płeć: ")]
        public string Gender { get; set; }
        [DisplayName("Wiek: ")]
        public int Age { get; set; }
        [DisplayName("Zawód: ")]
        public string Job { get; set; }
        [DisplayName("Opis: ")]
        public string Description { get; set; }
        [DisplayName("Treść: ")]
        public string Text { get; set; }
        [DisplayName("Tytuł: ")]
        public string Title { get; set; }
    }
}