﻿using System.ComponentModel.DataAnnotations;

namespace Authentication.Shared.Models
{
    public class ChangePassModel
    {
        [Display(Name = "Nombre de ususario"), Required(ErrorMessage = Utilities.MSGREQUIRED)]
        public string UserName { get; set; }

        [Display(Name = "Password actual"), Required(ErrorMessage = Utilities.MSGREQUIRED)]
        public string CurrentPass { get; set; }

        [Display(Name = "Nuevo Password"), Required(ErrorMessage = Utilities.MSGREQUIRED), MinLength(6, ErrorMessage = Utilities.MSGSTRINGlENGSHORT)]
        public string NewPass { get; set; }

        [Display(Name = "Confirmación Password"), Required(ErrorMessage = Utilities.MSGREQUIRED)]
        public string ConfirmPass { get; set; }
    }
}
