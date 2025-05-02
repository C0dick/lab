using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SurveyApp.Models.ViewModels
{
    public class PersonVM
    {
        public Guid Id { get; set; }

        [DisplayName("ФИО")]
        [Required(ErrorMessage = "Поле ФИО обязательно для заполнения")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "ФИО должно быть от 5 до 100 символов")]
        public string FullName { get; set; }

        [DisplayName("Возраст")]
        [Required(ErrorMessage = "Поле Возраст обязательно для заполнения")]
        [Range(1, 120, ErrorMessage = "Возраст должен быть от 1 до 120 лет")]
        public int Age { get; set; }

        [DisplayName("Пол")]
        [Required(ErrorMessage = "Поле Пол обязательно для заполнения")]
        public string Gender { get; set; }

        [DisplayName("Имеет работу")]
        public bool HasJob { get; set; }
    }
}