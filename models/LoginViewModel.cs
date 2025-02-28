﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunGym.Front.Models
{
    public class LoginViewModel
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "El campo {0} es requerido", AllowEmptyStrings = false)]
        [EmailAddress]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "El campo {0} es requerido", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}