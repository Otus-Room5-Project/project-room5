﻿using System.ComponentModel.DataAnnotations;

namespace CommonLib.DTO
{
    public class StaffDTO
    {
        [Required(ErrorMessage = "Не указано Имя")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "В имени должно быть не меньше 2 букв")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не указана Фамилия")]
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }

        [Display(Name = "Дата рождения")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Введите валидный e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан Телефон")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$",
            ErrorMessage = "Введите правильный номер телефона(через +7 XXX XX XX или 8 XXX XX XX) (не менее 7 цифр)")]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

    }
}
