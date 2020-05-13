﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class LoginModel
    {
         [Required(ErrorMessage = "Не указан никнейм")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
