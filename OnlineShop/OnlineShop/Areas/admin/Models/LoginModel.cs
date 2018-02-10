﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.admin.Models
{
    public class LoginModel
    {
        [Required]
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool RememberMe { get; set; }

    }
}